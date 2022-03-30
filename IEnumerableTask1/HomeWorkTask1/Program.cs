using System;
using System.IO;

namespace HomeWorkTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            var stringLogger = new LocalFileLogger<string>("logs.txt");
            stringLogger.LogInfo("INFOINFOINFO");
            stringLogger.LogWarning("WARNINGWARNINGWARNING");
            stringLogger.LogError("ERRORERRORERROR", new NullReferenceException());

            var intLogger = new LocalFileLogger<int>("logs.txt");
            intLogger.LogInfo("INFOINFOINFO");
            intLogger.LogWarning("WARNINGWARNINGWARNING");
            intLogger.LogError("ERRORERRORERROR", new NullReferenceException());

            var boolLogger = new LocalFileLogger<bool>("logs.txt");
            boolLogger.LogInfo("INFOINFOINFO");
            boolLogger.LogWarning("WARNINGWARNINGWARNING");
            boolLogger.LogError("ERRORERRORERROR", new NullReferenceException());
        }
    }
}
