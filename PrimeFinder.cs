using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeFinderLab
{
    public class PrimeFinder
    {
            public void Welcome()
            {
                Console.WriteLine("Welcome to our prime number generator. Please select a number 1-25 to see the correlating prime number from 1-100");
            }


            public int SelectANumber(int userinput)
            {
            List<int> Primes = GetPrimesInRange();
                 while (true)
                 {

                      Welcome();
                      try
                      {

                    if (userinput > 25 || userinput<0)
                            {
                            Console.WriteLine(" Please input a number that is less than 26 and greater than 0 ");
                            continue;
                            } 
                      }
                      catch
                      {
                            Console.WriteLine("Im sorry you havented inputed a an answer we cannot accept. Try again");
                            continue;
                      }

                       break;
                 }
                   userinput--;

            return Primes[userinput];
            }    


            public List<int> GetPrimesInRange()
            {
                int num = 100;
                List<int> primes = new List<int>();
                for (int i = 1; i <= num; i++)
                {
                    if (DetermineIsPrime(i) == true && i > 1)
                    {
                        primes.Add(i);
                    }
                }
                return primes;
            }

            public bool DetermineIsPrime(int num)
            {
                int y;
                List<int> divisors = new List<int>();
                double x = Math.Sqrt(num);
                y = (int)Math.Ceiling(x);
                if (num == 3 || num == 2)
                {
                    return true;
                }
                for (int counter = 1; counter <= y + 1; counter++)
                {
                    if (num % counter == 0)
                    {
                        divisors.Add(counter);
                        if (divisors.Count > 1)
                        {
                            return false;
                        }
                    }
                }
                return true;
            }

        //public int GetNumbersBack()
        //{
        //    List<int> Primes = GetPrimesInRange();
        //    int selectedNumber = SelectANumber();

        //    return Primes[selectedNumber];
        //}









    }
}
