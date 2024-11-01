using ABMMascotas.Datos;
using ABMMascotas.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABMMascotas.Presentacion
{
    public enum Modo
    {
        Nuevo,
        Ver,
        Editar,
        Borrar
    }
    public partial class FrmDetalle : Form
    {
        int codigo;
        Modo accion;
        AccesoDatos accesoDatos = new AccesoDatos();
        Mascota mascota = new Mascota();
        List <Parametro> parametros = new List <Parametro>();
        public FrmDetalle()
        {
            InitializeComponent();
            if(accion != Modo.Nuevo)
            {
                txtCodigo.Enabled = false;
            }
            else
            {
                txtCodigo.Enabled = true;
            }
        }
        public FrmDetalle(int codigo, Modo accion)
        {
            InitializeComponent();
            this.codigo = codigo;
            this.accion = accion;
            if (accion != Modo.Nuevo)
            {
                txtCodigo.Enabled = false;
            }
            else
            {
                txtCodigo.Enabled = true;
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro de que quieres salir?","Confirmar salida",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Close(); // Cierra la aplicación si el usuario elige "Sí"
            }
            // Si el usuario elige "No", no se hace nada y la aplicación sigue corriendo
        }
        private void FrmDetalle_Load(object sender, EventArgs e)
        {
            CargarCombo();
            if (accion != Modo.Nuevo)
            {
                CargarMascota(codigo);
                if (accion == Modo.Ver || accion == Modo.Borrar)
                {
                    txtCodigo.Enabled = false;
                    txtNombre.Enabled = false;
                    cboEspecie.Enabled = false;
                    rbtMacho.Enabled = false;
                    rbtHembra.Enabled = false;
                    dtpFechaNacimiento.Enabled = false;
                }
            }

        }
        private void CargarMascota(int codigo)
        {
            string consultaSQL = "SELECT * FROM Mascotas WHERE codigo = " + codigo;
            DataTable dataTable = accesoDatos.ConsultarBD(consultaSQL);
            if (dataTable.Rows.Count > 0)
            {
                DataRow dataRow = dataTable.Rows[0];
                mascota.Codigo = Convert.ToInt32(dataRow[0]);
                mascota.Nombre = Convert.ToString(dataRow[1]);
                mascota.Especie = new Especie {Codigo = Convert.ToInt32(dataRow[2]) };
                mascota.Sexo = Convert.ToInt32(dataRow[3]);
                mascota.FechaNacimiento = Convert.ToDateTime(dataRow[4]);

                txtCodigo.Text = Convert.ToString(mascota.Codigo);
                txtNombre.Text = mascota.Nombre;
                cboEspecie.SelectedValue = mascota.Especie.Codigo;
                if (mascota.Sexo == 1)
                {
                    rbtMacho.Checked = true;
                }
                else
                {
                    rbtHembra.Checked = true;
                }
                dtpFechaNacimiento.Text = mascota.FechaNacimiento.ToString();
            }
        }
        private void CargarCombo()
        {
            DataTable dataTable = accesoDatos.ConsultarTabla("Especies");
            cboEspecie.DataSource = dataTable;
            cboEspecie.ValueMember = dataTable.Columns[0].ColumnName;
            cboEspecie.DisplayMember = dataTable.Columns[1].ColumnName;
            cboEspecie.SelectedIndex = -1;
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            mascota.Codigo = Convert.ToInt32( txtCodigo.Text);
            mascota.Nombre = txtNombre.Text;
            mascota.Especie = new Especie { Codigo = Convert.ToInt32(cboEspecie.SelectedValue) };
            DateTime fechaSeleccionada = dtpFechaNacimiento.Value;
            if (fechaSeleccionada > DateTime.Today)
            {
                MessageBox.Show("La fecha de nacimiento no puede ser mayor a la fecha actual.", "Fecha no válida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Detener la ejecución si la fecha no es válida
            }
            if (cboEspecie.Text == "Roedor" && rbtHembra.Checked == true)
            {
                MessageBox.Show("No se pueden agregar hámsters femeninos.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Detener el proceso si la validación falla
            }
            if (rbtHembra.Checked == true)
            {
                mascota.Sexo = 2;
            }
            else
            {
                mascota.Sexo = 1;
            }
            dtpFechaNacimiento.Text = mascota.FechaNacimiento.ToString();
            if (accion == Modo.Nuevo)
            {
                NuevaMascota();
            }
            else if (accion == Modo.Editar)
            {
                EditarMascota(mascota.Codigo);
            }
            else if (accion == Modo.Borrar)
            {
                EliminarMascota(mascota.Codigo);
            }
            Close();
        }
        private void EliminarMascota(int codigo)
        {
            string consultaSQL = "delete from mascotas where codigo = " + codigo;
            int filasAfectadas = accesoDatos.ActualizarBD(consultaSQL);
            if (filasAfectadas == 0)
            {
                MessageBox.Show("No se ha podido eliminar.");
            }
            else
            {
                MessageBox.Show("Mascota eliminada correctamente");
            }
            Close();
        }
        private void EditarMascota(int codigo)
        {
            string consultaSQL = "update mascotas set nombre = " +
                "@Nombre, especie = @especie, sexo = @sexo, fechaNacimiento = @fechaNacimiento where codigo = " + codigo;
            parametros.Add(new Parametro("@codigo", mascota.Codigo));
            parametros.Add(new Parametro("@nombre", mascota.Nombre));
            parametros.Add(new Parametro("@especie", mascota.Especie.Codigo));
            parametros.Add(new Parametro("@sexo", mascota.Sexo));
            parametros.Add(new Parametro("@fechaNacimiento", mascota.FechaNacimiento));
            int filasAfectadas = accesoDatos.ActualizarBD(consultaSQL, parametros);
            if (filasAfectadas == 0)
            {
                MessageBox.Show("No se ha editado la mascota.");
            }
            else
            {
                MessageBox.Show("Mascota editada.");
            }
        }
        private void NuevaMascota()
        {
            string consultaSQL = "insert into mascotas (codigo, nombre, especie, sexo, fechaNacimiento) Values (@codigo, @nombre, @especie, @sexo, @fechaNacimiento)";
            parametros.Add(new Parametro("@codigo", mascota.Codigo));
            parametros.Add(new Parametro("@nombre", mascota.Nombre));
            parametros.Add(new Parametro("@especie", mascota.Especie.Codigo));
            parametros.Add(new Parametro("@sexo", mascota.Sexo));
            parametros.Add(new Parametro("@fechaNacimiento", mascota.FechaNacimiento));
            int filasAfectadas = accesoDatos.ActualizarBD(consultaSQL, parametros);
            if (filasAfectadas == 0)
            {
                MessageBox.Show("No se ha guardado la mascota.");
            }
            else
            {
                MessageBox.Show("Mascota guardada.");
            }
        }
        private void cboEspecie_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
