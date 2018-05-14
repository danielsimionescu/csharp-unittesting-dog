using DogLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var dog = new Dog("Lassie", 4);  // the set accessors are invoked here.
            Console.WriteLine(dog.Name);     // the get accessors are invoked here. 
            Console.WriteLine(dog.Age);

            try
            {
                var dog3 = new Dog("TY", -2);
                Console.WriteLine(dog3.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }
}
