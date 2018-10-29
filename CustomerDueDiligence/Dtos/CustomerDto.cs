using CustomerDueDiligence.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomerDueDiligence.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }

        public byte AccountTypeId { get; set; }

        public AccountTypeDto AccountType { get; set; }

        public string Firstname { get; set; }

        public string Lastname { get; set; }

    }
}