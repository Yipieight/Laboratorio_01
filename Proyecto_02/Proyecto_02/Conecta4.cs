using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Proyecto_02
{
    internal class Conecta4
    {
        public static int contadorpartidas = 1;
        public static string denuevo = "";
        public static string[] mododejuego = new string[2] { "JvsJ", "JvsB" };
        public static bool ganador = false;

        
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            visualizacion.bienvenida();
            Historialdepartida.crearpartidasguardadas();
            do
            {
                switch (Controles.subindice = visualizacion.menuprincipal())
                {
                    case 1:
                        menumododejuegos();
                        break;
                    case 2:
                        visualizacion.menuinstrucciones();
                        break;
                    case 3:
                        Historialdepartida.mostrarhistorialdepartida();
                        break;
                }
            }
            while(Controles.subindice != 4);
        }

        public static void menumododejuegos()
        {
            switch (Controles.subindice = visualizacion.menumododejuego())
            {
                case 1:
                    Tabla.tablacrear();
                    ganador = false;
                    Jugadorvs.nombrejugadores();
                    escojerpieza1y2();
                    Ganoperdio.tiempoinicial();
                    while (ganador != true)
                    {
                        Jugadorvs.jugador1o2();
                        Ganoperdio.comprobar();
                    }
                    break;
                case 2:
                    Tabla.tablacrear();
                    ganador = false;
                    Jugadorvs.nombrejugadores();
                    escojerpieza1y2();
                    Ganoperdio.tiempoinicial(); ;
                    while (ganador != true)
                    {
                        Jugadorvs.jugador1o2();
                        Ganoperdio.comprobar();
                    }
                    break;
                 case 3:
                    {
                        break;
                    }
            }
        }

        public static void jugardenuevo()
        {
            Console.Clear();
            Console.WriteLine("¿Desea Jugar de nuevo? (Si/No)");
            denuevo = Console.ReadLine().ToLower();
        }

        public static void escojerpieza1y2() 
        {
            do
            {
                Jugadorvs.jugador1 = Controles.controlespieza1();
                do
                {
                    Jugadorvs.jugador2 = Controles.controlespieza2();
                    if (Controles.tecla.Key != ConsoleKey.Backspace)
                    {
                        visualizacion.regresar();
                    }
                }while (Controles.tecla.Key != ConsoleKey.Enter && Controles.tecla.Key != ConsoleKey.Backspace || (Jugadorvs.jugador2.Contains(" ")));
            }
            while (Controles.tecla.Key != ConsoleKey.Enter);
            
        }


    }

    
}
