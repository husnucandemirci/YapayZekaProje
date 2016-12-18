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
            /*
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
            List<Prof> Professors = new List<Prof>();
            
            Prof Atay = new Prof();
            Atay.Id = 1;
            Atay.Name = "Atay";

            Course Bilgisayara_giris = new Course();
            Bilgisayara_giris.Id = 1;
            Bilgisayara_giris.Name = "Bilgisayar muhendisligine giris";
            Bilgisayara_giris.Year = 1;
            Bilgisayara_giris.Duration = 2;
            Atay.Courses.Add(Bilgisayara_giris);
            
            Time time1 = new Time(); time1.Begin = 9; time1.End = 11; time1.Day = 1;
            Atay.FreeTimes.Add(time1);
            
            Prof Pelletier = new Prof();
            Pelletier.Id = 2;
            Pelletier.Name = "Pelletier";

            Course fransizca = new Course(); 
            fransizca.Id = 2;
            fransizca.Name = "Fransizca";
            fransizca.Year = 1;
            fransizca.Duration = 2;
            Pelletier.Courses.Add(fransizca);

            Time time2 = new Time(); time2.Begin = 11; time2.End = 13; time2.Day = 1;
            Pelletier.FreeTimes.Add(time2);
            
            Prof Chavaz = new Prof();
            Chavaz.Id = 3;
            Chavaz.Name = "Chavaz";

            Course mat1 = new Course();
            mat1.Id = 3;
            mat1.Name = "Matematik";
            mat1.Year = 1;
            mat1.Duration = 2;
            Chavaz.Courses.Add(mat1);
            
            Course mat2 = new Course();
            mat2.Id = 4;
            mat2.Name = "Matematik";
            mat2.Year = 1;
            mat2.Duration = 3;
            Chavaz.Courses.Add(mat2);

            Course mat3 = new Course();
            mat3.Id = 5;
            mat3.Name = "Matematik";
            mat3.Year = 1;
            mat3.Duration = 2;
            Chavaz.Courses.Add(mat3);

            Course mat4 = new Course();
            mat4.Id = 6;
            mat4.Name = "Matematik";
            mat4.Year = 1;
            mat4.Duration = 3;
            Chavaz.Courses.Add(mat4);

            Time time3 = new Time(); time3.Begin = 14; time3.End = 16; time3.Day = 1; Chavaz.FreeTimes.Add(time3);
            Time time4 = new Time(); time4.Begin = 9;  time4.End = 12; time4.Day = 2; Chavaz.FreeTimes.Add(time4);
            Time time5 = new Time(); time5.Begin = 14; time5.End = 16; time5.Day = 3; Chavaz.FreeTimes.Add(time5);
            Time time6 = new Time(); time6.Begin = 14; time6.End = 17; time6.Day = 4; Chavaz.FreeTimes.Add(time6);

            Prof Naskali = new Prof();
            Naskali.Id = 4;
            Naskali.Name = "Naskali";

            Course Programlamaya_Giris1 = new Course();
            Programlamaya_Giris1.Id = 7;
            Programlamaya_Giris1.Name = "Programlamaya Giris";
            Programlamaya_Giris1.Year = 1;
            Programlamaya_Giris1.Duration = 2;
            Naskali.Courses.Add(Programlamaya_Giris1);

            Course Programlamaya_Giris2 = new Course();
            Programlamaya_Giris2.Id = 8;
            Programlamaya_Giris2.Name = "Programlamaya Giris";
            Programlamaya_Giris2.Year = 1;
            Programlamaya_Giris2.Duration = 2;
            Naskali.Courses.Add(Programlamaya_Giris2);

            Time time7 = new Time(); time7.Begin = 16; time7.End = 18; time7.Day = 1; Naskali.FreeTimes.Add(time7);
            Time time8 = new Time(); time8.Begin = 9;  time8.End = 11; time8.Day = 4; Naskali.FreeTimes.Add(time8);

            Prof Devoldere = new Prof();
            Devoldere.Id = 5;
            Devoldere.Name = "Devoldere";

            Course Fizik1 = new Course();
            Fizik1.Id = 9;
            Fizik1.Name = "Fizik";
            Fizik1.Year = 1;
            Fizik1.Duration = 3;
            Devoldere.Courses.Add(Fizik1);

            Course Fizik2 = new Course();
            Fizik2.Id = 10;
            Fizik2.Name = "Fizik";
            Fizik2.Year = 1;
            Fizik2.Duration = 2;
            Devoldere.Courses.Add(Fizik2);

            Course Kimya1 = new Course();
            Kimya1.Id = 11;
            Kimya1.Name = "Kimya";
            Kimya1.Year = 1;
            Kimya1.Duration = 2;
            Devoldere.Courses.Add(Kimya1);

            Course Kimya2 = new Course();
            Kimya2.Id = 12;
            Kimya2.Name = "Kimya/Fizik Labi";
            Kimya2.Year = 1;
            Kimya2.Duration = 3;
            Devoldere.Courses.Add(Kimya2);

            Time time9 = new Time(); time9.Begin = 13; time9.End = 16; time9.Day = 2;     Devoldere.FreeTimes.Add(time9);
            Time time10 = new Time(); time10.Begin = 11; time10.End = 13; time10.Day = 3;  Devoldere.FreeTimes.Add(time10);
            Time time11 = new Time(); time11.Begin = 13; time11.End = 15; time11.Day = 5; Devoldere.FreeTimes.Add(time11);
            Time time12 = new Time(); time12.Begin = 15; time12.End = 18; time12.Day = 5; Devoldere.FreeTimes.Add(time12);

            Prof Zoralioglu = new Prof();
            Zoralioglu.Id = 6;
            Zoralioglu.Name = "Zoralioglu";

            Course turkce = new Course();
            turkce.Id = 13;
            turkce.Name = "Turkce";
            turkce.Year = 1;
            turkce.Duration = 2;
            Zoralioglu.Courses.Add(turkce);

            Time time13 = new Time(); time13.Begin = 10; time13.End = 12; time13.Day = 5; Zoralioglu.FreeTimes.Add(time13);

            Prof YabancidilProf = new Prof();
            YabancidilProf.Id = 7;
            YabancidilProf.Name = "Yabanci Dil";

            Course yabancidil1 = new Course();
            yabancidil1.Id = 14;
            yabancidil1.Name = "Yabanci Dil";
            yabancidil1.Year = 1;
            yabancidil1.Duration = 2;
            YabancidilProf.Courses.Add(yabancidil1);

            Course yabancidil2 = new Course();
            yabancidil2.Id = 15;
            yabancidil2.Name = "Yabanci Dil";
            yabancidil2.Year = 1;
            yabancidil2.Duration = 2;
            YabancidilProf.Courses.Add(yabancidil2);

            Time time14 = new Time(); time14.Begin = 16; time14.End = 18; time14.Day = 2; YabancidilProf.FreeTimes.Add(time14);
            Time time15 = new Time(); time15.Begin = 16; time15.End = 18; time15.Day = 3; YabancidilProf.FreeTimes.Add(time15);

            Professors.Add(Atay); Professors.Add(Pelletier); Professors.Add(Chavaz); Professors.Add(Naskali); Professors.Add(Devoldere); Professors.Add(Zoralioglu); Professors.Add(YabancidilProf);

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
