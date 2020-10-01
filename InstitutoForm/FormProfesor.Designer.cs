namespace InstitutoForm
{
    partial class FormProfesor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProfesor));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbEstudiosProfesor = new System.Windows.Forms.TextBox();
            this.btnBorrarProfesor = new System.Windows.Forms.Button();
            this.btnGuardarProfesor = new System.Windows.Forms.Button();
            this.tbTelefonoProfesor = new System.Windows.Forms.TextBox();
            this.tbDireccionProfesor = new System.Windows.Forms.TextBox();
            this.tbNombreProfesor = new System.Windows.Forms.TextBox();
            this.tbDniProfesor = new System.Windows.Forms.TextBox();
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
            this.groupBox1.Controls.Add(this.tbEstudiosProfesor);
            this.groupBox1.Controls.Add(this.btnBorrarProfesor);
            this.groupBox1.Controls.Add(this.btnGuardarProfesor);
            this.groupBox1.Controls.Add(this.tbTelefonoProfesor);
            this.groupBox1.Controls.Add(this.tbDireccionProfesor);
            this.groupBox1.Controls.Add(this.tbNombreProfesor);
            this.groupBox1.Controls.Add(this.tbDniProfesor);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(44, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(539, 459);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Profesor";
            // 
            // tbEstudiosProfesor
            // 
            this.tbEstudiosProfesor.Location = new System.Drawing.Point(147, 284);
            this.tbEstudiosProfesor.Name = "tbEstudiosProfesor";
            this.tbEstudiosProfesor.Size = new System.Drawing.Size(201, 23);
            this.tbEstudiosProfesor.TabIndex = 14;
            // 
            // btnBorrarProfesor
            // 
            this.btnBorrarProfesor.BackColor = System.Drawing.Color.Bisque;
            this.btnBorrarProfesor.Location = new System.Drawing.Point(288, 374);
            this.btnBorrarProfesor.Name = "btnBorrarProfesor";
            this.btnBorrarProfesor.Size = new System.Drawing.Size(115, 43);
            this.btnBorrarProfesor.TabIndex = 13;
            this.btnBorrarProfesor.Text = "Borrar";
            this.btnBorrarProfesor.UseVisualStyleBackColor = false;
            this.btnBorrarProfesor.Click += new System.EventHandler(this.btnBorrarProfesor_Click);
            // 
            // btnGuardarProfesor
            // 
            this.btnGuardarProfesor.BackColor = System.Drawing.Color.Bisque;
            this.btnGuardarProfesor.Location = new System.Drawing.Point(117, 374);
            this.btnGuardarProfesor.Name = "btnGuardarProfesor";
            this.btnGuardarProfesor.Size = new System.Drawing.Size(115, 43);
            this.btnGuardarProfesor.TabIndex = 12;
            this.btnGuardarProfesor.Text = "Guardar";
            this.btnGuardarProfesor.UseVisualStyleBackColor = false;
            this.btnGuardarProfesor.Click += new System.EventHandler(this.btnGuardarProfesor_Click_1);
            // 
            // tbTelefonoProfesor
            // 
            this.tbTelefonoProfesor.Location = new System.Drawing.Point(147, 238);
            this.tbTelefonoProfesor.Name = "tbTelefonoProfesor";
            this.tbTelefonoProfesor.Size = new System.Drawing.Size(201, 23);
            this.tbTelefonoProfesor.TabIndex = 10;
            // 
            // tbDireccionProfesor
            // 
            this.tbDireccionProfesor.Location = new System.Drawing.Point(147, 187);
            this.tbDireccionProfesor.Name = "tbDireccionProfesor";
            this.tbDireccionProfesor.Size = new System.Drawing.Size(201, 23);
            this.tbDireccionProfesor.TabIndex = 9;
            // 
            // tbNombreProfesor
            // 
            this.tbNombreProfesor.Location = new System.Drawing.Point(147, 135);
            this.tbNombreProfesor.Name = "tbNombreProfesor";
            this.tbNombreProfesor.Size = new System.Drawing.Size(201, 23);
            this.tbNombreProfesor.TabIndex = 7;
            // 
            // tbDniProfesor
            // 
            this.tbDniProfesor.Location = new System.Drawing.Point(147, 86);
            this.tbDniProfesor.Name = "tbDniProfesor";
            this.tbDniProfesor.Size = new System.Drawing.Size(201, 23);
            this.tbDniProfesor.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(46, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Dirección";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(46, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Teléfono";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Estudios";
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
            this.bnAtras.Location = new System.Drawing.Point(794, 482);
            this.bnAtras.Name = "bnAtras";
            this.bnAtras.Size = new System.Drawing.Size(127, 94);
            this.bnAtras.TabIndex = 4;
            this.bnAtras.UseVisualStyleBackColor = false;
            this.bnAtras.Click += new System.EventHandler(this.bnAtras_Click);
            // 
            // FormProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(933, 588);
            this.Controls.Add(this.bnAtras);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormProfesor";
            this.Text = "FormProfesor";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbEstudiosProfesor;
        private System.Windows.Forms.Button btnBorrarProfesor;
        private System.Windows.Forms.Button btnGuardarProfesor;
        private System.Windows.Forms.TextBox tbTelefonoProfesor;
        private System.Windows.Forms.TextBox tbDireccionProfesor;
        private System.Windows.Forms.TextBox tbNombreProfesor;
        private System.Windows.Forms.TextBox tbDniProfesor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bnAtras;
    }
}