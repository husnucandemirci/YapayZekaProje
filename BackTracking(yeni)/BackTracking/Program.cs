using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackTracking
{
    public class Program
    {
        List<String> Days = new List<String>(5) { "Mon", "Tue", "Wed", "Thu", "Fri" };
        static void Main(string[] args)
        {
            List<Prof> Professors = new List<Prof>();
            int NumberOfProf, NumberOfCourse, j = 0, NumberOfFreeTimes;
            Console.WriteLine("Kac Tane Profesor var ? ");
            NumberOfProf = Convert.ToInt32(Console.ReadLine());
            for (int t = 0; t < NumberOfProf; t++)
            {
                Prof newProf = new Prof();
                Console.WriteLine("Profesorun ismi ne ? ");
                newProf.Name = Console.ReadLine();
                Console.WriteLine("Profesorun kac dersi var ? ");
                NumberOfCourse = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < NumberOfCourse; i++)
                {
                    Course newCourse = new Course();
                    Console.WriteLine("Kursun adi ne ? ");
                    string x = Console.ReadLine();
                    newCourse.Name = x;
                    newCourse.Id = j;
                    j = j + 1;
                    Console.WriteLine("Kacinci siniflarin dersi ? ");
                    newCourse.Year = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Dersin süresi ne kadar (saat cinsinden)");
                    newCourse.Duration = Convert.ToInt32(Console.ReadLine());
                    newProf.Courses.Add(newCourse);
                }
                Console.WriteLine("Toplam Kac bos vakit araligi var ? ");
                NumberOfFreeTimes = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < NumberOfFreeTimes; i++)
                {
                    Time newTime = new Time();
                    Console.WriteLine("Hangi Gun ?\n(Pzt icin 1, Cuma icin 5)");
                    newTime.Day = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Hangi saatler arasinda\n(mesela 9 icin 0900)");
                    newTime.Begin = Convert.ToInt32(Console.ReadLine());
                    newTime.End = Convert.ToInt32(Console.ReadLine());
                    newProf.FreeTimes.Add(newTime);
                }
                Professors.Add(newProf);
            }
            /*foreach (Prof x in Professors)
            {
                foreach (Course y in x.Courses)
                {
                    Console.WriteLine(y.Id + " - " + y.Name + " - " + y.Year);
                }
                foreach (Time y in x.FreeTimes)
                {
                    Console.WriteLine(y.Day + " : " + y.Begin + " - " + y.End);
                }
            }*/
            List<Course> Courses = new List<Course>();
            Result result = new Result();
            result = BackTrack.MainMethod(Professors);
            foreach (Course x in result.Courses)
            {
                Console.WriteLine(x.Name + " :" + x.TimeOfCourse.Begin + " " + " - " + " " + x.TimeOfCourse.End + " day: " + x.TimeOfCourse.Day);

            }
            /*foreach (Course x in Courses)
            {
                Console.WriteLine(x.Name + " :");
                foreach (Time y in x.PossibleTimes)
                {
                    Console.WriteLine(y.Day + " : " + y.Begin + " - " + y.End);
                }
            }*/
            Console.ReadLine();
        }
    }
}
