﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_02
{
    class Jugadorvs
    {
        
        public static string jugador1 = "o";
        public static string jugador2 = "x";
        public static int columna = 0;
        public static void colocarpieza()
        {
            Console.WriteLine("Ingrese en que columna desea colocar una ficha en la tabla");
            columna = int.Parse(Console.ReadLine());
            Tabla.tablacolocar();
        }
        
    }
}
