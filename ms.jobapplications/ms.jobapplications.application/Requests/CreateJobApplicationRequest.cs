using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ms.jobapplications.application.Requests
{
    public class CreateJobApplicationRequest
    {
        public int Id { get; set; }
        public string Position { get; set; }
        public string Organization { get; set; }
        public string City { get; set; }
        public string LinkToJobOffer { get; set; }
        public string Salary { get; set; }
        public string ContactDetails { get; set; }
        public string Notes { get; set; }
    }
}