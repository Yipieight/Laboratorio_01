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

        public static string[,] piezas = new string[2, 4] { { "[♣]","♠","♥","♦"}, {"X","O","@","#"} };
        public static void controlespieza()
        {
            string flechaiz = "[";
            string flechade = "]";
            int columna = 0;
            int fila = 0;
            do
            {
                Jugadorvs.mostrarpiezas();
                tecla = Console.ReadKey(true);
                if (tecla.Key == ConsoleKey.UpArrow && 0 != fila)
                {
                    piezas[fila,columna] = piezas[fila, columna].Replace(flechaiz,"").Replace(flechade,"");
                    fila -= 1;
                    piezas[fila, columna] = piezas[fila, columna].Insert(0, flechaiz).Insert(piezas[fila,columna].Length+1,flechade);

                }
                else if (tecla.Key == ConsoleKey.DownArrow && 1 != fila)
                {
                    piezas[fila, columna] = piezas[fila, columna].Replace(flechaiz, "").Replace(flechade, "");
                    fila += 1;
                    piezas[fila, columna] = piezas[fila, columna].Insert(0, flechaiz).Insert(piezas[fila, columna].Length+1, flechade);
                }
                else if(tecla.Key == ConsoleKey.RightArrow && 3 != columna)
                {
                    piezas[fila, columna] = piezas[fila, columna].Replace(flechaiz, "").Replace(flechade, "");
                    columna += 1;
                    piezas[fila, columna] = piezas[fila, columna].Insert(0, flechaiz).Insert(piezas[fila, columna].Length + 1, flechade);
                }
                else if(tecla.Key == ConsoleKey.LeftArrow && 0 != columna)
                {
                    piezas[fila, columna] = piezas[fila, columna].Replace(flechaiz, "").Replace(flechade, "");
                    columna -= 1;
                    piezas[fila, columna] = piezas[fila, columna].Insert(0, flechaiz).Insert(piezas[fila, columna].Length + 1, flechade);
                }
            }
            while (tecla.Key != ConsoleKey.Enter);
        }
    }
}
