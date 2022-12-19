using System;

namespace HelloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee tom = new Employee("Tom", "Microsoft");
        }
    }

    class Person
    {
        string name;
        int age;

        public Person()
        {
        }
        public Person(string name) : this(name, 18)
        {
        }
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }
    class Employee : Person
    {
        string company;

        public Employee()
        {
        }
        public Employee(string name, int age, string company) : base(name, age)
        {
            this.company = company;
        }
        public Employee(string name, string company) : base(name, 22)
        {
            this.company = company;
        }
    }
}