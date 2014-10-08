using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Persons
{
	class Persons
	{
		static void Main()
		{
			List<Person> persons = new List<Person> () 
			{
				new Person("Pen4o",22),
				new Person("Gan4o",23),
				new Person ("Ignati",43,"ignati@abv.bg"),
			};
			foreach (var person in persons) 
			{
				Console.WriteLine(person.ToString());
			}
		}	
	}
}
