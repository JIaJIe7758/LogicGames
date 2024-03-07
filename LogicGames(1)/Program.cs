using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicGames_1_
{
    internal class Program
    {

        private static int[,] numbers =
        {
            {1,2,3 },
            {4,5,6 },
            {7,8,9 }
        };
        
          private static Random random = new Random();

        static void Main(string[] args)
        {
            //fACTORIAL
            /*
            Console.Write("Please enter the NUMBER OF FACTORIAL as integer");
            var n = int.Parse(Console.ReadLine());

            //loop Calculation
            Console.WriteLine("LOOP calculation: Factorial of {0} is {1}", n, CalculateLoop2(n));
            Console.WriteLine("Recursion calculation: Factorial of {0} is {1}", n, CalculateRecursion(n));
            Console.WriteLine("--------------------------------------");
            */
            //FizBuzz
            /*
            FizzBuzz();
            FizzBuzz2();
            RecursiveSolution(100);
            */

            //LoShu Magic 
            int counter = 0;

            
            do//a Loop to switch cells until we find the magicSquare
            {
                counter++;
                Console.WriteLine(counter);
                SwitchCells();

            } while (!IsMagicSquare());

            DisplayBoard();
            Console.WriteLine("It took {0} tries to find the magic square",counter);
            Console.ReadLine();
            

            


        }
        private static int CalculateLoop(int n)
        {
            var factorial = 1;
            for (int i = n; i >= 1; i--)
            {
                factorial *= i;
            }
            return factorial;
        }
        private static int CalculateLoop2(int n)
        {
            var factorial = n;
            for (int i = 1; i < n; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
        private static int CalculateRecursion(int n)
        {
            if (n == 1)
                return 1;
            else
                return n * CalculateRecursion(n - 1);
            
        }
        //FizBUZZ
        private static void FizzBuzz()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                    continue;
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                    continue;
                }
                else if(i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                    continue;
                }
                else
                    Console.WriteLine(i);



            }


        }
        private static void FizzBuzz2()
        {
            string text;
            for (int i = 100; i >= 1; i--) 
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    text = "FizzBuzz";
                    
                }
                else if (i % 3 == 0)
                {
                    text = "Fizz";
                    
                }
                else if (i % 5 == 0)
                {
                    text = "Buzz";
                    
                }
                else
                    text = i.ToString(); if (i % 3 == 0 && i % 5 == 0)
                {
                    text = "FizzBuzz";
                    
                }
                else if (i % 3 == 0)
                {
                    text = "Fizz";
                    
                }
                else if (i % 5 == 0)
                {
                    text = "Buzz";
                    
                }
                else
                    text = i.ToString();

                Console.WriteLine(text);
            }
        }
        private static void RecursiveSolution(int n)
        {
            //Exit Condition
            string text = "";
            if (n < 1)
                return;

            if (n % 3 == 0 && n % 5 == 0)
            {
                text = "FizzBuzz";

            }
            else if (n % 3 == 0)
            {
                text = "Fizz";

            }
            else if (n % 5 == 0)
            {
                text = "Buzz";

            }
            else
                text = n.ToString();

            Console.WriteLine(text);
            RecursiveSolution(n - 1);

        }
        //Loshu
        private static void SwitchCells()
        {
            int[] number1 = new int[2];
            int[] number2 = new int[2];

            number1[0] = random.Next(0,3);
            number1[1] = random.Next(0, 3);
            number2[0] = random.Next(0, 3);
            number2[1] = random.Next(0, 3);

            int temp = numbers[number1[0], number1[1]];
            numbers[number1[0], number1[1]] = numbers[number2[0], number2[1]];
            numbers[number2[0], number2[1]] = temp;

        }
        private static bool IsMagicSquare()
        {
            var tempSum = numbers[0,0] + numbers[0,1] + numbers[0,2];
            //Start from row 1 becausetempSum already holds the sum for row 0

            for(var i = 1; i < 3; i++)// Checking the rows 1 and2
            {
                if (numbers[i,0] + numbers[i,1] + numbers[i,2] != tempSum)
                    return false;

            }
            //Compare Columns
            for (var j = 0; j < 3; j++)
            {
                if (numbers[0,j] + numbers[1, j] + numbers[2, j] != tempSum)
                    return false;
            }
            return numbers[0, 0] + numbers[1, 1] + numbers[2, 2] == tempSum &&
                   numbers[0, 2] + numbers[1, 1] + numbers[2, 0] == tempSum;
            


        }
        private static void DisplayBoard()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0;j < 3; j++)
                {
                    Console.Write(numbers[i,j] + "  ");
                }
                Console.WriteLine("\n");
            }    
        }
    }
}
