using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CountTimer
{
    /// <summary>
    /// Class, where the count is performed.
    /// </summary>
    class ClassCounter
    {
        public delegate void MethodContainer();
        // "Counted" event with delegate type MethodContainer.
        public event MethodContainer Counted;

        public void Count(int timer)
        {
            int half = timer / 2;
            Console.Write("Countdown in seconds: ");
            for (int i = timer; i >= 0; i--)
            {
                Console.CursorLeft = 28;
                Console.Write("{0} ", i);    // Adding space so that it does not overlap with previous contents
                Thread.Sleep(1000);
                if (i == half)               // To call alert classes
                {
                    if (Counted != null)
                    {
                        Console.WriteLine();
                        Counted();
                    }
                }
            }
        }
    }
}
