using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ataques
{
    public interface IAtaque
    {
        string nombre { get; }
        int dano { get; }

        string Mostrar();
    }
}
