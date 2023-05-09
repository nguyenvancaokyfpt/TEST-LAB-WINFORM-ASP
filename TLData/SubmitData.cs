using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TLData
{
    [Serializable]
    public class SubmitData
    {
        public int PaperId;
        public int StudentId;
        public List<Answer> Answers;
    }
}
