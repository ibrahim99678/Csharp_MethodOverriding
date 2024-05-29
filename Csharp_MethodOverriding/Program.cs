using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_MethodOverriding
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Method Overriding : provides a new version of a method inherited from a parent class
            //                      inherited method must be :abastract , virtual or already overriden 
            //                      used with Tostring(), polymorphism

            Dog dog = new Dog();
            Cat cat = new Cat();

            dog.Speak();
            cat.Speak();

            Console.ReadKey();

        }
        class Animal
        {

            public virtual void Speak()                                 //When we use virtual here 
            {
                Console.WriteLine("The animal goes **brrr*");

            }
        }
        class Dog : Animal
        {
            public override void Speak()                                // then we can use override and can use same class with seperate message
            {
                Console.WriteLine("The dog goes **Woof**");
            }

        }
        class Cat : Animal
        {
            public override void Speak()
            {
                Console.WriteLine("The cat goes **Meow**");                //inherited a parent class through overriding method.
            }
        }
    }
}
