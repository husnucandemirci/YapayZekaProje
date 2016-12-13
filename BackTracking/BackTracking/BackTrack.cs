using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackTracking
{
    public class BackTrack
    {
        public static List<Course> MainMethod(List<Prof> Professors)
        {
            List<Course> Courses = new List<Course>();
            List<Course> ArrangedCourses = new List<Course>();
            foreach (Prof x in Professors)
            {
                foreach (Course y in x.Courses)
                {
                    y.PossibleTimes = x.FreeTimes;
                    y.NumberOfPossibleTimes = x.FreeTimes.Count();
                    Courses.Add(y);
                }
            }
            return Courses;
        }
        public static void Backtracker(List<Course> Courses, int NumberOfArranged)
        {
            if (NumberOfArranged == Courses.Count())
            {
                return;
            }
            for (int i = 0



        }


    }
}
