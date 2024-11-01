using ABMMascotas.Datos;
using ABMMascotas.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//CURSO – LEGAJO – APELLIDO – NOMBRE

namespace ABMMascotas.Presentacion
{
    public partial class FrmMascota : Form
    {
        public AccesoDatos accesoDatos;
        public FrmMascota()
        {
            InitializeComponent();
            accesoDatos = new AccesoDatos();
            ConfigureDataGridView();
            
        }
        private void ConfigureDataGridView()
        {
            dgvMascotas.Columns.Clear();
            dgvMascotas.Columns.Add("codigo", "Código");
            dgvMascotas.Columns.Add("nombre", "Nombre");
            dgvMascotas.Columns.Add("nombreEspecie", "Especie");
        }
        private void FrmMascota_Load(object sender, EventArgs e)
        {
            CargarCombo();
        }
        private void CargarCombo()
        {
            DataTable dataTable = accesoDatos.ConsultarTabla("Especies");
            cboEspecie.DataSource = dataTable;
            cboEspecie.ValueMember = dataTable.Columns[0].ColumnName;
            cboEspecie.DisplayMember = dataTable.Columns[1].ColumnName;
            cboEspecie.SelectedIndex = -1;
        }
        private void CargarGrilla(string consultaSQL)
        {
            DataTable dataTable = accesoDatos.ConsultarBD(consultaSQL);
            dgvMascotas.Rows.Clear();
            foreach (DataRow row in dataTable.Rows)
            {
                dgvMascotas.Rows.Add(row["codigo"], row["nombre"], row["nombreEspecie"]);
            }
        }
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            bool hasWhereClause = false;
            string consultaSQL = "select m.codigo, m.nombre, e.nombreEspecie from mascotas m join especies e on m.especie = e.idEspecie";
            if (!string.IsNullOrEmpty(cboEspecie.Text))
            {
                consultaSQL += " WHERE e.nombreEspecie = '" + cboEspecie.Text + "'";
                hasWhereClause = true;
            }
            if (rbtMacho.Checked)
            {
                if (hasWhereClause)
                {
                    consultaSQL += " AND m.sexo = 1";
                }
                else
                {
                    consultaSQL += " WHERE m.sexo = 1";
                    hasWhereClause = true;
                }
            }
            if(chkTodos.Checked == true)
            {
                cboEspecie.Enabled = false;
                rbtHembra.Enabled = false;
                rbtMacho.Enabled = false;
                consultaSQL = "select m.codigo, m.nombre, e.nombreEspecie from mascotas m join especies e on m.especie = e.idEspecie";
            }
            if (rbtHembra.Checked)
            {
                if (hasWhereClause)
                {
                    consultaSQL += " AND m.sexo = 2";
                }
                else
                {
                    consultaSQL += " WHERE m.sexo = 2";
                }
            }
            CargarGrilla(consultaSQL);
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro de que quieres salir?","Confirmar salida",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Close(); // Cierra la aplicación si el usuario elige "Sí"
            }
            // Si el usuario elige "No", no se hace nada y la aplicación sigue corriendo
        }
        

        private void btnDetalles_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(dgvMascotas.CurrentRow.Cells[0].Value);
            FrmDetalle frmDetalle = new FrmDetalle(codigo, Modo.Ver);
            frmDetalle.ShowDialog();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmDetalle frm = new FrmDetalle(0, Modo.Nuevo);
            frm.ShowDialog();
        }

        private void chkTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTodos.Checked == true)
            {
                cboEspecie.Enabled = false;
                cboEspecie.SelectedIndex = -1;
                rbtHembra.Enabled = false;
                rbtMacho.Enabled = false;
                rbtHembra.Checked = false;
                rbtMacho.Checked = false;
            }
            if (chkTodos.Checked == false)
            {
                cboEspecie.Enabled = true;
                cboEspecie.SelectedIndex = -1;
                rbtHembra.Enabled = true;
                rbtMacho.Enabled = true;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvMascotas.CurrentRow != null) // Verificar si hay una fila seleccionada
            {
                int codigo = Convert.ToInt32(dgvMascotas.CurrentRow.Cells[0].Value);
                FrmDetalle frmDetalle = new FrmDetalle(codigo, Modo.Editar);
                frmDetalle.ShowDialog();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una mascota antes de editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (dgvMascotas.CurrentRow != null) // Verificar si hay una fila seleccionada
            {
                int codigo = Convert.ToInt32(dgvMascotas.CurrentRow.Cells[0].Value);
                FrmDetalle frmDetalle = new FrmDetalle(codigo, Modo.Borrar);
                frmDetalle.ShowDialog();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una mascota antes de borrar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        } 
        private void cboEspecie_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void grpFiltros_Enter(object sender, EventArgs e)
        {

        }
        private void dgvMascotas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        
    }
}
