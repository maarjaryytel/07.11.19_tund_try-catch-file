using System;

namespace how_to_handled_exeptions
{
	class Program
	{
		static void Main(string[] args)
		{
			//oletame et meil on progrmmm, mis küsib kasutajalt 2 numbrit ja siis jagab neid
			//need vead on sissekirjutatud, kuid me saame ise ka neid funktsioone kirjutada

			int number1;
			int number2;
			double number3;

			//siin me proovime kasutaja käest midagi saada ja nende andmetega midagi teha, tõstame kogu koodi
			//sinna try sisse

			try
			{
				Console.WriteLine("Enter nr 1: ");
				//peame intiks muutma
				number1 = int.Parse(Console.ReadLine());

				Console.WriteLine("Enter nr 2: ");
				number2 = int.Parse(Console.ReadLine());

				number3 = number1 / number2;
				Console.WriteLine(number3);
			}
			catch(DivideByZeroException e) //võime teha mitu catchi ja teame neid mis tüüpi vigu võivad 
			//ette tulla- nt format ja 0- ga jagamine
			{
				Console.WriteLine("You must not divide by zero!");
			}
			catch (FormatException e) //e täht on errori lühend, seda võib kasutada //valeformaadi puhul
			//anda kasutajale tagasisidet, mida ta valesti tegi

			{
				Console.WriteLine("You have used invalid format!");
			}

			Console.ReadLine();
			
			//algne kood alljärgnev, üleval uus kood kohandatuna
			//catch- püüa seda errorit ja ütle midagi
			/*Console.WriteLine("Enter nr 1: ");
			//peame intiks muutma
			number1 = int.Parse(Console.ReadLine());

			Console.WriteLine("Enter nr 2: ");
			number2 = int.Parse(Console.ReadLine());

			number3 = number1 / number2;
			Console.WriteLine(number3);*/

			//kasutaja võib numbri asemel kirjutada sõna, kood jookseb kokku ja annab hoiatuse, 

			//format on vale, ta ei suuda neid konventeerida
			// kui panna null, siis ei saa jagada 0. Mida teha, et kood jätkaks tööd kui kasutaja on valed andmed siestanud
			//selleks et tuvastada neid erroreid, on olemas try 
		}
	}
}
