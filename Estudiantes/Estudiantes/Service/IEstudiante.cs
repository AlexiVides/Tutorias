using Estudiantes.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudiantes.Servici
{
    interface IEstudiante
    {
        //CRUD

        //C
        void Create(estudiante estudiante);

        //D
        void Delete(estudiante estudiante);

        void update(estudiante estudiante);

        List<estudiante> ListOfDataOfTbaleEstudiante();
    }
}
