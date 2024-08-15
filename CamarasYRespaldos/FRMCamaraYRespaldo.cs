using System;
using System.Drawing;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;

namespace CamarasYRespaldos
{
    public partial class FRMCamaraYRespaldo : Form
    {
        private VideoCaptureDevice videoSource;

        public FRMCamaraYRespaldo()
        {
            InitializeComponent();
            LoadCameraList();
        }

        private void LoadCameraList()
        {
            // Lista de nombres de cámaras
            string[] cameraNames = new string[]
            {
                "CamaraEntrada1",
                "CamaraEntrada2",
                "CamaraGerencia",
                "CamaraLavadero",
                "CamaraTaller",
                "CamaraDeposito",
                "CamaraMotos",
                "CamaraRampaPrimerPiso",
                "CamaraAfueraSalaDeMaquinas",
                "CamaraPrimerPiso",
                "CamaraRampaSegundoPiso",
                "CamaraSegundoPiso1",
                "CamaraSegundoPiso2"
            };

            // Generar URLs de cámaras IP con nombres amigables
            for (int i = 0; i < cameraNames.Length; i++)
            {
                string cameraName = cameraNames[i];
                string cameraIP = $"192.168.3.{30 + i}";
                string cameraURL = $"rtsp://{cameraIP}/stream";

                // Añadir un objeto anónimo con nombre y URL al ComboBox
                comboBox1.Items.Add(new CameraItem { Name = cameraName, URL = cameraURL });
            }

            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "URL";

            comboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (videoSource != null && videoSource.IsRunning)
            {
                videoSource.SignalToStop();
                videoSource = null;
            }

            // Obtener la URL de la cámara seleccionada
            CameraItem selectedCamera = (CameraItem)comboBox1.SelectedItem;
            string cameraURL = selectedCamera.URL;

            videoSource = new VideoCaptureDevice(cameraURL);
            videoSource.NewFrame += new NewFrameEventHandler(VideoSource_NewFrame);
            videoSource.Start();
        }

        private void VideoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            pictureBox1.Image = bitmap;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }

                if (videoSource != null && videoSource.IsRunning)
                {
                    videoSource.SignalToStop();
                    videoSource = null;
                }
            }
            base.Dispose(disposing);
        }

        // Clase auxiliar para almacenar la información de la cámara
        private class CameraItem
        {
            public string Name { get; set; }
            public string URL { get; set; }

            // Sobrescribir ToString para mostrar el nombre en el ComboBox
            public override string ToString()
            {
                return Name;
            }
        }

        private void backupButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Backup realizado.");
            // Define la cadena de conexión a tu base de datos
            //string connectionString = "Data Source=Servidor;Initial Catalog=NombreBaseDeDatos;User ID=NombreUsuario;Password=LaContraseña";

            // Define la ubicación y el nombre del archivo de respaldo
            //string backupFileName = $"C:\\backups\\Backup_{DateTime.Now:yyyyMMddHHmmss}.bak";

            // Define la consulta para hacer el respaldo
            //string backupQuery = $"BACKUP DATABASE [NombreBaseDeDatos] TO DISK = '{backupFileName}' WITH FORMAT";

            // Ejecuta la consulta
            //using (SqlConnection connection = new SqlConnection(connectionString))
            //{
            //    SqlCommand command = new SqlCommand(backupQuery, connection);
            //    try
            //    {
            //        connection.Open();
            //        command.ExecuteNonQuery();
            //        MessageBox.Show("Respaldo de base de datos completado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show($"Error al realizar el respaldo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
        }
    }
}