namespace Factura
{
    partial class FrmVisorFactura
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVisorFactura));
            label1 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            lblCedula = new Label();
            lblDireccion = new Label();
            lblTelefono = new Label();
            lblMail = new Label();
            btnSalir = new Button();
            lblNombres = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Khaki;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Sitka Banner", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkBlue;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(441, 46);
            label1.TabIndex = 0;
            label1.Text = "Datos Cliente";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label5
            // 
            label5.Font = new Font("Sitka Banner", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 247);
            label5.Name = "label5";
            label5.Size = new Size(85, 31);
            label5.TabIndex = 9;
            label5.Text = "Mail:";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.Font = new Font("Sitka Banner", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 203);
            label4.Name = "label4";
            label4.Size = new Size(85, 31);
            label4.TabIndex = 8;
            label4.Text = "Teléfono:";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.Font = new Font("Sitka Banner", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 157);
            label3.Name = "label3";
            label3.Size = new Size(85, 31);
            label3.TabIndex = 7;
            label3.Text = "Dirección:";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.Font = new Font("Sitka Banner", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 113);
            label2.Name = "label2";
            label2.Size = new Size(85, 31);
            label2.TabIndex = 6;
            label2.Text = "Nombres:";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            label6.Font = new Font("Sitka Banner", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(12, 66);
            label6.Name = "label6";
            label6.Size = new Size(85, 31);
            label6.TabIndex = 5;
            label6.Text = "Cédula:";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(375, 49);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(66, 59);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // lblCedula
            // 
            lblCedula.Location = new Point(123, 71);
            lblCedula.Name = "lblCedula";
            lblCedula.Size = new Size(142, 25);
            lblCedula.TabIndex = 11;
            // 
            // lblDireccion
            // 
            lblDireccion.Location = new Point(123, 163);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(264, 25);
            lblDireccion.TabIndex = 13;
            // 
            // lblTelefono
            // 
            lblTelefono.Location = new Point(123, 203);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(158, 25);
            lblTelefono.TabIndex = 14;
            // 
            // lblMail
            // 
            lblMail.Location = new Point(123, 247);
            lblMail.Name = "lblMail";
            lblMail.Size = new Size(209, 25);
            lblMail.TabIndex = 15;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Khaki;
            btnSalir.Font = new Font("Sitka Banner", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.ForeColor = Color.Navy;
            btnSalir.Location = new Point(145, 331);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(136, 41);
            btnSalir.TabIndex = 16;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // lblNombres
            // 
            lblNombres.Location = new Point(123, 118);
            lblNombres.Name = "lblNombres";
            lblNombres.Size = new Size(241, 25);
            lblNombres.TabIndex = 12;
            // 
            // FrmVisorFactura
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.MistyRose;
            ClientSize = new Size(441, 384);
            Controls.Add(btnSalir);
            Controls.Add(lblMail);
            Controls.Add(lblTelefono);
            Controls.Add(lblDireccion);
            Controls.Add(lblNombres);
            Controls.Add(lblCedula);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label6);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmVisorFactura";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Datos Cliente";
            Load += FrmVisorFactura_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label6;
        private PictureBox pictureBox1;
        private Label lblCedula;
        private Label lblDireccion;
        private Label lblTelefono;
        private Label lblMail;
        private Button btnSalir;
        private Label lblNombres;
    }
}