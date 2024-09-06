using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DtoLayer.CouponCodeDto
{
    public class ResultCouponCodeDto
    {
        public int CouponCodeID { get; set; }
        public string Title { get; set; }
        public decimal Amout { get; set; }
    }
}
