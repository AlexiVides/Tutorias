using Estudiantes.Data;
using Estudiantes.Reposity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudiantes.Negocio
{
    class ClsEstudiante : ClsREstudiante
    {
        public void Guardar(estudiante es)
        {
            Create(es);
        }

        public List<estudiante> ListFinal()
        {
            List<estudiante> list = ListOfDataOfTbaleEstudiante();
            return list;
        }

        public void DeleteInformacion(estudiante es)
        {
            Delete(es);
        }

        public void UpdateInformation(estudiante es)
        {
            update(es);
        }
    }
}
