using System.Collections.Generic;

namespace app
{
	class TemporaryCollection
	{
		IEnumerable<Employee> GetRichEmployees(IEnumerable<Employee> employees)
		{
			List<Employee> result = new List<Employee>();
			foreach (var employee in employees)
			{
				if (employee.Salary >= 20000)
					result.Add(employee);
			}
			return result;
		}
	}

	class Employee
	{
		public string Name { get; set; }
		public int Salary { get; set; }
	}
}