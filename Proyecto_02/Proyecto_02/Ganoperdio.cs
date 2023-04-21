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
        public static void rectarriba()
        {
            for(int i = 0; i < Tabla.tabla.GetLength(1); i++)
            {
                for (int e = 5; e >= 0; e--)
                {
                    try
                    {
                        if (Tabla.tabla[e, i].Contains(Jugadorvs.piezactual))
                        {
                            if (Tabla.tabla[e - 1, i].Contains(Jugadorvs.piezactual))
                            {
                                if (Tabla.tabla[e - 2, i].Contains(Jugadorvs.piezactual))
                                {
                                    if (Tabla.tabla[e - 3, i].Contains(Jugadorvs.piezactual))
                                    {
                                        Conecta4.ganador = true;
                                        Tabla.tablamostrar();
                                        if(Jugadorvs.piezactual == Jugadorvs.jugador1)
                                        {
                                            visualizacion.ganador();
                                            Console.Write("\n¡El jugador " + Jugadorvs.nombreactual[0] + " (J1) es el ganador!");
                                        }
                                        else if (Jugadorvs.piezactual == Jugadorvs.jugador2)
                                        {
                                            Console.WriteLine("\n¡El jugador "+ Jugadorvs.nombreactual[1] +" (J2) es el ganador!");
                                        }
                                        else
                                        {
                                            Console.WriteLine("¡El Bot es el ganador!");
                                        }
                                        Console.ReadKey();
                                    }
                                }
                            }
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
