using System;
using System.Collections.Generic;
using CRUD_SQL_ENTITYFRAMEWORK.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUD_SQL_ENTITYFRAMEWORK.Data;

public partial class PersonaEfContext : DbContext
{
    public PersonaEfContext()
    {
    }

    public PersonaEfContext(DbContextOptions<PersonaEfContext> options)
        : base(options)
    {
    }

    public virtual DbSet<PersonaEf> PersonaEfs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=RCAL1306P11-111;Initial Catalog=PersonaEf;Integrated Security=True;Persist Security Info=False;Pooling=False;Multiple Active Result Sets=False;Encrypt=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
