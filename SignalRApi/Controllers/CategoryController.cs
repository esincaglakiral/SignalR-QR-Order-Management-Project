using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.CategoryDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;

        public CategoryController(ICategoryService categoryService, IMapper mapper)
        {
            _categoryService = categoryService;
            _mapper = mapper;
        }


        [HttpGet]
        public IActionResult CategoryList()
        {
            var value = _mapper.Map<List<ResultCategoryDto>>(_categoryService.TGetListAll()); //automapper
            return Ok(value);
        }


        [HttpPost]
        public IActionResult CreateCategory(CreateCategoryDto createCategoryDto)
        {
            var value = _mapper.Map<Category>(createCategoryDto);
            _categoryService.TAdd(value);
            return Ok("Kategori Başarılı bir şekilde eklendi.");
           
        }
        


        [HttpDelete("{id}")]
        public IActionResult DeleteCategory(int id)
        {
            var value = _categoryService.TGetByID(id);
            _categoryService.TDelete(value);
            return Ok("Kategori başarılı bir şekilde silindi");
        }


        [HttpPut]
        public IActionResult UpdateCategory(UpdateCategoryDto updateCategoryDto)
        {
            var value = _mapper.Map<Category>(updateCategoryDto);
            _categoryService.TUpdate(value);
            return Ok("Kayıt başarılı bir şekilde güncellendi.");
        }


        [HttpGet("{id}")]
        public IActionResult GetCategoryById(int id)
        {
            var value = _mapper.Map<GetCategoryDto>(_categoryService.TGetByID(id));
            return Ok(value);
        }



		[HttpGet("CategoryCount")]
		public IActionResult CategoryCount()
		{
			return Ok(_categoryService.TCategoryCount());
		}

		[HttpGet("ActiveCategoryCount")]
		public IActionResult ActiveCategoryCount()
		{
			return Ok(_categoryService.TActiveCategoryCount());
		}

		[HttpGet("PassiveCategoryCount")]
		public IActionResult PassiveCategoryCount()
		{
			return Ok(_categoryService.TPassiveCategoryCount());
		}


		[HttpPost("Deactivate/{id}")]
		public IActionResult DeactivateCategory(int id)
		{
			var category = _categoryService.TGetByID(id);
			if (category == null)
			{
				return NotFound("Kategori bulunamadı.");
			}
			_categoryService.TDeactivateCategory(id);
			return Ok("Kategori başarılı bir şekilde pasif hale getirildi.");
		}


		[HttpPost("Activate/{id}")]
		public IActionResult ActivateCategory(int id)
		{
			var category = _categoryService.TGetByID(id);
			if (category == null)
			{
				return NotFound("Kategori bulunamadı.");
			}
			_categoryService.TActivateCategory(id);
			return Ok("Kategori başarılı bir şekilde aktif hale getirildi.");
		}

	}
}
