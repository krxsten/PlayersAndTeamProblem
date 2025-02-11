using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamSolution
{
    public interface ILog
    {
        void Log(string text, IList<string> history);
    }
}
