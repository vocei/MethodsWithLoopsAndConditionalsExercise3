
using System.ComponentModel.Design;
using System.Diagnostics.Metrics;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace MethodsWithLoopsAndConditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintThousand();
            ThreeToNine();
            Console.WriteLine($"\nLet me show you if this is true or false, are these numbers the same: 45 and 69 \n{IsEqual(69, 45)}");
            IsEqualQuestion();
            EvenOrOdd();
            EvenOrOdd2();
            YouOldEnoughToVote();
            NegativeOrPositive(7);
            DanceyTime();
        }
        public static void PrintThousand()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i + $" Counting backwards to -1000 from 1000 by 1");
            }
        }
        public static void ThreeToNine()
        {
            for (int k = 3; k <= 999; k += 3)
            {
                Console.WriteLine(k + $" Now we can count from 3 to 999 by 3 each time");
            }
        }
        public static bool IsEqual(int a, int b)
        {
            var check = (b == a) ? true : false;
            return check;
        }
        public static void IsEqualQuestion()
        {
            {
                bool cont = true;
                do
                {
                    Console.WriteLine("\nPlease give me two numbers that equal the same value, enter them one at a time");
                    var a = int.Parse(Console.ReadLine());
                    Console.WriteLine("Now give me the other number");
                    var b = int.Parse(Console.ReadLine());
                    var check = (b == a) ? $"Yep.. these numbers are the same!" : $"These numbers are not the same value, did you read the question? :(";
                    Console.WriteLine(check);
                    if (a != b)
                    {
                        Console.WriteLine("Try again");
                        cont = false;
                    }
                    else
                    {
                        cont = true;
                        Console.WriteLine("Thank you for entering the same number twice. :)");
                    }
                } while (cont == false);

                //method ception
                //Console.WriteLine("Please give me two numbers that equal the same value, enter them one at a time");
                //var a = int.Parse(Console.ReadLine());
                //Console.WriteLine("Now give me the other number");
                //var b = int.Parse(Console.ReadLine());
                //var check = (b == a) ? $"Yep.. these numbers are the same!" : $"These numbers are not the same value, did you read the question? :(";
                //Console.WriteLine(check);
                //if (a != b)
                //{
                //    Console.WriteLine("Try again");
                //    IsEqualQuestion();
                //}
                //else
                //{
                //    Console.WriteLine("Thank you for entering the same number twice. :)");
                //}
            }
        }

        public static void EvenOrOdd()
        {
            Console.WriteLine("\nNow, give me a number to check if its even or odd");
            var eoro = int.Parse(Console.ReadLine());

            {
                var check = (eoro % 2 == 0) ? $"{eoro} is even" : $"{eoro} is odd";
                Console.WriteLine(check);
            }

        }
        public static void EvenOrOdd2()
        {
            Console.WriteLine("\nNow, another give me a number to check if its even or odd");
            var eoro2 = int.Parse(Console.ReadLine());

            {
                var check = (eoro2 % 2 == 0) ? $"{eoro2} is even" : $"{eoro2} is odd";
                Console.WriteLine(check);
            }
        }
        public static void NegativeOrPositive(int o)
        {
            Console.WriteLine("\nI coded to check if the number 7 is negative or positive..");
            if (o > 0)
            {
                Console.WriteLine($"This number is {o} so it's positive.");
            }
            else if (o < 0)
            {
                Console.WriteLine($"{o} is negative");
            }
            else
            {
                Console.WriteLine("This is zero ...");
            }
        }
         public static void YouOldEnoughToVote()
         {
            Console.WriteLine("\nAre you old enough to vote? Tell me your age");
            var userAge = int.Parse(Console.ReadLine());
            var difference = (18 - userAge);
            var check = (userAge >= 18) ? $"\nWow you're {userAge} years old, thats a great age to vote! Vote Wisely!" : $"\n{userAge} is too young to vote sorry! You're too young to vote come back in {difference} years!";
            Console.WriteLine(check);
         }
        public static void DanceyTime()
        {
            bool loop = false;
                Console.WriteLine("\nDo you wanna see a dance?");
            do {
                var yesorno = Console.ReadLine();
                switch (yesorno)
                {
                    case "yes":
                        Console.WriteLine("\n♫♪┏(°.°)┛♫♪ HELL YEA!!! *dances*");
                        loop = false;
                        break;
                    case "no":
                    case "why":
                        Console.WriteLine("\nDang, I  thought we could've had a fun time...");
                        Console.WriteLine("Just say yes");
                        loop = true;
                        break;
                    default:
                        Console.WriteLine("\nThats not a yes or a no so imma dance anyway *dances* ♫♪┏(°.°)┛♫♪");
                        loop = false;
                        break;
                }
            } while (loop);
        }
    }
}

    


