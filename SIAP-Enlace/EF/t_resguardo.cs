//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SIAP_Enlace.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class t_resguardo
    {
        public int IdResguardo { get; set; }
        public int Usuario { get; set; }
        public string Ruta { get; set; }
    
        public virtual t_usuario t_usuario { get; set; }
    }
}
