﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace API_EF.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class bdApiEfEntities : DbContext
    {
        public bdApiEfEntities()
            : base("name=bdApiEfEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Equipo> Equipo { get; set; }
        public virtual DbSet<Jugador> Jugador { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
    }
}
