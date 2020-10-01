namespace InstitutoForm
{
    partial class FormAlumno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAlumno));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBorrarAlumno = new System.Windows.Forms.Button();
            this.btnGuardarAlumno = new System.Windows.Forms.Button();
            this.dtpFechaAlumno = new System.Windows.Forms.DateTimePicker();
            this.tbTelefonoAlumno = new System.Windows.Forms.TextBox();
            this.tbDireccionAlumno = new System.Windows.Forms.TextBox();
            this.tbNombreAlumno = new System.Windows.Forms.TextBox();
            this.tbDniAlumno = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bnAtras = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Azure;
            this.groupBox1.Controls.Add(this.btnBorrarAlumno);
            this.groupBox1.Controls.Add(this.btnGuardarAlumno);
            this.groupBox1.Controls.Add(this.dtpFechaAlumno);
            this.groupBox1.Controls.Add(this.tbTelefonoAlumno);
            this.groupBox1.Controls.Add(this.tbDireccionAlumno);
            this.groupBox1.Controls.Add(this.tbNombreAlumno);
            this.groupBox1.Controls.Add(this.tbDniAlumno);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(47, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(539, 459);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Alumno";
            // 
            // btnBorrarAlumno
            // 
            this.btnBorrarAlumno.BackColor = System.Drawing.Color.Bisque;
            this.btnBorrarAlumno.Location = new System.Drawing.Point(288, 374);
            this.btnBorrarAlumno.Name = "btnBorrarAlumno";
            this.btnBorrarAlumno.Size = new System.Drawing.Size(115, 43);
            this.btnBorrarAlumno.TabIndex = 13;
            this.btnBorrarAlumno.Text = "Borrar";
            this.btnBorrarAlumno.UseVisualStyleBackColor = false;
            this.btnBorrarAlumno.Click += new System.EventHandler(this.btnBorrarAlumno_Click);
            // 
            // btnGuardarAlumno
            // 
            this.btnGuardarAlumno.BackColor = System.Drawing.Color.Bisque;
            this.btnGuardarAlumno.Location = new System.Drawing.Point(117, 374);
            this.btnGuardarAlumno.Name = "btnGuardarAlumno";
            this.btnGuardarAlumno.Size = new System.Drawing.Size(115, 43);
            this.btnGuardarAlumno.TabIndex = 12;
            this.btnGuardarAlumno.Text = "Guardar";
            this.btnGuardarAlumno.UseVisualStyleBackColor = false;
            this.btnGuardarAlumno.Click += new System.EventHandler(this.btnGuardarAlumno_Click);
            // 
            // dtpFechaAlumno
            // 
            this.dtpFechaAlumno.Location = new System.Drawing.Point(147, 185);
            this.dtpFechaAlumno.Name = "dtpFechaAlumno";
            this.dtpFechaAlumno.Size = new System.Drawing.Size(200, 23);
            this.dtpFechaAlumno.TabIndex = 11;
            // 
            // tbTelefonoAlumno
            // 
            this.tbTelefonoAlumno.Location = new System.Drawing.Point(147, 277);
            this.tbTelefonoAlumno.Name = "tbTelefonoAlumno";
            this.tbTelefonoAlumno.Size = new System.Drawing.Size(201, 23);
            this.tbTelefonoAlumno.TabIndex = 10;
            // 
            // tbDireccionAlumno
            // 
            this.tbDireccionAlumno.Location = new System.Drawing.Point(147, 231);
            this.tbDireccionAlumno.Name = "tbDireccionAlumno";
            this.tbDireccionAlumno.Size = new System.Drawing.Size(201, 23);
            this.tbDireccionAlumno.TabIndex = 9;
            // 
            // tbNombreAlumno
            // 
            this.tbNombreAlumno.Location = new System.Drawing.Point(147, 135);
            this.tbNombreAlumno.Name = "tbNombreAlumno";
            this.tbNombreAlumno.Size = new System.Drawing.Size(201, 23);
            this.tbNombreAlumno.TabIndex = 7;
            // 
            // tbDniAlumno
            // 
            this.tbDniAlumno.Location = new System.Drawing.Point(147, 86);
            this.tbDniAlumno.Name = "tbDniAlumno";
            this.tbDniAlumno.Size = new System.Drawing.Size(201, 23);
            this.tbDniAlumno.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(46, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Dirección";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(46, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Teléfono";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "DNI";
            // 
            // bnAtras
            // 
            this.bnAtras.BackColor = System.Drawing.Color.Transparent;
            this.bnAtras.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bnAtras.BackgroundImage")));
            this.bnAtras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bnAtras.ForeColor = System.Drawing.Color.Transparent;
            this.bnAtras.Location = new System.Drawing.Point(786, 483);
            this.bnAtras.Name = "bnAtras";
            this.bnAtras.Size = new System.Drawing.Size(127, 94);
            this.bnAtras.TabIndex = 1;
            this.bnAtras.UseVisualStyleBackColor = false;
            this.bnAtras.Click += new System.EventHandler(this.bnAtras_Click);
            // 
            // FormAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(934, 589);
            this.Controls.Add(this.bnAtras);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormAlumno";
            this.Text = "FormAlumno";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBorrarAlumno;
        private System.Windows.Forms.Button btnGuardarAlumno;
        private System.Windows.Forms.DateTimePicker dtpFechaAlumno;
        private System.Windows.Forms.TextBox tbTelefonoAlumno;
        private System.Windows.Forms.TextBox tbDireccionAlumno;
        private System.Windows.Forms.TextBox tbNombreAlumno;
        private System.Windows.Forms.TextBox tbDniAlumno;
        private System.Windows.Forms.Button bnAtras;
    }
}