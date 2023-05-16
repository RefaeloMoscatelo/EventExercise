using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ConsoleApp1
{

    public delegate void BoomDel();
    public class Boom
    {
        int num;
        public event BoomDel BoomDel_Handler;

        public void Boomseven()
        {
           
            for (int i = 0; i < 1000; i++)
            {
                if (BoomDel_Handler!=null)
                {
                   
                    if (i % 7 == 0)
                    {
                        BoomDel_Handler();
                    }
                    
                }
                
            }
        }


    }
}
