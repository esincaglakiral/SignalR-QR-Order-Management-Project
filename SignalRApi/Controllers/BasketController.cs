using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SignalR.BusinessLayer.Abstract;
using SignalR.DataAccessLayer.Concrete;
using SignalR.DtoLayer.BasketDto;
using SignalR.EntityLayer.Entities;
using SignalRApi.Models;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BasketController : ControllerBase
    {
        private readonly IBasketService _basketService;
        private readonly ICouponCodeService _couponCodeService;
        public BasketController(IBasketService basketService, ICouponCodeService couponCodeService)
        {
            _basketService = basketService;
            _couponCodeService = couponCodeService;
        }


        [HttpGet]
        public IActionResult GetBasketByMenuTableID(int id)
        {
            var values = _basketService.TGetBasketByMenuTableNumber(id);
            return Ok(values);
        }


        [HttpGet("BasketListByMenuTableWithProductName")] //Httpget sepetin içindeki ürünler ürün adına göre getirme sınıfı oluşturuldu.
        public IActionResult BasketListByMenuTableWithProductName(int id) //oluşturulan sınıf çağrıldı id ile
        {
            using var context = new SignalRContext(); //Database bağlantısı kuruldu.

            //Values içine include ile product tablosunu seçiyor => şartı ise menu sınıfındakileri id =>  bizim tanımlanan modele göre seçtir
            var values = context.Baskets.Include(x => x.Product).Where(y => y.MenuTableID == id).Select(z => new ResultBasketListWithProducts
            {
                //Buraya ise modelde tanımlanan tablo verilerinin getirdim.
                BasketID = z.BasketID,
                Count = z.Count,
                MenuTableID = z.MenuTableID,
                Price = z.Price,
                ProductID = z.ProductID,
                TotalPrice = z.TotalPrice,
                ProductName = z.Product.ProductName //Product sınıfının productname ile getirdim.
            }).ToList();//listeleme işlemi yaptım.
            return Ok(values); 
        }


        [HttpPost]
        public IActionResult CreateBasket(CreateBasketDto createBasketDto)
        {
            //Bahçe 01 --> 45
            using var context = new SignalRContext();
            _basketService.TAdd(new Basket()
            {
                ProductID = createBasketDto.ProductID,
                Count = 1,
                MenuTableID = 4,
                Price = context.Products.Where(x => x.ProductID == createBasketDto.ProductID).Select(y => y.Price).FirstOrDefault(),
                TotalPrice = 0
            });
            return Ok();
        }


        [HttpDelete("{id}")]
        public IActionResult DeleteBasket(int id)
        {
            var value = _basketService.TGetByID(id);
            _basketService.TDelete(value);
            return Ok("Sepetteki Seçilen Ürün Silindi");
        }


      


    }
}
