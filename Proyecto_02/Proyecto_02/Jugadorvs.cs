using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Proyecto_02
{
    class Jugadorvs
    {
        public static int[] turnosporjugador = new int[3] { 0, 0,0 };
        public static string[] nombreactual = new string[2];
        public static string piezactual = "";
        public static string jugador1 = "";
        public static string jugador2 = "";
        public static int columna = 0;
        public static void colocarpieza()
        {

            columna = Controles.controltabla();
            Tabla.tablacolocar(columna);
            //Console.WriteLine("Ingrese en que columna desea colocar una ficha en la tabla");
            //columna = int.Parse(Console.ReadLine());
            //Tabla.tablacolocar();
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
            else if (nombreactual[1] != "CPU1")
            {
                piezactual = jugador2;
                colocarpieza();
                turnosporjugador[1] += 1;
            }
            else
            {
                piezactual = jugador2;
                Tabla.tablacolocar(columna = r.Next(0, 7));
                Thread.Sleep(1500);
                turnosporjugador[2] += 1;
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
                nombreactual[1] = "CPU1";
            }

        }
        public static void nombrej1()
        {
            Console.WriteLine("Ingrese el nombre del primer jugador (J1)");
            nombreactual[0] = Console.ReadLine();
        }
        
    }
}
