using AutoMapper;
using CRMProject.BL.Abstract;
using CRMProject.DTO.Pages;
using Microsoft.AspNetCore.Mvc;

namespace CRMProject.WebUI.Controllers
{
    public class CategoryController : Controller
    {
        ICategoryService _categoryService;
        IMapper _mapper;

        public CategoryController(ICategoryService categoryService, IMapper mapper)
        {
            _mapper = mapper;
            _categoryService = categoryService;
        }



        [HttpGet("category-list")]
        public IActionResult List()
        {
            return View();
        }
        [HttpGet("category-list-data")]
        public JsonResult ListData()
        {
            var data = _categoryService.Select();
            return Json(new { data = data });

        }

        [HttpGet("category-detail/{id?}")]
        public IActionResult Detail(int? id)
        {
            var categoryDTO = FillCategory(id);
            return View(categoryDTO);

        }
        [HttpPost("category-detail/{id?}")]
        public IActionResult Detail(int? id, CategoryDTO categoryDTO)
        {
            if (Request.Form.Keys.Contains("btn-new"))
            {
                return RedirectToAction("Detail", "Category");
            }
            else if (Request.Form.Keys.Contains("btn-save"))
            {
                //if (ModelState.IsValid)
                //{

                //}

            }
            else if (Request.Form.Keys.Contains("btn-delete"))
            {

            }
            else if (Request.Form.Keys.Contains("btn-list"))
            {
                return RedirectToAction("List", "Category");
            }
            return View();
        }

        private object FillCategory(int? id)
        {
            //var category = _categoryService.GetById(Convert.ToInt32(id));

            return _mapper.Map<CategoryDTO>(_categoryService.GetById(Convert.ToInt32(id)));
        }
    }
}
