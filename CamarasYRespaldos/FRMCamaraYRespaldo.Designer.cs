namespace CamarasYRespaldos
{
    partial class FRMCamaraYRespaldo
    {
        private System.ComponentModel.IContainer components = null;
        private PictureBox pictureBox1;

        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            comboBox1 = new ComboBox();
            backupButton = new Button();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(234, 41);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(724, 545);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(389, 12);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(409, 23);
            comboBox1.TabIndex = 2;
            // 
            // backupButton
            // 
            backupButton.Location = new Point(29, 335);
            backupButton.Name = "backupButton";
            backupButton.Size = new Size(166, 23);
            backupButton.TabIndex = 3;
            backupButton.Text = "RealizarRespaldoBD";
            backupButton.UseVisualStyleBackColor = true;
            backupButton.Click += backupButton_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImageLayout = ImageLayout.None;
            pictureBox2.Image = Properties.Resources.menu;
            pictureBox2.Location = new Point(-1, -4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(959, 590);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.AIOLogo;
            pictureBox3.Location = new Point(-1, 101);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(229, 201);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(958, 584);
            Controls.Add(pictureBox3);
            Controls.Add(backupButton);
            Controls.Add(comboBox1);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Name = "Form1";
            Text = "Camaras y Respaldos";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        private ComboBox comboBox1;
        private Button backupButton;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}
