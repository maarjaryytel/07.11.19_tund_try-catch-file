using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._11_tund
{
	class Program
	{
		static void Main(string[] args)
		{
			//tänase tunni teemad
			//kuidas saaksime erandeid- exeption, võtmesõna frow ja mis nendega teha
			//konventeerimist- massiisivist listi
			//faili sisse kirjutada ja maha lugeda

			//küsime kasutaja käest 3 värvi
			Console.WriteLine("name three colors");
			string userInput = Console.ReadLine();
			//kasutaja vastus on string formaadis
			//kuidas ma saan komadest ja tühikutest lahti
			//tahan saada massiivi

			string[] colors = userInput.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
			
			//nüüd on massiivis 3 elementi
			//kui ma tahaks lisada või kustutada mida peab tegema
			//massiivi ei saa juurde lisada, loon lisamiseks listi

			//kuidas muudan listiks
			List<string>colorList = colors.ToList();

			//kuidas ma kuvan neid asju
			//nüüd mul saab masiivist list, enam ei ole massiivi
			foreach (string color in colorList)
			{
				Console.WriteLine(color);
			}

			Console.WriteLine("Add/remove a color");
			string userChoice = Console.ReadLine();

			if (userChoice.ToLower() == "add")
			{
				Console.WriteLine("Enter a color to add: ");
				string userAnswerToAdd = Console.ReadLine();
				colorList.Add(userAnswerToAdd);
			}
			else if (userChoice.ToLower() == "remove") //kuidas kustutame listist
			{
				Console.WriteLine("Enter a color to remove: ");
				string userAnswerToRemove = Console.ReadLine();//ei ole üks ja sama eelmise muutujaga, need blokid
				//ei ole omavahel seotud, võib kasutada ühe ja sama nimega muutujat erinervates blokkides
				//need on ajutised muutujad ja nad elavad niikaua kuni see blokk töötab
				colorList.Remove(userAnswerToRemove);
			}
			else
			{
				Console.WriteLine("Unknown command");
			}
			foreach (string color in colorList)
			{
				Console.WriteLine(color);
			}
			Console.ReadLine();
		}
	}
}
