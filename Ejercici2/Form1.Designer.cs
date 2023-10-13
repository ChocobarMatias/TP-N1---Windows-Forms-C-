namespace Ejercici2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.rdoPerro = new System.Windows.Forms.RadioButton();
            this.rdoCaballo = new System.Windows.Forms.RadioButton();
            this.rdoConejo = new System.Windows.Forms.RadioButton();
            this.btnAlimentar = new System.Windows.Forms.Button();
            this.btnJugar = new System.Windows.Forms.Button();
            this.btnDetalles = new System.Windows.Forms.Button();
            this.pic = new System.Windows.Forms.PictureBox();
            this.grpMascota = new System.Windows.Forms.GroupBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtRaza = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblRaza = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dgvMascotas = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Raza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pgrAlimentar = new System.Windows.Forms.ProgressBar();
            this.pgrJugar = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.grpMascota.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMascotas)).BeginInit();
            this.SuspendLayout();
            // 
            // rdoPerro
            // 
            this.rdoPerro.AutoSize = true;
            this.rdoPerro.Location = new System.Drawing.Point(37, 47);
            this.rdoPerro.Name = "rdoPerro";
            this.rdoPerro.Size = new System.Drawing.Size(91, 33);
            this.rdoPerro.TabIndex = 0;
            this.rdoPerro.TabStop = true;
            this.rdoPerro.Text = "Perro";
            this.rdoPerro.UseVisualStyleBackColor = true;
            this.rdoPerro.CheckedChanged += new System.EventHandler(this.rdoPerro_CheckedChanged);
            // 
            // rdoCaballo
            // 
            this.rdoCaballo.AutoSize = true;
            this.rdoCaballo.Location = new System.Drawing.Point(229, 47);
            this.rdoCaballo.Name = "rdoCaballo";
            this.rdoCaballo.Size = new System.Drawing.Size(105, 33);
            this.rdoCaballo.TabIndex = 1;
            this.rdoCaballo.TabStop = true;
            this.rdoCaballo.Text = "Caballo";
            this.rdoCaballo.UseVisualStyleBackColor = true;
            this.rdoCaballo.CheckedChanged += new System.EventHandler(this.rdoCaballo_CheckedChanged);
            // 
            // rdoConejo
            // 
            this.rdoConejo.AutoSize = true;
            this.rdoConejo.Location = new System.Drawing.Point(448, 47);
            this.rdoConejo.Name = "rdoConejo";
            this.rdoConejo.Size = new System.Drawing.Size(101, 33);
            this.rdoConejo.TabIndex = 2;
            this.rdoConejo.TabStop = true;
            this.rdoConejo.Text = "Conejo";
            this.rdoConejo.UseVisualStyleBackColor = true;
            this.rdoConejo.CheckedChanged += new System.EventHandler(this.rdoConejo_CheckedChanged);
            // 
            // btnAlimentar
            // 
            this.btnAlimentar.Location = new System.Drawing.Point(653, 182);
            this.btnAlimentar.Name = "btnAlimentar";
            this.btnAlimentar.Size = new System.Drawing.Size(93, 40);
            this.btnAlimentar.TabIndex = 3;
            this.btnAlimentar.Text = "Alimentar";
            this.btnAlimentar.UseVisualStyleBackColor = true;
            this.btnAlimentar.Click += new System.EventHandler(this.btnAlimentar_Click);
            // 
            // btnJugar
            // 
            this.btnJugar.Location = new System.Drawing.Point(653, 275);
            this.btnJugar.Name = "btnJugar";
            this.btnJugar.Size = new System.Drawing.Size(93, 38);
            this.btnJugar.TabIndex = 4;
            this.btnJugar.Text = "Jugar";
            this.btnJugar.UseVisualStyleBackColor = true;
            this.btnJugar.Click += new System.EventHandler(this.btnJugar_Click);
            // 
            // btnDetalles
            // 
            this.btnDetalles.Location = new System.Drawing.Point(653, 348);
            this.btnDetalles.Name = "btnDetalles";
            this.btnDetalles.Size = new System.Drawing.Size(93, 34);
            this.btnDetalles.TabIndex = 5;
            this.btnDetalles.Text = "Detalles";
            this.btnDetalles.UseVisualStyleBackColor = true;
            this.btnDetalles.Click += new System.EventHandler(this.btnDetalles_Click);
            // 
            // pic
            // 
            this.pic.Location = new System.Drawing.Point(12, 132);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(207, 297);
            this.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic.TabIndex = 6;
            this.pic.TabStop = false;
            this.pic.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // grpMascota
            // 
            this.grpMascota.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grpMascota.Controls.Add(this.rdoPerro);
            this.grpMascota.Controls.Add(this.rdoCaballo);
            this.grpMascota.Controls.Add(this.rdoConejo);
            this.grpMascota.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMascota.Location = new System.Drawing.Point(43, 26);
            this.grpMascota.Name = "grpMascota";
            this.grpMascota.Size = new System.Drawing.Size(638, 100);
            this.grpMascota.TabIndex = 7;
            this.grpMascota.TabStop = false;
            this.grpMascota.Text = "Mascota";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(428, 196);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(154, 26);
            this.txtNombre.TabIndex = 8;
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(428, 287);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(154, 26);
            this.txtEdad.TabIndex = 9;
            // 
            // txtRaza
            // 
            this.txtRaza.Location = new System.Drawing.Point(428, 403);
            this.txtRaza.Name = "txtRaza";
            this.txtRaza.Size = new System.Drawing.Size(154, 26);
            this.txtRaza.TabIndex = 10;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(487, 147);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(65, 20);
            this.lblNombre.TabIndex = 11;
            this.lblNombre.Text = "Nombre";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(487, 243);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(47, 20);
            this.lblEdad.TabIndex = 12;
            this.lblEdad.Text = "Edad";
            // 
            // lblRaza
            // 
            this.lblRaza.AutoSize = true;
            this.lblRaza.Location = new System.Drawing.Point(487, 348);
            this.lblRaza.Name = "lblRaza";
            this.lblRaza.Size = new System.Drawing.Size(47, 20);
            this.lblRaza.TabIndex = 13;
            this.lblRaza.Text = "Raza";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(445, 462);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(117, 40);
            this.btnAceptar.TabIndex = 14;
            this.btnAceptar.Text = "CARGAR";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // dgvMascotas
            // 
            this.dgvMascotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMascotas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Raza,
            this.Edad});
            this.dgvMascotas.Location = new System.Drawing.Point(407, 523);
            this.dgvMascotas.Name = "dgvMascotas";
            this.dgvMascotas.RowTemplate.Height = 28;
            this.dgvMascotas.Size = new System.Drawing.Size(703, 150);
            this.dgvMascotas.TabIndex = 15;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 150;
            // 
            // Raza
            // 
            this.Raza.HeaderText = "Raza";
            this.Raza.Name = "Raza";
            this.Raza.Width = 150;
            // 
            // Edad
            // 
            this.Edad.HeaderText = "Edad";
            this.Edad.Name = "Edad";
            this.Edad.Width = 120;
            // 
            // pgrAlimentar
            // 
            this.pgrAlimentar.Location = new System.Drawing.Point(809, 182);
            this.pgrAlimentar.Name = "pgrAlimentar";
            this.pgrAlimentar.Size = new System.Drawing.Size(192, 40);
            this.pgrAlimentar.TabIndex = 16;
            // 
            // pgrJugar
            // 
            this.pgrJugar.Location = new System.Drawing.Point(809, 275);
            this.pgrJugar.Name = "pgrJugar";
            this.pgrJugar.Size = new System.Drawing.Size(192, 40);
            this.pgrJugar.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1113, 714);
            this.Controls.Add(this.pgrJugar);
            this.Controls.Add(this.pgrAlimentar);
            this.Controls.Add(this.dgvMascotas);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblRaza);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtRaza);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.grpMascota);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.btnDetalles);
            this.Controls.Add(this.btnJugar);
            this.Controls.Add(this.btnAlimentar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.grpMascota.ResumeLayout(false);
            this.grpMascota.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMascotas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdoPerro;
        private System.Windows.Forms.RadioButton rdoCaballo;
        private System.Windows.Forms.RadioButton rdoConejo;
        private System.Windows.Forms.Button btnAlimentar;
        private System.Windows.Forms.Button btnJugar;
        private System.Windows.Forms.Button btnDetalles;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.GroupBox grpMascota;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtRaza;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblRaza;
        private System.Windows.Forms.Button btnAceptar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dgvMascotas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Raza;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edad;
        private System.Windows.Forms.ProgressBar pgrAlimentar;
        private System.Windows.Forms.ProgressBar pgrJugar;
    }
}

