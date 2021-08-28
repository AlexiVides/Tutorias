using System;
using Entidades;
using Negocios;

namespace Vista
{
    class Venta
    {
        static void Main(string[] args)
        {
            EntidadCarro carro = new EntidadCarro();

            NegociosCarros negocios = new NegociosCarros();



            Console.WriteLine("Bienvenido a Nuestra  empresa \n¿Que carro deseas comprar?" +
                "\n1-Toyota Hilux Bigo 3L" +
                "\n2-Toyota 4Runner" +
                "\n3-Honda Accura" +
                "\n4-Honda Civic" +
                "\n5-Nissan Frontier" +
                "\n6-Nissan Rogue");

            carro.Id = int.Parse(Console.ReadLine());

            carro = negocios.negocios_BuscarCarrosPorId(carro);

            if (carro == null)
            {
                Console.WriteLine("Lo sentimos ese carro no lo tenemos a la venta :(");
            }
            else
            {
                Console.WriteLine("Datos del carro que comprará" +
                    "\nMarca: " + carro.Marca +
                    "\nModelo: " + carro.Modelo +
                    "\nTransmición: " + carro.Transmición +
                    "\nAño: " + carro.Año +
                    "\nPrecio: " + carro.Precio +
                    "\nExistencias: " + carro.Existencias);

                Console.WriteLine("¿Cuántos carros comprará?");
                int cantidad = int.Parse(Console.ReadLine());

                Console.WriteLine("Usted comprará " + cantidad + " unidades de " + carro.Marca + " " + carro.Modelo + " año " + carro.Año + ".");
                Console.WriteLine("Procesando...");

                carro = negocios.VenderCarro(carro, cantidad);

                if (carro != null)
                {
                    Console.WriteLine("\nAhora quedan " + carro.Existencias + " existencias de este carro.");
                }
            }

        }
    }
}
