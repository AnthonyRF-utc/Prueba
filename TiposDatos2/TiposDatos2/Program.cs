using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TiposDatos2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // tipos de datos

            int num1, num2;
            num1 = 56;
            byte b = 255;
            short cortos = 65;
            long larga = 1313131313131;
            float flotante = 3.14f;
            double dobles = 56.1145236655554444d;
            decimal deci = 569.45m;
            Boolean boleano = true; // falso y verdadero
            string caadena = "Hoy es miercoles20 de septiembre";
            char caracter = 'S';

            // Tipos de datos dinamicos (var & dinamics)

            var variable = 20;


            dynamic dinamica = 30;
            dinamica = true;
            dinamica = "Hola mundo";
            dinamica = 'b';

            int resultado;
            num1 = 5;
            num2 = 8;
            resultado = num1 + num2;

            Console.WriteLine(resultado); // esta linea imprime el resultado
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("La suma es de: "+ (num1+num2));
            Console.WriteLine("________________________");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("La resta de {0}-{1} es de:{2} ", num1, num2, num1 - num2 );  //parametro
                   //                                             0    1      2
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("________________________");
            Console.ReadLine();
            Console.WriteLine($"La multiplicacion de {num1} * {num2} = {num1*num2}" ); // interpolacion
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("________________________");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Digite su nombre: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("Digite el monto del prestamo");
            float monto = float.Parse(Console.ReadLine());

            if (monto <= 500000)
            {
                monto = monto * 1.05f;
                Console.WriteLine("Digite los meses");
                int meses = int.Parse(Console.ReadLine());
                float cuota = monto / meses;
                Console.WriteLine($"El monto a pagar por mes es de {cuota} con un interes del 5%");
                Console.WriteLine();
            }
            else if (monto>500000 && monto<=1000000)
            {
                monto = monto * 1.13f;
                Console.WriteLine("Digite los meses");
                int meses = int.Parse(Console.ReadLine());
                float cuota = monto / meses;
                Console.WriteLine($"El monto a pagar por mes es de {cuota} con un interes del 13%");
                Console.WriteLine();
            }
         
            
            
            
            //int edad = int.Parse(Console.ReadLine());        //convertir texto a entero
            //double salario = double.Parse(Console.ReadLine());    //convertir texto a doble
            //byte dias = byte.Parse(Console.ReadLine());         //convertir texto a byte

            //int mes = 2;
            //string meses = mes.ToString();  //convertir un numero a texto
            //string meses2 = Convert.ToString(mes);  // convertir un numero a texto

            Console.ReadLine();  //La pantalla espera


        }
    }
}
