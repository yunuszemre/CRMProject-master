using AutoMapper;
using CRMProject.BL.Abstract;
using CRMProject.DTO.Pages;
using Microsoft.AspNetCore.Mvc;

namespace CRMProject.WebUI.Controllers
{
    public class ProductController : Controller
    {
        IProductService _productService;
        IMapper _mapper;
        public ProductController(IProductService productService, IMapper mapper)
        {
            _productService= productService;
            _mapper = mapper;
        }

        /// <summary>
        /// Ürün Liste View Action Method
        /// </summary>
        /// <returns></returns>
        [HttpGet("product-list")]
        public IActionResult List()
        {
            return View();
        }

        /// <summary>
        /// Ürün Detay Vİew Action Method
        /// </summary>
        /// <returns></returns>
        [HttpGet("product-list-data")]
        public JsonResult ListData()
        {
            var data = _productService.Select();
            return Json(new { data = data });
        }


        [HttpGet("product-detail/{id?}")]
        public IActionResult Detail(int? id)
        {
            var productDTO = FillProduct(id);
            return View(productDTO);
        }



        [HttpPost("product-detail/{id?}")]
        public IActionResult Detail(int? id, ProductDTO productDTO)
        {
            if (Request.Form.Keys.Contains("btn-new"))
            {
                return RedirectToAction("Detail", "Product");
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
                return RedirectToAction("List", "Product");
            }
            return View();
        }



        private object FillProduct(int? id)
        {
            //var product = _productService.GetById(Convert.ToInt32(id));

            return _mapper.Map<ProductDTO>(_productService.GetById(Convert.ToInt32(id)));
        }
    }
}
