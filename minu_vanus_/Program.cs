using System;

namespace minu_vanus_
{
	class Program
	{
		static void Main(string[] args)//loome uue funktsiooni
		{
			GetAge();
			Console.ReadLine();
		}

		public static void GetAge()
		{
			int yearOfBirth;
			Console.WriteLine("Enter your year of birth");
			try
				//try käib nii kaua kuni saab selles koodis õige vastuse
			{
				yearOfBirth = int.Parse(Console.ReadLine());
				Console.WriteLine($"You are { 2019 - yearOfBirth} years old");
			}
			catch
			{
                 Console.WriteLine("Invalid date format");
			     GetAge();
			}
			
			//püüame parsida neid andmeid, kui õnnestub, siis kirjutab, sa oled nii vana" +
			//kui int parse ei õnnestu, sis me püüame errori kinni ja paneme selle funtksiooni jälle kinni" +
			//seda kutsutakse rekonstruktsiooniks)
			//getAge kutsub ennast välja ja peame seda tegema ka mainis

		}
			

	}	
}
	

