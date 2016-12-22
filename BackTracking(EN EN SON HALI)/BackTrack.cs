using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackTracking
{
    public class BackTrack
    {
        public static List<Week> Weeks = new List<Week>();
        public static Week L1 = new Week();
        public static Week L2 = new Week();
        public static Week L3 = new Week();
        public static List<Course> NotArrangedCourses = new List<Course>();
 
        public static Result MainMethod(List<Prof> Professors,int tmp, Result result, Boolean isBack)
        {
            List<Course> Courses;
            Weeks = result.Weeks;
            if (tmp == 0)
            {
                Weeks.Add(L1);
                Weeks.Add(L2);
                Weeks.Add(L3);
                //Result result = new Result();

                Courses = new List<Course>();
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
            }
            else
            {
                Courses = result.Courses;
                int len = Professors.Count();
                int counter = 0;
                foreach (Prof x in Professors)
                {
                    foreach (Course y in x.Courses)
                    {
                        if (counter != len - 1)
                        {
                            Courses[counter].PossibleTimes = x.FreeTimes;
                            Courses[counter].NumberOfPossibleTimes = x.FreeTimes.Count();
                        }
                        else
                        {
                            
                            for (int nc = x.FreeTimes.Count; nc > 0; nc--)
                            {
                                if (!y.PossibleTimes.Contains(x.FreeTimes[Math.Abs(nc-1)]))
                                {
                                    y.PossibleTimes = x.FreeTimes;
                                    y.NumberOfPossibleTimes = x.FreeTimes.Count();
                                }
                            }
                            Courses.Add(y);
                        }
                    }
                    counter += 1;
                }
            }
           
            Courses = Sorting(Courses);
            if (isBack == false)
            {
                Backtracker(Courses, 0, Weeks, 0,Professors);
            }
            else
            {
                Back(Courses, 0, Weeks, 0, Professors,result);
            }
            
            result.Courses = Courses;
            result.Weeks = Weeks;
            result.NotArrangedCourses = NotArrangedCourses;
            return result;
        }
        public static Boolean Backtracker(List<Course> Courses, int NumberOfArranged, List<Week> Weeks, int dd, List<Prof> Professors)
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
                    while (x < y) {
                        for (int ctr = 0; ctr < Courses[i].Duration; ctr++)
                        {
                            saatler.Add(x);
                            x = x + 1;
                        }
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
                                    if(Weeks[year].Mon_CourseId[k-9] == Courses[i].Id)
                                    {
                                        check1 = true;
                                    }
                                    else { 
                                        check1 = false;
                                        if (!NotArrangedCourses.Contains(Courses[i]))
                                        {
                                            NotArrangedCourses.Add(Courses[i]);
                                            NumberOfArranged += 1;
                                        }
                                    }
                                }
                            }
                            if (check1 == true)
                            {
                                foreach (int k in saatler)
                                {
                                    Weeks[year].Mon[k - 9] = true;
                                    Weeks[year].Mon_CourseId[k - 9] = Courses[i].Id;

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
                                    if (Weeks[year].Tue_CourseId[k - 9] == Courses[i].Id)
                                    {
                                        check2 = true;
                                    }
                                    else
                                    {
                                        check2 = false;
                                        if (!NotArrangedCourses.Contains(Courses[i]))
                                        {
                                            NotArrangedCourses.Add(Courses[i]);
                                            NumberOfArranged += 1;
                                        }
                                    }
                                }
                            }
                            if (check2 == true)
                            {
                                foreach (int k in saatler)
                                {
                                    Weeks[year].Tue[k - 9] = true;
                                    Weeks[year].Tue_CourseId[k - 9] = Courses[i].Id;

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
                                    if (Weeks[year].Wed_CourseId[k - 9] == Courses[i].Id)
                                    {
                                        check3 = true;
                                    }
                                    else
                                    {
                                        check3 = false;
                                        if (!NotArrangedCourses.Contains(Courses[i]))
                                        {
                                            NotArrangedCourses.Add(Courses[i]);
                                            NumberOfArranged += 1;
                                        }
                                    }
                                }
                            }
                            if (check3 == true)
                            {
                                foreach (int k in saatler)
                                {
                                    Weeks[year].Wed[k - 9] = true;
                                    Weeks[year].Wed_CourseId[k - 9] = Courses[i].Id;

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
                                    if (Weeks[year].Thu_CourseId[k - 9] == Courses[i].Id)
                                    {
                                        check4 = true;
                                    }
                                    else
                                    {
                                        check4 = false;
                                        if (!NotArrangedCourses.Contains(Courses[i]))
                                        {
                                            NotArrangedCourses.Add(Courses[i]);
                                            NumberOfArranged += 1;
                                        }
                                    }
                                }
                            }
                            if (check4 == true)
                            {
                                foreach (int k in saatler)
                                {
                                    Weeks[year].Thu[k - 9] = true;
                                    Weeks[year].Thu_CourseId[k - 9] = Courses[i].Id;


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
                                    if (Weeks[year].Fri_CourseId[k - 9] == Courses[i].Id)
                                    {
                                        check5 = true;
                                    }
                                    else
                                    {
                                        check5 = false;
                                        if (!NotArrangedCourses.Contains(Courses[i]))
                                        {
                                            NotArrangedCourses.Add(Courses[i]);
                                            NumberOfArranged += 1;
                                        }
                                    }
                                }
                            }
                            if (check5 == true)
                            {
                                foreach (int k in saatler)
                                {
                                    Weeks[year].Fri[k - 9] = true;
                                    Weeks[year].Fri_CourseId[k - 9] = Courses[i].Id;


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
                                List<Prof> deneme = Professors;
                                Courses[delete_i].PossibleTimes.Remove(Courses[delete_i].PossibleTimes[delete_j]);

                            }
                        }
                        NumberOfArranged = NumberOfArranged + 1;
                        break;
                    }
                }
                Boolean checkk = new Boolean();
                checkk = Backtracker(Courses, NumberOfArranged, Weeks, dd+1, Professors);
                if (checkk == true)
                {
                    return true;
                }
                if(checkk == false)
                {
                    return false;
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

        public static Boolean Back(List<Course> Courses, int NumberOfArranged, List<Week> Weeks, int dd, List<Prof> Professors, Result result)
        {
            for(int i=0; i<result.NotArrangedCourses.Count; i++)
            {
                Course tmpCourse = new Course();
                tmpCourse = result.NotArrangedCourses[i];
                int k = tmpCourse.NumberOfPossibleTimes;
            }
            
            return true;
        }

    }
}
