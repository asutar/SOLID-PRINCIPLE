using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_PRINCIPLE.O
{
   public class FinalInvoive:Invoice
    {
        public override double GetInvoiceDiscount(double amount)
        {
            return amount - 100;
        }
    }
}
