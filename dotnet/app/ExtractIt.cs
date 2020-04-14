using System;

namespace app.extract
{

	public class Person
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public int Age { get; set; }

		public Person(string firstName, string lastName, int age)
		{
			this.FirstName = firstName;
			this.LastName = lastName;
			this.Age = age;
		}
	}

	public class ExtractIt
	{
		public static void Main()
		{
			var john = new Person("John", "Adams", 45);
			var (firstName, lastName) = john;
			var (_, _, age) = john;
		}
	}
}