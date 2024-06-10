using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class SumAgesContent
    {
        private Node node;

        public SumAgesContent (Node node)
        {
            this.node = node;
        }
        public int GetAge()
        {
            SumAgesVisitor visitor = new SumAgesVisitor();
            node.Accept(visitor);
            return visitor.SumAges; 
        }

    }

}