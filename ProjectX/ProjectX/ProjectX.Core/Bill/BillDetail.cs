using ProjectX.Core.Customer;
using ProjectX.Core.Slip;

namespace ProjectX.Core.Bill
{
    public class BillDetail : SlipDetail
    {
        public Category Category { get; set; }
        public Provider Provider { get; set; }
        public CustomerDetail Customer { get; set; }
    }
}
