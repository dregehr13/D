using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace dougFirstWebApp.Models
{
    public class GradeCalcFormModel
    {
     //get and set functions for all input values
     //validated by range 0-100
        [Range(0, 100)]
        public int Assignments { get; set; }

        [Range(0, 100)]
        public int Project { get; set; }

        [Range(0, 100)]
        public int Quizzes { get; set; }

        [Range(0, 100)]
        public int Midterm { get; set; }

        [Range(0,100)]
        public int Final { get; set; }

        [Range(0, 100)]

        public int Intex { get; set; }
    }
}
