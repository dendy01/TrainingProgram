using System;
using System.Reflection;

namespace TrainingProgram
{
    class Person<T>
    {
        public T Id { get; set; }
        private string _name { get; set; }

        public Person(T id, string name)
        {
            Id = id;
            _name = name;
        }

        public void PrintInfo() => Console.WriteLine($"Id: {Id} Name: {_name}");
    }

    class Company<P>
    {
        public P CEO { get; set; }

        public Company(P ceo)
        {
            CEO = ceo;
        }
    }

    class Program
    {
        public static void Show<T>(ref T x, ref T y)
        {
            T temp = x;
            x = y;
            y = temp;
        }

        static void Main()
        {
            Person<string> tim = new Person<string>("23", "Tim");
            Person<int> tom = new Person<int>(3, "Tom");

            Company<Person<string>> company = new Company<Person<string>>(tim);

            tim.PrintInfo();
            tom.PrintInfo();

            Console.WriteLine(company.CEO.Id);

            int x = 4, y = 5;

            Show(ref x, ref y);

            Console.WriteLine($"x: {x} y: {y}");
        }
    }
}