using Cajero;
using GUIGerente1;
using JefeServicios;
using CamarasYRespaldos;
using Ejecutivo;
namespace LoginEstacionamiento
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void BTLimpiar_Click(object sender, EventArgs e)//Boton de limpiar
        {
            TBNombre.Clear();
            TBPass.Clear();
        }

        private void BTLogin_Click(object sender, EventArgs e)//Boton de Inciciar sesion
        {
            string nombreUsuario;
            string passUsuario;
            nombreUsuario = TBNombre.Text;
            passUsuario = TBPass.Text;
            if (nombreUsuario == "Juan" && passUsuario == "qwerty" || nombreUsuario == "Santiago" && passUsuario == "qwerty" || nombreUsuario == "Camilo" && passUsuario == "qwerty")//Ejecutivos de servicios
            {
                this.Hide();
                FRMEjecutivoServicios fRMEjecutivoServicios = new FRMEjecutivoServicios();
                fRMEjecutivoServicios.Show();

                
            }
            else if (nombreUsuario == "Emanuel" && passUsuario == "qwerty")//Camara y Respaldos
            {              
                this.Hide();
                FRMCamaraYRespaldo fRMCamaraYRespaldo = new FRMCamaraYRespaldo();
                fRMCamaraYRespaldo.Show();
            }
            else if (nombreUsuario == "Fabrizio" && passUsuario == "qwerty")//Gerente
            {
                this.Hide();
                FRMGerente fRMGerente = new FRMGerente();
                fRMGerente.Show();
            }
            else if (nombreUsuario == "Ignacio" && passUsuario == "qwerty")//Cajero
            {
                this.Hide();
                FRMCajero fRMCajero = new FRMCajero();
                fRMCajero.Show();
            }
            else if (nombreUsuario == "Maria" && passUsuario == "qwerty" || nombreUsuario == "Jose" && passUsuario == "qwerty")//Jefe de servicios
            { 
                this.Hide();
                FRMJefeServicios fRMJefeServicios = new FRMJefeServicios();
                fRMJefeServicios.Show();
            }
            else
            {
                MessageBox.Show("Nombre usuario o contraseña incorrectos");
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}