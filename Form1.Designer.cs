namespace LoginEstacionamiento
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            LBNombre = new Label();
            label1 = new Label();
            TBPass = new TextBox();
            TBNombre = new TextBox();
            BTLimpiar = new Button();
            BTLogin = new Button();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.BackColor = Color.Wheat;
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-2, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(228, 628);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.AIOLogo;
            pictureBox1.Location = new Point(0, 106);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(228, 190);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // LBNombre
            // 
            LBNombre.AutoSize = true;
            LBNombre.BackColor = Color.Wheat;
            LBNombre.Location = new Point(542, 79);
            LBNombre.Name = "LBNombre";
            LBNombre.Size = new Size(151, 15);
            LBNombre.TabIndex = 1;
            LBNombre.Text = "Ingrese Nombre de Usuario";
            LBNombre.Click += label1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Wheat;
            label1.Location = new Point(559, 236);
            label1.Name = "label1";
            label1.Size = new Size(108, 15);
            label1.TabIndex = 2;
            label1.Text = "Ingrese Contraseña";
            // 
            // TBPass
            // 
            TBPass.Location = new Point(542, 306);
            TBPass.Name = "TBPass";
            TBPass.PasswordChar = '*';
            TBPass.Size = new Size(151, 23);
            TBPass.TabIndex = 3;
            // 
            // TBNombre
            // 
            TBNombre.Location = new Point(542, 131);
            TBNombre.Name = "TBNombre";
            TBNombre.Size = new Size(151, 23);
            TBNombre.TabIndex = 4;
            // 
            // BTLimpiar
            // 
            BTLimpiar.Location = new Point(537, 393);
            BTLimpiar.Name = "BTLimpiar";
            BTLimpiar.Size = new Size(75, 23);
            BTLimpiar.TabIndex = 5;
            BTLimpiar.Text = "Limpiar";
            BTLimpiar.UseVisualStyleBackColor = true;
            BTLimpiar.Click += BTLimpiar_Click;
            // 
            // BTLogin
            // 
            BTLogin.Location = new Point(632, 393);
            BTLogin.Name = "BTLogin";
            BTLogin.Size = new Size(75, 23);
            BTLogin.TabIndex = 6;
            BTLogin.Text = "Login";
            BTLogin.UseVisualStyleBackColor = true;
            BTLogin.Click += BTLogin_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.menu;
            pictureBox2.Location = new Point(26, 1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(935, 628);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(960, 631);
            Controls.Add(BTLogin);
            Controls.Add(BTLimpiar);
            Controls.Add(TBNombre);
            Controls.Add(TBPass);
            Controls.Add(label1);
            Controls.Add(LBNombre);
            Controls.Add(panel1);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FormLogin";
            Text = "Login";
            Load += FormLogin_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label LBNombre;
        private Label label1;
        private TextBox TBPass;
        private TextBox TBNombre;
        private Button BTLimpiar;
        private Button BTLogin;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}
