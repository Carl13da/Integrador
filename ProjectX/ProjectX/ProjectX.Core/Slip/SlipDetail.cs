using System;
using System.Collections.Generic;
using System.Text;
using ProjectX.Core.Bill;
using ProjectX.Core.Customer;

namespace ProjectX.Core.Slip
{
    public class SlipDetail
    {
        public int SlipId { get; set; }
        public string BarCode { get; set; }
        public string Description { get; set; }
        public decimal Value { get; set; }
        public DateTime? ExpiratedDate { get; set; }
    }
}
