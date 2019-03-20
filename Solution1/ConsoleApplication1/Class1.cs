using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Class1
    {
        public void MultiValores()
        {
            int valor1, valor2, mULT;
            Console.WriteLine("Ingrese El valor 1:");
            valor1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese El valor 2:");
            valor2 = int.Parse(Console.ReadLine());
            //mULT = valor1 * valor2;
            if (valor1 <= 0 && valor2 <= 0)
            {

                Console.WriteLine("El Producto de 0 por cualquier numero es 0");
            }
            else if (valor1 > 0 && valor2 > 0)
            {
                Console.WriteLine("Ingrese El valor de 2 :");
                mULT = valor1 * valor2;

            }
            else
            {
                Console.WriteLine("Error");
            }

        }
        public void DiviValore()
        {
            int valor1, valor2, Div;
            Console.WriteLine("Ingrese El valor 1:");
            valor1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese El valor 2:");
            valor2 = int.Parse(Console.ReadLine());
            
            if (valor1 <= 0 && valor2 <= 0)
            {

                Console.WriteLine("El Producto de 0 por cualquier numero es 0");
            }
            else if (valor1 > 0 && valor2 > 0)
            {
                Console.WriteLine("Ingrese El valor de 2 :");
                Div = valor1 / valor2;

            }
            else
            {
                Console.WriteLine("Error");
            }

        }
        public void Nombre()
        {
            String nombre1, nombre2, nombre3, nombre4, nombre5;
            Console.WriteLine("Ingrese Nombre1");
            nombre1 = Console.ReadLine();
            Console.WriteLine("Ingrese Nombre2");
            nombre2 = Console.ReadLine();
            Console.WriteLine("Ingrese Nombre3");
            nombre3 = Console.ReadLine();
            Console.WriteLine("Ingrese Nombre4");
            nombre4 = Console.ReadLine();
            Console.WriteLine("Ingrese Nombre5");
            nombre5 = Console.ReadLine();
        }
        public void Edad()
        {
            int edad1, edad2, edad3, edad4, edad5;
            Console.WriteLine("Ingrese Edad1");
            edad1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese Edad2");
            edad2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese Edad3");
            edad3 = int.Parse(Console.ReadLine()); 
            Console.WriteLine("Ingrese Edad4");
            edad4 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese Edad5");
            edad5 = int.Parse(Console.ReadLine());
        }
    }
}
