using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
   public class Payment
    {
        public long CardNumber { get; set; }
        public int CVVNumber { get; set; }
        public string ExpiryDate { get; set; }
        public string AccountHolderName { get; set; }
        public string BankName { get; set; }
        public string UserID { get; set; }
        public int UserPassword { get; set; }
        public Nullable<decimal> Balance { get; set; }
        public Nullable<decimal> Amount { get; set; }
     
        }
}
