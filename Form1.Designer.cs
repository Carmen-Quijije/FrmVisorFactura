namespace Factura
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtCedula = new TextBox();
            txtNombres = new TextBox();
            txtDireccion = new TextBox();
            txtTelefono = new TextBox();
            txtMail = new TextBox();
            btnGrabarCliente = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(14, 24);
            label1.Name = "label1";
            label1.Size = new Size(85, 31);
            label1.TabIndex = 0;
            label1.Text = "Cédula:";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.Location = new Point(14, 71);
            label2.Name = "label2";
            label2.Size = new Size(85, 31);
            label2.TabIndex = 1;
            label2.Text = "Nombres:";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.Location = new Point(14, 115);
            label3.Name = "label3";
            label3.Size = new Size(85, 31);
            label3.TabIndex = 2;
            label3.Text = "Dirección:";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.Location = new Point(14, 161);
            label4.Name = "label4";
            label4.Size = new Size(85, 31);
            label4.TabIndex = 3;
            label4.Text = "Teléfono:";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            label5.Location = new Point(14, 205);
            label5.Name = "label5";
            label5.Size = new Size(85, 31);
            label5.TabIndex = 4;
            label5.Text = "Mail:";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtCedula
            // 
            txtCedula.Location = new Point(105, 24);
            txtCedula.Margin = new Padding(3, 4, 3, 4);
            txtCedula.MaxLength = 10;
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(114, 27);
            txtCedula.TabIndex = 0;
            // 
            // txtNombres
            // 
            txtNombres.Location = new Point(105, 71);
            txtNombres.Margin = new Padding(3, 4, 3, 4);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(290, 27);
            txtNombres.TabIndex = 1;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(105, 115);
            txtDireccion.Margin = new Padding(3, 4, 3, 4);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(290, 27);
            txtDireccion.TabIndex = 2;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(105, 161);
            txtTelefono.Margin = new Padding(3, 4, 3, 4);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(114, 27);
            txtTelefono.TabIndex = 3;
            // 
            // txtMail
            // 
            txtMail.Location = new Point(105, 205);
            txtMail.Margin = new Padding(3, 4, 3, 4);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(290, 27);
            txtMail.TabIndex = 4;
            // 
            // btnGrabarCliente
            // 
            btnGrabarCliente.Location = new Point(159, 260);
            btnGrabarCliente.Margin = new Padding(3, 4, 3, 4);
            btnGrabarCliente.Name = "btnGrabarCliente";
            btnGrabarCliente.Size = new Size(143, 31);
            btnGrabarCliente.TabIndex = 5;
            btnGrabarCliente.Text = "Grabar Cliente";
            btnGrabarCliente.UseVisualStyleBackColor = true;
            btnGrabarCliente.Click += btnGrabarCliente_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(441, 384);
            Controls.Add(btnGrabarCliente);
            Controls.Add(txtMail);
            Controls.Add(txtTelefono);
            Controls.Add(txtDireccion);
            Controls.Add(txtNombres);
            Controls.Add(txtCedula);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Facturador ISTLC";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtCedula;
        private TextBox txtNombres;
        private TextBox txtDireccion;
        private TextBox txtTelefono;
        private TextBox txtMail;
        private Button btnGrabarCliente;
    }
}
