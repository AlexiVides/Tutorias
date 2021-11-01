using Estudiantes.Data;
using Estudiantes.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estudiantes.Reposity
{
    class ClsRMateria : IMateria
    {
        public void Create(materia materia)
        {
            using (EstudiantesEntities conexionBd = new EstudiantesEntities())
            {
                try
                {
                    materia mate = new materia();
                    mate.nombreMateria = materia.nombreMateria;

                    conexionBd.materia.Add(mate);
                    conexionBd.SaveChanges();
                    MessageBox.Show("Se a Registrado Correctamente");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error de base de datos " + ex);
                }
            }



        }

        public void Delete(materia materia)
        {
            throw new NotImplementedException();
        }
    }
}
