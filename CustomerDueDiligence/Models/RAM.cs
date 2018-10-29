using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomerDueDiligence.Models
{
    public class RAM
    {
        public int Id { get; set; }

        public AccountType AccountType { get; set; }

        public byte AccountTypeId { get; set; }

        public QuestionCategory QuestionCategory { get; set; }

        public byte QuestionCategoryId { get; set; }

        public int MinScore { get; set; }

        public int MaxScore { get; set; }

        public char Grade { get; set; }

        public string Description { get; set; }
    }
}