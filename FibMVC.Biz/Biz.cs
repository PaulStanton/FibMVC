using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibMVC.Biz
{
    public static class Biz
    {
        /// <summary>
        /// starts with 0 
        /// </summary>
        /// <param name="numFib"></param>
        /// <returns></returns>
        public static List<int> FibonacciCalculator( int numFib)
        {
            List<int> tempFib = new List<int>();
            int fibNum = 0;
            if (numFib == 0)
            {
                return null;
            }
            if (numFib >= 1)
            {
                tempFib.Add(fibNum);
                fibNum++;
            }
            if (numFib >= 2)
            {
                tempFib.Add(fibNum);
            }
            if (numFib >=3)
            {
                for (int i = 2; i < numFib; i++)
                {
                    fibNum = tempFib[i - 2] + tempFib[i - 1];
                    tempFib.Add(fibNum);
                }
            }
            return tempFib;

            
          
            }
        }
    }

