﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class siapgapEntities : DbContext
    {
        public siapgapEntities()
            : base("name=siapgapEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<t_almacen> t_almacen { get; set; }
        public virtual DbSet<t_area> t_area { get; set; }
        public virtual DbSet<t_marca> t_marca { get; set; }
        public virtual DbSet<t_producto> t_producto { get; set; }
        public virtual DbSet<t_proveedor> t_proveedor { get; set; }
        public virtual DbSet<t_resguardo> t_resguardo { get; set; }
        public virtual DbSet<t_so> t_so { get; set; }
        public virtual DbSet<t_tipo> t_tipo { get; set; }
        public virtual DbSet<t_ubicacion> t_ubicacion { get; set; }
        public virtual DbSet<t_usuario> t_usuario { get; set; }
    }
}
