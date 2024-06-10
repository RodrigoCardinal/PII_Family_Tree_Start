using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class Node 
    {
        private Person person;

        private List<Node> children = new List<Node>();

        public Node(string name, int age)
        {
            person = new Person(name, age);
        }


        public string Name
        {
            get
            {
                return this.person.Name;
            }
        }

        public int Age 
        {
            get
            {
                return this.person.Age;
            }
        }

       public Person Person
        {
            get
            {
                return this.person;
            }
        } 

        public ReadOnlyCollection<Node> Children 
        {
            get
            {
                return this.children.AsReadOnly();
            }
        }

        public void AddChildren(Node n)
        {
            this.children.Add(n);
        }

        public void Accept(Visitor visitor)
        {
            visitor.Visit(this);
        }
    }
}