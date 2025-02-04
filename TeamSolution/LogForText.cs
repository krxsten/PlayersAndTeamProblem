using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TeamSolution
{
    public class LogForText : ILog
    {
        string Text { get; set; }
        public LogForText(string text)
        {
            Text = text;
        }
        public void Logtext(string name, string text)
        {
            using (StreamWriter sw = new StreamWriter(text))
            {
                sw.WriteLine(name);
            }
        }
        public void Log(string text)
        {
            string name=Console.ReadLine();
            using (StreamWriter sw = new StreamWriter(text))
            {
                sw.WriteLine(name);
            }
        }
    }
}
