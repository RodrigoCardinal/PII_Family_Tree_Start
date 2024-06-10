using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class OldestChildContent
    {
        private Node node;
        public OldestChildContent(Node node)
        {
            this.node = node;
        }

        public Person GetPerson()
        {
            OldestChildVisitor visitor = new OldestChildVisitor();
            foreach (Node child in node.Children)
            {
                child.Accept(visitor);
            }
            return visitor.Person;
        }


    }


}