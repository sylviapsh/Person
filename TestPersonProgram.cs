using System;

namespace Person
{
    class TestPersonProgram
    {
        static void Main()
        {
            //Initialize some people
            Person person1 = new Person("Ivan Ivanov", 15);
            Person person2 = new Person("Dragan Draganov", 35);
            Person person3 = new Person("Petkan Petkanov");

            Console.WriteLine(person1);
            Console.WriteLine(person2);
            Console.WriteLine(person3);
        }
    }
}
