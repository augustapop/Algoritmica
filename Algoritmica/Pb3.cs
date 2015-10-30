using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmica
{
  public  class Pb3
    {
      public long PrimLongNumber()
      {
          long num = 600851475143;
          long LargestPrime = 0;
          for (long i = 2; i * i < num; i++)
          { 
          
          if(IsFactor(num,i))
              if (IsPrime(i))
              {
                  if (i > LargestPrime)
                      LargestPrime = i;
              }
          }
          return LargestPrime;
      }

      static bool IsPrime(long n)
      {
          for (long i = 2; i < n; ++i)
          
              if (n % i == 0)
                  return false;
          
              return true;          
      }

      static bool IsFactor(long x, long y)
      {
          if (x % y == 0)
              return true;
          return false;
      }

    }
}
