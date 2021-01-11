using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountTimer
{
    class Program
    {
        public delegate void Finish();
        delegate void AnonymousMethod(string message);
        public static void Main(string[] args)
        {
            int timer;
            Console.Write("Enter the countdown in seconds: ");
            bool flag = Int32.TryParse(Console.ReadLine(), out timer);
            int half = timer / 2;
            if (!flag)
            {
                Console.WriteLine("Please enter an integer number!");
            }
            else
            {
                ClassCounter Counter = new ClassCounter();
                Attention_I Attention1 = new Attention_I();
                Attention_II Attention2 = new Attention_II();
                Finish message = () => Message();

                Counter.Counted += Attention1.Message;
                Counter.Counted += Attention2.Message;

                // The counter is started
                Counter.Count(timer);
                Console.WriteLine();
                message();

                AnonymousMethod handler = delegate
                {
                    Console.WriteLine("Anonymous method works.");
                };
                handler("");            // anonymous method

                Console.ReadKey();
            }
        }
        static void Message() => Console.WriteLine("Time is over!");
    }
}
