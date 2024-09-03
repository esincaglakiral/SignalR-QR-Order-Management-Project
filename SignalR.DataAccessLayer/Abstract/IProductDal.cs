using SignalR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DataAccessLayer.Abstract
{
    public interface IProductDal : IGenericDal<Product>
    {
        List<Product> GetProductsWithCategories();
        int ProductCount();
		void DeactivateProduct(int id);
		void ActivateProduct(int id);
        int ProductCountByCategoryNameHamburger();
        int ProductCountByCategoryNameSalad();
        int ProductCountByCategoryNamePasta();
        int ProductCountByCategoryNameDrink();
        decimal ProductPriceAvg();
        string ProductNameByMaxPrice();
        string ProductNameByMinPrice();
        decimal ProductAvgPriceByHamburger();
        decimal ProductPriceBySteakBurger();
        decimal TotalPriceByDrinkCategory();
        decimal TotalPriceBySaladCategory();
    }
}
