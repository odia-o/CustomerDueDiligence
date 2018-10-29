using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomerDueDiligence.Models
{
    public class Customer
    {
        public int Id { get; set; }

        public AccountType AccountType { get; set; }

        public byte AccountTypeId { get; set; }

        public string Firstname { get; set; }

        public string Lastname { get; set; }



        public DateTime Created { get; set; }
    }
}