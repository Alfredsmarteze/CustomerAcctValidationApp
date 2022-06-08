using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStucture.Entity
{
    public class TransactionModel
    {
        public int Id { get; set; }
        public string? Surname { get; set; }
        public string? Firstname { get; set; }
        public bool? TransactionStatus { get; set; }
        public string? AccountName { get; set; }
        public string? AccountNumber { get; set; }
        public string? TransactionAmount { get; set; }

    }
}
