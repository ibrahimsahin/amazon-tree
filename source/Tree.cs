using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    public class Tree
    {
        Amazon a;
        ArrayList ar ;
        

        public Tree(Amazon a_) {
            if (a_.type.Equals("C"))
            {
                ar = new ArrayList();
            }
            else
                ar = null;
            a = a_;
           
        }

        public void ekle(Amazon c,Tree root) {
            int i;
            if (c.parent.Equals(root.a.name))
                root.ar.Add(new Tree(c));
            else {
                for (i = 0; !root.a.type.Equals("P") && i < root.cevir(ar).Length; i++)
                {
                    ekle(c,root.cevir(ar)[i]);
                }
            
            }


            
    
        }

        public Tree[] cevir(ArrayList ar){
            return (Tree[]) this.ar.ToArray(typeof(Tree));
        }

    }
}
