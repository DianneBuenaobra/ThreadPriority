using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadPriority
{
    internal class MyThreadClass
    {
        public static void Thread1()
        {
            for(int i = 0;  i <3; i++) 
            {
                Thread thread = Thread.CurrentThread;
                Thread.Sleep(1500);
                Console.WriteLine("Name of Thread: " + thread.Name + " = " + i);
                
            }
        }
        public static void Thread2()
        {
            for (int ii = 0; ii < 7; ii++)
            {
                Thread thread = Thread.CurrentThread;
                Thread.Sleep(1500);
                Console.WriteLine("Name of Thread: " + thread.Name + " = " + ii);
                
            }
        }
    }
}
