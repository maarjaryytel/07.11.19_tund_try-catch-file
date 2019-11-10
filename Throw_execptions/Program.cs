using System;

namespace Throw_execptions
{
	class Program
	{
		static void Main(string[] args)
		{
			//millal kasutaja on sündinud, funktsiooniga
			//kõigepealt loome uue muutuja

			//küsime tema sünniaega
			/*Console.WriteLine("Enter your day of birth yyyy/mm/dd: ");
			userInput = Console.ReadLine();*/
			//saab parameetriks selle sõne, loob sõneks maassiivi ja siis see funktsioon loob objekti
			//ja sealt objektist saab andmed kätte

			try
			{
				//proovin saada mingi sõna ja saan selle GetData
				string userData = GetData();
				//kui mul on sõna käes, siis võIn luua uue objekti- kasutaja sünnipöev
				var userBirthDay = GetDate(userData);
				Console.WriteLine($"You were born on {userBirthDay.DayOfWeek}");
			}
			catch (Exception e)
			{
				//annan kasutajale tagaisidet
				Console.WriteLine(e);
				Console.WriteLine("Please try again!");
				//
			}
		}
		//tagastab mulle Datetime objekti
		public static DateTime GetDate(string dateOfBirthString)
		//mis ma teen selle sõnega, 
		//teeme kõigepealt spliti, et saaks massiivi kätte ja et saaks elementi parssida
		{
			string[] userBDay = dateOfBirthString.Split('/');
			//try on vaja, et luua datetime objekti
			try
			{
				var dateObject = new DateTime(int.Parse(userBDay[0]), int.Parse(userBDay[1]), int.Parse(userBDay[2]));
				//kui ma saan selle objekti kätte siis teen
				return dateObject;
			}
			catch (FormatException e)
			//kui tal õnnestub parssida midagi, siis kirjutan throw
			//ka kirjutan ka hoiatuse kasutajale
			{
				Console.WriteLine("use the correct date format: yyyy/mm/dd: ");
				throw; //tagasta viga
			}
			//ta püüab luua kõigepealt objekti
			//kui on viga, annab tagasidet,
			//programm jätkab oma tööd
			//proovime seda rakendada
		}
		public static string GetData()//millega see võrdub? saame sõne
		
		{
		string userInput;
		Console.WriteLine("Enter your day of birth yyyy/mm/dd: ");
		return userInput = Console.ReadLine();
		}

	}
	
}
