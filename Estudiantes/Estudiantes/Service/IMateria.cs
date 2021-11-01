using Estudiantes.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudiantes.Service
{
    interface IMateria
    {
        //CRUD

        //C
        void Create(materia materia);

        //D
        void Delete(materia materia);
    }
}
