using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Security.Policy;
using System.Windows.Forms;

namespace Proyecto_02
{
    class Controles
    {
        public static ConsoleKeyInfo tecla;
        public static int subindice = 0;

        public static int mododejuego()
        {
            int fila = 2, posicion = 10;
            string[] flecha = new string[3] { visualizacion.flecha(), "  ", "  "};
            int subindice = 0;
            Console.SetCursorPosition(fila, posicion);
            Console.Write(flecha[subindice]);
            do
            {
                tecla = Console.ReadKey(true);
                if (tecla.Key == ConsoleKey.UpArrow && 10 != posicion || tecla.Key == ConsoleKey.W && 10 != posicion)
                {
                    flecha[subindice] = flecha[subindice].Replace(visualizacion.flecha(), "  ");
                    Console.SetCursorPosition(fila, posicion);
                    Console.Write(flecha[subindice]);
                    posicion -= 4;
                    subindice -= 1;
                    Console.SetCursorPosition(fila, posicion);
                    flecha[subindice] = flecha[subindice].Replace("  ", visualizacion.flecha());
                    Console.Write(flecha[subindice]);
                }
                else if (tecla.Key == ConsoleKey.DownArrow && 18 != posicion || tecla.Key == ConsoleKey.S && 18 != posicion)
                {
                    flecha[subindice] = flecha[subindice].Replace(visualizacion.flecha(), "  ");
                    Console.SetCursorPosition(fila, posicion);
                    Console.Write(flecha[subindice]);
                    posicion += 4;
                    subindice += 1;
                    Console.SetCursorPosition(fila, posicion);
                    flecha[subindice] = flecha[subindice].Replace("  ", visualizacion.flecha());
                    Console.Write(flecha[subindice]);
                }
            }
            while (tecla.Key != ConsoleKey.Enter);
            return subindice += 1;
        }
        public static int controlesmenu()
        {
            int fila = 2, posicion = 10;
            string[] flecha = new string[4] { visualizacion.flecha(), "  ", "  ", "  " };
            int subindice = 0;
            Console.SetCursorPosition(fila, posicion);
            Console.Write(flecha[subindice]);
            do
            {
                tecla = Console.ReadKey(true);
                if (tecla.Key == ConsoleKey.UpArrow && 10 != posicion || tecla.Key == ConsoleKey.W && 10 != posicion)
                {
                    flecha[subindice] = flecha[subindice].Replace(visualizacion.flecha(),"  ");
                    Console.SetCursorPosition(fila, posicion);
                    Console.Write(flecha[subindice]);
                    posicion -= 4;
                    subindice -= 1;
                    Console.SetCursorPosition(fila, posicion);
                    flecha[subindice] = flecha[subindice].Replace("  ", visualizacion.flecha());
                    Console.Write(flecha[subindice]);
                }
                else if (tecla.Key == ConsoleKey.DownArrow && 22 != posicion || tecla.Key == ConsoleKey.S && 22 != posicion)
                {
                    flecha[subindice] = flecha[subindice].Replace(visualizacion.flecha(), "  ");
                    Console.SetCursorPosition(fila, posicion);
                    Console.Write(flecha[subindice]);
                    posicion += 4;
                    subindice += 1;
                    Console.SetCursorPosition(fila, posicion);
                    flecha[subindice] = flecha[subindice].Replace("  ", visualizacion.flecha());
                    Console.Write(flecha[subindice]);
                }
            }
            while (tecla.Key != ConsoleKey.Enter);
            return subindice += 1;
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
                tecla = Console.ReadKey(true);
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
            Controles.piezas[fila, columna] = Controles.piezas[fila, columna].Replace(flechaiz, "").Replace(flechade, "");
            return Controles.piezas[fila, columna];

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
        public static string[,] letrastabla = new string[4, 9] { { "[1]", "2", "3", "4", "5", "6", "7", "8", "9" }, { "A", "B", "C", "D", "E", "F", "G", "H", "◄" }, { "I", "J", "K", "L", "M", "N", "O", "P", "Q" }, { "R", "S", "T", "U", "V", "W", "X", "Y", "►" } };
        public static string controlesnombres()
        {
            letrastabla = new string[4, 9] { { "[1]", "2", "3", "4", "5", "6", "7", "8", "9" }, { "A", "B", "C", "D", "E", "F", "G", "H", "I" }, { "J", "K", "L", "M", "N", "O", "P", "Q", "R" }, { "S", "T", "U", "V", "W", "X", "Y", "Z", "►" } };
            columna = 0; fila = 0; visualizacion.letras = true;
            string letranombre = "";
            string flechaiz = "["; string flechade = "]";
            do
            {
                visualizacion.menunombres();
                tecla = Console.ReadKey(true);
                if (tecla.Key == ConsoleKey.UpArrow && 0 != fila || tecla.Key == ConsoleKey.W && 0 != fila)
                {
                    letrastabla[fila, columna] = letrastabla[fila, columna].Replace(flechaiz, "").Replace(flechade, "");
                    fila -= 1;
                    letrastabla[fila, columna] = letrastabla[fila, columna].Insert(0, flechaiz).Insert(letrastabla[fila, columna].Length + 1, flechade);

                }
                else if (tecla.Key == ConsoleKey.DownArrow && 3 != fila || tecla.Key == ConsoleKey.S && 3 != fila)
                {
                    letrastabla[fila, columna] = letrastabla[fila, columna].Replace(flechaiz, "").Replace(flechade, "");
                    fila += 1;
                    letrastabla[fila, columna] = letrastabla[fila, columna].Insert(0, flechaiz).Insert(letrastabla[fila, columna].Length + 1, flechade);
                }
                else if (tecla.Key == ConsoleKey.RightArrow && letrastabla.GetLength(1) - 1 != columna || tecla.Key == ConsoleKey.D && letrastabla.GetLength(1) - 1 != columna)
                {
                    letrastabla[fila, columna] = letrastabla[fila, columna].Replace(flechaiz, "").Replace(flechade, "");
                    columna += 1;
                    letrastabla[fila, columna] = letrastabla[fila, columna].Insert(0, flechaiz).Insert(letrastabla[fila, columna].Length + 1, flechade);
                }
                else if (tecla.Key == ConsoleKey.LeftArrow && 0 != columna || tecla.Key == ConsoleKey.A && 0 != columna)
                {
                    letrastabla[fila, columna] = letrastabla[fila, columna].Replace(flechaiz, "").Replace(flechade, "");
                    columna -= 1;
                    letrastabla[fila, columna] = letrastabla[fila, columna].Insert(0, flechaiz).Insert(letrastabla[fila, columna].Length + 1, flechade);
                }
                else if (tecla.Key == ConsoleKey.Backspace && Jugadorvs.nombreactual[0].Length > 0)
                {
                    letranombre = Jugadorvs.nombreactual[0] = Jugadorvs.nombreactual[0].Substring(0, Jugadorvs.nombreactual[0].Length - 1);
                    return letranombre;
                }
                else if(tecla.Key == ConsoleKey.Enter && letrastabla[fila, columna].Contains("►"))
                {
                    visualizacion.letras = false;
                    break;
                }
            }
            while (tecla.Key != ConsoleKey.Enter || Jugadorvs.nombreactual[0] == letrastabla[fila, columna].Replace(flechaiz, "").Replace(flechade, ""));
            if (Jugadorvs.nombreactual[0].Length < 4)
            {
                letranombre = Jugadorvs.nombreactual[0] = Controles.controlesnombres();
            }
            else if (Jugadorvs.nombreactual[0].Length == 4)
            {
                letranombre = Jugadorvs.nombreactual[0] += letrastabla[fila, columna] = letrastabla[fila, columna].Replace(flechaiz, "").Replace(flechade, "");
            }
            return letranombre;
        }

    }
}
