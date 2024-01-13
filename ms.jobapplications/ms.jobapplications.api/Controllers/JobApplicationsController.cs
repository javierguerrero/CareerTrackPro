using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace ms.jobapplications.api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class JobApplicationsController : ControllerBase
    {
        private readonly ILogger<JobApplicationsController> _logger;

        public JobApplicationsController(ILogger<JobApplicationsController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            // Crear un array de objetos JSON dinámicamente
            JArray jsonArray = new JArray();

            // Agregar objetos al array
            dynamic firstObject = new JObject();
            firstObject.Position = "NET Dev Sr";
            firstObject.Organization = "Indra";
            jsonArray.Add(firstObject);

            dynamic secondObject = new JObject();
            secondObject.Position = "Full Stack NET Dev Sr";
            secondObject.Organization = "Hexacta";
            jsonArray.Add(secondObject);

            // Convertir el array a una cadena JSON
            string jsonString = jsonArray.ToString();


            return Ok(jsonString);
        }
    }
}
