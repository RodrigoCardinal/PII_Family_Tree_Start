using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class LongestNameContent
    {
        private Node node;

        public LongestNameContent (Node node)
        {
            this.node = node;
        }
            
        public Person GetPerson()
        {
            LongestNameVisitor visitor = new LongestNameVisitor();
            node.Accept(visitor);
            return visitor.Person;
        }

    }
}