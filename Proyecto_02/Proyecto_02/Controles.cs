using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Proyecto_02
{
    class Controles
    {
        public static ConsoleKeyInfo tecla;
        public static int subindice = 0;


        public static void controlesmenu()
        {
            int fila = 27;
            string[] flecha = new string[5] { "◄", " ", " ", " ", " " };
            subindice = 0;
            int posicion = 2;
            Console.SetCursorPosition(fila, posicion);
            Console.Write(flecha[subindice]);
            do
            {
                tecla = Console.ReadKey(true);
                if (tecla.Key == ConsoleKey.UpArrow && 2 != posicion)
                {
                    flecha[subindice] = flecha[subindice].Replace("◄", " ");
                    Console.SetCursorPosition(fila, posicion);
                    Console.Write(flecha[subindice]);
                    posicion -= 1;
                    subindice -= 1;
                    Console.SetCursorPosition(fila, posicion);
                    flecha[subindice] = flecha[subindice].Replace(" ", "◄");
                    Console.Write(flecha[subindice]);
                }
                else if (tecla.Key == ConsoleKey.DownArrow && 6 != posicion)
                {
                    flecha[subindice] = flecha[subindice].Replace("◄", " ");
                    Console.SetCursorPosition(fila, posicion);
                    Console.Write(flecha[subindice]);
                    posicion += 1;
                    subindice += 1;
                    Console.SetCursorPosition(fila, posicion);
                    flecha[subindice] = flecha[subindice].Replace(" ", "◄");
                    Console.Write(flecha[subindice]);
                }
            }
            while (tecla.Key != ConsoleKey.Enter);
            subindice += 1;
        }

        public static string[,] piezas = new string[2, 4] { { "♣","♠","♥","♦"}, {"X","O","@","#"} };
        public static void controlespieza()
        {
            string flechaiz = "[";
            string flechade = "]";
            int columna = 0;
            int fila = 0;
            int posicionx = 0;
            int posiciony = 2;
            Console.SetCursorPosition(fila, posicion);
            do
            {
                Jugadorvs.mostrarpiezas();
                tecla = Console.ReadKey(true);
                if (tecla.Key == ConsoleKey.UpArrow && 2 != posicion)
                {
                    piezas[fila, subindice] = flechaiz.Insert(0, piezas[fila, subindice]);
                    piezas[fila, subindice] = flechade.Insert(piezas[fila,subindice].Length, piezas[fila, subindice]);
                    
                }
                else if (tecla.Key == ConsoleKey.DownArrow && 6 != posicion)
                {
                    Console.SetCursorPosition(fila, posicion);
                    posicion += 1;
                    subindice += 1;
                    Console.SetCursorPosition(fila, posicion);
                }
            }
            while (tecla.Key != ConsoleKey.Enter);
            subindice += 1;
        }
    }
}
