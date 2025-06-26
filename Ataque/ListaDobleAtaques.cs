using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ataque
{
    public class ListaDobleAtaques
    {
        public NodoAtaque inicio;
        public NodoAtaque fin;
        
        //cantidad de ataques que tiene la lista
        public int cantidad;

        public void agregar(Ataque ataque)
        {
            NodoAtaque nuevo = new NodoAtaque();
            nuevo.ataque = ataque;
            if (inicio == null)
            {
                inicio = nuevo;
                fin = nuevo;
            }
            else
            {
                fin.siguiente = nuevo;
                nuevo.anterior = fin;
                fin = nuevo;
            }
            cantidad++;
        }

        //para que la lista funcione como un arrayList
        //solo ingresando el índice del ataque que queremos buscar, lo busca en la lista con este método y lo obtiene
        //lo queremos para poder asignar los ataques aleatoriamente
        public Ataque ObtenerEnIndice(int indice)
        {
            if (indice < 0 || indice >= cantidad)
            {
                throw new ArgumentOutOfRangeException("Índice fuera de rango");
            }
            NodoAtaque actual = inicio;
            for (int i = 0; i < indice; i++)
            {
                actual = actual.siguiente;
            }
            return actual.ataque;
        }

        public void mostrarTodo()
        {
            NodoAtaque actual = inicio;
            while (actual != null)
            {
                Console.WriteLine(actual.ataque.Mostrar());
                actual = actual.siguiente;
            }
        }

        public void agregarAtaques()
        {
            agregar(new Ataque { nombre = "Espada del Caído", dano = 22 });
            agregar(new Ataque { nombre = "Lanza del Abismo", dano = 18 });
            agregar(new Ataque { nombre = "Fuego Caótico", dano = 25 });
            agregar(new Ataque { nombre = "Garra Maldita", dano = 20 });
            agregar(new Ataque { nombre = "Impacto de Smough", dano = 30 });
            agregar(new Ataque { nombre = "Rayo de Ornstein", dano = 24 });
            agregar(new Ataque { nombre = "Llama de Piromántico", dano = 26 });
            agregar(new Ataque { nombre = "Aguijón Espectral", dano = 19 });
            agregar(new Ataque { nombre = "Espadón de Artorias", dano = 28 });
            agregar(new Ataque { nombre = "Explosión Profanada", dano = 23 });
            agregar(new Ataque { nombre = "Zarpazo de Manus", dano = 21 });
            agregar(new Ataque { nombre = "Daga de Carthus", dano = 17 });
            agregar(new Ataque { nombre = "Martillo de Havel", dano = 32 });
            agregar(new Ataque { nombre = "Espina de Priscilla", dano = 20 });
            agregar(new Ataque { nombre = "Llamarada del Vacío", dano = 27 });
            agregar(new Ataque { nombre = "Espina de Aldrich", dano = 25 });
            agregar(new Ataque { nombre = "Golpe del Gigante", dano = 29 });
            agregar(new Ataque { nombre = "Filo de Doran", dano = 18 });
            agregar(new Ataque { nombre = "Látigo de lava", dano = 26 });
            agregar(new Ataque { nombre = "Aliento del Dragón", dano = 31 });
        }
    }
}
