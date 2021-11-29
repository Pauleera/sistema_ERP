using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidades;
using CapaNegocio;


namespace CapaPresentacion
{
    public partial class FrmProveedor : Form
    {
        private string idproveedor;
        private bool Editarse = false;

        E_Proveedor objEntidad = new E_Proveedor();
        N_Proveedor objNegocio = new N_Proveedor();

        public FrmProveedor()
        {
            InitializeComponent();
        }

        private void cerrarFormulario_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void FrmProveedor_Load(object sender, EventArgs e)
        {
           
            mostrarBuscarTabla("");
            accionesTabla();
        }

        public void accionesTabla()
        {


            tablaProveedores.Columns[0].Visible = false;
            tablaProveedores.Columns[4].Visible = false;
            tablaProveedores.Columns[5].Visible = false;

            tablaProveedores.Columns[1].Width = 40;
            tablaProveedores.Columns[2].Width = 80;
            tablaProveedores.Columns[3].Width = 80;
            tablaProveedores.Columns[6].Width = 70;
            tablaProveedores.Columns[7].Width = 60;

            tablaProveedores.ClearSelection();
        }

        public void mostrarBuscarTabla(string buscar)
        {
            N_Proveedor objNegocio = new N_Proveedor();
            tablaProveedores.DataSource = objNegocio.ListandoProveedor(buscar);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            mostrarBuscarTabla(txtBuscar.Text);
        }

        private void limpiarCajas()
        {

            Editarse = false;
            txtRut.Text = "";
            txtNombre.Text = "";
            txtRazonSocial.Text = "";
            txtDireccion.Text = "";
            txtCiudad.Text = "";
            txtEmail.Text = "";
            txtContacto.Text = "";
            
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiarCajas();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if(tablaProveedores.SelectedRows.Count > 0)
            {
                Editarse = true;
                idproveedor = tablaProveedores.CurrentRow.Cells[0].Value.ToString();
                txtRut.Text = tablaProveedores.CurrentRow.Cells[1].Value.ToString();
                txtNombre.Text = tablaProveedores.CurrentRow.Cells[2].Value.ToString();
                txtRazonSocial.Text = tablaProveedores.CurrentRow.Cells[3].Value.ToString();
                txtDireccion.Text = tablaProveedores.CurrentRow.Cells[4].Value.ToString();
                txtCiudad.Text = tablaProveedores.CurrentRow.Cells[5].Value.ToString();
                txtEmail.Text= tablaProveedores.CurrentRow.Cells[6].Value.ToString();
                txtContacto.Text = tablaProveedores.CurrentRow.Cells[7].Value.ToString();

            }
            else
            {
                MessageBox.Show("Seleccione el proveedor que desea editar");
            }


        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(Editarse  == false)
            {
                try
                {
                    objEntidad.Rutproveedor = txtRut.Text.ToUpper();
                    objEntidad.Nombreproveedor = txtNombre.Text.ToUpper();
                    objEntidad.Razonsocialproveedor = txtRazonSocial.Text.ToUpper();
                    objEntidad.Direccionproveedor = txtDireccion.Text.ToUpper();
                    objEntidad.Ciudadproveedor = txtCiudad.Text.ToUpper();
                    objEntidad.Emailproveedor = txtEmail.Text.ToUpper();
                    objEntidad.Contactoproveedor = txtContacto.Text.ToUpper();

                    objNegocio.InsertandoProveedor(objEntidad);

                    MessageBox.Show("Proveedor guardado");

                    mostrarBuscarTabla("");
                    limpiarCajas();

                }

                catch(Exception ex)
                {
                    MessageBox.Show("No se pudo guardar"+ ex);
                }
            }

            if (Editarse)
            {
                try
                {

                    objEntidad.Idproveedor = Convert.ToInt32(idproveedor);
                    objEntidad.Rutproveedor = txtRut.Text.ToUpper();
                    objEntidad.Nombreproveedor = txtNombre.Text.ToUpper();
                    objEntidad.Razonsocialproveedor = txtRazonSocial.Text.ToUpper();
                    objEntidad.Direccionproveedor = txtDireccion.Text.ToUpper();
                    objEntidad.Ciudadproveedor = txtCiudad.Text.ToUpper();
                    objEntidad.Emailproveedor = txtEmail.Text.ToUpper();
                    objEntidad.Contactoproveedor = txtContacto.Text.ToUpper();

                    objNegocio.EditandoProveedor(objEntidad);

                    MessageBox.Show("Se edito el proveedor");

                    mostrarBuscarTabla("");
                    limpiarCajas();

                    Editarse = false;
                }

                catch (Exception ex)
                {
                    MessageBox.Show("No se editar guardar" + ex);
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
