using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Ingresante : Alumno, IMantenimiento
    {
        private string puestoExamenIn;
        private string metodoIngreso;

        public string PuestoExamenIn { get => puestoExamenIn; set => puestoExamenIn = value; }
        public string MetodoIngreso { get => metodoIngreso; set => metodoIngreso = value; }

        public bool Actualizar()
        {
            throw new NotImplementedException();
        }

        public bool Agregar()
        {
            throw new NotImplementedException();
        }

        public string Buscar()
        {
            throw new NotImplementedException();
        }

        public bool Eliminar()
        {
            throw new NotImplementedException();
        }

        public string Listar()
        {
            throw new NotImplementedException();
        }
    }
}
