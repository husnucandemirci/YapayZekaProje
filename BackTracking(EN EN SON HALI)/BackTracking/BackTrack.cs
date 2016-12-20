using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackTracking
{
    public class BackTrack
    {
        public static Result MainMethod(List<Prof> Professors)
        {
            List<Course> Courses = new List<Course>();
            //List<Course> ArrangedCourses = new List<Course>();
            foreach (Prof x in Professors)
            {
                foreach (Course y in x.Courses)
                {
                    y.PossibleTimes = x.FreeTimes;
                    y.NumberOfPossibleTimes = x.FreeTimes.Count();
                    Courses.Add(y);
                }
            }
            List<Week> Weeks = new List<Week>();
            Week L1 = new Week();
            Week L2 = new Week();
            Week L3 = new Week();
            Weeks.Add(L1);
            Weeks.Add(L2);
            Weeks.Add(L3);
            Courses = Sorting(Courses);
            Backtracker(Courses, 0, Weeks, 0);
            Result result = new Result();
            result.Courses = Courses;
            result.Weeks = Weeks;
            return result;
        }
        public static Boolean Backtracker(List<Course> Courses, int NumberOfArranged, List<Week>Weeks, int dd)
        {
            if (NumberOfArranged == Courses.Count())
            {
                return true;
            }
            for (int i = dd; i < Courses.Count(); i++)
            {
                int year = Courses[i].Year - 1;
                Boolean BreakLoop = new Boolean();
                BreakLoop = false;
                foreach( Time t in Courses[i].PossibleTimes)
                {
                    int x = t.Begin;
                    int y = t.End;
                    int j = 9;
                    List<int> saatler = new List<int>();
                    while (x <= j && j <= y-1)
                    {
                        saatler.Add(j);
                        j = j + 1;
                    }                   
                    int z = t.Day;
                    
                    switch (z)
                    {
                        case 1:
                            Boolean check1 = new Boolean();
                            check1 = true;
                            foreach (int k in saatler)
                            {
                                if (Weeks[year].Mon[k - 9] != false || Courses[i].Duration != (t.End-t.Begin))
                                {
                                    check1 = false;
                                }
                            }
                            if (check1 == true)
                            {
                                foreach (int k in saatler)
                                {
                                    Weeks[year].Mon[k - 9] = true;

                                }
                                BreakLoop = true;
                            }
                            break;
                        case 2:
                            Boolean check2 = new Boolean();
                            check2 = true;
                            foreach (int k in saatler)
                            {
                                if (Weeks[year].Tue[k - 9] != false || Courses[i].Duration != (t.End - t.Begin))
                                {
                                    check2 = false;
                                }
                            }
                            if (check2 == true)
                            {
                                foreach (int k in saatler)
                                {
                                    Weeks[year].Tue[k - 9] = true;
                                   
                                }
                                BreakLoop = true;
                            }
                            break;
                        case 3:
                            Boolean check3 = new Boolean();
                            check3 = true;
                            foreach (int k in saatler)
                            {
                                if (Weeks[year].Wed[k - 9] != false || Courses[i].Duration != (t.End - t.Begin))
                                {
                                    check3 = false;
                                }
                            }
                            if (check3 == true)
                            {
                                foreach (int k in saatler)
                                {
                                    Weeks[year].Wed[k - 9] = true;
                                   
                                }
                                BreakLoop = true;
                            }
                            break;
                        case 4:
                            Boolean check4 = new Boolean();
                            check4 = true;
                            foreach (int k in saatler)
                            {
                                if (Weeks[year].Thu[k - 9] != false || Courses[i].Duration != (t.End - t.Begin))
                                {
                                    check4 = false;
                                }
                            }
                            if (check4 == true)
                            {
                                foreach (int k in saatler)
                                {
                                    Weeks[year].Thu[k - 9] = true;
                                   
                                }
                                BreakLoop = true;
                            }
                            break;
                        case 5:
                            Boolean check5 = new Boolean();
                            check5 = true;
                            foreach (int k in saatler)
                            {
                                if (Weeks[year].Fri[k - 9] != false || Courses[i].Duration != (t.End - t.Begin))
                                {
                                    check5 = false;
                                }
                            }
                            if (check5 == true)
                            {
                                foreach (int k in saatler)
                                {
                                    Weeks[year].Fri[k - 9] = true;
                                   
                                }
                                BreakLoop = true;
                            }
                            break;
                    }
                    if (BreakLoop == true)
                    {
                        int delete_i = 0, delete_j = 0;
                        Boolean delete_check = false;
                        //t.End = t.Begin + Courses[i].Duration;
                        Courses[i].TimeOfCourse = t;
                        for (delete_i = 0; delete_i < Courses.Count(); delete_i ++)
                        {
                            delete_check = false;
                            for (delete_j = 0; delete_j < Courses[delete_i].PossibleTimes.Count(); delete_j ++)
                            {
                                if (t.Begin == Courses[delete_i].PossibleTimes[delete_j].Begin && t.End == Courses[delete_i].PossibleTimes[delete_j].End && t.Day == Courses[delete_i].PossibleTimes[delete_j].Day && t.ProfId == Courses[delete_i].PossibleTimes[delete_j].ProfId)
                                {
                                    delete_check = true;
                                    break;
                                }
                            }
                            if (delete_check == true)
                            {
                                Courses[delete_i].PossibleTimes.Remove(Courses[delete_i].PossibleTimes[delete_j]);
                            }
                        }
                        NumberOfArranged = NumberOfArranged + 1;
                        break;
                    }
                }
                Boolean checkk = new Boolean();
                checkk = Backtracker(Courses, NumberOfArranged, Weeks, dd+1);
                if (checkk == true)
                {
                    return true;
                }

            }
            return false;
        }
        public static List<Course> Sorting(List<Course> Courses)
        {
            int i, j;
            Course a = new Course();
            for (i = 0; i < Courses.Count(); ++i)
            {
                for (j = i + 1; j < Courses.Count(); ++j)
                {
                    if (Courses[i].NumberOfPossibleTimes > Courses[j].NumberOfPossibleTimes)
                    {
                        a = Courses[i];
                        Courses[i] = Courses[j];
                        Courses[j] = a;
                    }
                }
            }
            return Courses;
        }
        public static List<Course> Add(Course Course, List<Course> ArrangedCourses)
        {


            return ArrangedCourses;
        }



    }
}
