using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;

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
            Console.SetCursorPosition(24, 1);
            Console.Write("TURNO DE:\n");
            Console.SetCursorPosition(25, 3);
            Console.Write("  █ ▄█");
            Console.Write("  (" + Jugadorvs.nombreactual[0] + ")");
            Console.SetCursorPosition(25, 4);
            Console.Write("█▄█  █");
            Console.SetCursorPosition(32, 3);
            Console.SetCursorPosition(posicionac[0], posicionac[1]);
        }
        public static void mostrarturnoj2()
        {
            Console.SetCursorPosition(24, 1);
            Console.WriteLine("TURNO DE:\n");
            Console.SetCursorPosition(25, 3);
            Console.Write("  █ ▀█");
            Console.Write("  (" + Jugadorvs.nombreactual[1] + ")");
            Console.SetCursorPosition(25, 4);
            Console.Write("█▄█ █▄");
            Console.SetCursorPosition(posicionac[0], posicionac[1]);
        }

        public static void mostrarturnobot()
        {
            Console.SetCursorPosition(24, 1);
            Console.WriteLine("TURNO DE:\n");
            Console.SetCursorPosition(23, 3);
            Console.Write("█▄▄ █▀█ ▀█▀");
            Console.Write("  (" + Jugadorvs.nombreactual[1] + ")");
            Console.SetCursorPosition(23, 4);
            Console.Write("█▄█ █▄█  █");
            Console.SetCursorPosition(posicionac[0], posicionac[1]);
        }
        public static void ganador()
        {
            Console.WriteLine("\n█▀▀ ▄▀█ █▄░█ ▄▀█ █▀▄ █▀█ █▀█ ▄\r\n█▄█ █▀█ █░▀█ █▀█ █▄▀ █▄█ █▀▄ ▄");
        }

        public static void mostraractual()
        {
            if (Jugadorvs.piezactual != Jugadorvs.jugador1 || Jugadorvs.piezactual == "")
            {
                visualizacion.mostrarturnoj1();
            }
            else if(Jugadorvs.nombreactual[1] != "COMPUTADORA")
            {
                visualizacion.mostrarturnoj2();
            }
            else
            {
                visualizacion.mostrarturnobot();
            }
        }

        public static void bienvenida()
        {
            string visible = "Presione cualquier tecla para continuar...";
            string invisible = " ";
            string mostrar = visible;
            Console.WriteLine("" +
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
            do
            {
                Console.SetCursorPosition(20, 15);
                Console.WriteLine(mostrar);
                Thread.Sleep(700);
                if (mostrar.Any(char.IsLetter))
                {
                    Console.SetCursorPosition(20, 15);
                    mostrar = mostrar.Replace(visible, invisible);
                }
                else
                {
                    Console.SetCursorPosition(20, 15);
                    mostrar = mostrar.Replace(invisible, visible);
                }
                Console.Write(new string(' ', Console.WindowWidth));
            }
            while (!Console.KeyAvailable);
        }

        public static void ganadores()
        {
            Console.Clear();
            Console.WriteLine("\r\n\t░██████╗░░█████╗░███╗░░██╗░█████╗░██████╗░░█████╗░██████╗░███████╗░██████╗" +
                "\r\n\t██╔════╝░██╔══██╗████╗░██║██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔════╝██╔════╝" +
                "\r\n\t██║░░██╗░███████║██╔██╗██║███████║██║░░██║██║░░██║██████╔╝█████╗░░╚█████╗░" +
                "\r\n\t██║░░╚██╗██╔══██║██║╚████║██╔══██║██║░░██║██║░░██║██╔══██╗██╔══╝░░░╚═══██╗" +
                "\r\n\t╚██████╔╝██║░░██║██║░╚███║██║░░██║██████╔╝╚█████╔╝██║░░██║███████╗██████╔╝" +
                "\r\n\t░╚═════╝░╚═╝░░╚═╝╚═╝░░╚══╝╚═╝░░╚═╝╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚═════╝░");

            Console.SetCursorPosition(27,8);
            Console.WriteLine("Partida | Usuario | Turnos | Tiempo");
        }
        
    }
}
