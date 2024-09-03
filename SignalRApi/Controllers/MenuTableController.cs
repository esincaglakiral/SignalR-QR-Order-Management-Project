using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.MenuTableDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuTableController : ControllerBase
    {
        private readonly IMenuTableService _menuTableService;
        private readonly IMapper _mapper;
        public MenuTableController(IMenuTableService menuTableService, IMapper mapper)
        {
            _menuTableService = menuTableService;
            _mapper = mapper;
        }


        [HttpGet("MenuTableCount")]
        public IActionResult MenuTableCount()
        {
            return Ok(_menuTableService.TMenuTableCount());
        }



        [HttpGet("ActiveMenuTableCount")]
        public IActionResult ActiveMenuTableCount()
        {
            return Ok(_menuTableService.TActiveMenuTableCount());
        }


        [HttpGet("PassiveMenuTableCount")]
        public IActionResult PassiveMenuTableCount()
        {
            return Ok(_menuTableService.TPassiveMenuTableCount());
        }


        [HttpGet("CalculateActiveTableRatio")]
        public IActionResult CalculateActiveTableRatio()
        {
            var value = _menuTableService.TCalculateActiveTableRatio();
            return Ok(value);
        }


        [HttpGet]
        public IActionResult MenuTableList()
        {
            var values = _menuTableService.TGetListAll();
            return Ok(values);
        }


        [HttpPost]
        public IActionResult CreateMenuTable(CreateMenuTableDto createMenuTableDto)
        {
            var values = _mapper.Map<MenuTable>(createMenuTableDto);
            values.Status = false; // Status'ü manuel olarak false olarak ayarlıyoruz.
            _menuTableService.TAdd(values);
            return Ok("Masa Başarılı Şekilde Eklendi");
        }



        [HttpDelete("{id}")]
        public IActionResult DeleteMenuTable(int id)
        {
            var value = _menuTableService.TGetByID(id);
            _menuTableService.TDelete(value);
            return Ok();
        }


        [HttpPut]
        public IActionResult UpdateMenuTable(UpdateMenuTableDto updateMenuTableDto)
        {
            var values = _mapper.Map<MenuTable>(updateMenuTableDto);
            _menuTableService.TUpdate(values);
            return Ok();
        }


        [HttpGet("{id}")]
        public IActionResult GetMenuTableById(int id)
        {
            var value = _menuTableService.TGetByID(id);
            return Ok(value);
        }
    }
}
