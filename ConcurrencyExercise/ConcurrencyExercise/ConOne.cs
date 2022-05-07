using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConcurrencyExercise
{
    internal class ConOne
    {
        public void ConOneMain()
        {
            Console.WriteLine("Inside Con one Main");
            Calculate1();
            Calculate2();
            Calculate3();
        }

        public void ConOneMain1()
        {
            Console.WriteLine("Inside 1 Main");


            Task.Run(() => { Calculate1(); });
            Task.Run(() => { Calculate2(); });
            Task.Run(() => { Calculate3(); });



        }



        public void Calculate1()
        {
            Thread.Sleep(3000);
            Console.WriteLine("Inside Calculate1");
        }

        public void Calculate2()
        {
            Console.WriteLine("Inside Calculate2");
        }

        public void Calculate3()
        {
            Console.WriteLine("Inside Calculate3");
        }

    }
}
