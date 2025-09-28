using System.Security.Cryptography.X509Certificates;

namespace ado_multiplestablas
{
    public partial class Form1 : Form
    {
        RepositorioPasajes repositorioPasajes = new RepositorioPasajes();
        public Form1()
        {
            InitializeComponent();
            RefrescarAviones();
            RefrescarPasajeros();
            RefrescarPasajes();
        }

        public void RefrescarPasajeros()
        {
            dgvTablaPasajeros.DataSource = repositorioPasajes.ListarPasajeros();
        }

        public void RefrescarAviones()
        {
            dgvTablaAviones.DataSource = repositorioPasajes.ListarAviones();

        }

        public void RefrescarPasajes()
        {
            dgvTablaPasajes.DataSource = repositorioPasajes.ListarPasajes();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
