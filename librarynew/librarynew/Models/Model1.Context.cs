﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace librarynew.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class nitlibraryEntities1 : DbContext
    {
        public nitlibraryEntities1()
            : base("name=nitlibraryEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<author> authors { get; set; }
        public virtual DbSet<category> categories { get; set; }
        public virtual DbSet<publisher> publishers { get; set; }
        public virtual DbSet<book> books { get; set; }
        public virtual DbSet<issuebook> issuebooks { get; set; }
        public virtual DbSet<returnbook> returnbooks { get; set; }
        public virtual DbSet<member> members { get; set; }
    }
}