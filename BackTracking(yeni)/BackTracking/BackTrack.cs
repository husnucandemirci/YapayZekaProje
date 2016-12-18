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
                int year = Courses[i].Year;
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
                            List<Boolean> check1 = new List<Boolean>();
                            Boolean checkk1 = new Boolean();
                            checkk1 = true;
                            for (int xxx = 0; xxx < t.End - t.Begin; xxx++)
                            {
                                check1.Add(true);
                            }
                            int xxxx1 = 0;
                            foreach (int k in saatler)
                            {
                                
                                if (Weeks[year].Mon[k-9] != false)
                                {
                                    check1[xxxx1] = false;
                                }
                                xxxx1 = xxxx1 + 1;
                            }
                            for (int yy = 0; yy <= check1.Count() - Courses[i].Duration; yy++)
                            {
                                checkk1 = true;
                                int oo = yy;
                                for (int ddd = yy; ddd < oo + Courses[i].Duration; ddd++)
                                {
                                    if (check1[ddd] == false)
                                    {
                                        checkk1 = false;
                                    }
                                }
                                if (checkk1 == true)
                                {
                                    t.realBegin = t.Begin + yy-1;
                                }
                            }

                            if (checkk1 == true)
                            {
                                int x1 = Courses[i].Duration;
                                int ii = 0;
                                List<int> saatler2 = new List<int>();
                                for (int ity = t.realBegin; ity < t.End; ity++)
                                {
                                    saatler2.Add(ity);
                                }
                                foreach (int k in saatler2)
                                {
                                    if (ii == x1)
                                    {
                                        break;
                                    }
                                    Weeks[year].Mon[k-9] = true;
                                    ii = ii + 1;
                                }
                                BreakLoop = true;
                            }
                            break;
                        case 2:
                            List<Boolean> check2 = new List<Boolean>();
                            Boolean checkk2 = new Boolean();
                            checkk1 = true;
                            for (int xxx = 0; xxx < t.End - t.Begin; xxx++)
                            {
                                check2.Add(true);
                            }
                            int xxxx2 = 0;
                            foreach (int k in saatler)
                            {

                                if (Weeks[year].Tue[k - 9] != false)
                                {
                                    check2[xxxx2] = false;
                                }
                                xxxx2 = xxxx2 + 1;
                            }
                            for (int yy = 0; yy <= check2.Count() - Courses[i].Duration; yy++)
                            {
                                checkk2 = true;
                                int oo = yy;
                                for (int ddd = yy; ddd < oo + Courses[i].Duration; ddd++)
                                {
                                    if (check2[ddd] == false)
                                    {
                                        checkk2 = false;
                                    }
                                }
                                if (checkk2 == true)
                                {
                                    t.realBegin = t.Begin + yy;
                                }
                            }

                            if (checkk2 == true)
                            {
                                int x1 = Courses[i].Duration;
                                int ii = 0;
                                List<int> saatler2 = new List<int>();
                                for (int ity = t.realBegin; ity < t.End; ity++)
                                {
                                    saatler2.Add(ity);
                                }
                                foreach (int k in saatler2)
                                {
                                    if (ii == x1)
                                    {
                                        break;
                                    }
                                    Weeks[year].Tue[k - 9] = true;
                                    ii = ii + 1;
                                }
                                BreakLoop = true;
                            }
                            break;
                        case 3:
                            List<Boolean> check3 = new List<Boolean>();
                            Boolean checkk3 = new Boolean();
                            checkk3 = true;
                            for (int xxx = 0; xxx < t.End - t.Begin; xxx++)
                            {
                                check3.Add(true);
                            }
                            int xxxx3 = 0;
                            foreach (int k in saatler)
                            {

                                if (Weeks[year].Wed[k - 9] != false)
                                {
                                    check3[xxxx3] = false;
                                }
                                xxxx3 = xxxx3 + 1;
                            }
                            for (int yy = 0; yy <= check3.Count() - Courses[i].Duration; yy++)
                            {
                                checkk3 = true;
                                int oo = yy;
                                for (int ddd = yy; ddd < oo + Courses[i].Duration; ddd++)
                                {
                                    if (check3[ddd] == false)
                                    {
                                        checkk3 = false;
                                    }
                                }
                                if (checkk3 == true)
                                {
                                    t.realBegin = t.Begin + yy;
                                }
                            }

                            if (checkk3 == true)
                            {
                                int x1 = Courses[i].Duration;
                                int ii = 0;
                                List<int> saatler2 = new List<int>();
                                for (int ity = t.realBegin; ity < t.End; ity++)
                                {
                                    saatler2.Add(ity);
                                }
                                foreach (int k in saatler2)
                                {
                                    if (ii == x1)
                                    {
                                        break;
                                    }
                                    Weeks[year].Wed[k - 9] = true;
                                    ii = ii + 1;
                                }
                                BreakLoop = true;
                            }
                            break;
                        case 4:
                            List<Boolean> check4 = new List<Boolean>();
                            Boolean checkk4 = new Boolean();
                            checkk4 = true;
                            for (int xxx = 0; xxx < t.End - t.Begin; xxx++)
                            {
                                check4.Add(true);
                            }
                            int xxxx4 = 0;
                            foreach (int k in saatler)
                            {

                                if (Weeks[year].Thu[k - 9] != false)
                                {
                                    check4[xxxx4] = false;
                                }
                                xxxx4 = xxxx4 + 1;
                            }
                            for (int yy = 0; yy <= check4.Count() - Courses[i].Duration; yy++)
                            {
                                checkk4 = true;
                                int oo = yy;
                                for (int ddd = yy; ddd < oo + Courses[i].Duration; ddd++)
                                {
                                    if (check4[ddd] == false)
                                    {
                                        checkk4 = false;
                                    }
                                }
                                if (checkk4 == true)
                                {
                                    t.realBegin = t.Begin + yy;
                                }
                            }

                            if (checkk4 == true)
                            {
                                int x1 = Courses[i].Duration;
                                int ii = 0;
                                List<int> saatler2 = new List<int>();
                                for (int ity = t.realBegin; ity < t.End; ity++)
                                {
                                    saatler2.Add(ity);
                                }
                                foreach (int k in saatler2)
                                {
                                    if (ii == x1)
                                    {
                                        break;
                                    }
                                    Weeks[year].Thu[k - 9] = true;
                                    ii = ii + 1;
                                }
                                BreakLoop = true;
                            }
                            break;
                        case 5:
                             List<Boolean> check5 = new List<Boolean>();
                            Boolean checkk5 = new Boolean();
                            checkk5 = true;
                            for (int xxx = 0; xxx < t.End - t.Begin; xxx++)
                            {
                                check5.Add(true);
                            }
                            int xxxx5 = 0;
                            foreach (int k in saatler)
                            {

                                if (Weeks[year].Fri[k - 9] != false)
                                {
                                    check5[xxxx5] = false;
                                }
                                xxxx5 = xxxx5 + 1;
                            }
                            for (int yy = 0; yy <= check5.Count() - Courses[i].Duration; yy++)
                            {
                                checkk5 = true;
                                int oo = yy;
                                for (int ddd = yy; ddd < oo + Courses[i].Duration; ddd++)
                                {
                                    if (check5[ddd] == false)
                                    {
                                        checkk5 = false;
                                    }
                                }
                                if (checkk5 == true)
                                {
                                    t.realBegin = t.Begin + yy;
                                }
                            }

                            if (checkk5 == true)
                            {
                                int x1 = Courses[i].Duration;
                                int ii = 0;
                                List<int> saatler2 = new List<int>();
                                for (int ity = t.realBegin; ity < t.End; ity++)
                                {
                                    saatler2.Add(ity);
                                }
                                foreach (int k in saatler2)
                                {
                                    if (ii == x1)
                                    {
                                        break;
                                    }
                                    Weeks[year].Fri[k - 9] = true;
                                    ii = ii + 1;
                                }
                                BreakLoop = true;
                            }
                            break;
                    }
                    if (BreakLoop == true)
                    {
                        t.End = t.realBegin + Courses[i].Duration;
                        Courses[i].TimeOfCourse = t;
                        Courses[i].TimeOfCourse.Begin = t.realBegin;
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
