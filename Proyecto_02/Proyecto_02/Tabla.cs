using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Proyecto_02
{
    class Tabla
    {
        public static string[,] tabla = new string[6, 7];


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
            Console.Clear();
            for(int i = 0; i < 7; i++)
            {
                Console.Write(" "+Controles.tablaflecha[i]+" ");
            }
            Console.WriteLine("");
            for (int i = 0; i < tabla.GetLength(0); i++)
            {
                for (int j = 0; j < tabla.GetLength(1); j++)
                {
                    Console.Write(tabla[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("══════════════════════");
            Console.WriteLine($" 0  1  2  3  4  5  6");
            visualizacion.posicionactual();
            visualizacion.mostraractual();
        }

        public static bool tablacolocar(int columna)
        {
            if ((tabla[0, columna].Contains(Jugadorvs.jugador1) || tabla[0, columna].Contains(Jugadorvs.jugador2)) && (Jugadorvs.piezactual != Jugadorvs.jugador1 && Jugadorvs.nombreactual[2] == "CPU1"))
            {
                return true;
            }
            else if (tabla[0, columna].Contains(Jugadorvs.jugador1) || tabla[0, columna].Contains(Jugadorvs.jugador2))
            {
                Console.WriteLine("Ya se lleno la columan pruebe con otro");
                Thread.Sleep(1000);
                return true;
            }
            else
            {
                for (int i = 5; i >= 0; i--)
                {
                    if (!(tabla[i, columna].Contains(Jugadorvs.jugador1)) && !(tabla[i, columna].Contains(Jugadorvs.jugador2)))
                    {
                        tabla[i, columna] = tabla[i, columna].Replace(" ", Jugadorvs.piezactual);
                        return false;
                    }
                }
                return true;
            }
        }
    }
}
