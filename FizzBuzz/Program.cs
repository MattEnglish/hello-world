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
            string FizzBuzz = "";
            List<string> FizzBuzzList = new List<string>();
 
            if (number%3==0){FizzBuzzList.Add("Fizz");}

            if(number%13==0){FizzBuzzList.Add("Fezz");}

            if (number % 5 == 0){FizzBuzzList.Add("Buzz");}

            if (number % 7 == 0){FizzBuzzList.Add("Bang");}

            if (number % 11 == 0)
            {
                FizzBuzzList.Clear();

                if (number % 13 == 0){FizzBuzzList.Add("Fezz");}
                FizzBuzzList.Add("Bong");
            }

            if (number % 17 == 0){FizzBuzzList.Reverse();}


            for (int word = 0; word < FizzBuzzList.Count; word++)
            {
                FizzBuzz += FizzBuzzList[word];
            }
            
            if (FizzBuzz == ""){Console.WriteLine(number);}
           
            else{Console.WriteLine(FizzBuzz);}
        }
    }
}
