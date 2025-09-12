using CRUD_SQL_ENTITYFRAMEWORK.Data;
using CRUD_SQL_ENTITYFRAMEWORK.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
namespace CRUD_SQL_ENTITYFRAMEWORK
{
    public partial class TABLA : Form
    {
        private readonly PersonasEfContext personaDB = new();

        public TABLA()
        {
            InitializeComponent();
        }

        private async void TABLA_Load(object sender, EventArgs e)
        {
            using var db = new PersonasEfContext();              // <- equivalente a CrudEntities
            var datos = await db.PersonasEfs                      // DbSet generado por el scaffold
                .AsNoTracking()
                .OrderBy(p => p.Nombre)
                .ToListAsync();
            dgvTabla.DataSource = datos;
            dgvTabla.Columns["Nacimiento"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvTabla.Columns["Nacimiento"].DefaultCellStyle.NullValue = "";
        }
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            personaDB.Dispose();     // cerrás la conexión al cerrar la ventana
            base.OnFormClosed(e);
        }

        #region HELPER
        private void Refrescar()
        {
            using var db = new PersonasEfContext();              // <- equivalente a CrudEntities
            var datos = db.PersonasEfs                           // DbSet generado por el scaffold
                .AsNoTracking()
                .OrderByDescending(p => p.Id)
                .ToList();
            dgvTabla.DataSource = datos;

        }

        #endregion

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FRMDatosPersona frmPersona = new FRMDatosPersona();
            frmPersona.ShowDialog();
            Refrescar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvTabla.CurrentRow != null)
            {
                int id = (int)dgvTabla.CurrentRow.Cells["Id"].Value;
                var persona = personaDB.PersonasEfs.Find(id);
                if (persona != null)
                {
                    FRMDatosPersona frmPersona = new FRMDatosPersona(id);
                    frmPersona.ShowDialog();
                    Refrescar();
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvTabla.CurrentRow != null)
            {
                int id = (int)dgvTabla.CurrentRow.Cells["Id"].Value;
                var persona = personaDB.PersonasEfs.Find(id);
                if (persona != null)
                {
                    var confirmResult = MessageBox.Show("¿Estás seguro de eliminar a " + persona.Nombre + "?", "Confirmar eliminación", MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        personaDB.PersonasEfs.Remove(persona);
                        personaDB.SaveChanges();
                        Refrescar();
                    }
                }
            }
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            Refrescar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
