using System;
using System.Collections;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        public static void Seven()
        {
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine(i);
            }
        }
        static void Main(string[] args)
        {

            //BoomDel b = new BoomDel(Seven);
            //Boom bb = new Boom();
            //bb.BoomDel_Handler += Seven;
            //bb.Boomseven();
          
            ArrayList func1(ArrayList list)
            {
                Console.WriteLine("hhh");
                ArrayList list1 = new ArrayList();
                list1.Add(3);
                list1.Add("*");
                list1.Add(2);
                list1.Add("+");
                list1.Add(5);


                Console.WriteLine();


                return list1;
            }

        }
    }
}
