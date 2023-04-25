using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Proyecto_02
{
    class Jugadorvs
    {
        public static int[] turnosporjugador = new int[2] { 0, 0 };
        public static string[] nombreactual = new string[2];
        public static string piezactual = "";
        public static string jugador1 = "♦";
        public static string jugador2 = "♣";
        public static int columna = 0;
        public static void colocarpieza()
        {
            Console.WriteLine("Ingrese en que columna desea colocar una ficha en la tabla");
            columna = int.Parse(Console.ReadLine());
            Tabla.tablacolocar();
        }
        public static string[,] piezas = new string[2, 5] { { " ♣ ", " ♠ " ," ♥ "," ☻ "," ◘ "},{" ♫ "," ☺ "," ♦ ","•","♪" } };

        public static void mostrarpiezas()
        {
            for(int i = 0; i < 2; i++)
            {
                for(int e = 0;e < 5; e++)
                {
                    Console.Write(piezas[i,e]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
        public static void colocarpieza1()
        {
            Console.WriteLine("Escoque una pieza para jugar");
            mostrarpiezas();
        }
        public static void jugador1o2()
        {
            Random r = new Random();

            if (piezactual != jugador1 || piezactual == "")
            {
                piezactual = jugador1;
                colocarpieza();
                turnosporjugador[0] += 1;
            }
            else if (nombreactual[1] != "COMPUTADORA")
            {
                piezactual = jugador2;
                colocarpieza();
                turnosporjugador[1] += 1;
            }
            else
            {
                piezactual = jugador2;
                columna = r.Next(0, 7);
                Thread.Sleep(1500);
                Tabla.tablacolocar();
            }
        }
        public static void nombrejugadores()
        {
            Console.Clear();
            if (Controles.subindice == 1)
            {
                Console.WriteLine("Ingrese el nombre del primer jugador (J1)");
                nombreactual[0] = Console.ReadLine();
                Console.WriteLine("Ingrese el nombre del segundo jugador (J2)");
                nombreactual[1] = Console.ReadLine();
            }
            else if (Controles.subindice == 2)
            {
                Console.WriteLine("Ingrese el nombre del primer jugador (J1)");
                nombreactual[0] = Console.ReadLine();
                nombreactual[1] = "COMPUTADORA";
            }

        }
        public static void nombrej1()
        {
            Console.WriteLine("Ingrese el nombre del primer jugador (J1)");
            nombreactual[0] = Console.ReadLine();
        }
        
    }
}
