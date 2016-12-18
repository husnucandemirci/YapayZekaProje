using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackTracking
{
    public class Week
    {
        public List<Boolean> Mon = new List<Boolean>();
        public List<Boolean> Tue = new List<Boolean>();
        public List<Boolean> Wed = new List<Boolean>();
        public List<Boolean> Thu = new List<Boolean>();
        public List<Boolean> Fri = new List<Boolean>();
        public Week()
        {
            for (int i = 0; i < 10; i++)
            {
                Mon.Add(false);
                Tue.Add(false);
                Wed.Add(false);
                Thu.Add(false);
                Fri.Add(false);
            }
        }
    }
}
