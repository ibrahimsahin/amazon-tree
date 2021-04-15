using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    public class Category:Amazon
    {


        public Category(string name_,string parent_,string type_) {
            name = name_;
            parent = parent_;
            type = type_;
        }
        public string getName()
        {
            return name;
        }
        public string getParent()
        {
            return parent;
        }
        public string getType()
        {
            return type;
        }
    }
}
