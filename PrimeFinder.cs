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


            public int SelectANumber()
            {
            GetPrimesInRange();
            int selectednumb;
                 while (true)
                 {

                      Welcome();
                      try
                      {
                    selectednumb = int.Parse(Console.ReadLine());
                    if (selectednumb > 25 || selectednumb<0)
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
                   selectednumb--;
            return selectednumb;
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
                //foreach (int p in primes)
                //{
                //    Console.WriteLine(p);
                //}
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

        public int GetNumbersBack()
        {
            List<int> Primes = GetPrimesInRange();
            int selectedNumber = SelectANumber();

            return Primes[selectedNumber];
        }









    }
}
