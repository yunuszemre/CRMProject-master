using CRMProject.DTO;
using Microsoft.AspNetCore.Mvc;

namespace CRMProject.WebUI.Controllers
{
    using BL.Abstract;
    using CRMProject.DTO.Pages;

    public class AccountController : Controller
    {
        IUserAccountService _userAccountService;

        public AccountController(IUserAccountService userAccountService)
        {
            _userAccountService = userAccountService;
        }



        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Login(LoginDTO loginDTO)
        {
            var user = _userAccountService.GetUser(loginDTO.UserName, loginDTO.Password);
            if (user != null)
            {
                return RedirectToAction("List", "UserAccount");
            }
            return View(loginDTO);
        }
        
        
        
    }
}
