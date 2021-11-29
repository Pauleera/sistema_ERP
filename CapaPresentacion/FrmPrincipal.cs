using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        public void PantallaOk()
        {
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            PantallaOk();
        }

        private void btnCerrarTodo_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void SeleccionandoBotones(Bunifu.Framework.UI.BunifuFlatButton sender)
        {
            btnDashboard.Textcolor = Color.White;
            btnExistencias.Textcolor = Color.White;
            btnClientes.Textcolor = Color.White;
            btnProveedores.Textcolor = Color.White;
            btnLibroVentas.Textcolor = Color.White;
            btnKardex.Textcolor = Color.White;

            sender.selected = true;

            if (sender.selected)
            {
                sender.Textcolor = Color.FromArgb(98, 195, 140);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void btnProveedores_Click(object sender, EventArgs e)
        {
            SeleccionandoBotones((Bunifu.Framework.UI.BunifuFlatButton)sender);
            AbrirFormularioEnWrapper(new FrmProveedor());
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            SeleccionandoBotones((Bunifu.Framework.UI.BunifuFlatButton)sender);
            AbrirFormularioEnWrapper(new FrmDashboard());
        }

        private void btnExistencias_Click(object sender, EventArgs e)
        {
            SeleccionandoBotones((Bunifu.Framework.UI.BunifuFlatButton)sender);
            AbrirFormularioEnWrapper(new FrmExistencias());
        }

        private void btnKardex_Click(object sender, EventArgs e)
        {
            SeleccionandoBotones((Bunifu.Framework.UI.BunifuFlatButton)sender);
            AbrirFormularioEnWrapper(new FrmKardex());
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            SeleccionandoBotones((Bunifu.Framework.UI.BunifuFlatButton)sender);
        }

        private void btnLibroVentas_Click(object sender, EventArgs e)
        {
            SeleccionandoBotones((Bunifu.Framework.UI.BunifuFlatButton)sender);
            AbrirFormularioEnWrapper(new FrmLibroVentas());
        }


        private Form formActivado = null;

        private void AbrirFormularioEnWrapper(Form FormHijo)
        {
            if(formActivado != null)
            {
                formActivado.Close();
            }
            formActivado = FormHijo;
            FormHijo.TopLevel = false;
            FormHijo.Dock = DockStyle.Fill;
            Wrapper.Controls.Add(FormHijo);
            Wrapper.Tag = FormHijo;
            FormHijo.BringToFront();
            FormHijo.Show();

        }

        private void btnIngresarCompra_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnWrapper(new FrmCompra());
        }

        private void btnEmitirVenta_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnWrapper(new frmVenta());
        }

        private void btnPlandeCuentas_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnWrapper(new frmPlanDeCuentas());
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
           
        }

        private void Slidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnWrapper(new frmPersonal());
        }

        private void Wrapper_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
            AbrirFormularioEnWrapper(new FrmRemun());
        }
    }
}
