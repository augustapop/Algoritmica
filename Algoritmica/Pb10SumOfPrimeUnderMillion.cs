using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmica
{
  public  class Pb10SumOfPrimeUnderMillion
    {
      public  bool getPrime(long i)
      {
          for (long k = 2; k <= Math.Sqrt(i); k++)
          {
              if (i % k == 0)
              {
                  return false;
              }
          }
          return true;
      }

      public long SumOfPrimeMillion()
      { 
      long SumOfPrimeMillion=2;
      long limit = 2000000;
      long start = 3;
      while (start < limit)
      {
          if (getPrime(start))
          {
              SumOfPrimeMillion += start;
          }
          start += 2;
      }
      return SumOfPrimeMillion;
      }

     
    }
}
