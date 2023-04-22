using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EjerciciosLib
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //EJERCICIOS PRÁCTICOS CAP 2


            /*1 Hacer un programa que le pida a
			La computadora un número y responda si
			es par o impar.*/

            /*int numero;
            Console.WriteLine("Dame un numero");
            numero = Convert.ToInt32(Console.ReadLine());
            if ((numero % 2) == 0)
            {
                Console.WriteLine("El numero es par");
            }
            else
            {
                Console.WriteLine("El numero es impar");

            }
            Console.WriteLine();*/

            /*2 Hacer un programa que transforme de
			grados a radianes o de radianes a grados
			dependiendo de lo que necesite el
			usuario.*/

            /*float num = 0.0f;
            int opcion;

            Console.WriteLine("ingresa un numero");
            num = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("1. para convertir de grados a radianes");
            Console.WriteLine("2. para convertir de radianes a grados");
            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.WriteLine(num + " grados equivale a " + (num * 0.017453) + " radianes");
                    break;
                case 2:
                    Console.WriteLine(num + " radianes equivale a " + (num * 57.2957) + " grados");
                    break;
                default:
                    Console.WriteLine("Opcion no valida");
                    break;
            }*/

            /*3 Hacer un programa que calcule el
		   Impuesto de un producto, pero coloque
		   Un impuesto del 0 % si el producto es
		   Medicina.*/
            /*float imp = 0.15f;
            string item = "pan";
            string med= "ibuprofeno";
            float precio = 0.0f;
            string producto;
            float total = 0.0f;


            Console.WriteLine("Ingrese el producto");
           producto= Console.ReadLine();


            Console.WriteLine("Ingrese el precio");
            precio = Convert.ToSingle(Console.ReadLine());


            if (producto ==item)
            {
                total =precio + precio * imp;
            }
            else if (producto ==med) 
            {
                total = precio;
            }

            Console.WriteLine("El total a pagar son {0} Bs. ", total);*/


            /*4 Hacer un programa que le pida al usuario
			Un número del 1 al 7 y escriba el nombre
			Del día que corresponde ese número en la
			Semana.*/

            int num;
            Console.WriteLine("Ingresa un numero");
            num =Convert.ToInt32(Console.ReadLine());

            switch (num)
            {
                case 1:
                    Console.WriteLine("Es lunes");
                    break;
                case 2:
                    Console.WriteLine("Es martes");
                    break;
                case 3:
                    Console.WriteLine("Es miercoles");
                    break;
                case 4:
                    Console.WriteLine("Es jueves");
                    break;
                case 5:
                    Console.WriteLine("Es viernes");
                    break;
                case 6:
                    Console.WriteLine("Es sabado");
                    break;
                case 7:
                    Console.WriteLine("Es domingo");
                    break;
                default:
                    Console.WriteLine("no es un dia");
                    break;
            }

             /*5 Hacer una programa que pueda calcular
			El perimetro y el área de cualquier
			Polígono regular, pero que le prequnte al
			Usuario qué desea calcular.*/



            Console.ReadKey();

        }
    }
}
