using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ataque
{
    public class Ataque
    {
        //creación de atributos de la clase ListaAtaques
        public string nombre;
        public int dano;

        //método para mostrar los ataques (con return porque ocupamos mostrarlo en interfaz)
        //sino lo hubieramos hecho con un override ToString, pero no lo queremos en consola
        public string Mostrar()
        {
            return nombre + " hizo " + dano + " de daño";
        }
    }
}
