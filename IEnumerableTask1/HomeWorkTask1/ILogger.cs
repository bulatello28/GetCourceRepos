﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkTask1
{
    internal interface ILogger
    {
        public void LogInfo(string message)
        {
            
        }
        public void LogWarning(string message)
        {
            
        }

        public void LogError(string message, Exception ex)
        {
            
        }
    }
}
