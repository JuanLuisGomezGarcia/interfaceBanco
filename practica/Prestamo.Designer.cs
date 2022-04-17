
namespace practica
{
    partial class Prestamo
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Prestamo));
            this.Saludo = new System.Windows.Forms.Label();
            this.btnConfirmarSolicitud = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DatosPrestamo = new System.Windows.Forms.Panel();
            this.Cuotas = new System.Windows.Forms.ComboBox();
            this.Monto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DatosPersonales = new System.Windows.Forms.Panel();
            this.Lugares = new System.Windows.Forms.ComboBox();
            this.Raza = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.DatosPrestamo.SuspendLayout();
            this.DatosPersonales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // Saludo
            // 
            this.Saludo.AutoSize = true;
            this.Saludo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Saludo.ForeColor = System.Drawing.Color.DarkRed;
            this.Saludo.Location = new System.Drawing.Point(44, 9);
            this.Saludo.Name = "Saludo";
            this.Saludo.Size = new System.Drawing.Size(185, 32);
            this.Saludo.TabIndex = 0;
            this.Saludo.Text = "Bienvenido, ";
            // 
            // btnConfirmarSolicitud
            // 
            this.btnConfirmarSolicitud.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnConfirmarSolicitud.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmarSolicitud.ForeColor = System.Drawing.SystemColors.Control;
            this.btnConfirmarSolicitud.Location = new System.Drawing.Point(313, 313);
            this.btnConfirmarSolicitud.Name = "btnConfirmarSolicitud";
            this.btnConfirmarSolicitud.Size = new System.Drawing.Size(188, 87);
            this.btnConfirmarSolicitud.TabIndex = 1;
            this.btnConfirmarSolicitud.Text = "Confirmar solicitud";
            this.btnConfirmarSolicitud.UseVisualStyleBackColor = false;
            this.btnConfirmarSolicitud.Click += new System.EventHandler(this.btnConfirmarSolicitud_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.Color.White;
            this.btnVolver.Location = new System.Drawing.Point(707, 372);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(83, 69);
            this.btnVolver.TabIndex = 2;
            this.btnVolver.Text = "VOLVER";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Datos personales:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(427, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Detalles del prestamo:";
            // 
            // DatosPrestamo
            // 
            this.DatosPrestamo.BackColor = System.Drawing.Color.Plum;
            this.DatosPrestamo.Controls.Add(this.Cuotas);
            this.DatosPrestamo.Controls.Add(this.Monto);
            this.DatosPrestamo.Controls.Add(this.label4);
            this.DatosPrestamo.Controls.Add(this.label3);
            this.DatosPrestamo.Location = new System.Drawing.Point(434, 139);
            this.DatosPrestamo.Name = "DatosPrestamo";
            this.DatosPrestamo.Size = new System.Drawing.Size(356, 133);
            this.DatosPrestamo.TabIndex = 5;
            // 
            // Cuotas
            // 
            this.Cuotas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cuotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cuotas.FormattingEnabled = true;
            this.Cuotas.Location = new System.Drawing.Point(219, 83);
            this.Cuotas.Name = "Cuotas";
            this.Cuotas.Size = new System.Drawing.Size(121, 24);
            this.Cuotas.TabIndex = 9;
            // 
            // Monto
            // 
            this.Monto.Location = new System.Drawing.Point(219, 25);
            this.Monto.Name = "Monto";
            this.Monto.Size = new System.Drawing.Size(121, 22);
            this.Monto.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(129, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cuotas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(16, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Monto de prestamo";
            // 
            // DatosPersonales
            // 
            this.DatosPersonales.BackColor = System.Drawing.Color.Plum;
            this.DatosPersonales.Controls.Add(this.Lugares);
            this.DatosPersonales.Controls.Add(this.Raza);
            this.DatosPersonales.Controls.Add(this.label6);
            this.DatosPersonales.Controls.Add(this.label5);
            this.DatosPersonales.Location = new System.Drawing.Point(12, 139);
            this.DatosPersonales.Name = "DatosPersonales";
            this.DatosPersonales.Size = new System.Drawing.Size(365, 133);
            this.DatosPersonales.TabIndex = 6;
            // 
            // Lugares
            // 
            this.Lugares.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Lugares.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Lugares.FormattingEnabled = true;
            this.Lugares.Location = new System.Drawing.Point(206, 74);
            this.Lugares.Name = "Lugares";
            this.Lugares.Size = new System.Drawing.Size(121, 24);
            this.Lugares.TabIndex = 10;
            // 
            // Raza
            // 
            this.Raza.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Raza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Raza.FormattingEnabled = true;
            this.Raza.Location = new System.Drawing.Point(206, 25);
            this.Raza.Name = "Raza";
            this.Raza.Size = new System.Drawing.Size(121, 24);
            this.Raza.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkRed;
            this.label6.Location = new System.Drawing.Point(24, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Lugar de origen";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkRed;
            this.label5.Location = new System.Drawing.Point(126, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Raza";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Prestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(802, 453);
            this.Controls.Add(this.DatosPersonales);
            this.Controls.Add(this.DatosPrestamo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnConfirmarSolicitud);
            this.Controls.Add(this.Saludo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Prestamo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Prestamos";
            this.Load += new System.EventHandler(this.Prestamo_Load);
            this.DatosPrestamo.ResumeLayout(false);
            this.DatosPrestamo.PerformLayout();
            this.DatosPersonales.ResumeLayout(false);
            this.DatosPersonales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Saludo;
        private System.Windows.Forms.Button btnConfirmarSolicitud;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel DatosPrestamo;
        private System.Windows.Forms.Panel DatosPersonales;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Cuotas;
        private System.Windows.Forms.TextBox Monto;
        private System.Windows.Forms.ComboBox Lugares;
        private System.Windows.Forms.ComboBox Raza;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}