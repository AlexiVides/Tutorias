using Estudiantes.Data;
using Estudiantes.Servici;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estudiantes.Reposity
{
    class ClsREstudiante : IEstudiante
    {
        public void Create(estudiante estudiante)
        {
            using (EstudiantesEntities conexionBd = new EstudiantesEntities())
            {
                try
                {
                    estudiante est = new estudiante();
                    est.nombresEstudiante = estudiante.nombresEstudiante;
                    est.apellidos = estudiante.apellidos;
                    est.usuario = estudiante.usuario;
                    est.contrasenia = estudiante.contrasenia;
                    

                    conexionBd.estudiante.Add(est);
                    conexionBd.SaveChanges();
                    MessageBox.Show("Se a Registrado Correctamente" );
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error de base de datos" + ex);
                }
            }
        }

        public void Delete(estudiante estudiante)
        {
            using (EstudiantesEntities conexionBd = new EstudiantesEntities())
            {
                estudiante = conexionBd.estudiante.Find(estudiante.idEstudiante);
                conexionBd.estudiante.Remove(estudiante);
                conexionBd.SaveChanges();
            }
        }

        public List<estudiante> ListOfDataOfTbaleEstudiante()
        {
            using (EstudiantesEntities conexionBd = new EstudiantesEntities())
            {
                List<estudiante> ListofData = conexionBd.estudiante.ToList();
                //Es como decir
                //select * from estudinte
                return ListofData;
            }
            
        }

        public void update(estudiante estudiante)
        {
            using (EstudiantesEntities conexionBd = new EstudiantesEntities())
            {
                estudiante es = conexionBd.estudiante.Find(estudiante.idEstudiante);
                es.nombresEstudiante = estudiante.nombresEstudiante;
                es.apellidos = estudiante.apellidos;
                es.usuario = estudiante.usuario;
                es.contrasenia = estudiante.contrasenia;
                conexionBd.SaveChanges();
                MessageBox.Show("Update");
            }
        }
    }
}
