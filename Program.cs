//Дана послідовність непустих рядків. Використовуючи метод Aggregate,
//отримати рядок, що складається з початкових символів всіх рядків вихідної
//послідовності. (1)
//- First, FirstOrDefault, Last, LastOrDefault, Single, SingleOrDefault (поелементні операції)
//-Count, Sum, Average, Max, Min, Aggregate(агрегування); • Range(генерування послідовностей).
using System;
using System.Linq;
using System.Collections;

namespace laba3_3
{
    class Program
    {
        static void Main()
        {
            string path = "/Users/katerynakovalenko/Documents/laba3_3.txt";
            var strings = new List<string>();
            if (File.Exists(path))
            {
                CopyToList(strings, path);
                var res = strings.Aggregate("",(x, y)=>x+y.First());
                Console.WriteLine(res);
            }
            else
                Console.WriteLine("File does not exist!");
            Console.ReadKey();
        }

        public static void CopyToList(List<string> list, string path)
        {
            var file = File.ReadAllLines(path);
            foreach (var s in file) list.Add(s);
        }
    }
}
