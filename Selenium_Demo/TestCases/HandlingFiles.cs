using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Selenium_Demo.TestCases
{
    public class HandlingFiles
    {
        [Test]
        public void ReadTextFile()
        {
            string path = "C:\\Users\\Anand.Gummadilli\\Documents\\Apnaohio.txt";
            // Read the entire file content
            string content = File.ReadAllText(path);
            Console.WriteLine(content);
        }
        [Test]
        public void GenerateLogFile()
        {
            string path = "C:\\Users\\Anand.Gummadilli\\Documents\\log.txt";

            string content = "I am Mahesh." + DateTime.Now;

            //File.WriteAllText(path, content);
            File.AppendAllText(path, content);
            Console.WriteLine("File written successfully.");
        }
    }
}
