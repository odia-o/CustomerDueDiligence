using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomerDueDiligence.Models
{
    public class QuestionCategory
    {
        public byte Id { get; set; }

        public string Name { get; set; }

        public string Type { get; set; }

        public byte Weight { get; set; }

        public string Description { get; set; }
    }
}