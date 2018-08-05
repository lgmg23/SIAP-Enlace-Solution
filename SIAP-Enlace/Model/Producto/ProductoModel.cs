using SIAP_Enlace.Model.ProductoDetalles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIAP_Enlace.Model.Producto
{
    public class ProductoModel
    {
        public int IdProducto { get; set; }
        public virtual UsuarioModel Usuario { get; set; }
        public virtual UbicacionModel Ubicacion { get; set; }
        public virtual TipoModel Tipo { get; set; }
        public virtual MarcaModel Marca { get; set; }
        public string Modelo { get; set; }
        public string Serie { get; set; }
        public virtual SOModel SO { get; set; }
        public virtual AreaModel Area{ get; set; }
        public Boolean Estado { get; set; }
        public DateTime Adquisicion { get; set; }
        public string Factura { get; set; }
        public string NActivo { get; set; }
        public DateTime Garantia { get; set; }
        public virtual NombreEquipoModel NombreEquipo { get; set; }
        public string Caracteristicas { get; set; }
        public virtual ProveedorModel Proveedor { get; set; }
    }
}
