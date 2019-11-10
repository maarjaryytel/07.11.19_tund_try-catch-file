using System;
using System.IO; //IO tähendab input-output
using System.Collections.Generic;
using System.Linq;

namespace working_with_file
{
	class Program
	{
		static void Main(string[] args)
		{
			string path = @"C:\Demo\demo.txt"; //targurpidi kaldkriips- see on reserveeritud, paneme ette @
											   //proovime neid andmeid maha lugeda
		
			List<string> lines = File.ReadAllLines(path).ToList();
			//teeb selle faili lahti, loeb maha ja paneb faili kinni
			//meile sellest kasu ei ole, peab kusagile salvestama
			//salvestame need read mida ta luges listi sisse
			//kuvab need loetud read foreachiga

			foreach (string line in lines)
			{
				Console.WriteLine($"{line} is on the list");
			}

			//kui ma tahaks midagi lisada

			Console.WriteLine("Lets add an item: ");
			string userItem = Console.ReadLine();
			lines.Add(userItem);

			//kirjutame selle faili sisu ümber ja kui me tahame veenduda, kas on uus rida lisatud
			//võime selle maha lugeda, selle koodiga mida oleme kasutanud

			File.WriteAllLines(path, lines);  //path- ingl keeles rada, tee

			List<string> lines1 = File.ReadAllLines(path).ToList();

			foreach (string line in lines1)
			{
				Console.WriteLine($"{line} is on the list");
			}

			Console.ReadLine();
		}
	}
}
