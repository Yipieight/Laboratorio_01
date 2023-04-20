using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        ejercicio1();
        Console.Clear();
        ejercicio2();
        Console.Clear();
        ejercicio3();
    }

    // Función para determinar si un número es primo

    public static void ejercicio2()
    {
        int N = 10; // Cambiar por el tamaño deseado del vector
        int[] vector = new int[N];

        // Solicitar al usuario que ingrese los valores del vector
        for (int i = 0; i < N; i++)
        {
            Console.Write("Ingrese el valor en la posición {0}: ", i);
            vector[i] = int.Parse(Console.ReadLine());
        }

        // Inicializar contadores
        int contador1 = 0; // 0-5
        int contador2 = 0; // 6-10
        int contador3 = 0; // 11-15
        int contador4 = 0; // 16-20

        // Contar los valores en cada rango
        for (int i = 0; i < N; i++)
        {
            if (vector[i] >= 0 && vector[i] <= 5)
            {
                contador1++;
            }
            else if (vector[i] >= 6 && vector[i] <= 10)
            {
                contador2++;
            }
            else if (vector[i] >= 11 && vector[i] <= 15)
            {
                contador3++;
            }
            else if (vector[i] >= 16 && vector[i] <= 20)
            {
                contador4++;
            }
        }

        // Mostrar resultados
        Console.WriteLine("Cantidad de valores en el rango 0-5: " + contador1);
        Console.WriteLine("Cantidad de valores en el rango 6-10: " + contador2);
        Console.WriteLine("Cantidad de valores en el rango 11-15: " + contador3);
        Console.WriteLine("Cantidad de valores en el rango 16-20: " + contador4);

        Console.ReadKey();
    }
    public static void ejercicio1()
    {
        int[] valores = { 85, 96, 65, 70, 55, 45, 62, 95, 74, 100, 74, 83, 93 };

        // Buscar valores primos
        Console.WriteLine("Posiciones de los valores primos:");
        for (int i = 0; i < valores.Length; i++)
        {
            if (EsPrimo(valores[i]))
            {
                Console.WriteLine(i);
            }
        }

        // Buscar múltiplos de 5
        Console.WriteLine("Posiciones de los valores múltiplos de 5:");
        for (int i = 0; i < valores.Length; i++)
        {
            if (valores[i] % 5 == 0)
            {
                Console.WriteLine(i);
            }
        }

        // Encontrar el menor valor
        int menor = valores[0];
        for (int i = 1; i < valores.Length; i++)
        {
            if (valores[i] < menor)
            {
                menor = valores[i];
            }
        }
        Console.WriteLine("El menor valor del arreglo es: " + menor);
        Console.ReadKey();
    }
    static bool EsPrimo(int n)
    {
        if (n <= 1)
        {
            return false;
        }
        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
            {
                return false;
            }
        }
        return true;
    }

    public static void ejercicio3()
    {
        int N = 40; // Tamaño de los vectores

        // Declarar los tres vectores de calificaciones
        double[] evaluacion1 = new double[N];
        double[] evaluacion2 = new double[N];
        double[] evaluacion3 = new double[N];

        // Solicitar al usuario que ingrese las calificaciones de cada evaluación
        for (int i = 0; i < N; i++)
        {
            Console.Write("Ingrese la calificación del estudiante {0} para la evaluación 1: ", i + 1);
            evaluacion1[i] = double.Parse(Console.ReadLine());

            Console.Write("Ingrese la calificación del estudiante {0} para la evaluación 2: ", i + 1);
            evaluacion2[i] = double.Parse(Console.ReadLine());

            Console.Write("Ingrese la calificación del estudiante {0} para la evaluación 3: ", i + 1);
            evaluacion3[i] = double.Parse(Console.ReadLine());
        }

        // Calcular la calificación final del curso para cada estudiante
        double[] calificacionesFinales = new double[N];
        for (int i = 0; i < N; i++)
        {
            double calificacionFinal = (evaluacion1[i] * 0.3) + (evaluacion2[i] * 0.3) + (evaluacion3[i] * 0.4);
            calificacionesFinales[i] = calificacionFinal;
        }

        // Mostrar las calificaciones finales en pantalla
        Console.WriteLine("Calificaciones finales del curso:");
        for (int i = 0; i < N; i++)
        {
            Console.WriteLine("Estudiante {0}: {1}", i + 1, calificacionesFinales[i]);
        }

        Console.ReadKey();
    }
}
