using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_PRINCIPLE.O
{
    public class Invoice
    {
        #region violation SRP
        //public double GetInvoiceDiscount(double amount,InvoiceType _invoiceType)
        //{
        //    double finalAmount=0;
        //    if (_invoiceType == InvoiceType.FinalInvoive)
        //    {
        //        finalAmount = amount - 100;
        //    }
        //    if (_invoiceType == InvoiceType.ProposedInvoce) {
        //        finalAmount = amount - 50;
        //    }
        //    return finalAmount;
        //}
        #endregion
        #region According to SRP
        public virtual double GetInvoiceDiscount(double amount)
        {
            return amount - 10;
        }
        #endregion
    }
    public enum InvoiceType
    {
        FinalInvoive,
        ProposedInvoce
    };
}
