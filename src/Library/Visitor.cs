using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public abstract class Visitor
    {
        public string Content
        {
            get
            {
                return this.ContentBuilder.ToString();
            }
        }
        protected StringBuilder ContentBuilder { get; } = new StringBuilder();






    }




}	
