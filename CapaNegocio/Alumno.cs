using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Alumno : Persona ,IMantenimiento
    {
        private string seguro;
        private string escuela;


        public string Escuela { get => escuela; set => escuela = value; }
        public string Seguro { get => seguro; set => seguro = value; }

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

        public string Estudiar()
        {
            return "El metodo estudiar no ha sido implementado";
        }

        public string Listar()
        {
            throw new NotImplementedException();
        }
    }
}
