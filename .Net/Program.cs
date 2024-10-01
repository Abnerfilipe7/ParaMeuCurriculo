using System;

class Program
{
	static void Main()
	{
		Console.Write("Digite a temperatura em Celsius : ");
		if (!double.TryParse(Console.ReadLine(), out double temperatura))
		{
			Console.WriteLine("Por favor, insira um valor numérico válido.");
		}

		
			else
			
				if (temperatura < 15)
				{
					Console.WriteLine("Está frio.");
				}
				else if (temperatura >= 15 && temperatura <= 25)
				{
					Console.WriteLine("Está agradável.");
				}
				else
				{
					Console.WriteLine("Está quente.");
				}
			}
		}