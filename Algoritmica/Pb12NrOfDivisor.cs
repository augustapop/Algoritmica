using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmica
{
  public  class Pb12NrOfDivisor
    {
      public int NumberOfDivisors(int number)
      {
          int count = 0;
          int sqrt = (int)Math.Sqrt(number);
          for (int i = 1; i <= sqrt; i++)
          {
              if (number % i == 0)
              {
                  count += 2;
              }
          }
          if (sqrt * sqrt == number)
          {
              count--;
          }
          return count;           
      }

      public int Number()
      {
          int number = 0;
          int i = 1;
          while (NumberOfDivisors(number) < 500)
          {
              number += i;
              i++;
          }
          return number;
      }


    }
}
