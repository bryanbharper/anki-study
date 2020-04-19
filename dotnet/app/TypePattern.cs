using System;

namespace app.isop
{
		public class Employee
{
    public String Name { get; set; }
    public int Id { get; set; }

    public void WriteName(Object o)
    {
        var e = o as Employee;
        if (e == null)
        {
           throw new ArgumentException("o is not an Employee object.");
        }
        
				Console.WriteLine(e.Name);
    }
}
}