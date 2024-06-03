using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void Family (string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}	
