using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamSolution
{
    public class Log2 : ILog
    {
        string Text { get; set; }
        public Log2(string text)
        {
            Text = text;
        }
        public void Log(string text)
        {
            File.AppendAllText(Text, text);
        }

        public void Log(string text, IList<string> history)
        {
            throw new NotImplementedException();
        }
    }
}
