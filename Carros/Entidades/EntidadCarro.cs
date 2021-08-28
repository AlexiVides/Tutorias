using System;

namespace Entidades
{
    public class EntidadCarro
    {
        private int id;
        private string modelo;
        private string marca;
        private string transmición;
        private int año;
        private double precio;
        private int existencias;

        public int Id { get => id; set => id = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Transmición { get => transmición; set => transmición = value; }
        public int Año { get => año; set => año = value; }
        public double Precio { get => precio; set => precio = value; }
        public int Existencias { get => existencias; set => existencias = value; }

        public EntidadCarro() { }

        public EntidadCarro(int id, string modelo, string marca, string transmición, int año, double precio, int existencias)
        {
            this.id = id;
            this.modelo = modelo;
            this.marca = marca;
            this.transmición = transmición;
            this.año = año;
            this.precio = precio;
            this.existencias = existencias;
        }
    }
}
