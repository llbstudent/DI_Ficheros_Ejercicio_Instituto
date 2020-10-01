namespace InstitutoForm
{
    partial class FormAsignatura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAsignatura));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBorrarProfesor = new System.Windows.Forms.Button();
            this.btnGuardarProfesor = new System.Windows.Forms.Button();
            this.tbhorasSemanalesAsig = new System.Windows.Forms.TextBox();
            this.tbDepartamentoAsig = new System.Windows.Forms.TextBox();
            this.tbNombreAsignatura = new System.Windows.Forms.TextBox();
            this.tbIDAsignatura = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bnAtras = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Azure;
            this.groupBox1.Controls.Add(this.btnBorrarProfesor);
            this.groupBox1.Controls.Add(this.btnGuardarProfesor);
            this.groupBox1.Controls.Add(this.tbhorasSemanalesAsig);
            this.groupBox1.Controls.Add(this.tbDepartamentoAsig);
            this.groupBox1.Controls.Add(this.tbNombreAsignatura);
            this.groupBox1.Controls.Add(this.tbIDAsignatura);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(50, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(539, 459);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del las Asignaturas";
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
            this.btnGuardarProfesor.Click += new System.EventHandler(this.btnGuardarProfesor_Click);
            // 
            // tbhorasSemanalesAsig
            // 
            this.tbhorasSemanalesAsig.Location = new System.Drawing.Point(192, 260);
            this.tbhorasSemanalesAsig.Name = "tbhorasSemanalesAsig";
            this.tbhorasSemanalesAsig.Size = new System.Drawing.Size(201, 23);
            this.tbhorasSemanalesAsig.TabIndex = 10;
            // 
            // tbDepartamentoAsig
            // 
            this.tbDepartamentoAsig.Location = new System.Drawing.Point(192, 209);
            this.tbDepartamentoAsig.Name = "tbDepartamentoAsig";
            this.tbDepartamentoAsig.Size = new System.Drawing.Size(201, 23);
            this.tbDepartamentoAsig.TabIndex = 9;
            // 
            // tbNombreAsignatura
            // 
            this.tbNombreAsignatura.Location = new System.Drawing.Point(192, 157);
            this.tbNombreAsignatura.Name = "tbNombreAsignatura";
            this.tbNombreAsignatura.Size = new System.Drawing.Size(201, 23);
            this.tbNombreAsignatura.TabIndex = 7;
            // 
            // tbIDAsignatura
            // 
            this.tbIDAsignatura.Location = new System.Drawing.Point(192, 108);
            this.tbIDAsignatura.Name = "tbIDAsignatura";
            this.tbIDAsignatura.Size = new System.Drawing.Size(201, 23);
            this.tbIDAsignatura.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(48, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Departamento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(48, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Horas Semanales";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
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
            this.bnAtras.TabIndex = 3;
            this.bnAtras.UseVisualStyleBackColor = false;
            this.bnAtras.Click += new System.EventHandler(this.bnAtras_Click);
            // 
            // FormAsignatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(933, 588);
            this.Controls.Add(this.bnAtras);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormAsignatura";
            this.Text = "FormAsignatura";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBorrarProfesor;
        private System.Windows.Forms.Button btnGuardarProfesor;
        private System.Windows.Forms.TextBox tbhorasSemanalesAsig;
        private System.Windows.Forms.TextBox tbDepartamentoAsig;
        private System.Windows.Forms.TextBox tbNombreAsignatura;
        private System.Windows.Forms.TextBox tbIDAsignatura;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bnAtras;
    }
}