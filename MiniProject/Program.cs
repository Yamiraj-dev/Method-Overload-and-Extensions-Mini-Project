using System;

namespace MiniProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonModel person = new PersonModel();

           
            person.FirstName = "What is your first name: ".RequestString();

            person.LastName = "What is your last name: ".RequestString();

            person.Age = "What is your last age: ".RequestInt(0, 100);

            Console.ReadLine();
        }
    }
}