﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace softcomputacion.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BDSoftComputacionEntities : DbContext
    {
        public BDSoftComputacionEntities()
            : base("name=BDSoftComputacionEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<categoria> categoria { get; set; }
        public virtual DbSet<cliente> cliente { get; set; }
        public virtual DbSet<detallePago> detallePago { get; set; }
        public virtual DbSet<detalleVenta> detalleVenta { get; set; }
        public virtual DbSet<estado> estado { get; set; }
        public virtual DbSet<historialStock> historialStock { get; set; }
        public virtual DbSet<metodoPago> metodoPago { get; set; }
        public virtual DbSet<producto> producto { get; set; }
        public virtual DbSet<proveedor> proveedor { get; set; }
        public virtual DbSet<proveedorXproducto> proveedorXproducto { get; set; }
        public virtual DbSet<reparacion> reparacion { get; set; }
        public virtual DbSet<subcategoria> subcategoria { get; set; }
        public virtual DbSet<tipoUsuario> tipoUsuario { get; set; }
        public virtual DbSet<usuario> usuario { get; set; }
        public virtual DbSet<valorUSD> valorUSD { get; set; }
        public virtual DbSet<venta> venta { get; set; }
    }
}
