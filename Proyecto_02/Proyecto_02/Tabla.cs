using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public static void tablacolocar()
        {
            if (tabla[0, Jugadorvs.columna].Contains(Jugadorvs.jugador1) || tabla[0, Jugadorvs.columna].Contains(Jugadorvs.jugador2))
            {
                Console.WriteLine("Ya se lleno la columan pruebe con otro");
                Console.ReadKey();
            }
            else
            {
                for (int i = 5; i >= 0; i--)
                {
                    if (!(tabla[i, Jugadorvs.columna].Contains(Jugadorvs.jugador1)) && !(tabla[i, Jugadorvs.columna].Contains(Jugadorvs.jugador2)))
                    {
                        tabla[i, Jugadorvs.columna] = tabla[i, Jugadorvs.columna].Replace(" ", Jugadorvs.piezactual);
                        break;
                    }

                }
            }
        }
    }
}
