
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class LongestNameVisitor : Visitor
    {
        private Person person;

        public Person Person
        {
            get
            {
                return person;
            }
        }

        public override void Visit(Person person)
        {
            if (this.person is null || this.person.Name.Length < person.Name.Length)
            {
                this.person = person;
            }
        }

        public override void Visit(Node node)
        {
            node.Person.Accept(this);
            foreach (Node child in node.Children)
            {
                child.Accept(this);
            }
        }
    }
}