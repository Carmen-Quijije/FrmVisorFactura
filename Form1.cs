using Factura.Clases;

namespace Factura
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGrabarCliente_Click(object sender, EventArgs e)
        {
            if (ValidarDatosCliente()){
                Cliente objCliente = new Cliente(txtCedula.Text,
                    txtNombres.Text,
                    txtDireccion.Text,
                    txtTelefono.Text,
                    txtMail.Text
                    );
                FrmVisorFactura objVisor = new FrmVisorFactura();
                objVisor.objClienteForm = objCliente;
                objVisor.ShowDialog();



                //MessageBox.Show($"Cliente {objCliente.Nombres} grabado exitosamente");
            }
        }

        private bool ValidarDatosCliente()
        {
            if (txtCedula.Text.Length != 10)
            {
                MessageBox.Show("La c�dula ingresada no es v�lida");
                txtCedula.Focus();
                return false;
            }
            if (txtNombres.Text.Length == 0)
            {
                MessageBox.Show("Ingrese sus nombres");
                txtNombres.Focus();
                return false;
            }
            if (txtDireccion.Text.Length == 0)
            {
                MessageBox.Show("Ingrese su direcci�n");
                txtDireccion.Focus();
                return false;
            }
            if (txtTelefono.Text.Length == 0)
            {
                MessageBox.Show("Ingrese n�mero de tel�fono");
                txtTelefono.Focus();
                return false;
            }
            if (txtMail.Text.Length == 0)
            {
                MessageBox.Show("Ingrese su mail");
                txtMail.Focus();
                return false;
            }
            return true;
        }
                
    }
}
