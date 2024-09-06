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
    public class CouponCodeManager : ICouponCodeService
    {
        private readonly ICouponCodeDal _couponCodeDal;

        public CouponCodeManager(ICouponCodeDal couponCodeDal)
        {
            _couponCodeDal = couponCodeDal;
        }

        public void TAdd(CouponCode entity)
        {
            _couponCodeDal.Add(entity);
        }

        public void TDelete(CouponCode entity)
        {
            _couponCodeDal.Delete(entity);
        }

        public CouponCode TGetByID(int id)
        {
            return _couponCodeDal.GetByID(id);
        }

        public List<CouponCode> TGetListAll()
        {
            return _couponCodeDal.GetListAll();
        }

        public List<CouponCode> TGetListByFilter(Expression<Func<CouponCode, bool>> where)
        {
            return _couponCodeDal.GetListByFilter(where);
        }

        public void TUpdate(CouponCode entity)
        {
            _couponCodeDal.Update(entity);
        }
    }
}
