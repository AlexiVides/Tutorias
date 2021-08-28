using System;
using Entidades;
using Datos;
namespace Negocios
{
    public class NegociosCarros
    {
        DatosCarros datos = new DatosCarros();

        public EntidadCarro negocios_BuscarCarrosPorId(EntidadCarro carro)
        {
            if (carro.Id < 1 || carro.Id > 6)
            {
                return null;
            }
            else
            {
                carro = datos.buscarCarroPorId(carro);

                if (carro == null)
                {
                    return null;
                }
                else
                {
                    return carro;
                }

            }
        }

        public double TotalVenta(double precio, int cantidad)
        {
            double total;
            total = precio * cantidad;

            return total;
        }

        public EntidadCarro VenderCarro(EntidadCarro carro, int cantidad)
        {
            if (cantidad > carro.Existencias)
            {
                Console.WriteLine("Lo sentimos! No puedes comprar más de " + carro.Existencias + " unidades de este carro.");
                return null;
            }
            else
            {
                carro = datos.venderCarro(carro, cantidad);

                Console.WriteLine("Se vendieron " + cantidad + " unidades de " + carro.Marca + " " + carro.Modelo + " año " + carro.Año + "." +
               "\nTotal: $" + TotalVenta(carro.Precio, cantidad).ToString("00000.00"));

                return carro;
            }

        }

    }
}
