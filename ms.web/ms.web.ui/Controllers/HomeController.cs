using MediatR;
using Microsoft.AspNetCore.Mvc;
using ms.web.application.Queries;
using ms.web.ui.Models;
using System.Diagnostics;

namespace ms.web.ui.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IMediator _mediator;

        public HomeController(ILogger<HomeController> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SignIn(LoginModel loginModel)
        {
            try
            {
                //log in an existing user
                var user = await _mediator.Send(new GetUserQuery(loginModel.Username, loginModel.Password));

                //save the token to a session variable
                if (user.Token is not null)
                {
                    HttpContext.Session.SetString("_UserToken", user.Token);
                    return RedirectToAction("Index", "Student");
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(String.Empty, ex.Message);
                return View(loginModel);
            }

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}