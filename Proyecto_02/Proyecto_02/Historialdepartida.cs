using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;

namespace Proyecto_02
{
    internal class Historialdepartida
    {
        public static string[] partidasamostrar = new string[10];
        public static void guardarhistorialdepartida(string partidas)
        {
            for(int i = 9; i >= 1; i--)
            {
                partidasamostrar[i] = partidasamostrar[i-1];
            }
            partidasamostrar[0] = partidas;
        }
        public static void mostrarhistorialdepartida()
        {
            int fila = 10;
            if(partidasamostrar[0].Contains("USER"))
            {
                visualizacion.ganadores();
                for (int i = 0; i <= 11; i++)
                {
                    if(i < 10)
                    {
                        Console.SetCursorPosition(29, fila);
                        Console.WriteLine(partidasamostrar[i]);
                        Thread.Sleep(300);
                        fila += 1;
                    }
                    else if (i == 11)
                    {
                        Console.SetCursorPosition(28, fila);
                        Console.WriteLine("No hay partidas guardadas todavia...");
                    }
                    else
                    {
                        fila += 1;
                    }

                }
                //Console.WriteLine("\n\t\t\t\t      ▄▀▄     ▄▀▄" +
                //    "\r\n\t\t\t\t     ▄█░░▀▀▀▀▀░░█▄" +
                //    "\r\n\t\t\t\t ▄▄  █░░░░░░░░░░░█  ▄▄" +
                //    "\r\n\t\t\t\t█▄▄█ █░░▀░░┬░░▀░░█ █▄▄█" +
                //    "\r\n\t\t\t\t▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀");
            }
            else
            {
                visualizacion.ganadores();
                for (int i = 0; i < 10; i++)
                {
                    Console.SetCursorPosition(29, fila);
                    Console.WriteLine(partidasamostrar[i]);
                    Thread.Sleep(300);
                    fila += 1;
                }
            }
            Console.ReadKey();
        }

        public static void crearpartidasguardadas()
        {
            for(int i = 0; i < 10; i++)
            {
                partidasamostrar[i] = "00" + "       " + "USER" + "       " + "00" + "      " + "00:00";
            }
        }
    }
}
