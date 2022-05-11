using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    public class Logger
    {
        private int _logRecordsIndex = 0;
        private string[] _logRecords = new string[100];
        private static Logger instance = null;

        private Logger()
        {
        }

        public static Logger Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Logger();
                }

                return instance;
            }
        }

        public void LogInfo(string message)
        {
            var logRecord = $"{DateTime.Now}: Info: {message}";
            _logRecords[_logRecordsIndex] = logRecord;
            _logRecordsIndex++;
            Console.WriteLine(logRecord);
        }

        public void LogWarning(string message)
        {
            var logRecord = $"{DateTime.Now}: Warning: {message}";
            _logRecords[_logRecordsIndex] = logRecord;
            _logRecordsIndex++;
            Console.WriteLine(logRecord);
        }

        public void LogError(string message)
        {
            var logRecord = $"{DateTime.Now}: Error: {message}";
            _logRecords[_logRecordsIndex] = logRecord;
            _logRecordsIndex++;
            Console.WriteLine(logRecord);
        }

        public string GetAllLogs()
        {
            return string.Join(Environment.NewLine, _logRecords);
        }
    }
}
