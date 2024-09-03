using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SignalR.BusinessLayer.Abstract;
using SignalR.DataAccessLayer.Concrete;
using SignalR.DtoLayer.ProductDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        public ProductController(IProductService productService, IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }


        [HttpGet]
        public IActionResult ProductList()
        {
            var values = _mapper.Map<List<ResultProductDto>>(_productService.TGetListAll());
            return Ok(values);
        }


        //[HttpPost]
        //public IActionResult CreateProduct(CreateProductDto createProductDto)
        //{
        //    var value = _mapper.Map<Product>(createProductDto);
        //    _productService.TAdd(value);
        //    return Ok("Ürün başarılı bir şekilde eklendi.");
        //}


        [HttpPost]
        public IActionResult CreateProduct(CreateProductDto createProductDto)
        {
            _productService.TAdd(new Product()
            {
                CategoryID = createProductDto.CategoryID,
                Description = createProductDto.Description,
                ImageUrl = createProductDto.ImageUrl,
                ProductName = createProductDto.ProductName,
                ProductStatus = createProductDto.ProductStatus,
                Price = createProductDto.Price,
            });
            return Ok("Ürün Eklendi.");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            var value = _productService.TGetByID(id);
            _productService.TDelete(value);
            return Ok("Ürün başarılı bir şekilde silindi");
        }


        [HttpPut]
        public IActionResult UpdateProduct(UpdateProductDto updateProductDto)
        {
            var value = _mapper.Map<Product>(updateProductDto);
            _productService.TUpdate(value);
            return Ok("Ürün başarılı bir şekilde güncellendi.");
        }



        [HttpGet("{id}")]
        public IActionResult GetProductById(int id)
        {
            var value = _mapper.Map<GetProductDto>(_productService.TGetByID(id));
            return Ok(value);
        }


        [HttpGet("ProductListWithCategory")]
        public IActionResult ProductListWithCategory()
        {
            var context = new SignalRContext();
            var values = context.Products.Include(x => x.Category).Select(y => new ResultProductWithCategory
            {
                Description = y.Description,
                ImageUrl = y.ImageUrl,
                Price = y.Price,
                ProductID = y.ProductID,
                ProductName = y.ProductName,
                ProductStatus = y.ProductStatus,
                CategoryName = y.Category.CategoryName
            });
            return Ok(values.ToList());
        }



        [HttpGet("ProductCount")]
        public IActionResult ProductCount()
        {
            return Ok(_productService.TProductCount());
        }



		[HttpPost("Deactivate/{id}")]
		public IActionResult DeactivateProduct(int id)
		{
            var product = _productService.TGetByID(id);
			if (product == null)
			{
				return NotFound("Ürün bulunamadı.");
			}
			_productService.TDeactivateProduct(id);
			return Ok("Ürün başarılı bir şekilde pasif hale getirildi.");
		}


		[HttpPost("Activate/{id}")]
		public IActionResult ActivateProduct(int id)
		{
			var product = _productService.TGetByID(id);
			if (product == null)
			{
				return NotFound("Ürün bulunamadı.");
			}
			_productService.TActivateProduct(id);
			return Ok("Ürün başarılı bir şekilde aktif hale getirildi.");
		}



        [HttpGet("ProductCountByHamburger")]
        public IActionResult ProductCountByHamburger()
        {
            return Ok(_productService.TProductCountByCategoryNameHamburger());
        }

        [HttpGet("ProductCountByPasta")]
        public IActionResult ProductCountByPasta()
        {
            return Ok(_productService.TProductCountByCategoryNamePasta());
        }


        [HttpGet("ProductCountBySalad")]
        public IActionResult ProductCountBySalad()
        {
            return Ok(_productService.TProductCountByCategoryNameSalad());
        }

        [HttpGet("ProductCountByDrink")]
        public IActionResult ProductCountByDrink()
        {
            return Ok(_productService.TProductCountByCategoryNameDrink());
        }

        [HttpGet("TotalPriceByDrinkCategory")]
        public IActionResult TotalPriceByDrinkCategory()
        {
            return Ok(_productService.TTotalPriceByDrinkCategory());
        }

        [HttpGet("TotalPriceBySaladCategory")]
        public IActionResult TotalPriceBySaladCategory()
        {
            return Ok(_productService.TTotalPriceBySaladCategory());
        }

        [HttpGet("ProductNameByMaxPrice")]
        public IActionResult ProductNameByMaxPrice()
        {
            return Ok(_productService.TProductNameByMaxPrice());
        }


        [HttpGet("ProductNameByMinPrice")]
        public IActionResult ProductNameByMinPrice()
        {
            return Ok(_productService.TProductNameByMinPrice());
        }


        [HttpGet("ProductAvgPriceByHamburger")]
        public IActionResult ProductAvgPriceByHamburger()
        {
            return Ok(_productService.TProductAvgPriceByHamburger());
        }


        [HttpGet("ProductPriceAvg")]
        public IActionResult ProductPriceAvg()
        {
            return Ok(_productService.TProductPriceAvg());
        }

        [HttpGet("ProductPriceBySteakBurger")]
        public IActionResult ProductPriceBySteakBurger()
        {
            return Ok(_productService.TProductPriceBySteakBurger());
        }

    }
}
