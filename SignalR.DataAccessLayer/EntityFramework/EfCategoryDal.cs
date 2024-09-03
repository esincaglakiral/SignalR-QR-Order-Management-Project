using Microsoft.EntityFrameworkCore;
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
    public class EfCategoryDal : GenericRepository<Category>, ICategoryDal
	{
		private readonly SignalRContext _context;
		public EfCategoryDal(SignalRContext context) : base(context)
        {
			_context = context;
		}

		public void ActivateCategory(int id)
		{
			var category = _context.Categories.FirstOrDefault(c => c.CategoryID == id);
			if (category != null)
			{
				category.Status = true;
				_context.SaveChanges();
			}
		}

		public int ActiveCategoryCount()
		{
			using var context = new SignalRContext();
			return context.Categories.Where(x => x.Status == true).Count();
		}

		public int CategoryCount()
		{
			using var context = new SignalRContext();
			return context.Categories.Count();
		}

		public void DeactivateCategory(int id)
		{
			// Kategori bulunur
			var category = _context.Categories.FirstOrDefault(c => c.CategoryID == id);
			if (category != null)
			{
				// Kategori pasif hale getirilir
				category.Status = false;
				_context.SaveChanges(); // Değişiklikler kaydedilir
			}
		}

		public int PassiveCategoryCount()
		{
			using var context = new SignalRContext();
			return context.Categories.Where(x => x.Status == false).Count();
		}
	}
}
