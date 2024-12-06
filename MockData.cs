using System.Collections.Generic;

namespace Assignment_4._1._1
{
    internal static class MockData
    {
        public static Dictionary<string, Person> CreateData()
        {
            var persons = new Dictionary<string, Person>();

            var person1 = new Person
            {
                FirstName = "Kevin",
                LastName = "Liu",
                MobilePhone = "916-555-1234",
                WorkPhone = "916-555-4567",
                Address = "Sequim WA"
            };
            persons.Add(person1.FullName, person1);

            var person2 = new Person
            {
                FirstName = "James",
                LastName = "Smith",
                MobilePhone = "916-555-7890",
                WorkPhone = "916-555-6543",
                Address = "Seattle WA"
            };
            persons.Add(person2.FullName, person2);

            return persons;
        }
    }
}
