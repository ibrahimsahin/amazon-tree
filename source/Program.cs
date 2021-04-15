using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public class Program
    {
        
       public  static void Main()
        {
          
           Amazon c = new Amazon();
           Amazon amazon=new Category("Amazon","dad","C");
           Tree root = new Tree(amazon);
           int i=0;
           string[] a = File.ReadAllLines("urunler.txt");
           for (i = 0; i < a.Length; i++)
           {
               string[] b = a[i].Split(',');
               if (b[0].Equals("null"))
                   b[0] = "Amazon";
               if (b[2].Equals("C"))
               {
                   c = new Category(b[1], b[0], b[2]);
               }
               if (b[2].Equals("P"))
               {
                   c = new Product(b[1], b[0], b[2], int.Parse(b[3]), int.Parse(b[4]));
               }
               root.ekle(c, root);
           }
        }
    }
}
