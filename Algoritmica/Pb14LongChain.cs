using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmica
{
   public class Pb14LongChain
    {
       public long GetLongChain()
       {
           long iValue = 3;
           long iLimit = 1000000;
           long greatestIterationCount = 0;
           long greatestIteration = 0;

           while (iValue < iLimit)
           {
               long iCount = 0;
               long chainSol = iValue;
               while (chainSol > 1)
               {
                   if (chainSol % 2 == 0)
                   {
                       chainSol = chainSol / 2;
                   }
                   else
                   {
                       chainSol = (3 * chainSol) + 1;
                   }
                   iCount++;
               }
               if (iCount > greatestIterationCount)
               {
                   greatestIterationCount = iCount;
                   greatestIteration = iValue;
               }
               iValue++;
           }
           return greatestIteration;       
       }
    }
}
