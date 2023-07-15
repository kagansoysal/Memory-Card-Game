using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//HATALAR KONTROL ETTİRİLECEK//

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> NumberLetterPairs = new Dictionary<int, string>();
            int[] authors = Enumerable.Range(1, 16).ToArray();
            List<int> authorsRange = new List<int>();
            authorsRange.AddRange(authors);
            string[] letters = { "A", "B", "C", "D", "E", "F", "G", "H", "A", "B", "C", "D", "E", "F", "G", "H" };
            Random random = new Random();
            letters = letters.OrderBy(x => random.Next()).ToArray();

            for (int i = 0; i<16; i++)
            {
                NumberLetterPairs.Add(authorsRange[i], letters[i]);

            }
            foreach (var item in NumberLetterPairs)
            {
                Console.WriteLine(item);
            }

            List<string> writing = new List<string> { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16" };

            
            for (int i = 0; i < 20; i++)
            {
                Console.Write("1.kartı seçiniz: ");
                int choice1 = Convert.ToInt32(Console.ReadLine());
                writing[choice1 - 1] = NumberLetterPairs[choice1];

                for (int j = 0; j < 16; j++)
                {
                    if ((j+1) % 4 != 0)
                    {
                        if (j+1 < 10)
                        {
                            Console.Write(writing[j] + "  ");
                        }
                        
                        else
                        {
                            Console.Write(writing[j] + " ");
                        }
                    }

                    else
                    {
                        Console.WriteLine(writing[j] + " ");
                    }
                }
                Console.WriteLine();

                Console.Write("2.kartı seçiniz: ");
                int choice2 = Convert.ToInt32(Console.ReadLine());
                writing[choice2 - 1] = NumberLetterPairs[choice2];

                for (int j = 0; j < 16; j++)
                {
                    if ((j + 1) % 4 != 0)
                    {
                        if (j + 1 < 10)
                        {
                            Console.Write(writing[j] + "  ");
                        }

                        else
                        {
                            Console.Write(writing[j] + " ");
                        }
                    }

                    else
                    {
                        Console.WriteLine(writing[j] + " ");
                    }
                }
                Console.WriteLine();
                Console.WriteLine();

                if (NumberLetterPairs[choice1] != NumberLetterPairs[choice2])
                {
                    writing[choice1 - 1] = Convert.ToString(choice1);
                    writing[choice2 - 1] = Convert.ToString(choice2);
                }


                for (int j = 0; j < 16; j++)
                {
                    if ((j + 1) % 4 != 0)
                    {
                        if (j + 1 < 10)
                        {
                            Console.Write(writing[j] + "  ");
                        }

                        else
                        {
                            Console.Write(writing[j] + " ");
                        }
                    }

                    else
                    {
                        Console.WriteLine(writing[j] + " ");
                    }
                }
                Console.WriteLine();
            }
              
        }

    }
}
