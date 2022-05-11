using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConcurrencyExercise
{
    internal class ConThree
    {

        public void ConThreeMain()
        {
            var task1 = Task.Run(() => { return calculate1(); });
            var awaiter1 = task1.GetAwaiter();
            awaiter1.OnCompleted(() => 
            {
                var result1 = task1.Result;
                calculate2(result1);
            
            
            });
            var task2 = Task.Run(() => { return calculate3(); });
        }

        public int calculate1()
        {
            Thread.Sleep(3000);
            Console.WriteLine("Inside calculate1");
            return 10;
        }
        
        public void calculate2(int a)
        {
            Console.WriteLine("calculate2");
            
        }

        public int calculate3()
        {
            Console.WriteLine("calculate3");
            return 30;
        }

    }
}
