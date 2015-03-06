using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintMesssage();
        }
        public static void PrintMesssage()
        {
            Console.WriteLine("Welcome to my first c# Program");
            float theta;
            float speed;
            float vox;
            float voy;
            double time;
            double height;
            double dx;
            const double GRAVITY = 9.8;


            Console.WriteLine("Welcome Please enter the angle Theta:  ");
            theta = float.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the Speed:  ");
            speed = float.Parse(Console.ReadLine());

            Console.WriteLine("You have entered: " + speed);
            vox = speed * (float)Math.Cos(theta);
            voy = speed * (float)Math.Sin(theta);
            time = (double)(voy / GRAVITY);
            height = voy * voy / (2 * GRAVITY);
            dx = vox * 2 * time;
            Console.WriteLine(" VOX: " + vox + "\n voY: " + voy + "\nTime: " + time + "\n   h: " + height + "\n  dx: " + dx);
            
        }
    }
    
}
