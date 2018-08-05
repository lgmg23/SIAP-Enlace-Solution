using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIAP_Enlace.Model.ProductoDetalles
{
    public class NombreEquipoModel
    {
        public int IdNombreEquipo { get; set; }
        public string NombreEquipo { get; set; }
        public virtual UsuarioModel Usuario { get; set; }
    }
}
