using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    public class Actions
    {
        public Result FirstMethod()
        {
            var message = "Start method:FirstMethod";
            Logger.Instance.LogInfo(message);

            return new Result { Status = true };
        }

        public Result SeccondMethod()
        {
            var message = "Skipped logic in method:SeccondMethod";
            Logger.Instance.LogWarning(message);

            return new Result { Status = true };
        }

        public Result ThirdtMethod()
        {
            var message = "I broke a logic";

            return new Result { Status = false, Message = message };
        }
    }
}
