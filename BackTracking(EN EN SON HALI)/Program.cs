using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackTracking
{
    public class Program
    {
        static List<String> Days = new List<String>(5) { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" };
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

            Result result = new Result();

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

            Time time1 = new Time(); time1.Begin = 9; time1.End = 11; time1.Day = 1; time1.ProfId = 1; Atay.FreeTimes.Add(time1);
            Professors.Add(Atay); 
            result = BackTrack.MainMethod(Professors,0,result,false);

            Prof Pelletier = new Prof();
            Pelletier.Id = 2;
            Pelletier.Name = "Pelletier";

            Course fransizca = new Course(); 
            fransizca.Id = 2;
            fransizca.Name = "Fransizca";
            fransizca.Year = 1;
            fransizca.Duration = 2;
            Pelletier.Courses.Add(fransizca);

            Time time2 = new Time(); time2.Begin = 9; time2.End = 11; time2.Day = 1; time2.ProfId = 2;
            Atay.FreeTimes.Add(time1);
            Pelletier.FreeTimes.Add(time2);
            Professors.Add(Pelletier);
            result = BackTrack.MainMethod(Professors,1,result,false);

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

            Time time3 = new Time(); time3.Begin = 14; time3.End = 16; time3.Day = 1; time3.ProfId = 3; 
            Time time4 = new Time(); time4.Begin = 9; time4.End = 12; time4.Day = 2;  time4.ProfId = 3; 
            Time time5 = new Time(); time5.Begin = 14; time5.End = 16; time5.Day = 3; time5.ProfId = 3; 
            Time time6 = new Time(); time6.Begin = 14; time6.End = 17; time6.Day = 4; time6.ProfId = 3; 
            
            Atay.FreeTimes.Add(time1);
            Pelletier.FreeTimes.Add(time2);
            Chavaz.FreeTimes.Add(time3);Chavaz.FreeTimes.Add(time4);Chavaz.FreeTimes.Add(time5);Chavaz.FreeTimes.Add(time6);
            Professors.Add(Chavaz);
            
            result = BackTrack.MainMethod(Professors,1,result,false);

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

            Time time7 = new Time(); time7.Begin = 16; time7.End = 18; time7.Day = 1; time7.ProfId = 4; 
            Time time8 = new Time(); time8.Begin = 9; time8.End = 11; time8.Day = 4;  time8.ProfId = 4; 
            Atay.FreeTimes.Add(time1);
            Pelletier.FreeTimes.Add(time2);
            Chavaz.FreeTimes.Add(time3); Chavaz.FreeTimes.Add(time4); Chavaz.FreeTimes.Add(time5); Chavaz.FreeTimes.Add(time6);
            Naskali.FreeTimes.Add(time7);Naskali.FreeTimes.Add(time8);
            Professors.Add(Naskali); 
            result = BackTrack.MainMethod(Professors,1,result,false);

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

            Time time9 = new Time(); time9.Begin = 13; time9.End = 16; time9.Day = 2; time9.ProfId = 5; 
            Time time10 = new Time(); time10.Begin = 11; time10.End = 13; time10.Day = 3; time10.ProfId = 5; 
            Time time11 = new Time(); time11.Begin = 13; time11.End = 15; time11.Day = 5; time11.ProfId = 5; 
            Time time12 = new Time(); time12.Begin = 15; time12.End = 18; time12.Day = 5; time12.ProfId = 5; 
            Atay.FreeTimes.Add(time1);
            Pelletier.FreeTimes.Add(time2);
            Chavaz.FreeTimes.Add(time3); Chavaz.FreeTimes.Add(time4); Chavaz.FreeTimes.Add(time5); Chavaz.FreeTimes.Add(time6);
            Naskali.FreeTimes.Add(time7); Naskali.FreeTimes.Add(time8);
            Devoldere.FreeTimes.Add(time9);Devoldere.FreeTimes.Add(time10);Devoldere.FreeTimes.Add(time11);Devoldere.FreeTimes.Add(time12);
            Professors.Add(Devoldere); 
            result = BackTrack.MainMethod(Professors,1,result,false);

            Prof Zoralioglu = new Prof();
            Zoralioglu.Id = 6;
            Zoralioglu.Name = "Zoralioglu";

            Course turkce = new Course();
            turkce.Id = 13;
            turkce.Name = "Turkce";
            turkce.Year = 1;
            turkce.Duration = 2;
            Zoralioglu.Courses.Add(turkce);

            Time time13 = new Time(); time13.Begin = 10; time13.End = 12; time13.Day = 5; time13.ProfId = 6;
            Atay.FreeTimes.Add(time1);
            Pelletier.FreeTimes.Add(time2);
            Chavaz.FreeTimes.Add(time3); Chavaz.FreeTimes.Add(time4); Chavaz.FreeTimes.Add(time5); Chavaz.FreeTimes.Add(time6);
            Naskali.FreeTimes.Add(time7); Naskali.FreeTimes.Add(time8);
            Devoldere.FreeTimes.Add(time9); Devoldere.FreeTimes.Add(time10); Devoldere.FreeTimes.Add(time11); Devoldere.FreeTimes.Add(time12);
            Zoralioglu.FreeTimes.Add(time13);
            Professors.Add(Zoralioglu);
            
            result = BackTrack.MainMethod(Professors,1,result,false);

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

            Time time14 = new Time(); time14.Begin = 16; time14.End = 18; time14.Day = 2; time14.ProfId = 7;
            Time time15 = new Time(); time15.Begin = 16; time15.End = 18; time15.Day = 3; time15.ProfId = 7;
            Atay.FreeTimes.Add(time1);
            Pelletier.FreeTimes.Add(time2);
            Chavaz.FreeTimes.Add(time3); Chavaz.FreeTimes.Add(time4); Chavaz.FreeTimes.Add(time5); Chavaz.FreeTimes.Add(time6);
            Naskali.FreeTimes.Add(time7); Naskali.FreeTimes.Add(time8);
            Devoldere.FreeTimes.Add(time9); Devoldere.FreeTimes.Add(time10); Devoldere.FreeTimes.Add(time11); Devoldere.FreeTimes.Add(time12);
            Zoralioglu.FreeTimes.Add(time13);
            YabancidilProf.FreeTimes.Add(time14);
            YabancidilProf.FreeTimes.Add(time15);
            Professors.Add(YabancidilProf); 
            result = BackTrack.MainMethod(Professors,1,result,false);

            Prof Orman = new Prof();
            Orman.Id = 8;
            Orman.Name = "Orman";

            Course VeriYapisi1 = new Course();
            VeriYapisi1.Id = 15;
            VeriYapisi1.Name = "Veri Yapisi ve Algoritmalar";
            VeriYapisi1.Year = 2;
            VeriYapisi1.Duration = 2;
            Orman.Courses.Add(VeriYapisi1);

            Course VeriYapisi2 = new Course();
            VeriYapisi2.Id = 16;
            VeriYapisi2.Name = "Veri Yapisi ve Algoritmalar";
            VeriYapisi2.Year = 2;
            VeriYapisi2.Duration = 2;
            Orman.Courses.Add(VeriYapisi2);

            Course Programlama_Uygulamaları = new Course();
            Programlama_Uygulamaları.Id = 17;
            Programlama_Uygulamaları.Name = "Programlama Uygulamaları";
            Programlama_Uygulamaları.Year = 2;
            Programlama_Uygulamaları.Duration = 2;
            Orman.Courses.Add(Programlama_Uygulamaları);


            Time time16 = new Time(); time16.Begin = 9; time16.End = 11; time16.Day = 1; time16.ProfId = 8; 
            Time time17 = new Time(); time17.Begin = 9; time17.End = 11; time17.Day = 4; time17.ProfId = 8; 
            Time time18 = new Time(); time18.Begin = 11; time18.End = 13; time18.Day = 5; time18.ProfId = 8; 
            Atay.FreeTimes.Add(time1);
            Pelletier.FreeTimes.Add(time2);
            Chavaz.FreeTimes.Add(time3); Chavaz.FreeTimes.Add(time4); Chavaz.FreeTimes.Add(time5); Chavaz.FreeTimes.Add(time6);
            Naskali.FreeTimes.Add(time7); Naskali.FreeTimes.Add(time8);
            Devoldere.FreeTimes.Add(time9); Devoldere.FreeTimes.Add(time10); Devoldere.FreeTimes.Add(time11); Devoldere.FreeTimes.Add(time12);
            Zoralioglu.FreeTimes.Add(time13);
            YabancidilProf.FreeTimes.Add(time14);
            YabancidilProf.FreeTimes.Add(time15);
            Orman.FreeTimes.Add(time16);Orman.FreeTimes.Add(time17);Orman.FreeTimes.Add(time18);
            Professors.Add(Orman);
            result = BackTrack.MainMethod(Professors,1,result,false);

            Prof Peroueme = new Prof();
            Peroueme.Id = 9;
            Peroueme.Name = "Peroueme";

            Course Yuksek_Matematik1 = new Course();
            Yuksek_Matematik1.Id = 18;
            Yuksek_Matematik1.Name = "Yuksek Matematik";
            Yuksek_Matematik1.Year = 2;
            Yuksek_Matematik1.Duration = 3;
            Peroueme.Courses.Add(Yuksek_Matematik1);

            Course Yuksek_Matematik2 = new Course();
            Yuksek_Matematik2.Id = 19;
            Yuksek_Matematik2.Name = "Yuksek Matematik";
            Yuksek_Matematik2.Year = 2;
            Yuksek_Matematik2.Duration = 2;
            Peroueme.Courses.Add(Yuksek_Matematik2);

            Time time19 = new Time(); time19.Begin = 11; time19.End = 14; time19.Day = 1;
            Time time20 = new Time(); time20.Begin = 9; time20.End = 11; time20.Day = 5;
            time19.ProfId = 9;
            time20.ProfId = 9;
            Atay.FreeTimes.Add(time1);
            Pelletier.FreeTimes.Add(time2);
            Chavaz.FreeTimes.Add(time3); Chavaz.FreeTimes.Add(time4); Chavaz.FreeTimes.Add(time5); Chavaz.FreeTimes.Add(time6);
            Naskali.FreeTimes.Add(time7); Naskali.FreeTimes.Add(time8);
            Devoldere.FreeTimes.Add(time9); Devoldere.FreeTimes.Add(time10); Devoldere.FreeTimes.Add(time11); Devoldere.FreeTimes.Add(time12);
            Zoralioglu.FreeTimes.Add(time13);
            YabancidilProf.FreeTimes.Add(time14);
            YabancidilProf.FreeTimes.Add(time15);
            Orman.FreeTimes.Add(time16); Orman.FreeTimes.Add(time17); Orman.FreeTimes.Add(time18);
            Peroueme.FreeTimes.Add(time19);
            Peroueme.FreeTimes.Add(time20);
            Professors.Add(Peroueme);
            result = BackTrack.MainMethod(Professors,1,result,false);

            Prof Okay = new Prof();
            Okay.Id = 10;
            Okay.Name = "Okay";

            Course tarih = new Course();
            tarih.Id = 20;
            tarih.Name = "Inkilap Tarihi 1";
            tarih.Year = 2;
            tarih.Duration = 2;
            Okay.Courses.Add(tarih);

            Time time21 = new Time(); time21.Begin = 14; time21.End = 16; time21.Day = 1;
            time21.ProfId = 10;
            Atay.FreeTimes.Add(time1);
            Pelletier.FreeTimes.Add(time2);
            Chavaz.FreeTimes.Add(time3); Chavaz.FreeTimes.Add(time4); Chavaz.FreeTimes.Add(time5); Chavaz.FreeTimes.Add(time6);
            Naskali.FreeTimes.Add(time7); Naskali.FreeTimes.Add(time8);
            Devoldere.FreeTimes.Add(time9); Devoldere.FreeTimes.Add(time10); Devoldere.FreeTimes.Add(time11); Devoldere.FreeTimes.Add(time12);
            Zoralioglu.FreeTimes.Add(time13);
            YabancidilProf.FreeTimes.Add(time14);
            YabancidilProf.FreeTimes.Add(time15);
            Orman.FreeTimes.Add(time16); Orman.FreeTimes.Add(time17); Orman.FreeTimes.Add(time18);
            Peroueme.FreeTimes.Add(time19);
            Peroueme.FreeTimes.Add(time20);
            Okay.FreeTimes.Add(time21);
            Professors.Add(Okay); 
            result = BackTrack.MainMethod(Professors,1,result,false);

            Prof Lebras = new Prof();
            Lebras.Id = 11;
            Lebras.Name = "Lebras";

            Course AnalogElektronik1 = new Course();
            AnalogElektronik1.Id = 21;
            AnalogElektronik1.Name = "Analog Elektronik ";
            AnalogElektronik1.Year = 2;
            AnalogElektronik1.Duration = 2;
            Lebras.Courses.Add(AnalogElektronik1);

            Course AnalogElektronik2 = new Course();
            AnalogElektronik2.Id = 22;
            AnalogElektronik2.Name = "Analog Elektronik ";
            AnalogElektronik2.Year = 2;
            AnalogElektronik2.Duration = 2;
            Lebras.Courses.Add(AnalogElektronik2);

            Time time22 = new Time(); time22.Begin = 16; time22.End = 18; time22.Day = 1;
            time22.ProfId = 11;
            Time time23 = new Time(); time23.Begin = 14; time23.End = 16; time23.Day = 3;
            time23.ProfId = 11;
            Atay.FreeTimes.Add(time1);
            Pelletier.FreeTimes.Add(time2);
            Chavaz.FreeTimes.Add(time3); Chavaz.FreeTimes.Add(time4); Chavaz.FreeTimes.Add(time5); Chavaz.FreeTimes.Add(time6);
            Naskali.FreeTimes.Add(time7); Naskali.FreeTimes.Add(time8);
            Devoldere.FreeTimes.Add(time9); Devoldere.FreeTimes.Add(time10); Devoldere.FreeTimes.Add(time11); Devoldere.FreeTimes.Add(time12);
            Zoralioglu.FreeTimes.Add(time13);
            YabancidilProf.FreeTimes.Add(time14);
            YabancidilProf.FreeTimes.Add(time15);
            Orman.FreeTimes.Add(time16); Orman.FreeTimes.Add(time17); Orman.FreeTimes.Add(time18);
            Peroueme.FreeTimes.Add(time19);
            Peroueme.FreeTimes.Add(time20);
            Okay.FreeTimes.Add(time21);
            Lebras.FreeTimes.Add(time22);
            Lebras.FreeTimes.Add(time23);
            Professors.Add(Lebras);

            result = BackTrack.MainMethod(Professors,1,result,false);

            Prof Godreau = new Prof();
            Godreau.Id = 12;
            Godreau.Name = "Godreau";

            Course AnalogElektroniktp1 = new Course();
            AnalogElektroniktp1.Id = 23;
            AnalogElektroniktp1.Name = "Analog Elektronik (Tp Grp: 1) ";
            AnalogElektroniktp1.Year = 2;
            AnalogElektroniktp1.Duration = 2;
            Godreau.Courses.Add(AnalogElektroniktp1);

            Course AnalogElektroniktp2 = new Course();
            AnalogElektroniktp2.Id = 24;
            AnalogElektroniktp2.Name = "Analog Elektronik (Tp Grp: 2) ";
            AnalogElektroniktp2.Year = 2;
            AnalogElektroniktp2.Duration = 2;
            Godreau.Courses.Add(AnalogElektroniktp2);

            Time time24 = new Time(); time24.Begin = 12; time24.End = 14; time24.Day = 2;
            time24.ProfId = 12;
            Time time25 = new Time(); time25.Begin = 14; time25.End = 16; time25.Day = 2;
            time25.ProfId = 12;
            Atay.FreeTimes.Add(time1);
            Pelletier.FreeTimes.Add(time2);
            Chavaz.FreeTimes.Add(time3); Chavaz.FreeTimes.Add(time4); Chavaz.FreeTimes.Add(time5); Chavaz.FreeTimes.Add(time6);
            Naskali.FreeTimes.Add(time7); Naskali.FreeTimes.Add(time8);
            Devoldere.FreeTimes.Add(time9); Devoldere.FreeTimes.Add(time10); Devoldere.FreeTimes.Add(time11); Devoldere.FreeTimes.Add(time12);
            Zoralioglu.FreeTimes.Add(time13);
            YabancidilProf.FreeTimes.Add(time14);
            YabancidilProf.FreeTimes.Add(time15);
            Orman.FreeTimes.Add(time16); Orman.FreeTimes.Add(time17); Orman.FreeTimes.Add(time18);
            Peroueme.FreeTimes.Add(time19);
            Peroueme.FreeTimes.Add(time20);
            Okay.FreeTimes.Add(time21);
            Lebras.FreeTimes.Add(time22);
            Lebras.FreeTimes.Add(time23);
            Godreau.FreeTimes.Add(time24);
            Godreau.FreeTimes.Add(time25);
            Professors.Add(Godreau);
            result = BackTrack.MainMethod(Professors,1,result,false);

            Course LineerCebir1 = new Course();
            LineerCebir1.Id = 25;
            LineerCebir1.Name = "Lineer Cebir";
            LineerCebir1.Year = 2;
            LineerCebir1.Duration = 2;
            Chavaz.Courses.Add(LineerCebir1);

            Course LineerCebir2 = new Course();
            LineerCebir2.Id = 26;
            LineerCebir2.Name = "Lineer Cebir";
            LineerCebir2.Year = 2;
            LineerCebir2.Duration = 2;
            Chavaz.Courses.Add(LineerCebir2);

            Time time26 = new Time(); time26.Begin = 11; time26.End = 13; time26.Day = 3;
            time26.ProfId = 3;
            Time time27 = new Time(); time27.Begin = 11; time27.End = 13; time27.Day = 4;
            time27.ProfId = 3;

            Atay.FreeTimes.Add(time1);
            Pelletier.FreeTimes.Add(time2);
            Chavaz.FreeTimes.Add(time3); Chavaz.FreeTimes.Add(time4); Chavaz.FreeTimes.Add(time5); Chavaz.FreeTimes.Add(time6);
            Naskali.FreeTimes.Add(time7); Naskali.FreeTimes.Add(time8);
            Devoldere.FreeTimes.Add(time9); Devoldere.FreeTimes.Add(time10); Devoldere.FreeTimes.Add(time11); Devoldere.FreeTimes.Add(time12);
            Zoralioglu.FreeTimes.Add(time13);
            YabancidilProf.FreeTimes.Add(time14);
            YabancidilProf.FreeTimes.Add(time15);
            Orman.FreeTimes.Add(time16); Orman.FreeTimes.Add(time17); Orman.FreeTimes.Add(time18);
            Peroueme.FreeTimes.Add(time19);
            Peroueme.FreeTimes.Add(time20);
            Okay.FreeTimes.Add(time21);
            Lebras.FreeTimes.Add(time22);
            Lebras.FreeTimes.Add(time23);
            Godreau.FreeTimes.Add(time24);
            Godreau.FreeTimes.Add(time25);
            Chavaz.FreeTimes.Add(time26);
            Chavaz.FreeTimes.Add(time27);
            result = BackTrack.MainMethod(Professors,1,result,false);

            Prof Alptekin = new Prof();
            Alptekin.Id = 13;
            Alptekin.Name = "Alptekin";

            Course VeriYapisi3 = new Course();
            VeriYapisi3.Id = 27;
            VeriYapisi3.Name = "Veri Yapısı ve Algoritmalar";
            VeriYapisi3.Year = 2;
            VeriYapisi3.Duration = 3;
            Alptekin.Courses.Add(VeriYapisi3);

            Time time28 = new Time(); time28.Begin = 14; time28.End = 17; time28.Day = 4;
            time28.ProfId = 13;
            Alptekin.FreeTimes.Add(time28);
            Professors.Add(Alptekin);
            result = BackTrack.MainMethod(Professors,1,result,false);

            Prof Tugcu = new Prof();
            Tugcu.Id = 14;
            Tugcu.Name = "Tugcu";

            Course Elektromanyetik = new Course();
            Elektromanyetik.Id = 28;
            Elektromanyetik.Name = "Elektromanyetik Dalgalar";
            Elektromanyetik.Year = 2;
            Elektromanyetik.Duration = 3;
            Tugcu.Courses.Add(Elektromanyetik);

            Time time29 = new Time(); time29.Begin = 14; time29.End = 17; time29.Day = 5;
            time29.ProfId = 14;
            Atay.FreeTimes.Add(time1);
            Pelletier.FreeTimes.Add(time2);
            Chavaz.FreeTimes.Add(time3); Chavaz.FreeTimes.Add(time4); Chavaz.FreeTimes.Add(time5); Chavaz.FreeTimes.Add(time6);
            Naskali.FreeTimes.Add(time7); Naskali.FreeTimes.Add(time8);
            Devoldere.FreeTimes.Add(time9); Devoldere.FreeTimes.Add(time10); Devoldere.FreeTimes.Add(time11); Devoldere.FreeTimes.Add(time12);
            Zoralioglu.FreeTimes.Add(time13);
            YabancidilProf.FreeTimes.Add(time14);
            YabancidilProf.FreeTimes.Add(time15);
            Orman.FreeTimes.Add(time16); Orman.FreeTimes.Add(time17); Orman.FreeTimes.Add(time18);
            Peroueme.FreeTimes.Add(time19);
            Peroueme.FreeTimes.Add(time20);
            Okay.FreeTimes.Add(time21);
            Lebras.FreeTimes.Add(time22);
            Lebras.FreeTimes.Add(time23);
            Godreau.FreeTimes.Add(time24);
            Godreau.FreeTimes.Add(time25);
            Chavaz.FreeTimes.Add(time26);
            Chavaz.FreeTimes.Add(time27);
            Tugcu.FreeTimes.Add(time29);

            Professors.Add(Tugcu); 
            result = BackTrack.MainMethod(Professors,1,result,false);

            Prof YabancidilProf2 = new Prof();
            YabancidilProf2.Id = 15;
            YabancidilProf2.Name = "Yabanci Dil";

            Course yabancidil3 = new Course();
            yabancidil3.Id = 29;
            yabancidil3.Name = "Yabanci Dil";
            yabancidil3.Year = 2;
            yabancidil3.Duration = 2;
            YabancidilProf2.Courses.Add(yabancidil3);

            Course yabancidil4 = new Course();
            yabancidil4.Id = 30;
            yabancidil4.Name = "Yabanci Dil";
            yabancidil4.Year = 2;
            yabancidil4.Duration = 2;
            YabancidilProf2.Courses.Add(yabancidil4);

            Time time30 = new Time(); time30.Begin = 16; time30.End = 18; time30.Day = 2; time30.ProfId = 15; 
            Time time31 = new Time(); time31.Begin = 16; time31.End = 18; time31.Day = 3; time31.ProfId = 15; 
            Atay.FreeTimes.Add(time1);
            Pelletier.FreeTimes.Add(time2);
            Chavaz.FreeTimes.Add(time3); Chavaz.FreeTimes.Add(time4); Chavaz.FreeTimes.Add(time5); Chavaz.FreeTimes.Add(time6);
            Naskali.FreeTimes.Add(time7); Naskali.FreeTimes.Add(time8);
            Devoldere.FreeTimes.Add(time9); Devoldere.FreeTimes.Add(time10); Devoldere.FreeTimes.Add(time11); Devoldere.FreeTimes.Add(time12);
            Zoralioglu.FreeTimes.Add(time13);
            YabancidilProf.FreeTimes.Add(time14);
            YabancidilProf.FreeTimes.Add(time15);
            Orman.FreeTimes.Add(time16); Orman.FreeTimes.Add(time17); Orman.FreeTimes.Add(time18);
            Peroueme.FreeTimes.Add(time19);
            Peroueme.FreeTimes.Add(time20);
            Okay.FreeTimes.Add(time21);
            Lebras.FreeTimes.Add(time22);
            Lebras.FreeTimes.Add(time23);
            Godreau.FreeTimes.Add(time24);
            Godreau.FreeTimes.Add(time25);
            Chavaz.FreeTimes.Add(time26);
            Chavaz.FreeTimes.Add(time27);
            Tugcu.FreeTimes.Add(time29);
            YabancidilProf2.FreeTimes.Add(time30);YabancidilProf2.FreeTimes.Add(time31);
            Professors.Add(YabancidilProf2); 
            result = BackTrack.MainMethod(Professors,1,result,false);

            Course ProjeRiskDegisiklik = new Course();
            ProjeRiskDegisiklik.Id = 31;
            ProjeRiskDegisiklik.Name = "Bilgisayar muhendisleri icin Proje Risk...";
            ProjeRiskDegisiklik.Year = 3;
            ProjeRiskDegisiklik.Duration = 2;
            Alptekin.Courses.Add(ProjeRiskDegisiklik);
            Time time32 = new Time(); time32.Begin = 11; time32.End = 13; time32.Day = 1; time32.ProfId = 13; Alptekin.FreeTimes.Add(time32);
            result = BackTrack.MainMethod(Professors,1,result,false);

            Prof makin = new Prof();
            makin.Name = "Akın";
            makin.Id = 16;
            
            Course mimari1 = new Course();
            mimari1.Id = 32;
            mimari1.Name = "Bilgisayar Mimarisi";
            mimari1.Year = 3;
            mimari1.Duration = 2;
            makin.Courses.Add(mimari1);

            Course mimari2 = new Course();
            mimari2.Id = 33;
            mimari2.Name = "Bilgisayar Mimarisi";
            mimari2.Year = 3;
            mimari2.Duration = 2;
            makin.Courses.Add(mimari2);

            Time time33 = new Time(); time33.Begin = 13; time33.End = 15; time33.Day = 1; time33.ProfId = 16;
            Time time34 = new Time(); time34.Begin = 12; time34.End = 14; time34.Day = 4; time34.ProfId = 16; 
            Atay.FreeTimes.Add(time1);
            Pelletier.FreeTimes.Add(time2);
            Chavaz.FreeTimes.Add(time3); Chavaz.FreeTimes.Add(time4); Chavaz.FreeTimes.Add(time5); Chavaz.FreeTimes.Add(time6);
            Naskali.FreeTimes.Add(time7); Naskali.FreeTimes.Add(time8);
            Devoldere.FreeTimes.Add(time9); Devoldere.FreeTimes.Add(time10); Devoldere.FreeTimes.Add(time11); Devoldere.FreeTimes.Add(time12);
            Zoralioglu.FreeTimes.Add(time13);
            YabancidilProf.FreeTimes.Add(time14);
            YabancidilProf.FreeTimes.Add(time15);
            Orman.FreeTimes.Add(time16); Orman.FreeTimes.Add(time17); Orman.FreeTimes.Add(time18);
            Peroueme.FreeTimes.Add(time19);
            Peroueme.FreeTimes.Add(time20);
            Okay.FreeTimes.Add(time21);
            Lebras.FreeTimes.Add(time22);
            Lebras.FreeTimes.Add(time23);
            Godreau.FreeTimes.Add(time24);
            Godreau.FreeTimes.Add(time25);
            Chavaz.FreeTimes.Add(time26);
            Chavaz.FreeTimes.Add(time27);
            Tugcu.FreeTimes.Add(time29);
            YabancidilProf2.FreeTimes.Add(time30); YabancidilProf2.FreeTimes.Add(time31);
            makin.FreeTimes.Add(time33);makin.FreeTimes.Add(time34);
            Professors.Add(makin);
            result = BackTrack.MainMethod(Professors,1,result,false);

           if(result.NotArrangedCourses != null)
            {
                Atay.FreeTimes.Add(time1);
                Pelletier.FreeTimes.Add(time2);
                Chavaz.FreeTimes.Add(time3); Chavaz.FreeTimes.Add(time4); Chavaz.FreeTimes.Add(time5); Chavaz.FreeTimes.Add(time6);
                Naskali.FreeTimes.Add(time7); Naskali.FreeTimes.Add(time8);
                Devoldere.FreeTimes.Add(time9); Devoldere.FreeTimes.Add(time10); Devoldere.FreeTimes.Add(time11); Devoldere.FreeTimes.Add(time12);
                Zoralioglu.FreeTimes.Add(time13);
                YabancidilProf.FreeTimes.Add(time14);
                YabancidilProf.FreeTimes.Add(time15);
                Orman.FreeTimes.Add(time16); Orman.FreeTimes.Add(time17); Orman.FreeTimes.Add(time18);
                Peroueme.FreeTimes.Add(time19);
                Peroueme.FreeTimes.Add(time20);
                Okay.FreeTimes.Add(time21);
                Lebras.FreeTimes.Add(time22);
                Lebras.FreeTimes.Add(time23);
                Godreau.FreeTimes.Add(time24);
                Godreau.FreeTimes.Add(time25);
                Chavaz.FreeTimes.Add(time26);
                Chavaz.FreeTimes.Add(time27);
                Tugcu.FreeTimes.Add(time29);
                YabancidilProf2.FreeTimes.Add(time30); YabancidilProf2.FreeTimes.Add(time31);
                makin.FreeTimes.Add(time33); makin.FreeTimes.Add(time34);
                result = BackTrack.MainMethod(Professors, 1, result, true);
            }


            result = BackTrack.MainMethod(Professors,1,result,false);
            Console.WriteLine("Licence 1: ");
            foreach (Course x in result.Courses)
            {
                if (x.Year == 1 && x.TimeOfCourse != null)
                {
                    Console.WriteLine(x.Name + " :" + x.TimeOfCourse.Begin + " " + " - " + " " + x.TimeOfCourse.End + " day: " + Days[x.TimeOfCourse.Day - 1]);
                }
            }
            Console.WriteLine("\nLicence 2: ");
            foreach (Course x in result.Courses)
            {
                if (x.Year == 2 && x.TimeOfCourse != null)
                {
                    Console.WriteLine(x.Name + " :" + x.TimeOfCourse.Begin + " " + " - " + " " + x.TimeOfCourse.End + " day: " + Days[x.TimeOfCourse.Day - 1]);
                }
            }

            Console.WriteLine("\nLicence 3: ");
            foreach (Course x in result.Courses)
            {
                if (x.Year == 3 && x.TimeOfCourse != null)
                {
                    Console.WriteLine(x.Name + " :" + x.TimeOfCourse.Begin + " " + " - " + " " + x.TimeOfCourse.End + " day: " + Days[x.TimeOfCourse.Day - 1]);
                }
            }

            Console.WriteLine("\n Not Arranged Courses: ");
            foreach (Course x in result.NotArrangedCourses)
            {
                if (x.TimeOfCourse == null)
                {
                    Console.WriteLine(x.Name);
                }
            }
            Console.ReadLine();
        }
    }
}
