using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Security.Policy;

namespace Proyecto_02
{
    class Controles
    {
        public static ConsoleKeyInfo tecla;
        public static int subindice = 0;


        public static void controlesmenu()
        {
            int fila = 27, posicion = 2;
            string[] flecha = new string[5] { "◄", " ", " ", " ", " " };
            subindice = 0;
            Console.SetCursorPosition(fila, posicion);
            Console.Write(flecha[subindice]);
            do
            {
                tecla = Console.ReadKey(true);
                if (tecla.Key == ConsoleKey.UpArrow && 2 != posicion || tecla.Key == ConsoleKey.W && 2 != posicion)
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
                else if (tecla.Key == ConsoleKey.DownArrow && 6 != posicion || tecla.Key == ConsoleKey.S && 6 != posicion)
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
        //----------------------------------------------------------------------------------------------------------------------------------------------------
        //menú de colocar pieza
        public static string[,] piezas = new string[2, 5] { { "♣", "♠", "♥", "♦","☺"}, { "X", "O", "@", "#" , "☻" } };
        public static int columna = 0;
        public static int fila = 0;
        public static string controlespieza1()
        {

            piezas[0, 0] = "[♣]"; columna = 0; fila = 0;
            string flechaiz = "["; string flechade = "]";

            do
            {
                visualizacion.mostrarpiezas();
                tecla = Console.ReadKey(false);
                if (tecla.Key == ConsoleKey.UpArrow && 0 != fila || tecla.Key == ConsoleKey.W && 0 != fila)
                {
                    Controles.piezas[fila, columna] = Controles.piezas[fila, columna].Replace(flechaiz, "").Replace(flechade, "");
                    fila -= 1;
                    Controles.piezas[fila, columna] = Controles.piezas[fila, columna].Insert(0, flechaiz).Insert(Controles.piezas[fila, columna].Length + 1, flechade);

                }
                else if (tecla.Key == ConsoleKey.DownArrow && 1 != fila || tecla.Key == ConsoleKey.S && 1 != fila)
                {
                    Controles.piezas[fila, columna] = Controles.piezas[fila, columna].Replace(flechaiz, "").Replace(flechade, "");
                    fila += 1;
                    Controles.piezas[fila, columna] = Controles.piezas[fila, columna].Insert(0, flechaiz).Insert(Controles.piezas[fila, columna].Length + 1, flechade);
                }
                else if (tecla.Key == ConsoleKey.RightArrow && piezas.GetLength(1) - 1 != columna || tecla.Key == ConsoleKey.D && piezas.GetLength(1) - 1 != columna)
                {
                    Controles.piezas[fila, columna] = Controles.piezas[fila, columna].Replace(flechaiz, "").Replace(flechade, "");
                    columna += 1;
                    Controles.piezas[fila, columna] = Controles.piezas[fila, columna].Insert(0, flechaiz).Insert(Controles.piezas[fila, columna].Length + 1, flechade);
                }
                else if (tecla.Key == ConsoleKey.LeftArrow && 0 != columna || tecla.Key == ConsoleKey.A && 0 != columna)
                {
                    Controles.piezas[fila, columna] = Controles.piezas[fila, columna].Replace(flechaiz, "").Replace(flechade, "");
                    columna -= 1;
                    Controles.piezas[fila, columna] = Controles.piezas[fila, columna].Insert(0, flechaiz).Insert(Controles.piezas[fila, columna].Length + 1, flechade);
                }
                if (Jugadorvs.jugador1 == Controles.piezas[fila, columna].Replace(flechaiz, "").Replace(flechade, "") && tecla.Key == ConsoleKey.Enter)
                {
                    visualizacion.incorrecto();
                    Thread.Sleep(1000);
                }
            }
            while (tecla.Key != ConsoleKey.Enter || Jugadorvs.jugador1 == Controles.piezas[fila, columna].Replace(flechaiz, "").Replace(flechade, ""));
            return Controles.piezas[fila, columna] = Controles.piezas[fila, columna].Replace(flechaiz, "").Replace(flechade, "");

        }
        public static string[,] piezas1 = new string[2, 5] { { "♣", "♠", "♥", "♦", "☺" }, { "X", "O", "@", "#", "☻" } };
        //public static string[,] piezas1 = new string[2, 4] { { "♣", "♠", "♥", "♦" }, { "X", "O", "@", "#" } };
        public static string controlespieza2()
        {
            piezas1[0, 0] = "[♣]"; columna = 0; fila = 0;
            string flechaiz = "["; string flechade = "]";
            do
            {
                visualizacion.mostrarpiezas();
                tecla = Console.ReadKey(true);
                if (tecla.Key == ConsoleKey.UpArrow && 0 != fila || tecla.Key == ConsoleKey.W && 0 != fila)
                {
                    piezas1[fila, columna] = piezas1[fila, columna].Replace(flechaiz, "").Replace(flechade, "");
                    fila -= 1;
                    piezas1[fila, columna] = piezas1[fila, columna].Insert(0, flechaiz).Insert(piezas1[fila, columna].Length + 1, flechade);

                }
                else if (tecla.Key == ConsoleKey.DownArrow && 1 != fila || tecla.Key == ConsoleKey.S && 1 != fila)
                {
                    piezas1[fila, columna] = piezas1[fila, columna].Replace(flechaiz, "").Replace(flechade, "");
                    fila += 1;
                    piezas1[fila, columna] = piezas1[fila, columna].Insert(0, flechaiz).Insert(piezas1[fila, columna].Length + 1, flechade);
                }
                else if (tecla.Key == ConsoleKey.RightArrow && piezas1.GetLength(1) - 1 != columna || tecla.Key == ConsoleKey.D && piezas1.GetLength(1) - 1 != columna)
                {
                    piezas1[fila, columna] = piezas1[fila, columna].Replace(flechaiz, "").Replace(flechade, "");
                    columna += 1;
                    piezas1[fila, columna] = piezas1[fila, columna].Insert(0, flechaiz).Insert(piezas1[fila, columna].Length + 1, flechade);
                }
                else if (tecla.Key == ConsoleKey.LeftArrow && 0 != columna || tecla.Key == ConsoleKey.A && 0 != columna)
                {
                    piezas1[fila, columna] = piezas1[fila, columna].Replace(flechaiz, "").Replace(flechade, "");
                    columna -= 1;
                    piezas1[fila, columna] = piezas1[fila, columna].Insert(0, flechaiz).Insert(piezas1[fila, columna].Length + 1, flechade);
                }
                else if(tecla.Key == ConsoleKey.Backspace)
                {
                    piezas1 = new string[2, 5] { { "♣", "♠", "♥", "♦", "☺" }, { "X", "O", "@", "#", "☻" } };
                    visualizacion.mostrarpiezas();
                    Jugadorvs.jugador1 = "";
                    return "";
                }
                if (Jugadorvs.jugador1 == piezas1[fila, columna].Replace(flechaiz, "").Replace(flechade, "") && tecla.Key == ConsoleKey.Enter)
                {
                    visualizacion.incorrecto();
                    Thread.Sleep(1000);
                }
            }
            while (tecla.Key != ConsoleKey.Enter || Jugadorvs.jugador1 == piezas[fila, columna].Replace(flechaiz, "").Replace(flechade, ""));
            return piezas1[fila, columna] = piezas[fila, columna].Replace(flechaiz, "").Replace(flechade, "");
        }

        public static string[] tablaflecha = new string[7] { "▼", " ", " ", " ", " ", " ", " " };

        public static int controltabla()
        {
            tablaflecha = new string[7] { "▼", " ", " ", " ", " ", " ", " " };
            Console.Clear();
            string flecha = "▼";
            columna = 0;
            do
            {
                Tabla.tablamostrar();
                tecla = Console.ReadKey(true);
                if (tecla.Key == ConsoleKey.RightArrow && 6 != columna || tecla.Key == ConsoleKey.D && 6 != columna)
                {
                    tablaflecha[columna] = tablaflecha[columna].Replace(flecha," ");
                    columna += 1;
                    tablaflecha[columna] = tablaflecha[columna].Replace(" ",flecha);
                }
                else if (tecla.Key == ConsoleKey.LeftArrow && 0 != columna || tecla.Key == ConsoleKey.A && 0 != columna)
                {
                    tablaflecha[columna] = tablaflecha[columna].Replace(flecha, " ");
                    columna -= 1;
                    tablaflecha[columna] =  tablaflecha[columna].Replace(" ", flecha);
                }
            }
            while (tecla.Key != ConsoleKey.Enter || Jugadorvs.jugador1 == tablaflecha[columna].Replace(flecha, " "));
            return columna;

        }

    }
}
