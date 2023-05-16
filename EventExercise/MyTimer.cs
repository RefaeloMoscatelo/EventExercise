using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace EventExercise
{
    public delegate void WakeUp20sec();
    class MyTimer
    {
        public event WakeUp20sec WakeUp20sec_Handler;

        public void WakeMeUp()
        {

            for (int i = 0; ; i++)
            {
                if (DateTime.Now.Second % 15 == 0)
                {
                    if (WakeUp20sec_Handler!=null)
                    {
                        WakeUp20sec_Handler();
                    }
                   
                    Thread.Sleep(500);
                }

            }
        }
       
    }
}
