using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositorio.Model;

namespace Repositorio.ViewModel
{
    class ViewModelAlumno:IViewModel<Alumno>
    {
        public Alumno ToBaseDatos()
        {
            throw new NotImplementedException();
        }

        public void FromBaseDatos(Alumno modelo)
        {
            throw new NotImplementedException();
        }

        public void UpdateBaseDatos(Alumno modelo)
        {
            throw new NotImplementedException();
        }
    }
}
