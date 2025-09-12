using System;
using System.Collections.Generic;
using CRUD_SQL_ENTITYFRAMEWORK.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUD_SQL_ENTITYFRAMEWORK.Data;

public partial class PersonasEfContext : DbContext
{
    public PersonasEfContext()
    {
    }

    public PersonasEfContext(DbContextOptions<PersonasEfContext> options)
        : base(options)
    {
    }

    public virtual DbSet<PersonasEf> PersonasEfs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=GASPAR-SCALBI\\SQLEXPRESS;Database=PersonasEF;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
