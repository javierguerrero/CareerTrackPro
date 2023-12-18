using AutoMapper;
using MediatR;
using ms.rabbitmq.Events;
using ms.rabbitmq.Producers;
using ms.jobseekers.domain.Entities;
using ms.jobseekers.domain.Interfaces;

namespace ms.jobseekers.application.Commands.Handler
{
    public class CreateJobSeekerCommandHandler : IRequestHandler<CreateJobSeekerCommand, string>
    {
        private readonly IJobSeekertRepository _studentRepository;
        private readonly IProducer _producer;
        private readonly IMapper _mapper;

        public CreateJobSeekerCommandHandler(IJobSeekertRepository studentRepository, IMapper mapper, IProducer producer)
        {
            _studentRepository = studentRepository;
            _mapper = mapper;
            _producer = producer;
        }

        public async Task<string> Handle(CreateJobSeekerCommand createJobSeekerCommand, CancellationToken cancellationToken)
        {
            var result = await _studentRepository.CreateJobSeeker(new JobSeeker
            {
                UserName = createJobSeekerCommand.userName,
                FirstName = createJobSeekerCommand.firstName,
                LastName = createJobSeekerCommand.lastName
            });

            var jobSeekerCreatedEvent = _mapper.Map<JobSeekerCreatedEvent>(createJobSeekerCommand);
            _producer.Produce(jobSeekerCreatedEvent);

            return result;
        }
    }
}