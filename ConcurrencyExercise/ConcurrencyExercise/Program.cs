using System;

namespace ConcurrencyExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //new ConOne().ConOneMain();
            //new ConOne().ConOneMain1();

            Console.WriteLine("--------------------------------------------------------------");
            //new ConThree().ConThreeMain();
            new ConFour().ConFourMain();

           Console.Read();
        }
    }
}
