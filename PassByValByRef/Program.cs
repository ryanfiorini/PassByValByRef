using System;

namespace PassByValByRef
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start");

            var inParam1 = "original value";
            var inParam2 = 9;
            byte inParam3 = 250;
            var person = new Person("John", "Doe");

            Console.WriteLine("");
            Console.WriteLine("Starting Values");
            Console.WriteLine($"inParam1: {inParam1}");
            Console.WriteLine($"inParam2: {inParam2}");
            Console.WriteLine($"inParam3: {inParam3}");
            Console.WriteLine($"inParam4: {person.GetFullName()}");

            CheckParamVal(inParam1, inParam2, inParam3, person);

            Console.WriteLine("");
            Console.WriteLine("After CheckParamVal");
            Console.WriteLine($"inParam1: {inParam1}");
            Console.WriteLine($"inParam2: {inParam2}");
            Console.WriteLine($"inParam3: {inParam3}");
            Console.WriteLine($"inParam4: {person.GetFullName()}");

            CheckParamRef(ref inParam1, ref inParam2, ref inParam3, ref person);

            Console.WriteLine("");
            Console.WriteLine("After CheckParamRef");
            Console.WriteLine($"inParam1: {inParam1}");
            Console.WriteLine($"inParam2: {inParam2}");
            Console.WriteLine($"inParam3: {inParam3}");
            Console.WriteLine($"inParam4: {person.GetFullName()}");

            Console.WriteLine("End");
        }

        private static void CheckParamVal(string param1, int param2, byte param3, Person person)
        {
            param1 = "changed value";
            param2 = 100;
            param3 = 200;
            person.FirstName = "Jane";
            person.LastName = "Smith";
        }

        private static void CheckParamRef(ref string param1, ref int param2, ref byte param3, ref Person person)
        {
            param1 = "changed value";
            param2 = 100;
            param3 = 200;
            person.FirstName = "Sally";
            person.LastName = "Peoples";
        }

        private class Person {
            public string FirstName { get; set; }
            public string LastName { get; set; }

            public Person(string firstName, string lastName)
            {
                FirstName = firstName;
                LastName = lastName;
            }

            public string GetFullName()
            {
                return $"{FirstName} {LastName}";
            }
        }
    }
}
