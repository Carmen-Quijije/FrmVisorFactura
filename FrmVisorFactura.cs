using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Factura.Clases;

namespace Factura
{
    public partial class FrmVisorFactura : Form
    {
        public Cliente objClienteForm;
        public FrmVisorFactura()
        {
            InitializeComponent();
        }

        private void FrmVisorFactura_Load(object sender, EventArgs e)
        {
            lblCedula.Text = objClienteForm.Cedula;
            lblNombres.Text = objClienteForm.Nombres;
            lblDireccion.Text = objClienteForm.Direccion;
            lblTelefono.Text = objClienteForm.Telefono;
            lblMail.Text = objClienteForm.Email;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
           this.Dispose();

        }
    }
}
