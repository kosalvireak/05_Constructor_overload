using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson05Exercises1
{
    internal class Program
    {
        class Point
        {
            public float fltX, fltY, fltZ;
            private string strType;
            public Point(float fltX, float fltY)
            {
                this.fltX = fltX;
                this.fltY = fltY;
                strType = "2D"; // This constructor sets strType to “2D”.

            }
            public Point(float fltX, float fltY, float fltZ)
            {
                this.fltX = fltX;
                this.fltY = fltY;
                this.fltZ = fltZ;
                strType = "3D";
            }
            public void DisplayCoordidates() /// What to do///
            {

                if (strType == "2D")
                {
                    Console.WriteLine("This is 2 Dimentions x = {0}, y = {1}",fltX,fltY  );
                }
                else if (strType == "3D")
                {
                    Console.WriteLine("This is 3 Dimentions x = {0}, y = {1}, z = {2}", fltX, fltY,fltZ);
                }

            }
        
        }
        static void Main(string[] args)
        {
            Point objP1, objP2;
            Console.Write("Enter x: ");
            float x = float.Parse(Console.ReadLine());
            Console.Write("Enter y: ");
            float y = float.Parse(Console.ReadLine());
            objP1 = new Point(x, y);
            objP1.DisplayCoordidates();


            Console.Write("Enter x: ");
            float x2 = float.Parse(Console.ReadLine());
            Console.Write("Enter y: ");
            float y2 = float.Parse(Console.ReadLine());
            Console.Write("Enter z: ");
            float z2 = float.Parse(Console.ReadLine());
            objP2 = new Point(x2, y2, z2);

            objP2.DisplayCoordidates();
        }
    }
}
