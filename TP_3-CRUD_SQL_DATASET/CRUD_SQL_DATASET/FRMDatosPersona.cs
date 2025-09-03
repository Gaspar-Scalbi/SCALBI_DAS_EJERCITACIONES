using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_SQL_DATASET
{
    public partial class FRMDatosPersona : Form
    {
        private int? id;
        public FRMDatosPersona(int? id = null)
        {
            InitializeComponent();
            this.id = id;
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bdCrudTableAdapters.PersonaTableAdapter TableAdapter = new bdCrudTableAdapters.PersonaTableAdapter();
            if (id != null)
                TableAdapter.ModificarPersona(txtnombre.Text.Trim(), (int)nudEdad.Value, (int)id);
            else
                TableAdapter.AgregarPersona(txtnombre.Text.Trim(), (int)nudEdad.Value);
            this.Close();
        }

        private void FRMDatosPersona_Load(object sender, EventArgs e)
        {
            if (id != null)
            {
                bdCrudTableAdapters.PersonaTableAdapter TableAdapter = new bdCrudTableAdapters.PersonaTableAdapter();
                bdCrud.PersonaDataTable tabla = TableAdapter.ObtenerDatosID((int)id);
                if (tabla.Rows.Count == 1)
                {
                    txtnombre.Text = tabla[0].nombre; 
                    nudEdad.Value = tabla[0].edad;
                }
            }
        }
    }
}
