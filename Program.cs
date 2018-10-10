using System;

namespace ex1_3
{
    class Program
    {
        public static double Calculate(string userInput)
        {
            String[] jest = userInput.Split(' ');
            var a1 = Convert.ToDouble(jest[0]);
            var a2 = Convert.ToDouble(jest[1]);
            var a3 = Convert.ToDouble(jest[2]);
            double s = a1;
            for (int i = 0; i < a3; i++)
                s += s * a2 / 1200; 
            return s;
           
        }
        static void Main()
        {
            Console.WriteLine(Calculate(Console.ReadLine()));
            Console.ReadKey();
        }

    }
}
