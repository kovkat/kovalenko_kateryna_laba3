using System;
using System.Linq;
//Переставте сусідні елементи списку. Якщо елементів непарне число, то останній
//елемент залишається на своєму місці.

namespace laba3._1
{
    class Program
    {
        static void Main()
        {
            var words = new List<string>();
            randstrings(words);
            print(words);
            Console.WriteLine();
            Console.WriteLine("Result:");
            Console.WriteLine();
            if (words.Count%2==0)
            {
                change(words, words.Count);
            }
            else
            {
                change(words, words.Count - 1);
            }
            print(words);
            Console.ReadKey();
        }

        public static void change(List<string> list, int size)
        {
            string fst;
            for (int i = 0; i < (size - 1); i += 2)
            {
                fst = list[i];
                list[i] = list[i + 1];
                list[i + 1] = fst;
            }
        }

        public static void print(List<string> lists)
        {
            for (int i=0; i<lists.Count; i++)
            {
                Console.Write(lists[i]+"\n");
            }
        }

        public static void randstrings(List<string> lists)
        {
            Random n = new Random();
            int value = n.Next(3, 10);
            for (int i = 1; i <= value; i++)
            {
                lists.Add(Convert.ToString(i));
            }
        }
    }
    
}

