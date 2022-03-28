using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkTask1
{
    internal class LocalFileLogger<T> : ILogger
    {
        private string roadToFile;
        public LocalFileLogger(string roadToFile)
        {
            this.roadToFile = roadToFile;
        }

        public void LogInfo(string message)
        {
            File.AppendAllText(roadToFile, $"[Info]: [{typeof(T).Name}] : {message}");
        }

        public void LogWarning(string message)
        {
            File.AppendAllText(roadToFile, $"[Warning] : [{typeof(T).Name}] : {message}");
        }

        public void LogError(string message, Exception ex)
        {
            File.AppendAllText(roadToFile, $"[Error] : [{typeof(T)}] : {message}. {ex.Message}");
        }
    }
}
