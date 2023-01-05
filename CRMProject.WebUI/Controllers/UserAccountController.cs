using AutoMapper;
using CRMProject.BL.Abstract;
using CRMProject.BL.Concrete;
using CRMProject.DTO.Pages;
using CRMProject.Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CRMProject.WebUI.Controllers
{
    //[Authorize]
    public class UserAccountController : Controller
    {
        IUserAccountService _userAccountService;
        IMapper _mapper;
        public UserAccountController(IUserAccountService userAccountService, IMapper mapper)
        {
            _userAccountService = userAccountService;
            _mapper = mapper;
        }
        [HttpPost("detail/{id}")]
        public IActionResult Detail()
        {

            return View();
        }

        [HttpGet("user-list")]
        public IActionResult List()
        {
            return View();
        }

        [HttpGet("user-list-data")]
        public JsonResult ListData()
        {
            var data = _userAccountService.Select();
            return Json(new { data = data });
        }
        [HttpGet("user-detail/{id?}")]
        public IActionResult Detail(int? id)
        {
            var userAccountDTO = FillUserAccount(id);
            return View(userAccountDTO);
        }
        [HttpPost("user-detail/{id?}")]
        public IActionResult Detail(int id, UserAccountDTO userAccountDTO)
        {
            if (Request.Form.Keys.Contains("btn-new"))
            {
                return RedirectToAction("Detail", "UserAccount");
            }
            else if (Request.Form.Keys.Contains("btn-save"))
            {
                var user = _mapper.Map<UserAccount>(userAccountDTO);
                if (id>0)
                {
                    _userAccountService.Update(user);
                }
                else
                {
                    _userAccountService.Add(user);
                }

            }
            else if (Request.Form.Keys.Contains("btn-delete"))
            {
                var user = _mapper.Map<UserAccount>(userAccountDTO);
                _userAccountService.Delete(user);
                return RedirectToAction("List", "Account");
            }
            else if (Request.Form.Keys.Contains("btn-list"))
            {
                return RedirectToAction("List", "UserAccount");
            }
            return View();
        }
        
        private UserAccountDTO FillUserAccount(int? id)
        {

            var userAccount = _userAccountService.GetById(Convert.ToInt32(id));

            //if (userAccount != null)
            //{
            //    //return new UserAccountDTO { UserName = userAccount.UserName, FullName = userAccount.Fullname, RecordDate = userAccount.RecordDate, ModifiedDate = userAccount.ModifiedDate, UserId = userAccount.UserId, Password = userAccount.Password };
            //    return _mapper.Map<UserAccountDTO>(userAccount);
            //}

            return _mapper.Map<UserAccountDTO>(_userAccountService.GetById(Convert.ToInt32(id)));
            

        }
        //public JsonResult ListData()
        //{
        //	var data = _userAccountService.Select();
        //	//return Json(new { data: 'data' });
        //	return Json(data);
        //}
    }
}
