using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmica
{
    
    public class Pb5
    {
        //What is the smallest positive number 
        //that is evenly divisible by all of the numbers from 1 to 20?
        public int DivideBy20()
        {
            int num = 1;
            bool isDivisiblyByAll = false;
            bool isFound = false;
            while (isFound == false)
            {
                for (int i = 1; i <= 20; i++)
                {
                    if (num % i == 0)
                    {
                        isDivisiblyByAll = true;
                    }
                    else
                    {
                        isDivisiblyByAll = false;
                        break;
                    }
                }
                if (isDivisiblyByAll)
                {
                    isFound = true;
                }

                num++;
            }
            return num;
        }
    }
}
