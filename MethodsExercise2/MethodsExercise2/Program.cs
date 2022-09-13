using System;

namespace MethodsExercise2
{
    class Program
    {
        public static int Sum(int num1, int num2)
        {
            var answer = num1 + num2;
            return answer;
        }

        public static int Subtract(int num3, int num4)
        {
            var answer = num3 - num4;
            return answer;
        }

        public static int Multiply(int num5, int num6)
        {
            var answer = num5 * num6;
            return answer;
        }

        public static int Divide(int num7, int num8)
        {
            var answer = num7 / num8;
            return answer;
        }


        static void Main(string[] args)
        {
            // Exercise Methods 2

            var amountOfBooks = Sum(2, 6);
            Console.WriteLine(amountOfBooks);

            var amountOfMoneyLeft = Subtract(15, 5);
            Console.WriteLine(amountOfMoneyLeft);

            var tablesSeated = Multiply(8, 6);
            Console.WriteLine(tablesSeated);

            var foodSplit = Divide(25, 5);
            Console.WriteLine(foodSplit);
            
        }
    }
}

