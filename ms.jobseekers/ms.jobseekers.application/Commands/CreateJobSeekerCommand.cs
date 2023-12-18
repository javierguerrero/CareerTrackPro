using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ms.jobseekers.application.Commands
{
    public record CreateJobSeekerCommand(string userName, string firstName, 
                                       string lastName, string email, 
                                       string password, string role) : IRequest<string>;
}
