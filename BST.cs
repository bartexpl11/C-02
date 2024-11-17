using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw03
{
    internal class BST
    {
        public NodeT root;
        public NodeT Add(int liczba)
        {
            var dziecko = new NodeT(liczba);
            if (this.root == null)
            {
                this.root = dziecko;
            }
            else
            {
                var rodzic = this.ZnajdzRodzica(dziecko);
                dziecko.rodzic = rodzic;
                if(dziecko.data<rodzic.data)
                {
                    rodzic.lewe = dziecko;
                }
                else
                {
                    rodzic.prawe = dziecko;
                }
            }
            return dziecko;
        }

        public NodeT ZnajdzRodzica(NodeT dziecko)
        {
            var rodzic = this.root;
            while (true)
            {
                if (dziecko.data < rodzic.data)
                {
                    if (rodzic.lewe == null)
                    {
                        return rodzic;
                    }
                    else
                    {
                        rodzic = rodzic.lewe;
                    }
                }
                else
                {
                    if (rodzic.prawe == null)
                    {
                        return rodzic;
                    }
                    else
                    {
                        rodzic = rodzic.prawe;
                    }
                }
            }
        }

        public NodeT Remove()
        {
            
        }
    }
}
