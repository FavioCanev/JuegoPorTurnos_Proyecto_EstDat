using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ataque;

namespace Criatura
{
    internal class Jugador
    {
        public string nombre;
        public int vida;
        public Ataque.Ataque[] Ataques = new Ataque.Ataque[4];

        public void MostrarAtaques()
        {
            for (int i = 0; i < Ataques.Length; i++)
            {
                Console.WriteLine((i + 1) + ". " + Ataques[i]);
            }
        }

        //creamos un objeto de la clase Jugador para cada tipo de jugador
        Jugador Guerrero = new Jugador();
        Jugador Mago = new Jugador();
        Jugador PorConfirmar = new Jugador();

        //llamada a la clase para poder usar sus métodos y atributos
        Ataque.ListaDobleAtaques listaAtaques = new ListaDobleAtaques();

        public void asignarAtributosJugador()
        {
            //Insertando primero los ataques a la lista
            listaAtaques.agregarAtaques();

            //Asignando ataques a cada clase de jugador
            Guerrero.nombre = "Guerrero";
            Guerrero.vida = 100;
            Guerrero.Ataques[0] = listaAtaques.ObtenerEnIndice(0);
            Guerrero.Ataques[1] = listaAtaques.ObtenerEnIndice(1);
            Guerrero.Ataques[2] = listaAtaques.ObtenerEnIndice(2);
            Guerrero.Ataques[3] = listaAtaques.ObtenerEnIndice(3);

            Mago.nombre = "Mago";
            Mago.vida = 70;
            Mago.Ataques[0] = listaAtaques.ObtenerEnIndice(4);
            Mago.Ataques[1] = listaAtaques.ObtenerEnIndice(5);
            Mago.Ataques[2] = listaAtaques.ObtenerEnIndice(6);
            Mago.Ataques[3] = listaAtaques.ObtenerEnIndice(7);

            PorConfirmar.nombre = "Por confirmar y balancear"; //aqui falta ponerle un nombre a la clase
            PorConfirmar.vida = 90;
            PorConfirmar.Ataques[0] = listaAtaques.ObtenerEnIndice(8);
            PorConfirmar.Ataques[1] = listaAtaques.ObtenerEnIndice(9);
            PorConfirmar.Ataques[2] = listaAtaques.ObtenerEnIndice(10);
            PorConfirmar.Ataques[3] = listaAtaques.ObtenerEnIndice(11);
        }
    }
}
