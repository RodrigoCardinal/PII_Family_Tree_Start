using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class Person
    {
        // Declaro parametros name y age
        private string name;
        private int age;

        //Propiedades   publicas de solo lectura para acceder a los campos name y age
        public string Name
        {
            get 
            {
                return this.name; 
            }
        }

        public int Age
        {
            get
            { 
                return this.age; 
            }
        }

        //Constructor Person con nombre y edad
        public Person (string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }
}	
