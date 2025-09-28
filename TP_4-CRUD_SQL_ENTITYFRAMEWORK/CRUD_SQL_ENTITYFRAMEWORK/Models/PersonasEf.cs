using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CRUD_SQL_ENTITYFRAMEWORK.Models;

[Table("PersonaEF")]
public partial class PersonaEf
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("nombre")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Nombre { get; set; }

    [Column("nacimiento", TypeName = "datetime")]
    public DateTime? Nacimiento { get; set; }
}

