using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_02
{
    class visualizacion
    {
        public static int[] posicionac = new int[2];
        public static void posicionactual()
        {
            posicionac[0] = Console.CursorLeft;
            posicionac[1] = Console.CursorTop;
        }
        public static void mostarturnoj1()
        {
            Console.SetCursorPosition(24, 2);
            Console.Write("TURNO DE:\n");
            Console.SetCursorPosition(25, 3);
            Console.Write("  █ ▄█");
            Console.SetCursorPosition(25, 4);
            Console.Write("█▄█  █");
            Console.SetCursorPosition(posicionac[0], posicionac[1]);
        }
        public static void mostarturnoj2()
        {
            Console.SetCursorPosition(24, 2);
            Console.Write("TURNO DE:\n");
            Console.SetCursorPosition(25, 3);
            Console.Write("  █ ▀█");
            Console.SetCursorPosition(25, 4);
            Console.Write("█▄█ █▄");
            Console.SetCursorPosition(posicionac[0], posicionac[1]);
        }

        public static void mostraractual()
        {
            if (Jugadorvs.jugadoractual == true)
            {
                mostarturnoj1();
            }
            else
            {
                mostarturnoj2();
            }
        }
    }
}
