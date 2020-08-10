using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp9.PrimaryConstructors
{
    public record Person(string firstName, string lastName);

    public record PersonWithDefaultValue(string firstName, string lastName = "lastName");

    //public class Person
    //{
    //    public Person(string firstName, string lastName)
    //    {
    //        this.FirstName = firstName;
    //        this.LastName = lastName;
    //    }

    //    public string FirstName { get; }
    //    public string LastName { get; }
    //}
}
