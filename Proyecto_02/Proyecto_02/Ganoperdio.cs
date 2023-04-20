using System;
using System.Collections.Generic;
using System.Linq;
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
                    if (Tabla.tabla[e, i].Contains(Jugadorvs.piezactual))
                    {
                        if (Tabla.tabla[e-1, i].Contains(Jugadorvs.piezactual))
                        {
                            if (Tabla.tabla[e-2, i].Contains(Jugadorvs.piezactual))
                            {
                                if (Tabla.tabla[e-3, i].Contains(Jugadorvs.piezactual))
                                {
                                    Conecta4.ganador = true;
                                    Tabla.tablamostrar();
                                    Console.WriteLine("\n¡El jugador 1 o 2 es el ganador!");
                                    Console.ReadKey();

                                }
                                else
                                {
                                    i = Tabla.tabla.GetLength(1);
                                    e = -1;
                                    Tabla.tablamostrar();
                                }
                            }
                            else
                            {
                                i = Tabla.tabla.GetLength(1);
                                e = -1;
                                Tabla.tablamostrar();
                            }
                        }
                        else
                        {
                            i = Tabla.tabla.GetLength(1);
                            e = -1;
                            Tabla.tablamostrar();
                        }
                    }
                    else
                    {
                        i = Tabla.tabla.GetLength(1);
                        e = -1;
                        Tabla.tablamostrar();
                    }
                }
            }
        }
    }
}
