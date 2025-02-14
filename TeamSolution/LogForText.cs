﻿using System;
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
        public void Log(string text, IList<string> history)
        {
            using (StreamWriter sw = new StreamWriter(text))
            {
                foreach (var line in history)
                {
                    sw.WriteLine(line);
                }
            }
        }
    }
}
