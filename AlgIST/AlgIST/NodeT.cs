using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgIST
{
    internal class NodeT
    {
       public NodeT rodzic,lewe,prawe;
       public int data;

        public NodeT(int liczba)
        {
            this.data = liczba;
        }

    }
}
