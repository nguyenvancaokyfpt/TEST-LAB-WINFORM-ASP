using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TracNghiemOnline.Models
{
    public class QuestionOfTestViewModel
    {
        public quests_of_test quests_Of_Test { get; set; }
        public test test { get; set; }
        public question question { get; set; }
    }
}