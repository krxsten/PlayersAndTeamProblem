using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamSolution
{
    public class LogForExcel:ILog
    {
        private List<string> text;
        public LogForExcel()
        {
            text = new List<string>();
        }
        public void Log(string excelText)
        {
            text.Add(excelText);
        }
        public void SaveLog(string filePath)
        {
            throw new NotImplementedException("Not Implemented");
        }
    }
}
