using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Implementing Problem #1");



            Problem1Solution();


            calculate();
            check();

            // call solution 2



            // call solution 3



            // ...



            // Important to use this line of code to keep the console open

            Console.ReadKey();

        }



        private static void Problem1Solution()
          
        {
            int a = Convert.ToInt16(Console.ReadLine());


            int b = Convert.ToInt16(Console.ReadLine());
            string result;



            try

            {
                result = Convert.ToString(a + b);
                Console.WriteLine("result is" + result);
                // Implement your solution

            }

            catch (Exception ex)

            {

                Console.WriteLine("An error occurred: " + ex.ToString());

            }



        }
        private static void calculate() {
            //Factorial 

            Console.WriteLine("Please enter your number: ");
                int n = int.Parse(Console.ReadLine());

        int factorial = 1;
                for (int i = 1; i <= n; i++)
                {
                    factorial *= i;
                }

    Console.WriteLine(factorial);
          
        }

        //Time Converter



        private static void check()
        {// Number Comparison
            Console.WriteLine("Type number 1");
            int number1=Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Type Number2");
            int number2 = Convert.ToInt16(Console.ReadLine()); ;
            bool flag = number1 < number2;

            Console.WriteLine("number1 is less than number2:"+ flag);



            if (flag == true)
            {
                return;
            }

                else 
                {
                flag = false;
                    
                return;
                }
                else
            // If the parameter values are equal to each other then return the string -1.
            {
                 Console.WriteLine("- 1");
                return;
                }
            
           


        }
        private static void Capitalize()
        {
            //Capitalize Letters
            string myString = "This is a test.";
            char[] separator = { ' ' };//character
            string[] myWords;
            myWords = myString.Split(separator);
            foreach (string word in myWords)
            // foreach(int index =0; index< myString.Length; index =index+4)
            {
                Console.WriteLine("{0}", word);
            }
            Console.ReadKey();
        }
    }
}

