using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.DiscountDto;
using SignalR.DtoLayer.TestimonialDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialController : ControllerBase
    {
        private readonly ITestimonialService _testimonialService;
        private readonly IMapper _mapper;

        public TestimonialController(ITestimonialService testimonialService, IMapper mapper)
        {
            _testimonialService = testimonialService;
            _mapper = mapper;
        }


        [HttpGet]
        public IActionResult TestimonialList()
        {
            var values = _mapper.Map<List<ResultTestimonialDto>>(_testimonialService.TGetListAll());
            return Ok(values);
        }


        [HttpPost]
        public IActionResult CreateTestimonial(CreateTestimonialDto createTestimonialDto)
        {
            var value = _mapper.Map<Testimonial>(createTestimonialDto);
            _testimonialService.TAdd(value);
            return Ok("Referans başarılı bir şekilde eklendi.");
        }



        [HttpDelete("{id}")]
        public IActionResult DeleteTestimonial(int id)
        {
            var value = _testimonialService.TGetByID(id);
            _testimonialService.TDelete(value);
            return Ok("Referans başarılı bir şekilde silindi");
        }


        [HttpPut]
        public IActionResult UpdateTestimonial(UpdateTestimonialDto updateTestimonialDto)
        {
            var value = _mapper.Map<Testimonial>(updateTestimonialDto);
            _testimonialService.TUpdate(value);
            return Ok("Referans başarılı bir şekilde güncellendi.");
        }


        [HttpGet("{id}")]
        public IActionResult GetTestimonialById(int id)
        {
            var value = _mapper.Map<GetTestimonialDto>(_testimonialService.TGetByID(id));
            return Ok(value);
        }




        [HttpPost("DeActivate/{id}")]
        public IActionResult DeactivateTestimonial(int id)
        {
            var testimonial = _testimonialService.TGetByID(id);
            if (testimonial == null)
            {
                return NotFound("Referans bulunamadı.");
            }
            _testimonialService.TDeActivateTestimonial(id);
            return Ok("Referans başarılı bir şekilde pasif hale getirildi.");
        }


        [HttpPost("Activate/{id}")]
        public IActionResult ActivateTestimonial(int id)
        {
            var testimonial = _testimonialService.TGetByID(id);
            if (testimonial == null)
            {
                return NotFound("Referans bulunamadı.");
            }
            _testimonialService.TActivateTestimonial(id);
            return Ok("Referans başarılı bir şekilde aktif hale getirildi.");
        }
    }
}
