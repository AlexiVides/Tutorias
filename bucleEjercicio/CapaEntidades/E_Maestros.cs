using System;
using System.Collections.Generic;
using System.Text;

namespace CapaEntidades
{
    class E_Maestros
    {
        private int id;
        private string nombres;
        private string apellidos;
        private int edad;
        private string carrera;

        public int Id { get => id; set => id = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Carrera { get => carrera; set => carrera = value; }

        public E_Maestros() { }

        public E_Maestros(int id, string nombres, string apellidos, int edad, string carrera)
        {
            this.id = id;
            this.nombres = nombres;
            this.apellidos = apellidos;
            this.edad = edad;
            this.carrera = carrera;
        }
    }
}
