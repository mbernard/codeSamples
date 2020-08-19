using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp9.TargetTyped
{
    public abstract class Animal
    {
    }

    public class Dog : Animal
    {
        public Dog(string breed)
        {
            Breed = breed;
        }

        public string Breed { get; }
    }

    public class Cat : Animal
    {
        public Cat(string name)
        {
            Name = name;
        }

        public string Name { get; }
    }
}
