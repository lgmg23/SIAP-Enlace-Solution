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
    
    public partial class t_marca
    {
        public t_marca()
        {
            this.t_producto = new HashSet<t_producto>();
        }
    
        public int Id_Marca { get; set; }
        public string Marca { get; set; }
    
        public virtual ICollection<t_producto> t_producto { get; set; }
    }
}