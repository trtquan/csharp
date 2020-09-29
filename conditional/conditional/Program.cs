using System;

namespace conditional
{
    class Program
    {
        static void Main(string[] args)
        {
            string op = Console.ReadLine();
            string numb1Input = Console.ReadLine();
            string numb2Input = Console.ReadLine();
            int numb1;
            Int32.TryParse(numb1Input, out numb1);
            int numb2;
            Int32.TryParse(numb2Input, out numb2);
            switch (op)
            {
                case "addition":
                    Console.WriteLine(Addition(numb1, numb2));
                    break;
                case "subtraction":
                    Console.WriteLine(Subtraction(numb1, numb2));
                    break;
                case "multiplication":
                    Console.WriteLine(Multiplication(numb1, numb2));
                    break;
                case "division":
                    Console.WriteLine(Division(numb1, numb2));
                    break;

            }
        }

        static int Addition(int numb1,int numb2)
        {
            return numb1 + numb2;
        }

        static int Subtraction(int numb1, int numb2)
        {
            return numb1 - numb2;
        }

        static int Multiplication(int numb1, int numb2)
        {
            return numb1 * numb2;
        }

        static int Division(int numb1 , int numb2)
        {
            return numb1 / numb2;
        }

    }
}
