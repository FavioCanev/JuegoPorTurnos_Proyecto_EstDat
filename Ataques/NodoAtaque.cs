using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ataques
{
    public class NodoAtaque
    {
        public IAtaque ataque;
        public NodoAtaque siguiente;
        public NodoAtaque anterior;
    }
}
