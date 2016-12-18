using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackTracking
{
    public class Prof
    {
        public int Id;
        public List<Time> FreeTimes = new List<Time>();
        public List<Course> Courses = new List<Course>();
        public string Name;
    }
}
