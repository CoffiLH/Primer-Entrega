using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIGerente1
{
    public partial class FRMGerente : Form
    {

        public FRMGerente()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        //Boton Agregar Cliente
        private void button1_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = true;
            textBox6.Visible = true;
            button1.Visible = true;
            button2.Visible = true;
            label7.Visible = false;
            textBox7.Visible = false;
            button3.Visible = false;
            label8.Visible = true;
            textBox8.Visible = true;
        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        //Boton Quitar Cliente
        private void quitarCbtn_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            label7.Visible = true;
            textBox7.Visible = true;
            button3.Visible = true;
            label8.Visible = false;
            textBox8.Visible = false;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {


        }
        //Boton Modificar Cliente
        private void modificarCbtn_Click(object sender, EventArgs e)
        {
            label8.Visible = true;
            textBox8.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = true;
            textBox6.Visible = true;
            button1.Visible = true;
            button2.Visible = true;
            label7.Visible = false;
            textBox7.Visible = false;
            button3.Visible = false;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
        //Boton check Parking
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           
            // Cambiar el estado de los controles según el CheckBox
            numericUpDown1.Enabled = checkBox1.Checked;
            label11.Enabled = checkBox1.Checked;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }
        //BOTON SERVICIO
        private void button4_Click(object sender, EventArgs e)
        {
            label9.Visible = true;
            label10.Visible = true;
            label11.Visible = true;
            textBox9.Visible = true;
            textBox10.Visible = true;
            checkBox1.Visible = true;
            checkBox2.Visible = true;
            checkBox3.Visible = true;
            numericUpDown1.Visible = true;
            panel8.Visible = false;
            button8.Visible = true;    
            button9.Visible = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0) { 
            label13.Visible = true;
            label14.Visible = true;           
            comboBox2.Visible = true;            
            numericUpDown2.Visible = true;
            label15.Visible = false;
            numericUpDown3.Visible = false;
            }
          else  if (comboBox1.SelectedIndex == 1)
            {
                label13.Visible = true;
                label14.Visible = false;
                comboBox2.Visible = true;
                numericUpDown2.Visible = false;
                label15.Visible = true;
                numericUpDown3.Visible = true;
            }
           else if (comboBox1.SelectedIndex == 3)
            {
                label13.Visible = true;
                label14.Visible = false;
                comboBox2.Visible = true;
                numericUpDown2.Visible = false;
                label15.Visible = false;
                numericUpDown3.Visible = false;
            }

        }
        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtener el valor seleccionado


            // Realizar una acción según la opción seleccionada
            if (comboBox1.SelectedIndex == 0)
            {
                
            }
            else if (comboBox1.SelectedIndex == 1)
            {
               
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                
            }
            else
            {
                MessageBox.Show("Opción no válida.");
            }
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {
          
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            InitializeComponent();
            comboBox1.Items.Add("Moto");
            comboBox1.Items.Add("Auto");
            comboBox1.Items.Add("Camioneta");
            comboBox1.Items.Add("Pequeño camión");
            comboBox1.Items.Add("Pequeño utilitario");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel11.Visible = false;
            panel8.Visible = true;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            textBox9.Visible = false;
            textBox10.Visible = false;
            checkBox1.Visible = false;
            checkBox2.Visible = false;
            checkBox3.Visible = false;
            numericUpDown1.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            label12.Visible = true;
            label13.Visible = true;
            label14.Visible = true;
        
        }

        private void comboBox2_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            panel11.Visible = true;
            panel8.Visible = false;
            label19.Visible = true;
            label16.Visible = true;
            textBox11.Visible = true;  
            textBox12.Visible = true;
            panelVentaN.Visible = false;
        }

        

       

      

        private void button11_Click(object sender, EventArgs e)
        {
            panelVentaN.Visible = true;
            panel11.Visible = true;
            panel8.Visible = false;
            panel14.Visible = false;

        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            panel14.Visible = true;
          
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {

        }
    }
}