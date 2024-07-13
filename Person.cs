using System;

namespace MyFirstApp;
{
    public class Person
    {
        public string Name;
        public int Age;

        public void Introduce()
        {
            Console.WriteLine("Hi, my name is "+ Name+ "and I am"+ Age+ "year old");
        }
    }
}