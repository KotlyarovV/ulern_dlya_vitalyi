using System;

namespace ex1_3
{
    class Program
    {
        /*
            1.названия переменных - пиздец, их надо называть так, чтобы из названия было понятно, о чем идет речь. 
            2. Convert.ToDouble(jest[0]); - нечто очень странное , юзай double.Parse() (или Double.Parse) 
            3. здесь точно можно обойтись без цикла - юзай возведение в степень
            4. String[] - дважды плохо - во первых юзай string[] вместо String[] , во вторых везде, где можно пиши var
        */
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
