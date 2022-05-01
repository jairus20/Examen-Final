using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    interface IMantenimiento
    {
        // Metoddos
        bool Agregar();
        bool Eliminar();
        bool Actualizar();
        string Listar();
        string Buscar();
    }
}
