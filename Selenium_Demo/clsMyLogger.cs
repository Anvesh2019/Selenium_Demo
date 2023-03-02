using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Selenium_Demo
{
    public class clsMyLogger
    {
        string path = @"C:\Logs\Mylogs.txt";
        public void LogMessage(string logMsg)
        {
            StreamWriter sw;
            if (!File.Exists(path))
            { 
                sw = File.CreateText(path); 
            }
            else
            { 
                sw = File.AppendText(path); 
            }

            LogWrite(logMsg, sw);

            sw.Flush();
            sw.Close();
        }
        private static void LogWrite(string logMessage, StreamWriter w)
        {
            w.WriteLine("{0}", logMessage);
            w.WriteLine("----------------------------------------");
        }
    }
}
