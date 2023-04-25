﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_02
{
    internal class Conecta4
    {
        public static int contadorpartidas = 0;
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
                Controles.controlespieza();
                Console.Clear();
                Console.WriteLine("¿De que forma quiere jugar conecta 4? \n");
                Console.WriteLine("1. Jugador vs Jugador");
                Console.WriteLine(("2. Jugador vs Computadora"));
                Console.WriteLine(("3. Instrucciones del juego"));
                Console.WriteLine(("4. Historial de partidas"));
                Console.WriteLine("5. Salir \n");
                Controles.controlesmenu();
                switch (Controles.subindice)
                {
                    case 1:
                        Tabla.tablacrear();
                        ganador = false;
                        Jugadorvs.nombrejugadores();
                        Tabla.tablamostrar();
                        Ganoperdio.tiempoinicial();
                        while (ganador != true)
                        {
                            Jugadorvs.jugador1o2();
                            Ganoperdio.comprobar();
                        }
                        contadorpartidas++;
                        break;
                    case 2:
                        Ganoperdio.tiempoinicial();
                        Tabla.tablacrear();
                        ganador = false;
                        Jugadorvs.nombrejugadores();
                        Tabla.tablamostrar();
                        while (ganador != true)
                        {
                            Jugadorvs.jugador1o2();
                            Ganoperdio.comprobar();
                        }
                        break;
                    case 4:
                        Historialdepartida.mostrarhistorialdepartida();
                        break;
                }
            }
            while(Controles.subindice != 5);
        }

        public static void jugardenuevo()
        {
            Console.Clear();
            Console.WriteLine("¿Desea Jugar de nuevo? (Si/No)");
            denuevo = Console.ReadLine().ToLower();
        }


    }

    
}
