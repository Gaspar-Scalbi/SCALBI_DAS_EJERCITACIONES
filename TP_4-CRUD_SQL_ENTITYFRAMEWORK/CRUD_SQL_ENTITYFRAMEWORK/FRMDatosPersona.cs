using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRUD_SQL_ENTITYFRAMEWORK.Data;
using CRUD_SQL_ENTITYFRAMEWORK.Models;
using Microsoft.EntityFrameworkCore;
namespace CRUD_SQL_ENTITYFRAMEWORK
{
    public partial class FRMDatosPersona : Form
    {
        private int? id;
        public FRMDatosPersona(int? id = null)
        {
            InitializeComponent();
            this.id = id;
            if (id != null)
                CargarDatos();

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(id != null)
                ModificarPersona();
            
            else
                AgregarPersona();          
        }
        private void AgregarPersona()
        {
            using var db = new PersonaEfContext();
            var nuevaPersona = new PersonaEf
            {
                Nombre = txtnombre.Text.Trim(),
                Nacimiento = dtpDatosPersona.Value
            };
            db.PersonaEfs.Add(nuevaPersona);
            db.SaveChanges();
            this.Close();
        }
        private void ModificarPersona()
        {
            using var db = new PersonaEfContext();
            var persona = db.PersonaEfs.Find(id);
            if (persona != null)
            {
                persona.Nombre = txtnombre.Text.Trim();
                persona.Nacimiento = dtpDatosPersona.Value;
                db.SaveChanges();
            }
            this.Close();
        }
        private void CargarDatos()
        {
            using var db = new PersonaEfContext();
            var persona = db.PersonaEfs.AsNoTracking().FirstOrDefault(p => p.Id == id);
            if (persona is null) return;

            txtnombre.Text = persona.Nombre ?? string.Empty;

            if (persona.Nacimiento.HasValue)
            {
                dtpDatosPersona.Value = persona.Nacimiento.Value; 
                dtpDatosPersona.Checked = true;                   
            }
            else
            {
                dtpDatosPersona.Value = DateTime.Today;           
                dtpDatosPersona.Checked = false;                  
            }
        }
    }
}
