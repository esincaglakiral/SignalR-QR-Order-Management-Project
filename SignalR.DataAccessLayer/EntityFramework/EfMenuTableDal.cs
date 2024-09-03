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
    public class EfMenuTableDal : GenericRepository<MenuTable>, IMenuTableDal
    {
        public EfMenuTableDal(SignalRContext context) : base(context)
        {
        }

        public int ActiveMenuTableCount()  //dolu olan masa sayısı (aktif)
        {
            using var context = new SignalRContext();
            return context.MenuTables.Where(x => x.Status == true).Count();
        }

        public decimal CalculateActiveTableRatio()
        {
            //  MenuTable tablosundaki Status değeri true olan tabloların, toplam tablo sayısına oranını hesaplayarak yüzde cinsinden döndürür.
            //  Bu yöntem, veritabanındaki tabloların ne kadarının belirli bir durumda olduğunu (örneğin, aktif) analiz etmek için
            using var context = new SignalRContext();
            float falseTableCount = context.MenuTables.Where(x => x.Status == true).Count();
            float allTableCount = MenuTableCount();
            decimal rate = Convert.ToDecimal((falseTableCount / allTableCount) * 100);
            return rate;
        }

        public int MenuTableCount()  //Tüm masaların sayıları
        {
            using var context = new SignalRContext();
            return context.MenuTables.Count();
        }

        public int PassiveMenuTableCount() //boş olan masa sayısı (pasif)
        {
            using var context = new SignalRContext();
            return context.MenuTables.Where(x => x.Status == false).Count();
        }
    }
}
