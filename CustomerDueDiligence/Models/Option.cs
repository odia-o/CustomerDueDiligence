using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomerDueDiligence.Models
{
    public class Option
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Question Question { get; set; }

        public int QuestionID { get; set; }

        public byte Weight { get; set; }
    }
}