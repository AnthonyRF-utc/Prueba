using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudiantes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Acumuladores y contadores
            //int contador = 0;

            //contador = contador + 1;
            //contador++; // 0 1 2 3
            //++contador; //0 1 2 3 
            //--contador; //0 1 2 3
            //contador--; //0 1 2 3

            ////Acumuladores
            //// Salarios = 100, 300, 500
            //float salarios = 0;
            //float total = 0;

            //total = total + salarios;
            //total += salarios;
            //total += 5;
            //total *= salarios;
            //total *= 3;
            //total /= 6;

            ////Ciclos for
            //for (int i = 0; i < 100; i+=5)
            //{
            //    Console.WriteLine(i);

            //}
            //Console.ReadLine();

            //Arreglos

            // hacer un algoritmo que calcule el promedio de la nota promedio de todos los estudiantes
            //Calcular la cantidad de estudiantes ue tienen una nota superior al promedio
            // 4 estudiantes, formula la suma de notas dividido la cantidad de estudiantes

            string[] esttudiantes = new string[4];
            float[] notas = new float[4];
            float promedio = 0;
            float contador = 0;
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Digite el nombre:");
                esttudiantes[i] = Console.ReadLine();
                Console.WriteLine("Digite la nota:");
                notas[i] = float.Parse(Console.ReadLine());
                promedio += notas[i];
                
            }
            promedio /= esttudiantes.Length;

            Console.WriteLine( $"El promedio es de {promedio} ");
            //Calcular la cantidad de estudiantes que tienen una nota superior al promedio

            contador = 0;
            for (int i = 0; i < notas.Length; i++)
            {
                if (notas[i] > promedio)
                {
                    Console.WriteLine($"Nombre: {esttudiantes[i]} nota: {notas[i]}");
                    contador++;
                }
            }
            Console.WriteLine($"Estudiantes con nota superior al promedio: {contador}");

            Console.ReadLine();
        }
    }
}
