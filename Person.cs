﻿namespace Assignment_4._1._1
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MobilePhone { get; set; }
        public string WorkPhone { get; set; }
        public string Address { get; set; }

        public string FullName => $"{FirstName} {LastName}";
    }
}
