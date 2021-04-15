using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    public class Product:Amazon
    {
       public  int price;
       public int stock;
       public int saled;

        public Product(string name_,string parent_,string type_,int price_,int stock_) {
            name = name_;
            parent = parent_;
            type = type_;
            price = price_;
            stock = stock_;
            saled = 0;
        
        }

        public string getName( ) {
            return name;
        }
        public string getParent() {
            return parent;
        }
        public string getType()
        {
            return type;
        }
        public int getPrice(){
            return price;
        }
        public int getStock() {
            return stock;
        }
        public int getSaled() {
            return saled;
        }
       

    
    
    }
}
