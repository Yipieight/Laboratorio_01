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
            Tabla.tablamostrar();
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
                            tiempofinal();
                            for (int j = 0; j < 4; j++)
                            {
                                Tabla.tabla[e, i] = Tabla.tabla[e, i].Replace(Jugadorvs.piezactual, piezaganador);
                                e--;
                            }
                            Conecta4.ganador = true;
                            Tabla.tablamostrar();
                            if (Jugadorvs.piezactual == Jugadorvs.jugador1)
                            {
                                visualizacion.ganador();
                                Console.Write("\n¡El jugador " + Jugadorvs.nombreactual[0] + " (J1) es el ganador!");
                                guardarpartida(Jugadorvs.nombreactual[0], tiempofinal(), Jugadorvs.turnosporjugador[0]);
                            }
                            else if (Jugadorvs.piezactual == Jugadorvs.jugador2)
                            {
                                visualizacion.ganador();
                                Console.WriteLine("\n¡El jugador " + Jugadorvs.nombreactual[1] + " (J2) es el ganador!");
                                guardarpartida(Jugadorvs.nombreactual[1], tiempofinal(), Jugadorvs.turnosporjugador[1]);
                            }
                            else
                            {
                                visualizacion.ganador();
                                Console.WriteLine("¡La COMPUTADORA es el ganador!");
                            }
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
                            tiempofinal();
                            for (int j = 0; j < 4; j++)
                            {
                                Tabla.tabla[e, i] = Tabla.tabla[e, i].Replace(Jugadorvs.piezactual, piezaganador);
                                i++;
                            }
                            Conecta4.ganador = true;
                            Tabla.tablamostrar();
                            if (Jugadorvs.piezactual == Jugadorvs.jugador1)
                            {
                                visualizacion.ganador();
                                Console.Write("\n¡El jugador " + Jugadorvs.nombreactual[0] + " (J1) es el ganador!");
                            }
                            else if (Jugadorvs.piezactual == Jugadorvs.jugador2)
                            {
                                visualizacion.ganador();
                                Console.WriteLine("\n¡El jugador " + Jugadorvs.nombreactual[1] + " (J2) es el ganador!");
                            }
                            else
                            {
                                visualizacion.ganador();
                                Console.WriteLine("¡La COMPUTADORA es el ganador!");
                            }
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
                            tiempofinal();
                            for (int j = 0; j < 4; j++)
                            {
                                Tabla.tabla[e, i] = Tabla.tabla[e, i].Replace(Jugadorvs.piezactual, piezaganador);
                                i++; e--;
                            }
                            Conecta4.ganador = true;
                            Tabla.tablamostrar();
                            if (Jugadorvs.piezactual == Jugadorvs.jugador1)
                            {
                                visualizacion.ganador();
                                Console.Write("\n¡El jugador " + Jugadorvs.nombreactual[0] + " (J1) es el ganador!");
                            }
                            else if (Jugadorvs.piezactual == Jugadorvs.jugador2)
                            {
                                visualizacion.ganador();
                                Console.WriteLine("\n¡El jugador " + Jugadorvs.nombreactual[1] + " (J2) es el ganador!");
                            }
                            else
                            {
                                visualizacion.ganador();
                                Console.WriteLine("¡La COMPUTADORA es el ganador!");
                            }
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
                            tiempofinal();
                            for (int j = 0; j < 4; j++)
                            {
                                Tabla.tabla[e, i] = Tabla.tabla[e, i].Replace(Jugadorvs.piezactual, piezaganador);
                                i++; e++;
                            }
                            Conecta4.ganador = true;
                            Tabla.tablamostrar();
                            if (Jugadorvs.piezactual == Jugadorvs.jugador1)
                            {
                                visualizacion.ganador();
                                Console.Write("\n¡El jugador " + Jugadorvs.nombreactual[0] + " (J1) es el ganador!");
                                guardarpartida(Jugadorvs.nombreactual[0],tiempofinal(),Jugadorvs.turnosporjugador[0]);
                            }
                            else if (Jugadorvs.piezactual == Jugadorvs.jugador2)
                            {
                                visualizacion.ganador();
                                Console.Write("\n¡El jugador " + Jugadorvs.nombreactual[1] + " (J2) es el ganador!");
                                guardarpartida(Jugadorvs.nombreactual[1], tiempofinal(), Jugadorvs.turnosporjugador[1]);
                            }
                            else
                            {
                                visualizacion.ganador();
                                Console.Write("¡La COMPUTADORA es el ganador!");
                            }
                            Console.ReadKey();
                        }
                        else
                        {

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
        public static void guardarpartida(string ganador,string tiempo, int turnos)
        {
            historialganador[ultimonumero()] = ganador + " | " + turnos + " | " + tiempo; 
        }
    }
}
