//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SIAP_Enlace.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class t_producto
    {
        public int Id_Producto { get; set; }
        public int Usuario { get; set; }
        public int Ubicacion { get; set; }
        public int Tipo { get; set; }
        public int Marca { get; set; }
        public string Modelo { get; set; }
        public string Serie { get; set; }
        public int Sistema_Operativo { get; set; }
        public int Area { get; set; }
        public sbyte Estado { get; set; }
        public System.DateTime Adquisicion { get; set; }
        public string Factura { get; set; }
        public string NActivo { get; set; }
        public System.DateTime Garantia { get; set; }
        public int NombreEquipo { get; set; }
        public string Caracteristicas { get; set; }
        public int Proveedor { get; set; }
    
        public virtual t_area t_area { get; set; }
        public virtual t_marca t_marca { get; set; }
        public virtual t_nombreequipo t_nombreequipo { get; set; }
        public virtual t_proveedor t_proveedor { get; set; }
        public virtual t_so t_so { get; set; }
        public virtual t_tipo t_tipo { get; set; }
        public virtual t_ubicacion t_ubicacion { get; set; }
        public virtual t_usuario t_usuario { get; set; }
    }
}