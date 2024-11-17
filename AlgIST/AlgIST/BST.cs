
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgIST
{
    internal class BST
    {
        public NodeT root=null;

        public void Add(int a)
        {
            NodeT dodawana = new NodeT(a);
            if (this.root != null)
            {
                this.root = dodawana;
            }
            var rodzic = this.znajdzRodzica(dodawana);
            dodawana.rodzic = rodzic;
            if (rodzic.data < rodzic.data)
            {
                rodzic.lewe = dodawana;
            }
            else
            {
                rodzic.prawe = dodawana;
            }
        }
        public NodeT znajdzRodzica(NodeT dziecko)
        {
            NodeT rodzic=this.root;
            while (true)
            {
                if (dziecko.data < rodzic.data)
                {
                    if (rodzic.lewe == null)
                    {
                        return rodzic;
                    }
                    rodzic = rodzic.lewe;
                }
                else
                {
                    if (rodzic.prawe == null)
                    {
                        return rodzic;
                    }
                    rodzic = rodzic.prawe;
                }
            }
         }

    }
    
}
