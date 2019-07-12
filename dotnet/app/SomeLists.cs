using System.Collections.Generic;
using System.Linq;
using app.models;

namespace app
{
    public class SomeLists
    {
        List<string> spells = new List<string> { "accio", "alohamora", "lumos" };

        List<Person> people = new List<Person>()
        {
            new Person() { FirstName = "John", LastName = "Smith", Age = 18 } ,
            new Person() { FirstName = "Steve", LastName = "Freeman", Age = 15 } ,
            new Person() { FirstName = "Ron", LastName = "Burgondy", Age = 19 } ,
        };

        List<Student> students = new List<Student>()
        {
            new Student() { ID = 1, Name = "John", Age = 18 } ,
            new Student() { ID = 2, Name = "Steve",  Age = 15 } ,
            new Student() { ID = 3, Name = "Bill",  Age = 25 } ,
            new Student() { ID = 4, Name = "Ram" , Age = 20 } ,
            new Student() { ID = 5, Name = "Ron" , Age = 19 }
        };

        //////////////
        public void Foo()
        {
            
        }

    }
}