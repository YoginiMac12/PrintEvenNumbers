using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintEvenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {  
            int EvenCount = 0;
            Console.WriteLine("1 to 50 Even Number:");
            for (int i=1;i<=50;i++)
            {
                if(i%2==0)
                {
                   Console.WriteLine(i);
                   EvenCount++;
                }
            }
            Console.WriteLine("Total Even Number Count=" +  EvenCount);
          { 
           Console.ReadLine();
          }
        }
    }
}


    

    
    

