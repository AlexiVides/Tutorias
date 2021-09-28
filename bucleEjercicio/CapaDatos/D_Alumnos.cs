using System;
using System.Collections.Generic;
using CapaEntidades;

namespace CapaDatos
{
    public class D_Alumnos
    {
        List<E_Alumno> listaEstudiantes = new List<E_Alumno>();

        //Este metodo nos retorna una lista de tipo E_Alumno
        public List<E_Alumno> listaDeAlumnos() {

            //Si la lista ya tiene datos
            if (listaEstudiantes.Count != 0)
            {
                //nos retorna la lista con los datos que tenga
                return listaEstudiantes;
            }

            //Si la lista no tiene datos
            else
            {
                //Agrega estos datos
                listaEstudiantes.Add(new E_Alumno(1, "Wilfredo", "Morales", 19, 7.4)); //Posicion [0]
                listaEstudiantes.Add(new E_Alumno(2, "Cristian", "Figueroa", 18, 9.9)); //Posicion [1]
                listaEstudiantes.Add(new E_Alumno(3, "Wilfredo", "Calles", 20, 9.3)); //Posicion [2]
                listaEstudiantes.Add(new E_Alumno(4, "Kemberly", "Amaya", 19, 8.2)); //Posicion [3]
                listaEstudiantes.Add(new E_Alumno(5, "Eduardo", "Vasquez", 18, 7.5)); //Posicion [4]

                //Y los retorna
                return listaEstudiantes;
            }
        }

        //Este metodo recibe un Alumno para agregarlo en la lista
        public void AgregarAlumno(E_Alumno alumnoNuevo) {

            //El metodo ".Add()" agrega un elemento a la 
            //coleccion (lista).
            listaEstudiantes.Add(alumnoNuevo);

        }

        //Este metodo recibe un Alumno para editarlo en la lista
        public void EditarAlumno(E_Alumno alumnoEditado) {

            //Con este for se recorre cada elemento de la listaEstudiantes
            for (int i = 0; i < listaEstudiantes.Count; i++)
            {
               //En cada iteración se compara el Id de la lista
               //con el Id del alumno recibido(alumnoEditado)
                if (listaEstudiantes[i].Id == alumnoEditado.Id)
                {

                    //Cuando se encuentra el alumno, se reemplaza
                    //la vieja informacion con la nueva.
                    listaEstudiantes[i] = alumnoEditado;
                }
            }
        }

        //Este metodo elimina un alumno de la listaEstudiante
        public void EliminarAlumno(E_Alumno alumnoEliminado) {

            //El metodo RemoveAll busca en la listaEstudiantes
            //y cuando encuentra un dato que cumpla con la condicion "r.Id == alumno.Id"
            //lo borra de la lista
            listaEstudiantes.RemoveAll(r => r.Id == alumnoEliminado.Id);

        }

        //
        List<E_Alumno> listaMaestros = new List<E_Alumno>();

        //Este metodo nos retorna una lista de tipo E_Alumno
        public List<E_Alumno> listaDeMaestros()
        {

            //Si la lista ya tiene datos
            if (listaMaestros.Count != 0)
            {
                //nos retorna la lista con los datos que tenga
                return listaMaestros;
            }

            //Si la lista no tiene datos
            else
            {
                //Agrega estos datos
                listaMaestros.Add(new E_Alumno(1, "Adrian", "Zamora", 19, 9)); //Posicion [0]
                listaMaestros.Add(new E_Alumno(2, "Cristian", "Lemus", 18, 9)); //Posicion [1]
                listaMaestros.Add(new E_Alumno(3, "Elisa", "Palma", 20, 9)); //Posicion [2]
                listaMaestros.Add(new E_Alumno(4, "Sara", "Navarrete", 19, 9)); //Posicion [3]
                listaMaestros.Add(new E_Alumno(5, "Eduardo", "Tejada", 18, 9)); //Posicion [4]

                //Y los retorna
                return listaMaestros;
            }
        }

    }
}
