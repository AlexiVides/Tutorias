using System;
using Entidades;
namespace Datos
{
    public class DatosCarros
    {
        EntidadCarro carro1 = new EntidadCarro(1, "Hilux Bigo 3.0L", "Toyota", "Estándar", 2018, 30000.00, 5);
        EntidadCarro carro2 = new EntidadCarro(2, "4Runner", "Toyota", "Automática", 2020, 25000.00, 10);
        EntidadCarro carro3 = new EntidadCarro(3, "Accura", "Honda", "Secuencial", 2015, 15000.00, 8);
        EntidadCarro carro4 = new EntidadCarro(4, "Civic", "Honda", "Automática", 2020, 18000.00, 15);
        EntidadCarro carro5 = new EntidadCarro(5, "Frontier", "Nissan", "Estándar", 2016, 20000.00, 7);
        EntidadCarro carro6 = new EntidadCarro(6, "Rogue", "Nissan", "Atomática", 2021, 27000.00, 20);

        public EntidadCarro buscarCarroPorId(EntidadCarro carro)
        {
            if (carro.Id == 1)
            {
                carro = carro1;
                return carro;
            }
            else if (carro.Id == 2)
            {
                carro = carro2;
                return carro;
            }
            else if (carro.Id == 3)
            {
                carro = carro3;
                return carro;
            }
            else if (carro.Id == 4)
            {
                carro = carro4;
                return carro;
            }
            else if (carro.Id == 5)
            {
                carro = carro5;
                return carro;
            }
            else if (carro.Id == 6)
            {
                carro = carro6;
                return carro;
            }
            else
                return null;
        }

        public EntidadCarro venderCarro(EntidadCarro carro, int cantidad)
        {
            carro.Existencias = (carro.Existencias - cantidad);

            return carro;
        }
    }
}
