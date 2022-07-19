using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson05Exercises2
{
    internal class Program
    {
        class Time
        {
            public int intHour, intMin, intSec;
            public Time()
            {

            }
            public Time (int hour, int min, int sec)
            {
                this.intHour = hour;
                this.intMin = min;
                this.intSec = sec;
            }
            public string GetTime()
            {

                return "3 hours 30 minutes 50 seconds";
            }
            public float GetTime(string strType)
            {
                float Calculation = 0;
                if (strType == "sec")
                {
                    Calculation = intHour * 3600 + intMin * 60 + intSec;
                }
                else if (strType == "min")
                {
                    Calculation = intHour * 60f + intMin + intSec / 60f;
                }
                else if (strType == "hour")
                {
                    Calculation = intHour + intMin / 60f + intSec / 3600f;
                }
                return Calculation;

            }
        }
        static void Main(string[] args)
        {
            Time objTime1, objTime2;
            objTime1 = new Time();


            Console.Write("Enter hour: ");
            float hour1 = float.Parse(Console.ReadLine());
            Console.Write("Enter min: ");
            float min1 = float.Parse(Console.ReadLine());
            Console.Write("Enter sec: ");


            float sec1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Time of objTime1: "+ objTime1.GetTime());


            Console.Write("Enter hour: ");
            int hour2 = int.Parse(Console.ReadLine());
            Console.Write("Enter min: ");
            int min2 = int.Parse(Console.ReadLine());
            Console.Write("Enter sec: ");
            int sec2 = int.Parse(Console.ReadLine());


            objTime2 = new Time(hour2, min2, sec2);


            Console.WriteLine("Time of objTime1: " + objTime2.GetTime("hour").ToString());
            Console.WriteLine("Time of objTime1: " + objTime2.GetTime("min").ToString());
            Console.WriteLine("Time of objTime1: " + objTime2.GetTime("sec").ToString());
            Console.ReadKey();

        }
    }
}
