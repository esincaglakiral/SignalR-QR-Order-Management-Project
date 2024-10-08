﻿using SignalR.BusinessLayer.Abstract;
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
    public class BasketManager : IBasketService
    {
        private readonly IBasketDal _basketDal;

        public BasketManager(IBasketDal basketDal)
        {
            _basketDal = basketDal;
        }

        public void TAdd(Basket entity)
        {
            _basketDal.Add(entity);
        }

        public decimal TBasketSum()
        {
            return _basketDal.BasketSum();
        }

        public void TDelete(Basket entity)
        {
            _basketDal.Delete(entity);
        }

        public List<Basket> TGetBasketByMenuTableNumber(int id)
        {
            return _basketDal.GetBasketByMenuTableNumber(id);
        }

        public Basket TGetByID(int id)
        {
            return _basketDal.GetByID(id);
        }

        public List<Basket> TGetListAll()
        {
            return _basketDal.GetListAll();
        }

        public List<Basket> TGetListByFilter(Expression<Func<Basket, bool>> where)
        {
            return _basketDal.GetListByFilter(where);
        }

        public decimal TSetCouponCode(string couponName)
        {
            return _basketDal.SetCouponCode(couponName);
        }

        public void TUpdate(Basket entity)
        {
            _basketDal.Update(entity);
        }
    }
}
