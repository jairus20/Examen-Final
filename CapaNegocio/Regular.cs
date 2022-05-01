using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Regular : Alumno ,IMantenimiento
    {
        private int numSemestre;
        private int creditos;
        private int cursosAprobados;
        private int cursosDesaprobados;

        public int NumSemestre { get => numSemestre; set => numSemestre = value; }
        public int Creditos { get => creditos; set => creditos = value; }
        public int CursosAprobados { get => cursosAprobados; set => cursosAprobados = value; }
        public int CursosDesaprobados { get => cursosDesaprobados; set => cursosDesaprobados = value; }

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
