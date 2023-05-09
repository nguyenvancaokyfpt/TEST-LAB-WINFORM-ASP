using TLData;

namespace TLData
{
    [Serializable]
    public class TLData
    {
        public List<Question> Questions;
        public int PaperId;
        public string ExamName;
        public string ExamCode;
        public int ExamDuration;
        public byte[] GUI;
    }
}