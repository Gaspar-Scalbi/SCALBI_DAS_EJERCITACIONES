namespace CRUD_SQL_DATASET
{
    public partial class TABLA : Form
    {
        public TABLA()
        {
            InitializeComponent();
            Refrescar();
        }

        public void Refrescar()
        {
            bdCrudTableAdapters.PersonaTableAdapter TableAdapter = new bdCrudTableAdapters.PersonaTableAdapter();
            bdCrud.PersonaDataTable tabla = TableAdapter.GetData();
            dgvTabla.DataSource = tabla;
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            Refrescar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FRMDatosPersona frmDatosPersona = new FRMDatosPersona();
            frmDatosPersona.ShowDialog();
            Refrescar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int? id = ObtenerId();
            if (id != null)
            {
                FRMDatosPersona frmDatosPersona = new FRMDatosPersona(id);
                frmDatosPersona.ShowDialog();
                Refrescar();
            }
        }


        private int? ObtenerId()
        {
            try
            {
                return int.Parse(dgvTabla.Rows[dgvTabla.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch
            {
                return null;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            int? id = ObtenerId();
            if (id != null)
            {
                bdCrudTableAdapters.PersonaTableAdapter TableAdapter = new bdCrudTableAdapters.PersonaTableAdapter();
                TableAdapter.EliminarPersona((int)id);
                Refrescar();
            }
        }

        private void TABLA_Load(object sender, EventArgs e)
        {

        }
    }
}
