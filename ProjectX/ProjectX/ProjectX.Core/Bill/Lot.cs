using ProjectX.Core.Customer;
using ProjectX.Core.Utils;
using System.Collections.Generic;

namespace ProjectX.Core.Bill
{
    public class Lot
    {
        public int LotId { get; set; }
        public CustomerDetail Customer { get; set; }
        public bool? AlreadyPaid { get; set; }
        public Month Month { get; set; }
        public int DayOfLot { get; set; }
        public List<BillDetail> Bills { get; set; }
    }
}
