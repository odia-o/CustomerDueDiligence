using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomerDueDiligence.Models
{
    public class Question
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public AccountType AccountType { get; set; }

        public byte AccountTypeId { get; set; }

        public DateTime created { get; set; }

        public QuestionCategory QuestionCategory { get; set; }

        public byte QuestionCategoryId { get; set; }

        public QuestionType QuestionType { get; set; }

        public byte QuestionTypeId { get; set; }

        public byte Weight { get; set; }
    }
}