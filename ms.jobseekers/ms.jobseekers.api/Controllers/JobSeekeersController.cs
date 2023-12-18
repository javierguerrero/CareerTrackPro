using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ms.jobseekers.application.Commands;
using ms.jobseekers.application.Queries;
using ms.jobseekers.application.Requests;
using System.Data;

namespace ms.jobseekers.api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class JobSeekeersController : ControllerBase
    {
        private readonly IMediator _mediator;

        public JobSeekeersController(IMediator mediator) => _mediator = mediator;

        [Authorize(Roles = "Admin")]
        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> GetAllJobSeekers()
            => Ok(await _mediator.Send(new GetAllJobSeekersQuery()));

        [Authorize(Roles = "Admin")]
        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> CreateJobSeeker([FromBody] CreateJobSeekerRequest jobSeeker) =>
            Ok(await _mediator.Send(new CreateJobSeekerCommand(jobSeeker.UserName, jobSeeker.FirstName, 
                                                             jobSeeker.LastName, jobSeeker.Email,
                                                             jobSeeker.Password, jobSeeker.Role)));
    }
}
