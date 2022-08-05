using System;
using System.Text;

namespace Гласныесогласные
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
         
            

            string word = "сенсация";
          
            string sign = "аеёиоуыэюя";
            for (int ch = 0; ch < sign.Length; ch++) 
            {
                if(word.Contains(sign[ch]))
                    count++;
            } 
           
            Console.WriteLine(count);
            Console.ReadLine();
          
              
        }
    }
}
