using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;
using System.ComponentModel;
using System.Windows.Forms;

namespace Proyecto_02
{
    class Ganoperdio
    {
        public static Stopwatch stopwatch = new Stopwatch();
        public static string tiempoP = "";
        public static string[] historialganador = new string[10];
        public static string piezaganador = "█";
        public static void comprobar()
        {
            rectarriba();
            rectahorizontal();
            diagonal();
            reversadiagonal();

        }
        public static void empate()
        {
            if (Tabla.tabla.Cast<string>().Skip(0).Take(Tabla.tabla.GetLength(1)).Any(elemento => elemento.Contains(Jugadorvs.jugador1)) && Tabla.tabla.Cast<string>().Skip(0).Take(Tabla.tabla.GetLength(1)).Any(elemento => elemento.Contains(Jugadorvs.jugador2)) && 
                !Tabla.tabla.Cast<string>().Skip(0).Take(Tabla.tabla.GetLength(1)).Any(elemento => elemento.Contains(" ")))
            {
                Console.WriteLine("\r\n\n█▀▀ █▀▄▀█ █▀█ ▄▀█ ▀█▀ █▀▀ ░ ░ ░" +
                    "\r\n██▄ █░▀░█ █▀▀ █▀█ ░█░ ██▄ ▄ ▄ ▄");
                Conecta4.ganador = true;
                Console.ReadKey();
            }
        }
        public static void posiblesganadores()
        {
            if (Jugadorvs.piezactual == Jugadorvs.jugador1)
            {
                visualizacion.ganador();
                Console.Write("\n¡El jugador " + Jugadorvs.nombreactual[0] + " (J1) es el ganador!");
                guardarpartida(Jugadorvs.nombreactual[0], tiempofinal(), Jugadorvs.turnosporjugador[0], Conecta4.mododejuego[Controles.subindice - 1]);

            }
            else if (Jugadorvs.piezactual == Jugadorvs.jugador2 && Jugadorvs.nombreactual[2] != "CPU1")
            {
                visualizacion.ganador();
                Console.WriteLine("\n¡El jugador " + Jugadorvs.nombreactual[1] + " (J2) es el ganador!");
                guardarpartida(Jugadorvs.nombreactual[1], tiempofinal(), Jugadorvs.turnosporjugador[1], Conecta4.mododejuego[Controles.subindice - 1]);
            }
            else
            {
                visualizacion.ganador();
                Console.WriteLine("¡La CPU1 es el ganador!");
                guardarpartida(Jugadorvs.nombreactual[2], tiempofinal(), Jugadorvs.turnosporjugador[2], Conecta4.mododejuego[Controles.subindice - 1]);
            }
        }
        public static void rectarriba()
        {
            for(int i = 0; i < Tabla.tabla.GetLength(1); i++)
            {
                for (int e = 5; e >= 0; e--)
                {
                    try
                    {
                        if (Tabla.tabla[e, i].Contains(Jugadorvs.piezactual) && Tabla.tabla[e - 1, i].Contains(Jugadorvs.piezactual)
                            && Tabla.tabla[e - 2, i].Contains(Jugadorvs.piezactual) && Tabla.tabla[e - 3, i].Contains(Jugadorvs.piezactual))
                        {
                            for (int j = 0; j < 4; j++)
                            {
                                Tabla.tabla[e, i] = Tabla.tabla[e, i].Replace(Jugadorvs.piezactual, piezaganador);
                                e--;
                            }
                            Conecta4.ganador = true;
                            Tabla.tablamostrar();
                            posiblesganadores();
                            Console.ReadKey();
                        }
                    }
                    catch 
                    {
                        
                    }
                }
            }
        }

        public static void rectahorizontal()
        {
            for (int e = 5; e >= 0; e--)
            {
                for (int i = 0; i < Tabla.tabla.GetLength(1); i++)
                {
                    try
                    {
                        if (Tabla.tabla[e, i].Contains(Jugadorvs.piezactual) && Tabla.tabla[e, i + 1].Contains(Jugadorvs.piezactual)
                            && Tabla.tabla[e, i + 2].Contains(Jugadorvs.piezactual) && Tabla.tabla[e, i + 3].Contains(Jugadorvs.piezactual))
                        {
                            for (int j = 0; j < 4; j++)
                            {
                                Tabla.tabla[e, i] = Tabla.tabla[e, i].Replace(Jugadorvs.piezactual, piezaganador);
                                i++;
                            }
                            Conecta4.ganador = true;
                            Tabla.tablamostrar();
                            posiblesganadores();
                            Console.ReadKey();
                        }
                    }
                    catch
                    {

                    }
                }
            }
        }
        public static void diagonal()
        {
            for (int e = 5; e >= 0; e--)
            {
                for (int i = 0; i < Tabla.tabla.GetLength(1); i++)
                {
                    try
                    {
                        if (Tabla.tabla[e, i].Contains(Jugadorvs.piezactual) && Tabla.tabla[e - 1, i + 1].Contains(Jugadorvs.piezactual)
                            && Tabla.tabla[e - 2, i + 2].Contains(Jugadorvs.piezactual) && Tabla.tabla[e - 3, i + 3].Contains(Jugadorvs.piezactual))
                        {
                            for (int j = 0; j < 4; j++)
                            {
                                Tabla.tabla[e, i] = Tabla.tabla[e, i].Replace(Jugadorvs.piezactual, piezaganador);
                                i++; e--;
                            }
                            Conecta4.ganador = true;
                            Tabla.tablamostrar();
                            posiblesganadores();
                            Console.ReadKey();
                        }
                    }
                    catch
                    {

                    }
                }
            }
        }
        public static void reversadiagonal()
        {
            for (int e = 0; e < Tabla.tabla.GetLength(0); e++)
            {
                for (int i = 0; i < Tabla.tabla.GetLength(1); i++)
                {
                    try
                    {
                        if (Tabla.tabla[e, i].Contains(Jugadorvs.piezactual) && Tabla.tabla[e + 1, i + 1].Contains(Jugadorvs.piezactual)
                            && Tabla.tabla[e + 2, i + 2].Contains(Jugadorvs.piezactual) && Tabla.tabla[e + 3, i + 3].Contains(Jugadorvs.piezactual))
                        {
                            for (int j = 0; j < 4; j++)
                            {
                                Tabla.tabla[e, i] = Tabla.tabla[e, i].Replace(Jugadorvs.piezactual, piezaganador);
                                i++; e++;
                            }
                            Conecta4.ganador = true;
                            Tabla.tablamostrar();
                            posiblesganadores();
                            Console.ReadKey();
                        }
                        else
                        {
                            Tabla.tablamostrar();
                            empate();
                            break;
                        }
                    }
                    catch
                    {

                    }
                }
            }
        }

        public static void tiempoinicial()
        {
            stopwatch = new Stopwatch();
            stopwatch.Start();
        }

        public static string tiempofinal()
        {
            stopwatch.Stop();
            TimeSpan tiempoTranscurrido = stopwatch.Elapsed;
            tiempoP = tiempoTranscurrido.ToString("mm':'ss");
            return tiempoP;
        }
        public static int ultimonumero()
        {
            int numero = 0;
            numero = Jugadorvs.columna % 10;
            return numero;
        }
        public static void guardarpartida(string ganador,string tiempo, int turnos, string mododejuego)
        {
            Jugadorvs.turnosporjugador[0] = 0; Jugadorvs.turnosporjugador[1] = 0; Jugadorvs.turnosporjugador[2] = 0;
            string partidasstring = "";
            string turnosstring = "";
            Jugadorvs.nombreactual[0] = "";
            Jugadorvs.nombreactual[1] = "";
            Jugadorvs.nombreactual[2] = "";
            Controles.subindice = 0;
            if (Conecta4.contadorpartidas < 10)
            {
                partidasstring = "0" + Conecta4.contadorpartidas;
            }
            else
            {
                partidasstring = "" + Conecta4.contadorpartidas;
            }
            if (turnos < 10)
            {
                turnosstring = "0" + turnos; 
            }
            else
            {
                turnosstring = "" + turnos;
            }
            historialganador[ultimonumero()] = partidasstring + "       " + ganador + "       " + turnosstring + "         " + mododejuego+ "         " + tiempo;
            Historialdepartida.guardarhistorialdepartida(historialganador[ultimonumero()]);
            Jugadorvs.jugador1 = ""; Jugadorvs.jugador2 = "";

            Conecta4.contadorpartidas++;
        }
    }
}
