using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
         
        static void Main(string[] args)
        {
            for (int number = 0; number < 300; number++)
            {
                PrintFizzBuzzNumber(number);
            }

        }

        private static void PrintFizzBuzzNumber(int number)
        {
            
            List<string> FizzBuzzList = new List<string>();
            Dictionary<int,string> rules = new Dictionary<int, string>();
            rules.Add(3, "Fizz");
            rules.Add(13, "Fezz");
            rules.Add(5, "Buzz");
            rules.Add(7, "Bang");

            foreach (var rule in rules)
            {
                if(number%rule.Key==0)
                {                   
                    FizzBuzzList.Add(rule.Value);
                }
            }


            if (number % 11 == 0)
            {
                FizzBuzzList.Clear();
                if (number % 13 == 0){FizzBuzzList.Add("Fezz");}
                FizzBuzzList.Add("Bong");
            }

            if (number % 17 == 0){FizzBuzzList.Reverse();}


            string FizzBuzz = string.Join("", FizzBuzzList);
            
            if (FizzBuzz == "")
            {
                Console.WriteLine(number);
            }
           
            else
            {
                Console.WriteLine(FizzBuzz);
            }
        }
    }
}
