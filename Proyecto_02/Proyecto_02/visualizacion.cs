using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using System.Security.Permissions;

namespace Proyecto_02
{
    class visualizacion
    {
        public static int[] posicionac = new int[2];
        public static bool letras = true; 
        public static void posicionactual()
        {
            posicionac[0] = Console.CursorLeft;
            posicionac[1] = Console.CursorTop;
        }
        //-------------------------------------------------------------------------------------------------------------------
        //visualizacion del menu de modo de juegos

        public static void menuinstrucciones()
        {
            Console.Clear();
            menuinst();
            explicacion();
            Console.ReadKey();

        }
        public static void explicacion()
        {
            Console.WriteLine("\n\t\t\tEl jugador que primero logre conectar cuatro fichas de su color gana. Las");
            Console.WriteLine("\t\t\t   fichas pueden estar conectadas verticalmente, horizontalmente o en");
            Console.WriteLine("\t\t\t\t\t    diagonal. Como se observa ahora:");

            Console.SetCursorPosition(4, 14);
            Console.WriteLine("HORIZONTALMENTE");
            Console.SetCursorPosition(30, 15);
            Console.WriteLine("\r\n\t  ▄▄ " + "\r\n\t  ██ " + "\r\n\t  ▄▄ " + "\r\n\t  ██ " + "\r\n\t  ▄▄ " + "\r\n\t  ██ " + "\r\n\t  ▄▄ " +
                "\r\n\t  ██");
            Console.SetCursorPosition(38, 14);
            Console.WriteLine("VERTICALMENTE");
            Console.SetCursorPosition(36, 20);
            Console.Write("██   ██   ██   ██");

            Console.SetCursorPosition(102, 14);
            Console.WriteLine("DIAGONAL INVERSA");
            Console.SetCursorPosition(70, 15);
            Console.WriteLine(
                "\r\n\t\t\t\t\t\t\t\t\t\t\t\t      ▄▄ " +
                "\r\n\t\t\t\t\t\t\t\t\t\t\t\t      ██ " +
                "\r\n\t\t\t\t\t\t\t\t\t\t\t\t          ▄▄ " +
                "\r\n\t\t\t\t\t\t\t\t\t\t\t\t          ██ " +
                "\r\n\t\t\t\t\t\t\t\t\t\t\t\t              ▄▄ " + "" +
                "\r\n\t\t\t\t\t\t\t\t\t\t\t\t              ██ " +
                "\r\n\t\t\t\t\t\t\t\t\t\t\t\t                  ▄▄ " +
                "\r\n\t\t\t\t\t\t\t\t\t\t\t\t                  ██ ");

            Console.SetCursorPosition(72, 14);
            Console.WriteLine("DIAGONAL");
            Console.SetCursorPosition(70, 15);
            Console.WriteLine(
                "\r\n\t\t\t\t\t\t\t\t                ▄▄ " +
                "\r\n\t\t\t\t\t\t\t\t                ██ " +
                "\r\n\t\t\t\t\t\t\t\t            ▄▄ " +
                "\r\n\t\t\t\t\t\t\t\t            ██ " +
                "\r\n\t\t\t\t\t\t\t\t        ▄▄ " +
                "\r\n\t\t\t\t\t\t\t\t        ██ " +
                "\r\n\t\t\t\t\t\t\t\t    ▄▄ " +
                "\r\n\t\t\t\t\t\t\t\t    ██ ");


        }
        public static void menuinst()
        {
            Console.WriteLine("" +
                "\r\n\t   ██╗███╗░░██╗░██████╗████████╗██████╗░██╗░░░██╗░█████╗░░█████╗░██╗░█████╗░███╗░░██╗███████╗░██████╗" +
                "\r\n\t   ██║████╗░██║██╔════╝╚══██╔══╝██╔══██╗██║░░░██║██╔══██╗██╔══██╗██║██╔══██╗████╗░██║██╔════╝██╔════╝" +
                "\r\n\t   ██║██╔██╗██║╚█████╗░░░░██║░░░██████╔╝██║░░░██║██║░░╚═╝██║░░╚═╝██║██║░░██║██╔██╗██║█████╗░░╚█████╗░" +
                "\r\n\t   ██║██║╚████║░╚═══██╗░░░██║░░░██╔══██╗██║░░░██║██║░░██╗██║░░██╗██║██║░░██║██║╚████║██╔══╝░░░╚═══██╗" +
                "\r\n\t   ██║██║░╚███║██████╔╝░░░██║░░░██║░░██║╚██████╔╝╚█████╔╝╚█████╔╝██║╚█████╔╝██║░╚███║███████╗██████╔╝" +
                "\r\n\t   ╚═╝╚═╝░░╚══╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝░╚═════╝░░╚════╝░░╚════╝░╚═╝░╚════╝░╚═╝░░╚══╝╚══════╝╚═════╝░");
            Console.WriteLine("\t════════════════════════════════════════════════════════════════════════════════════════════════════════");
        }

        //-------------------------------------------------------------------------------------------------------------------
        //visualizacion del menu de nombres

        public static void menunombresj1()
        {
            Console.Clear();
            nombre();
            nombrej1();
            mostrartablanombres();

        }
        public static void menunombresj2()
        {
            Console.Clear();
            nombre();
            nombrej2();
            mostrartablanombres();

        }
        public static void menunombrescodigoj1()
        {
            do
            {
                Jugadorvs.nombreactual[0] = Controles.controlesnombresj1();
            }
            while (letras == true);
        }
        public static void menunombrescodigoj2()
        {
            do
            {
                Jugadorvs.nombreactual[1] = Controles.controlesnombresj2();
            }
            while (letras == true);
        }


        public static void mostrartablanombres()
        {
            for (int i = 0; i < 4; i++)
            {
                Console.SetCursorPosition(25, 15 + i);
                for (int e = 0; e < Controles.letrastabla.GetLength(1); e++)
                {
                    Console.Write(Controles.letrastabla[i, e] + "\t");
                }
                Console.WriteLine();
            }
        }
        public static void nombre()
        {
            Console.WriteLine("" +
                "\r\n\t\t\t\t███╗░░██╗░█████╗░███╗░░░███╗██████╗░██████╗░███████╗" +
                "\r\n\t\t\t\t████╗░██║██╔══██╗████╗░████║██╔══██╗██╔══██╗██╔════╝" +
                "\r\n\t\t\t\t██╔██╗██║██║░░██║██╔████╔██║██████╦╝██████╔╝█████╗░░" +
                "\r\n\t\t\t\t██║╚████║██║░░██║██║╚██╔╝██║██╔══██╗██╔══██╗██╔══╝░░" +
                "\r\n\t\t\t\t██║░╚███║╚█████╔╝██║░╚═╝░██║██████╦╝██║░░██║███████╗" +
                "\r\n\t\t\t\t╚═╝░░╚══╝░╚════╝░╚═╝░░░░░╚═╝╚═════╝░╚═╝░░╚═╝╚══════╝");
            Console.WriteLine("\t\t\t════════════════════════════════════════════════════════════════════");
        }
        public static void nombrej1()
        {
            Console.WriteLine("" +
                "\r\n\t\t\t\t\t\t     ░░▒█ ▄█░ " +
                "\r\n\t\t\t\t\t\t     ▄░▒█ ░█░ " +
                "\r\n\t\t\t\t\t\t     █▄▄█ ▄█▄\n");
            Console.SetCursorPosition(55, 13);
            Console.WriteLine(Jugadorvs.nombreactual[0] + "\n");
        }
        public static void nombrej2()
        {
            Console.WriteLine("" +
                "\r\n\t\t\t\t\t\t     ░░▒█ █▀█ " +
                "\r\n\t\t\t\t\t\t     ▄░▒█ ░▄▀ " +
                "\r\n\t\t\t\t\t\t     █▄▄█ █▄▄");
            Console.SetCursorPosition(55, 13);
            Console.WriteLine(Jugadorvs.nombreactual[1] + "\n");

        }
        //-------------------------------------------------------------------------------------------------------------------
        //visualizacion del menu de modo de juegos
        public static int menumododejuego()
        {
            mododejuego();
            jvsj();
            jvsb();
            menuregresar();
            return Controles.mododejuego();
        }
        public static void mododejuego() 
        {
            Console.Clear();
            Console.WriteLine("" +
                "\r\n\t███╗░░░███╗░█████╗░██████╗░░█████╗░  ██████╗░███████╗  ░░░░░██╗██╗░░░██╗███████╗░██████╗░░█████╗░" +
                "\r\n\t████╗░████║██╔══██╗██╔══██╗██╔══██╗  ██╔══██╗██╔════╝  ░░░░░██║██║░░░██║██╔════╝██╔════╝░██╔══██╗" +
                "\r\n\t██╔████╔██║██║░░██║██║░░██║██║░░██║  ██║░░██║█████╗░░  ░░░░░██║██║░░░██║█████╗░░██║░░██╗░██║░░██║" +
                "\r\n\t██║╚██╔╝██║██║░░██║██║░░██║██║░░██║  ██║░░██║██╔══╝░░  ██╗░░██║██║░░░██║██╔══╝░░██║░░╚██╗██║░░██║" +
                "\r\n\t██║░╚═╝░██║╚█████╔╝██████╔╝╚█████╔╝  ██████╔╝███████╗  ╚█████╔╝╚██████╔╝███████╗╚██████╔╝╚█████╔╝" +
                "\r\n\t╚═╝░░░░░╚═╝░╚════╝░╚═════╝░░╚════╝░  ╚═════╝░╚══════╝  ░╚════╝░░╚═════╝░╚══════╝░╚═════╝░░╚════╝░");
            Console.WriteLine("════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════");
        }
        public static void jvsj()
        {
            Console.WriteLine("" +
                "\r\n\t░░▒█ ▄█░ 　 ▀█░█▀ █▀▀ 　 ░░░▒█ █▀█ " +
                "\r\n\t▄░▒█ ░█░ 　 ░█▄█░ ▀▀█ 　 ░▄░▒█ ░▄▀ " +
                "\r\n\t█▄▄█ ▄█▄ 　 ░░▀░░ ▀▀▀ 　 ▒█▄▄█ █▄▄");
        }
        public static void jvsb()
        {
            Console.WriteLine("" +
                "\r\n\t░░▒█ ▄█░ 　 ▀█░█▀ █▀▀ 　 ▒█▀▀█ █▀▀█ ▀▀█▀▀ " +
                "\r\n\t▄░▒█ ░█░ 　 ░█▄█░ ▀▀█ 　 ▒█▀▀▄ █░░█ ░░█░░ " +
                "\r\n\t█▄▄█ ▄█▄ 　 ░░▀░░ ▀▀▀ 　 ▒█▄▄█ ▀▀▀▀ ░░▀░░");
        }
        public static void menuregresar()
        {
            Console.WriteLine("" +
                "\r\n\t█▀▀▄ █▀▀█ █▀▀ █░█" +
                "\r\n\t█▀▀▄ █▄▄█ █░░ █▀▄" +
                "\r\n\t▀▀▀░ ▀░░▀ ▀▀▀ ▀░▀");
        }
        //-------------------------------------------------------------------------------------------------------------------
        //visualizacion del menu principal
        public static int menuprincipal()
        {
            Console.Clear();
            menu();
            jugar();
            instrucciones();
            historial();
            salir();
            return Controles.controlesmenu();
        }

        public static void menu()
        {
            Console.Write("\r\n\t███╗░░░███╗███████╗███╗░░██╗██╗░░░██╗" +
                "\r\n\t████╗░████║██╔════╝████╗░██║██║░░░██║" +
                "\r\n\t██╔████╔██║█████╗░░██╔██╗██║██║░░░██║" +
                "\r\n\t██║╚██╔╝██║██╔══╝░░██║╚████║██║░░░██║" +
                "\r\n\t██║░╚═╝░██║███████╗██║░╚███║╚██████╔╝" +
                "\r\n\t╚═╝░░░░░╚═╝╚══════╝╚═╝░░╚══╝░╚═════╝░ \n");
            Console.WriteLine("═══════════════════════════════════════════════════════");
        }
        public static string flecha()
        {
            return("██");
        }
        public static void jugar()
        {
            Console.WriteLine("" +
                "\r\n\t░░▒█ █░░█ █▀▀▀ █▀▀█ █▀▀█ " +
                "\r\n\t▄░▒█ █░░█ █░▀█ █▄▄█ █▄▄▀ " +
                "\r\n\t█▄▄█ ░▀▀▀ ▀▀▀▀ ▀░░▀ ▀░▀▀");
        }
        public static void instrucciones()
        {
            Console.WriteLine("" +
                "\r\n\t▀█▀ █▀▀▄ █▀▀ ▀▀█▀▀ █▀▀█ █░░█ █▀▀ █▀▀ ░▀░ █▀▀█ █▀▀▄ █▀▀ █▀▀ " +
                "\r\n\t▒█░ █░░█ ▀▀█ ░░█░░ █▄▄▀ █░░█ █░░ █░░ ▀█▀ █░░█ █░░█ █▀▀ ▀▀█ " +
                "\r\n\t▄█▄ ▀░░▀ ▀▀▀ ░░▀░░ ▀░▀▀ ░▀▀▀ ▀▀▀ ▀▀▀ ▀▀▀ ▀▀▀▀ ▀░░▀ ▀▀▀ ▀▀▀");
        }
        public static void historial()
        {
            Console.WriteLine("" +
                "\r\n\t█░▒█ ░▀░ █▀▀ ▀▀█▀▀ █▀▀█ █▀▀█ ░▀░ █▀▀█ █░░ " +
                "\r\n\t█▀▀█ ▀█▀ ▀▀█ ░░█░░ █░░█ █▄▄▀ ▀█▀ █▄▄█ █░░ " +
                "\r\n\t█░▒█ ▀▀▀ ▀▀▀ ░░▀░░ ▀▀▀▀ ▀░▀▀ ▀▀▀ ▀░░▀ ▀▀▀");
        }
        public static void salir()
        {
            Console.WriteLine("" +
                "\r\n\t█▀▀▀█ █▀▀█ █░░ ░▀░ █▀▀█" +
                "\r\n\t▀▀▀▄▄ █▄▄█ █░░ ▀█▀ █▄▄▀" +
                "\r\n\t█▄▄▄█ ▀░░▀ ▀▀▀ ▀▀▀ ▀░▀▀");
        }
        //--------------------------------------------------------------------------------------------------------------------
        //visualizacion de turnos en la tabla
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
            Console.Write("  (" + Jugadorvs.nombreactual[2] + ")");
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
            if (Jugadorvs.piezactual == Jugadorvs.jugador1 || Jugadorvs.piezactual == "")
            {
                visualizacion.mostrarturnoj1();
            }
            else if(Jugadorvs.nombreactual[2] != "CPU1")
            {
                visualizacion.mostrarturnoj2();
            }
            else
            {
                visualizacion.mostrarturnobot();
            }
        }

        //--------------------------------------------------------------------------------------------------------------------
        //visualizacion en el menu de bienvenida
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

        //--------------------------------------------------------------------------------------------------------------------
        //visualizacion del menú de ganadores(el historial)
        public static void ganadores()
        {
            Console.Clear();
            Console.WriteLine("\r\n\t\t\t░██████╗░░█████╗░███╗░░██╗░█████╗░██████╗░░█████╗░██████╗░███████╗░██████╗" +
                "\r\n\t\t\t██╔════╝░██╔══██╗████╗░██║██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔════╝██╔════╝" +
                "\r\n\t\t\t██║░░██╗░███████║██╔██╗██║███████║██║░░██║██║░░██║██████╔╝█████╗░░╚█████╗░" +
                "\r\n\t\t\t██║░░╚██╗██╔══██║██║╚████║██╔══██║██║░░██║██║░░██║██╔══██╗██╔══╝░░░╚═══██╗" +
                "\r\n\t\t\t╚██████╔╝██║░░██║██║░╚███║██║░░██║██████╔╝╚█████╔╝██║░░██║███████╗██████╔╝" +
                "\r\n\t\t\t░╚═════╝░╚═╝░░╚═╝╚═╝░░╚══╝╚═╝░░╚═╝╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚═════╝░");

            Console.SetCursorPosition(35,8);
            Console.WriteLine("Partida | Usuario | Turnos | Modo de juego | Tiempo");
        }

        //----------------------------------------------------------------------------------------------------------------------------------
        //visualizacion en el menu de escoger ficha

        public static void regresar()
        {
            visualizacion.mostrarpiezas();
            string espacio = "\t\t\t\t     ";
            Console.WriteLine("\r\n"+espacio+ "░▄ █▀▀ █▀ ▀█▀ ▄▀█ █▄░█   █░░ █ █▀ ▀█▀ █▀█ █▀ ▀█" +
                "\r\n"+espacio+ "█▄ ██▄ ▄█ ░█░ █▀█ █░▀█   █▄▄ █ ▄█ ░█░ █▄█ ▄█ ░▄");
            Console.SetCursorPosition(31, 27);
            Console.WriteLine("Presiona ENTER para continuar o presiona DELETE para regresar...");
            Controles.tecla = Console.ReadKey(true);
            if (Controles.tecla.Key == ConsoleKey.Backspace)
            {
                Jugadorvs.jugador2 = " ";
            }
            else
            {
            }
        }
        public static void mostrarpiezas()
        {
            Console.Clear();
            Console.Write("\r\n\t    ███████╗░██████╗░█████╗░░█████╗░░██████╗░███████╗██████╗░  ███████╗██╗░█████╗░██╗░░██╗░█████╗░" +
                "\r\n\t    ██╔════╝██╔════╝██╔══██╗██╔══██╗██╔════╝░██╔════╝██╔══██╗  ██╔════╝██║██╔══██╗██║░░██║██╔══██╗" +
                "\r\n\t    █████╗░░╚█████╗░██║░░╚═╝██║░░██║██║░░██╗░█████╗░░██████╔╝  █████╗░░██║██║░░╚═╝███████║███████║" +
                "\r\n\t    ██╔══╝░░░╚═══██╗██║░░██╗██║░░██║██║░░╚██╗██╔══╝░░██╔══██╗  ██╔══╝░░██║██║░░██╗██╔══██║██╔══██║" +
                "\r\n\t    ███████╗██████╔╝╚█████╔╝╚█████╔╝╚██████╔╝███████╗██║░░██║  ██║░░░░░██║╚█████╔╝██║░░██║██║░░██║" +
                "\r\n\t    ╚══════╝╚═════╝░░╚════╝░░╚════╝░░╚═════╝░╚══════╝╚═╝░░╚═╝  ╚═╝░░░░░╚═╝░╚════╝░╚═╝░░╚═╝╚═╝░░╚═╝");

            if (Jugadorvs.nombreactual[0] == Jugadorvs.nombreactual[0])
            {
                mostrarpiezasj1();
            }
            visualizacion.vs();
            if (Jugadorvs.nombreactual[2] != "CPU1")
            {
                mostrarpiezasj2();
            }
            if (Jugadorvs.nombreactual[2] == "CPU1")
            {
                mostrarpiezasbot();
            }   
        }

        public static void mostrarpiezasbot()
        {
            string espacios = "\t\t\t\t\t\t\t\t\t     ";
            Console.SetCursorPosition(0, 7);
            Console.Write("\n\n" + espacios + "\t\t   █▄▄ █▀█ ▀█▀" +
                "\r\n" + espacios + "\t\t   █▄█ █▄█  █");
            Console.WriteLine("\r\n\n" + espacios + "═══════════════════════════════════════════\n\n");
            for (int i = 0; i < 2; i++)
            {
                Console.SetCursorPosition(80, 15 + i);
                for (int e = 0; e < Controles.piezas1.GetLength(1); e++)
                {
                    Console.Write(Controles.piezas1[i, e] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\r\n\n" + espacios + "═══════════════════════════════════════════");
            if (Controles.tecla.Key == ConsoleKey.Enter && Jugadorvs.jugador2.Any(char.IsLetter) || Jugadorvs.jugador2.Any(char.IsSymbol)
                || Jugadorvs.jugador2.Any(c => c == '☻' || c == '☺' || c == '#' || c == '@'))
            {
                listoj2();
            }
        }
        public static void mostrarpiezasj2()
        {
            string espacios = "\t\t\t\t\t\t\t\t\t     ";
            Console.SetCursorPosition(0, 7);
            Console.Write("\n\n" + espacios + "\t\t\t  █ ▀█" +
                "\r\n" + espacios + "\t\t\t█▄█ █▄");
            Console.WriteLine("\r\n\n" + espacios + "═══════════════════════════════════════════\n\n");
            for (int i = 0; i < 2; i++)
            {
                Console.SetCursorPosition(80, 15 + i);
                for (int e = 0; e < Controles.piezas1.GetLength(1); e++)
                {
                    Console.Write(Controles.piezas1[i, e] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\r\n\n" + espacios + "═══════════════════════════════════════════");
            if (Controles.tecla.Key == ConsoleKey.Enter && Jugadorvs.jugador2.Any(char.IsLetter) || Jugadorvs.jugador2.Any(char.IsSymbol) 
                || Jugadorvs.jugador2.Any(c => c == '☻' || c == '☺'|| c == '#' || c == '@'))
            {
                listoj2();
            }
        }
        public static void mostrarpiezasj1()
        {
            Console.Write("\n\n\n\t\t  █ ▄█" +
                "\r\n\t\t█▄█  █");
            Console.WriteLine("\r\n\n═══════════════════════════════════════════\n\n");
            for (int i = 0; i < 2; i++)
            {
                for (int e = 0; e < Controles.piezas.GetLength(1); e++)
                {
                    Console.Write("  "+Controles.piezas[i, e] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\r\n\n═══════════════════════════════════════════");
            if(Jugadorvs.jugador1.Any(char.IsLetter) || Jugadorvs.jugador1.Any(char.IsSymbol) 
                || Jugadorvs.jugador1.Any(c => c == '☻' || c == '☺' || c == '#' || c == '@'))
            {
                listoj1();
            }
        }

        public static void incorrecto()
        {
            Console.Write("\r\n\n\n\n\n\t\t█▀▀ █▀ ▀█▀ ▄▀█   █▀▀ █ █▀▀ █░█ ▄▀█   █▄█ ▄▀█   █▀▀ █▀ ▀█▀ ▄▀█   █▀▀ █▄░█   █░█ █▀ █▀█ ░ ░ ░");
            Console.Write("\r\n\t\t██▄ ▄█ ░█░ █▀█   █▀░ █ █▄▄ █▀█ █▀█   ░█░ █▀█   ██▄ ▄█ ░█░ █▀█   ██▄ █░▀█   █▄█ ▄█ █▄█ ▄ ▄ ▄");
        }
        public static void vs()
        {
            string espacios = "\t\t\t\t\t\t    ";
            Console.SetCursorPosition(0, 12);
            Console.Write("\r\n" + espacios + "██╗░░░██╗░██████╗" +
                "\r\n" + espacios + "██║░░░██║██╔════╝" +
                "\r\n" + espacios + "╚██╗░██╔╝╚█████╗░" +
                "\r\n" + espacios + "░╚████╔╝░░╚═══██╗" +
                "\r\n" + espacios + "░░╚██╔╝░░██████╔╝" +
                "\r\n" + espacios + "░░░╚═╝░░░╚═════╝░");
        }

        public static void listoj1()
        {
            Console.WriteLine("\r\n\t   █░░ █ █▀ ▀█▀ █▀█ █" +
                "\r\n\t   █▄▄ █ ▄█ ░█░ █▄█ ▄");
        }
        public static void listoj2()
        {
            string espacios = "\t\t\t\t\t\t\t\t\t\t\t";
            Console.WriteLine("\r\n"+espacios+"   █░░ █ █▀ ▀█▀ █▀█ █" +
                "\r\n"+espacios+"   █▄▄ █ ▄█ ░█░ █▄█ ▄");
        }

    }
}
