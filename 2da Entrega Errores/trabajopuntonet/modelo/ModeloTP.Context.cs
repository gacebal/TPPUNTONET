﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace modelo
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ModeloTPContainer : DbContext
    {
        public ModeloTPContainer()
            : base("name=ModeloTPContainer")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Gerente> GerenteSet { get; set; }
        public virtual DbSet<Factor> FactorSet { get; set; }
        public virtual DbSet<Categoria> CategoriaSet { get; set; }
        public virtual DbSet<Proyecto> ProyectoSet { get; set; }
    }
}