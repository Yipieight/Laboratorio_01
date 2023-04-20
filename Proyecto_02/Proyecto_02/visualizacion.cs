using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
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
        public static void mostrarturnoj1()
        {
            Console.SetCursorPosition(24, 2);
            Console.Write("TURNO DE:\n");
            Console.SetCursorPosition(25, 3);
            Console.Write("  █ ▄█");
            Console.SetCursorPosition(25, 4);
            Console.Write("█▄█  █");
            Console.SetCursorPosition(posicionac[0], posicionac[1]);
        }
        public static void mostrarturnoj2()
        {
            Console.SetCursorPosition(24, 2);
            Console.WriteLine("TURNO DE:\n");
            Console.SetCursorPosition(25, 3);
            Console.Write("  █ ▀█");
            Console.SetCursorPosition(25, 4);
            Console.Write("█▄█ █▄");
            Console.SetCursorPosition(posicionac[0], posicionac[1]);
        }
        public static void ganador()
        {
            Console.WriteLine("\n█▀▀ ▄▀█ █▄░█ ▄▀█ █▀▄ █▀█ █▀█ ▄");
            Console.Write("█▄█ █▀█ █░▀█ █▀█ █▄▀ █▄█ █▀▄ ▄");
        }

        public static void mostraractual()
        {
            if (Jugadorvs.piezactual != Jugadorvs.jugador1 || Jugadorvs.piezactual == "")
            {
                visualizacion.mostrarturnoj1();
            }
            else
            {
                visualizacion.mostrarturnoj2();
            }
        }

        public static void bienvenida()
        {
            string visible = "Presione cualquier tecla para continuar...";
            string invisible = " ";
            string mostrar = visible;
            do
            {
                Console.Clear();
                Console.WriteLine(""+
                "\r\n ██████╗░██╗███████╗███╗░░██╗██╗░░░██╗███████╗███╗░░██╗██╗██████╗░░" + "█████╗░  ░█████╗░" +
                "\r\n ██╔══██╗██║██╔════╝████╗░██║██║░░░██║██╔════╝████╗░██║██║" + "██╔══██╗██╔══██╗  ██╔══██╗" +
                "\r\n ██████╦╝██║█████╗░░██╔██╗██║╚██╗░██╔╝█████╗░░██╔" + "██╗██║██║██║░░██║██║░░██║  ███████║" +
                "\r\n ██╔══██╗██║██╔══╝░░██║╚████║░╚████╔╝░" + "██╔══╝░░██║╚████║██║██║░░██║██║░░██║  ██╔══██║" +
                "\r\n ██████╦╝██║███████╗██║░╚" + "███║░░╚██╔╝░░███████╗██║░╚███║██║██████╔╝╚█████╔╝  ██║░░██║" +
                "\r\n ╚═════╝░" + "╚═╝╚══════╝╚═╝░░╚══╝░░░╚═╝░░░╚══════╝╚═╝░░╚══╝╚═╝╚═════╝░░╚════╝░  ╚═╝░░╚═╝" +
                "\r\n\r\n\t░█████╗░░█████╗░███╗░░██╗███████╗░█████╗░████████╗░█████╗░  ░░██╗██╗" +
                "\r\n\t██╔══██╗██╔══██╗████╗░██║██╔════╝██╔══██╗╚══██╔══╝██╔══██╗  ░██╔╝██║" +
                "\r\n\t██║░░╚═╝██║░░██║██╔██╗██║█████╗░░██║░░╚═╝░░░██║░░░███████║  ██╔╝░██║" +
                "\r\n\t██║░░██╗██║░░██║██║╚████║██╔══╝░░██║░░██╗░░░██║░░░██╔══██║  ███████║" +
                "\r\n\t╚█████╔╝╚█████╔╝██║░╚███║███████╗╚█████╔╝░░░██║░░░██║░░██║  ╚════██║" +
                "\r\n\t░╚════╝░░╚════╝░╚═╝░░╚══╝╚══════╝░╚════╝░░░░╚═╝░░░╚═╝░░╚═╝  ░░░░░╚═╝");
                Console.SetCursorPosition(20, 15);
                Console.WriteLine(mostrar);
                Thread.Sleep(600);
                if(mostrar.Any(char.IsLetter))
                {
                    mostrar = mostrar.Replace(visible,invisible);
                }
                else
                {
                    mostrar = mostrar.Replace(invisible, visible);
                }
            }
            while (!Console.KeyAvailable); 
        }
    }
}
