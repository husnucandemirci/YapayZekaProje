using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackTracking
{
    public class Course
    {
        public List<Time> PossibleTimes = new List<Time>();
        public int NumberOfPossibleTimes;
        public int Id;
        public string Name;
        public Time TimeOfCourse;
        public int Year;    // Kacinci siniflarin dersi olacağı bilgisi
        public int Duration;
    }
}
