using Microsoft.AspNetCore.Mvc;

namespace ms.web.ui.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            var token = HttpContext.Session.GetString("_UserToken");

            if (token != null)
            {
                //var viewModel = new HomeViewModel();
                //viewModel.AnimeList = await _mediator.Send(new GetAllAnimeQuery());
                //return View(viewModel);
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }
    }
}
