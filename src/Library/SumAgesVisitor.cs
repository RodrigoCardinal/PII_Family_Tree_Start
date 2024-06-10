using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class SumAgesVisitor : Visitor
    {
        private int sumAges = 0;

        public int SumAges
        {
            get  
            { 
                return sumAges; 
            }
        }

        public override void Visit (Person person)
        {
            sumAges += person.Age;
        }

        public override void Visit(Node node)
        {
            node.Person.Accept (this);
            foreach (Node child in node.Children)
            {
                child.Accept(this);
            }
        }
    }
}