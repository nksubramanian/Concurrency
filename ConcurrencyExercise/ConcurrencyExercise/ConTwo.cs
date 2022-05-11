using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConcurrencyExercise
{
    internal class ConTwo
    {

        public void ConTwoMain()
        {
            var task1 = Task.Run(() => { return Calculate1(); });
            var task2 = Task.Run(() => { return Calculate2(); });
            Task.WaitAll(task1, task2);
            var awaiter1 = task1.GetAwaiter();
            var awaiter2 = task2.GetAwaiter();
            var result1 = awaiter1.GetResult();
            var result2 = awaiter2.GetResult();
            Calculate3(result1, result2);

        }

        public int Calculate1()
        {
            Thread.Sleep(3000);
            Console.WriteLine("Inside Calculate1");
            return 10;
        }

        public int Calculate2()
        {
            Console.WriteLine("Inside Calculate2");
            return 20;
        }

        public int Calculate3(int a, int b)
        {
            Console.WriteLine("Inside Calculate3");
            Console.WriteLine(a + b);
            return a+b;
        }


    }
}
