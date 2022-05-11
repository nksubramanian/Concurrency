using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConcurrencyExercise
{
    internal class ConFour
    {
        public void ConFourMain()
        {
            calculate1_2();
            calculatefinal();

        }

        public int calculate1()
        {
            Thread.Sleep(3000);
            Console.WriteLine("calculate1");
            return 10;
        }

        public int calculate2(int q)
        {
            Console.WriteLine("calculate2");
            return 2 * q;
        }

        public async void calculate1_2()
        {
            var result = await Task.Run(() => { return calculate1(); });
            int d = calculate2(result);
        }
       
        public void calculatefinal()
        {
            Console.WriteLine("final");
        }




    }
}
