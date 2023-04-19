using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_02
{
    internal class Program
    {
        public static string opciondejuego;
        public static bool ganador = false;
        static void Main(string[] args)
        {
            Tabla.tablacrear();
            Console.WriteLine("¿De que forma quiere jugar conecta 4? \n");
            Console.WriteLine("1. Jugador vs Jugador");
            Console.WriteLine(("2. Jugador vs Computadora"));
            opciondejuego = Console.ReadLine();
            if (opciondejuego == "1")
            {
                while(ganador != true)
                {
                    Tabla.tablamostrar();
                    Jugadorvs.colocarpieza();
                }
                
            }
            else
            {

            }
        }

        public static void jugadorvs()
        {
            
        }
        public static void jugavsbot()
        {
            
        }
    }

    
}
