using System;

namespace Zadachki
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//Деклариране на променливи
			string a = "Hello", b = "Live";
			object c = (a + " " + b);
			string d = (string)c;

			Console.WriteLine ("Изписва променлива от тип object: " + c + "\n");
			Console.WriteLine ("{0} {1}", a, b);



		
		}
	}
}
