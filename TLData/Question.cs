using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TLData
{
    [Serializable]
    public class Question
    {
        public int Id;

        public string QuestionText;

        public byte[] QuestionImage;

        public List<Answer> Answers;
    }
}
