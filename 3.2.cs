using System;
using System.Collections;
//Дано словник з масивами літер у значеннях ключа.
//Вивести на екран комбінації усіх літер, перебравши всі можливі комбінації
//літер різних ключів словника. Вхідний словник : {'1':['A','d'], '2':['C','B']}.
//Вихідний результат ACAB dCdB
namespace laba3_2
{
	public class Program
	{
		static void Main()
		{
			var dict = new Dictionary<int, char[]>
			{
				{ 1 ,new char[]{ 'A', 'd' } },
				{ 2 ,new char[]{ 'C', 'B' } },
				//{ 3 ,new char[]{ 'f', 'n' } }
			};
			for(int i=0; i < dict[1].Length; i++)
            {
				for(int l=2; l<=dict.Count; l++)
				{
					for (int j = 0; j < dict[l].Length; j++)
					{
						Console.Write(dict[1][i] + "" + dict[l][j]);
					}
					Console.WriteLine(" ");
				}
				
            }
			Console.ReadKey();
		}
	}
}

