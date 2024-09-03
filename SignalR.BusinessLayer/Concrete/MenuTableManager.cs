using SignalR.BusinessLayer.Abstract;
using SignalR.DataAccessLayer.Abstract;
using SignalR.DataAccessLayer.EntityFramework;
using SignalR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.BusinessLayer.Concrete
{
    public class MenuTableManager : IMenuTableService
    {
        private readonly IMenuTableDal _menuTableDal;

        public MenuTableManager(IMenuTableDal menuTableDal)
        {
            _menuTableDal = menuTableDal;
        }

        public int TActiveMenuTableCount()
        {
            return _menuTableDal.ActiveMenuTableCount();
        }

        public void TAdd(MenuTable entity)
        {
            _menuTableDal.Add(entity);
        }

        public decimal TCalculateActiveTableRatio()
        {
            return _menuTableDal.CalculateActiveTableRatio();
        }

        public void TDelete(MenuTable entity)
        {
            _menuTableDal.Delete(entity);
        }

        public MenuTable TGetByID(int id)
        {
            return _menuTableDal.GetByID(id);
        }

        public List<MenuTable> TGetListAll()
        {
            return _menuTableDal.GetListAll();
        }

        public List<MenuTable> TGetListByFilter(Expression<Func<MenuTable, bool>> where)
        {
            return _menuTableDal.GetListByFilter(where);
        }

        public int TMenuTableCount()
        {
            return _menuTableDal.MenuTableCount();
        }

        public int TPassiveMenuTableCount()
        {
            return _menuTableDal.PassiveMenuTableCount();
        }

        public void TUpdate(MenuTable entity)
        {
            _menuTableDal.Update(entity);
        }
    }
}
