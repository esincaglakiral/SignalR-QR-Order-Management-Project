using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.EntityLayer.Entities
{
    public class CouponCode
    {
        public int CouponCodeID { get; set; }
        public string Title { get; set; }
        public decimal Amout { get; set; }
    }
}
