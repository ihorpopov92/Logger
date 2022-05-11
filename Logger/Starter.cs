using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    public class Starter
    {
        public void Run()
        {
            Actions actions = new Actions();
            for (int i = 0; i < 100; i++)
            {
                Result result;
                Random random = new Random();
                var methodIndex = random.Next(1, 4);
                if (methodIndex == 1)
                {
                    result = actions.FirstMethod();
                }
                else if (methodIndex == 2)
                {
                    result = actions.SeccondMethod();
                }
                else
                {
                    result = actions.ThirdtMethod();
                }

                if (result.Status == false)
                {
                    Logger.Instance.LogError($"Action failed by a reason: {result.Message}");
                }
            }
        }
    }
}
