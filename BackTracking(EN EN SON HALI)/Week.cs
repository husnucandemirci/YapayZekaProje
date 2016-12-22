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
        public int[] Mon_CourseId = new int[10];
        public int[] Tue_CourseId = new int[10];
        public int[] Wed_CourseId = new int[10];
        public int[] Thu_CourseId = new int[10];
        public int[] Fri_CourseId = new int[10];
        public Week()
        {
            for (int i = 0; i < 10; i++)
            {
                Mon.Add(false);
                Tue.Add(false);
                Wed.Add(false);
                Thu.Add(false);
                Fri.Add(false);
                Mon_CourseId[i] = 0;
                Tue_CourseId[i] = 0;
                Wed_CourseId[i] = 0;
                Thu_CourseId[i] = 0;
                Fri_CourseId[i] = 0;

            }
        }
    }
}
