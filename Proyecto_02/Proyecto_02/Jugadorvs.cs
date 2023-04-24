using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_02
{
    class Jugadorvs
    {
        public static bool jugadoractual = true;
        public static string[] nombreactual = new string[2];
        public static string piezactual = "";
        public static string jugador1 = "♦";
        public static string jugador2 = "♣";
        public static int columna = 0;
        public static void colocarpieza()
        {
            visualizacion.tiempoinicial();
            Console.WriteLine("Ingrese en que columna desea colocar una ficha en la tabla");
            columna = int.Parse(Console.ReadLine());
            Tabla.tablacolocar();
        }
        public static void jugador1o2()
        {
            if(piezactual != jugador1 || piezactual == "")
            {
                piezactual = jugador1;
                Jugadorvs.colocarpieza();
            }
            else
            {
                piezactual = jugador2;
                Jugadorvs.colocarpieza();
            }
        }
        public static void nombrejugadores()
        {
            if(Conecta4.opciondejuego == "1")
            {
                Console.WriteLine("Ingrese el nombre del primer jugador (J1)");
                nombreactual[0] = Console.ReadLine();
                Console.WriteLine("Ingrese el nombre del segundo jugador (J2)");
                nombreactual[1] = Console.ReadLine();
            }
            else if (Conecta4.opciondejuego == "2")
            {
                Console.WriteLine("Ingrese el nombre del primer jugador (J1)");
                nombreactual[0] = Console.ReadLine();
            }
            
        }
        
    }
}
