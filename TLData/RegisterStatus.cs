using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TLData
{
    [Serializable]
    public enum RegisterStatus
    {
        NEW,
        FINISHED,
        REGISTER_ERROR,
        EXAM_CODE_NOT_EXISTS,
        LOGIN_FAILED
    }
}
