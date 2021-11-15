using System;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string cumle = "bu gün hava çok güzel....arkadaşlar ile kavak olan bir yere gittik. tabi gitmeden ütü yaptım. orada ata bindim....";

            string[] cumleler = cumle.Split(' ');

            foreach (var item in cumleler)
            {
                int i = 0;
                while (i < item.Length)
                {
                    if (item[i] == item[item.Length - (i + 1)])
                    {
                        i++; 
                    }
                    else
                    {
                        break;
                    }
                }

                if (i==item.Length)
                {
                    Console.WriteLine($"{item} bir palindromedir.");
                }
            } 

            Console.ReadKey();
        }
    }
}
