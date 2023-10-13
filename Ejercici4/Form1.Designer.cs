namespace Ejercici4
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnMostrar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtSueldoxMes = new System.Windows.Forms.TextBox();
            this.txtDiasTrabajados = new System.Windows.Forms.TextBox();
            this.txtSueldoxDia = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblSueldoxDia = new System.Windows.Forms.Label();
            this.lblDiasTrabajados = new System.Windows.Forms.Label();
            this.lblSueldoMensual = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(123, 293);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(79, 29);
            this.btnMostrar.TabIndex = 0;
            this.btnMostrar.Text = "Mostar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(143, 32);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 26);
            this.txtNombre.TabIndex = 1;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(143, 81);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 26);
            this.txtApellido.TabIndex = 2;
            // 
            // txtSueldoxMes
            // 
            this.txtSueldoxMes.Location = new System.Drawing.Point(486, 290);
            this.txtSueldoxMes.Name = "txtSueldoxMes";
            this.txtSueldoxMes.Size = new System.Drawing.Size(119, 26);
            this.txtSueldoxMes.TabIndex = 4;
            // 
            // txtDiasTrabajados
            // 
            this.txtDiasTrabajados.Location = new System.Drawing.Point(143, 227);
            this.txtDiasTrabajados.Name = "txtDiasTrabajados";
            this.txtDiasTrabajados.Size = new System.Drawing.Size(100, 26);
            this.txtDiasTrabajados.TabIndex = 5;
            // 
            // txtSueldoxDia
            // 
            this.txtSueldoxDia.Location = new System.Drawing.Point(143, 179);
            this.txtSueldoxDia.Name = "txtSueldoxDia";
            this.txtSueldoxDia.Size = new System.Drawing.Size(100, 26);
            this.txtSueldoxDia.TabIndex = 6;
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(143, 125);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(100, 26);
            this.txtEdad.TabIndex = 7;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(13, 32);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(65, 20);
            this.lblNombre.TabIndex = 8;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(13, 87);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(65, 20);
            this.lblApellido.TabIndex = 9;
            this.lblApellido.Text = "Apellido";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(13, 131);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(47, 20);
            this.lblEdad.TabIndex = 10;
            this.lblEdad.Text = "Edad";
            // 
            // lblSueldoxDia
            // 
            this.lblSueldoxDia.AutoSize = true;
            this.lblSueldoxDia.Location = new System.Drawing.Point(13, 179);
            this.lblSueldoxDia.Name = "lblSueldoxDia";
            this.lblSueldoxDia.Size = new System.Drawing.Size(104, 20);
            this.lblSueldoxDia.TabIndex = 11;
            this.lblSueldoxDia.Text = "Sueldo Diario";
            // 
            // lblDiasTrabajados
            // 
            this.lblDiasTrabajados.AutoSize = true;
            this.lblDiasTrabajados.Location = new System.Drawing.Point(13, 233);
            this.lblDiasTrabajados.Name = "lblDiasTrabajados";
            this.lblDiasTrabajados.Size = new System.Drawing.Size(124, 20);
            this.lblDiasTrabajados.TabIndex = 12;
            this.lblDiasTrabajados.Text = "Dias Trabajados";
            // 
            // lblSueldoMensual
            // 
            this.lblSueldoMensual.AutoSize = true;
            this.lblSueldoMensual.Location = new System.Drawing.Point(346, 293);
            this.lblSueldoMensual.Name = "lblSueldoMensual";
            this.lblSueldoMensual.Size = new System.Drawing.Size(123, 20);
            this.lblSueldoMensual.TabIndex = 13;
            this.lblSueldoMensual.Text = "Sueldo Mensual";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(272, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(958, 187);
            this.dataGridView1.TabIndex = 14;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(724, 319);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(190, 41);
            this.btnNuevo.TabIndex = 15;
            this.btnNuevo.Text = "Nuevo Empleado ";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Apellido";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Edad";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Sueldo Diario";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Dias Trabajados";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Sueldo Mensual";
            this.Column5.Name = "Column5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 384);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblSueldoMensual);
            this.Controls.Add(this.lblDiasTrabajados);
            this.Controls.Add(this.lblSueldoxDia);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtSueldoxDia);
            this.Controls.Add(this.txtDiasTrabajados);
            this.Controls.Add(this.txtSueldoxMes);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnMostrar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtSueldoxMes;
        private System.Windows.Forms.TextBox txtDiasTrabajados;
        private System.Windows.Forms.TextBox txtSueldoxDia;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblSueldoxDia;
        private System.Windows.Forms.Label lblDiasTrabajados;
        private System.Windows.Forms.Label lblSueldoMensual;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}

