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
            //EJERCICIOS PRÁCTICOS CAP 3 TOMA DE DECISIONES


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
            //string[] item = new string[5] { "pan", "queso", "pasta", "atun", "pollo" };
            //string[] med = new string[5] { "atamel", "ibuprofeno", "loartan", "vitamina c", "alcohol" };

            /*float imp = 0.15f;
			string item, med, producto;
			float precio = 0.0f;
			float total = 0.0f;
			int opcion;

			Console.WriteLine("Tipo de producto \n 1- Item \n 2- Medicina");
			opcion = Convert.ToInt32(Console.ReadLine());
			
			Console.WriteLine("Ingrese el producto");
			producto= Console.ReadLine();

			Console.WriteLine("Ingrese el precio");
			precio = Convert.ToSingle(Console.ReadLine());


			if (opcion ==1)
			{
				total = precio + precio * imp;
			}
			else if (opcion ==2) 
			{
				total = precio;
			}

			Console.WriteLine("El total a pagar por el {0} son {1} Bs. ", producto, total);*/


            /*4 Hacer un programa que le pida al usuario
			Un número del 1 al 7 y escriba el nombre
			Del día que corresponde ese número en la
			Semana.*/

            /*int num;
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
			}*/

            /*5 Hacer una programa que pueda calcular
		   El perimetro y el área de cualquier
		   Polígono regular, pero que le prequnte al
		   Usuario qué desea calcular.*/

            float perimetro, area, lado, N, ap = 0.0f;
            int opcion;

            Console.WriteLine("¿Que desea calcular?");
            Console.WriteLine("1- Area \n2- Perimetro");
            opcion = Convert.ToInt32(Console.ReadLine());

            if (opcion == 1)
            {
                Console.WriteLine("Dame el valor de un lado en cmts");
                lado = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("Dame la cantidad de lados");
                N = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("Dame el valor de la apotema en ctms");
                ap = Convert.ToSingle(Console.ReadLine());

                area = lado * N * ap / 2;
                Console.WriteLine("El area a calcular es {0} cm² ", area);
            }
            else if (opcion == 2)
            {
                Console.WriteLine("Dame el valor de un lado en cmts");
                lado = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("Dame la cantidad de lados");
                N = Convert.ToSingle(Console.ReadLine());

                perimetro = lado * N;
                Console.WriteLine("El perimtro a calcular es {0} cm ", perimetro);
            }

            //EJERCICIOS PRÁCTICOS CAP 4 CICLOS







            Console.ReadKey();

        }
    }
}
