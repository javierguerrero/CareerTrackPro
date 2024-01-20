using Microsoft.AspNetCore.Mvc;
using ms.jobapplications.domain;
using Newtonsoft.Json.Linq;

namespace ms.jobapplications.api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class JobApplicationsController : ControllerBase
    {
        private readonly ILogger<JobApplicationsController> _logger;

        public JobApplicationsController(ILogger<JobApplicationsController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetJobApplication(int id)
        {
            var jobApplication = new JobApplication()
            {
                Id = 1,
                Position = "Senior .Net Developer",
                Organization = "Jobot",
                City = "Lima",
                LinkToJobOffer = "https://www.linkedin.com/jobs/view/3809172906/",
                Salary = "100.000 $/año - 120.000 $/año",
                ContactDetails = "",
                Notes = ""
            };

            if (jobApplication is null)
            {
                return NotFound();
            }
            return Ok(jobApplication);
        }

        [HttpGet]
        public async Task<IActionResult> GetJobApplications()
        {
            // Crear un array de objetos JSON dinámicamente
            JArray jsonArray = new JArray();

            // Agregar objetos al array
            dynamic firstObject = new JObject();
            firstObject.Id = 1;
            firstObject.Position = "Senior .Net Developer";
            firstObject.Organization = "Jobot";
            firstObject.City = "Lima";
            firstObject.LinkToJobOffer = "https://www.linkedin.com/jobs/view/3809172906/";
            firstObject.Salary = "100.000 $/año - 120.000 $/año";
            firstObject.ContactDetails = "";
            firstObject.Notes = "";
            jsonArray.Add(firstObject);

            dynamic secondObject = new JObject();
            secondObject.Id = 2;
            secondObject.Position = "Full Stack NET Dev Sr";
            secondObject.Organization = "Hexacta";
            secondObject.City = "";
            secondObject.LinkToJobOffer = "";
            secondObject.Salary = "";
            secondObject.ContactDetails = "";
            secondObject.Notes = "";
            jsonArray.Add(secondObject);

            // Convertir el array a una cadena JSON
            string jsonString = jsonArray.ToString();

            return Ok(jsonString);
        }
    }
}