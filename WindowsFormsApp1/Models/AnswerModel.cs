using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public class AnswerModel
    {
        public int Ans_ID { get; set; }
        public bool ISCorrect { get; set; }
        public int? Stud_Marks { get; set; }
        public int Ques_ID { get; set; }
        public string StudentAnswer { get; set; }

    }
}
