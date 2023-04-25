using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

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
            if (string.IsNullOrEmpty(partidasamostrar[0]))
            {
                visualizacion.ganadores();
                Console.SetCursorPosition(27,10);
                Console.WriteLine("No hay partidas guardadas todavia...");
            }
            else
            {
                visualizacion.ganadores();
                for (int i = 0; i < 10; i++)
                {
                    Console.SetCursorPosition(30, fila);
                    Console.WriteLine(partidasamostrar[i]);
                    fila += 1;
                }
            }
            Console.ReadKey();
        }
    }
}
