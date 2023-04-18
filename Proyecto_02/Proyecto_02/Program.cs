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
        ConsoleColor jugador1 = ConsoleColor.Blue;
        ConsoleColor jugador2bot = ConsoleColor.Red;
        public static string[,] tabla = new string[6, 7];
        static void Main(string[] args)
        {
            tablacrear();
            Console.WriteLine("¿De que forma quiere jugar conecta 4? \n");
            Console.WriteLine("1. Jugador vs Jugador");
            Console.WriteLine(("2. Jugador vs Computadora"));
            opciondejuego = Console.ReadLine();
            if (opciondejuego == "1")
            {
                tablamostrar();
                Console.ReadKey();
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
        public static void tablacrear()
        {
            for (int i = 0; i < tabla.GetLength(0); i++)
            {
                for (int j = 0; j < tabla.GetLength(1); j++)
                {
                    tabla[i, j] = "[ ]";
                }
            }
        }
        public static void tablamostrar()
        {
            for (int i = 0; i < tabla.GetLength(0); i++)
            {
                for (int j = 0; j < tabla.GetLength(1); j++)
                {
                    Console.WriteLine(tabla[i,j]);
                }
            }
        }
    }

    
}
