using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_02
{
    class Ganoperdio
    {
        public static string piezaganador = "■";
        public static void comprobar()
        {
            rectarriba();
            rectahorizontal();
            diagonal();
            reversadiagonal();
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
                            Tabla.tabla[e, i] = Tabla.tabla[e, i].Replace(Jugadorvs.piezactual, piezaganador);
                            Tabla.tabla[e-1, i] = Tabla.tabla[e, i].Replace(Jugadorvs.piezactual, piezaganador);
                            Tabla.tabla[e-2, i] = Tabla.tabla[e, i].Replace(Jugadorvs.piezactual, piezaganador);
                            Tabla.tabla[e-3, i] = Tabla.tabla[e, i].Replace(Jugadorvs.piezactual, piezaganador);
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
                                Console.WriteLine("¡El Bot es el ganador!");
                            }
                            Console.ReadKey();
                        }
                    }
                    catch 
                    {
                        
                    }
                }
            }
            Tabla.tablamostrar();
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
                                Console.WriteLine("¡El Bot es el ganador!");
                            }
                            Console.ReadKey();
                        }
                    }
                    catch
                    {

                    }
                }
            }
            Tabla.tablamostrar();
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
                                Console.WriteLine("¡El Bot es el ganador!");
                            }
                            Console.ReadKey();
                        }
                    }
                    catch
                    {

                    }
                }
            }
            Tabla.tablamostrar();
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
                                Console.WriteLine("¡El Bot es el ganador!");
                            }
                            Console.ReadKey();
                        }
                    }
                    catch
                    {

                    }
                }
            }

            Tabla.tablamostrar();
        }
    }
}
