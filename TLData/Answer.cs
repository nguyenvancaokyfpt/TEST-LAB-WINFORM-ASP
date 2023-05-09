using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TLData
{
    [Serializable]
    public class Answer
    {
        public int Id;

        public int QuestionId;

        public string AnswerText;

        public bool IsChoice;
    }
}
