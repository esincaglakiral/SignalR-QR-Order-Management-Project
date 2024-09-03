using SignalR.DataAccessLayer.Abstract;
using SignalR.DataAccessLayer.Concrete;
using SignalR.DataAccessLayer.Repositories;
using SignalR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DataAccessLayer.EntityFramework
{
    public class EfOrderDal : GenericRepository<Order>, IOrderDal
    {
        public EfOrderDal(SignalRContext context) : base(context)
        {
        }

        public int ActiveOrderCount()   // Müşteri henüz masadaysa aktif sipariş olarak geçicek. Description = Müşteri Masada olanlar aktif sipariştir.
        {
            using var context = new SignalRContext();
            return context.Orders.Where(x => x.Description == "Müşteri Masada").Count();
        }

        public decimal LastOrderPrice()  //son sipariş tutarı
        {
            // bugune ait olan son sipariş, henüz masadaki müşterininkidir. Masada olan birden fazla müşteri var sa da son girilen kayıttır.

            using var context = new SignalRContext();
            var value = context.Orders.Where(x => x.Description == "Müşteri Masada").OrderByDescending(x => x.OrderDate).Select(y => y.TotalPrice).FirstOrDefault();
            return value;
        }

        public decimal TodayTotalPrice() // günlük siparişlerin toplam fiyatı (günlük ciro), hesabı kapatılmış olanlar için hesaplanan tutar
        {
            using var context = new SignalRContext();
            var value = context.Orders.Where(x => x.OrderDate == DateTime.Now.Date & x.Description == "Hesap Kapatıldı").Sum(x => x.TotalPrice);
            return value;
        }

        public int TotalOrderCount()  // şimdiye kadarki tüm siparişlerin sayısı
        {
            using var context = new SignalRContext();
            return context.Orders.Count();
        }
    }
}
