using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class Node
    {
        private Person person;
        private int number;

        private List<Node> childrenm = new List<Node>();

        public int Number {
            get
            {
                return this.person;
            }
        }

        public ReadOnlyCollection<Node> Children {
            get
            {
                return this.children.AsReadOnly();
            }
        }

        public Node(int number)
        {
            this.number = number;
        }

        public void AddChildren(Node n)
        {
            this.children.Add(n);
        }
    }
}
