using System;
using System.Text;

namespace Гласныесогласные
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;

            int count2 = 0;

            string word1 = "Сенация";
           string word =word1.ToLower();
          
            string sign = "аеёиоуыэюя";
            for (int ch = 0; ch < sign.Length; ch++) 
            {
                if(word.Contains(sign[ch]))
                    count++;
            }
            string sign2 = "бвгджзйклмнпрстфхцчшщ";
            for (int ch = 0; ch < sign2.Length; ch++)
            {
                if (word.Contains(sign2[ch]))
                    count2++;
            }


            Console.WriteLine($"Количество гласных букв{ count}");
            Console.WriteLine($"Количество согласных букв{count2}");
            Console.ReadLine();
          
              
        }
    }
}
