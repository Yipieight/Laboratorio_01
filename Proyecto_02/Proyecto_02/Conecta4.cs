using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_02
{
    internal class Conecta4
    {
        public static string denuevo = "";
        public static string opciondejuego;
        public static bool ganador = false;
        static void Main(string[] args)
        {
            visualizacion.bienvenida();
            do
            {
                Console.Clear();
                Console.WriteLine("¿De que forma quiere jugar conecta 4? \n");
                Console.WriteLine("1. Jugador vs Jugador");
                Console.WriteLine(("2. Jugador vs Computadora"));
                Console.WriteLine("3. Salir");
                opciondejuego = Console.ReadLine();
                if (opciondejuego == "1")
                {
                    Tabla.tablacrear();
                    ganador = false;
                    Jugadorvs.nombrejugadores();
                    Tabla.tablamostrar();
                    while (ganador != true)
                    {
                        Jugadorvs.jugador1o2();
                        Ganoperdio.comprobar();
                    }
                }
                else if (opciondejuego == "2")
                {
                    ganador = false;
                    Jugadorvs.nombrejugadores();
                    Tabla.tablamostrar();
                    while (ganador != true)
                    {
                        Jugadorvs.jugador1o2();
                        Ganoperdio.comprobar();
                    }
                }
            }
            while(opciondejuego != "3");
        }

        public static void jugardenuevo()
        {
            Console.Clear();
            Console.WriteLine("¿Desea Jugar de nuevo? (Si/No)");
            denuevo = Console.ReadLine().ToLower();
        }


    }

    
}
