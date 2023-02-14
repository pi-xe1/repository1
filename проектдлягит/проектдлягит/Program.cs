using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace проектдлягит
{
	class Program
	{
		static void Main(string[] args)
		{
			double a, b;
			Console.WriteLine("Допустимые операции: +, -, *, /, INT"); //INT - округление числа до целой части
			Console.Write("первый операнд: ");
			a = Convert.ToDouble(Console.ReadLine());
			Console.Write("операция: ");
			string smb = Console.ReadLine();
			switch (smb)
			{
				case "+":
					Console.Write("второй операнд: ");
					b = Convert.ToDouble(Console.ReadLine());
					Console.Write("результат: "); Console.WriteLine(a + b);
					Console.WriteLine("\n");
					break;
				case "-":
					Console.Write("второй операнд: ");
					b = Convert.ToDouble(Console.ReadLine());
					Console.Write("результат: "); Console.WriteLine(a - b);
					Console.WriteLine("\n");
					break;
				case "*":
					Console.Write("второй операнд: ");
					b = Convert.ToDouble(Console.ReadLine());
					Console.Write("результат: "); Console.WriteLine(a * b);
					Console.WriteLine("\n");
					break;
				case "/":
					Console.Write("второй операнд: ");
					b = Convert.ToDouble(Console.ReadLine());
					Console.Write("результат: "); Console.WriteLine(a / b);
					Console.WriteLine("\n");
					break;
				case "INT":
					Console.Write("результат: "); Console.WriteLine(Convert.ToInt32(a));
					Console.WriteLine("\n");
					break;
				default:
					Console.WriteLine("ошибка ввода данных \n");
					break;
			}
			Console.ReadKey();
		}
	}
}
