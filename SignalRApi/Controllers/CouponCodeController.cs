using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.CouponCodeDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CouponCodeController : ControllerBase
    {
        private readonly ICouponCodeService _couponCodeService;
        private readonly IMapper _mapper;

        public CouponCodeController(ICouponCodeService couponCodeService, IMapper mapper)
        {
            _couponCodeService = couponCodeService;
            _mapper = mapper;
        }


        [HttpGet]
        public IActionResult CouponCodeList()
        {
            var values = _couponCodeService.TGetListAll();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult CreateCouponCode(CreateCouponCodeDto createCouponCodeDto)
        {
            var values = _mapper.Map<CouponCode>(createCouponCodeDto);
            _couponCodeService.TAdd(values);

            return Ok("Kupon Başarılı Bir Şekilde Eklendi");
        }


        [HttpDelete("{id}")]
        public IActionResult DeleteCouponCode(int id)
        {
            var value = _couponCodeService.TGetByID(id);
            _couponCodeService.TDelete(value);
            return Ok("Kupon Başarılı Bir Şekilde Silindi");
        }


        [HttpPut]
        public IActionResult UpdateCode(UpdateCouponCodeDto updateCouponCodeDto)
        {
            CouponCode couponCode = new CouponCode()
            {
                Amout = updateCouponCodeDto.Amout,
                CouponCodeID = updateCouponCodeDto.CouponCodeID,
                Title = updateCouponCodeDto.Title,
            };
            _couponCodeService.TUpdate(couponCode);
            return Ok("Kupon Güncelleme Işlemi Başarıyla Sonuçlandı.");
        }



        [HttpGet("{id}")]
        public IActionResult GetCouponCodeById(int id)
        {
            var value = _couponCodeService.TGetByID(id);
            return Ok(value);
        }

    }
}
