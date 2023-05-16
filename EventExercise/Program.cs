using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventExercise
{
    class Program
    {
        static void PrintTime()
        {
            Console.WriteLine(DateTime.Now);
        }
        static void Main(string[] args)
        {
            MyTimer mt = new MyTimer();
            mt.WakeUp20sec_Handler += new WakeUp20sec(PrintTime);
            mt.WakeMeUp();

            //today you make the 7 boom
        }
    }
}
