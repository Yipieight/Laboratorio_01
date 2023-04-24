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
        public static Stopwatch stopwatch = new Stopwatch();
        public static string[] tiempoP = new string[10] {"","","","","","","","","",""};
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
            Console.SetCursorPosition(24, 2);
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
            Console.SetCursorPosition(24, 2);
            Console.WriteLine("TURNO DE:\n");
            Console.SetCursorPosition(25, 3);
            Console.Write("█▄▄ █▀█ ▀█▀");
            Console.Write("  (" + Jugadorvs.nombreactual[1] + ")");
            Console.SetCursorPosition(25, 4);
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
        public static void tiempoinicial()
        {
            stopwatch.Start();
        }
        public static void tiempofinal()
        {
            stopwatch.Stop();
            for (int k = 0; k < 10; k++)
            {
                if (!tiempoP[k].Contains(":"))
                {
                    TimeSpan tiempoTranscurrido = stopwatch.Elapsed;
                    tiempoP[k] = tiempoTranscurrido.ToString("hh'\t:'mm'\t:'ss'\t:'fff");
                    break;
                }
            }
        }
    }
}
