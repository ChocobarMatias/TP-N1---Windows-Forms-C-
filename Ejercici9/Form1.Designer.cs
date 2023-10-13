namespace Ejercici9
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
            this.btnDormir = new System.Windows.Forms.Button();
            this.btnComunicar = new System.Windows.Forms.Button();
            this.gprAve = new System.Windows.Forms.GroupBox();
            this.rdoVoladora = new System.Windows.Forms.RadioButton();
            this.rdoNoVoladora = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picAve = new System.Windows.Forms.PictureBox();
            this.grpDetalles = new System.Windows.Forms.GroupBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblAccion = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblEdad2 = new System.Windows.Forms.Label();
            this.lblAccion2 = new System.Windows.Forms.Label();
            this.btnAccion = new System.Windows.Forms.Button();
            this.lblcome = new System.Windows.Forms.Label();
            this.lblcomer = new System.Windows.Forms.Label();
            this.gprAve.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAve)).BeginInit();
            this.grpDetalles.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDormir
            // 
            this.btnDormir.Location = new System.Drawing.Point(52, 422);
            this.btnDormir.Name = "btnDormir";
            this.btnDormir.Size = new System.Drawing.Size(75, 29);
            this.btnDormir.TabIndex = 0;
            this.btnDormir.Text = "Dormir";
            this.btnDormir.UseVisualStyleBackColor = true;
            this.btnDormir.Click += new System.EventHandler(this.btnDormir_Click);
            // 
            // btnComunicar
            // 
            this.btnComunicar.Location = new System.Drawing.Point(300, 422);
            this.btnComunicar.Name = "btnComunicar";
            this.btnComunicar.Size = new System.Drawing.Size(129, 30);
            this.btnComunicar.TabIndex = 1;
            this.btnComunicar.Text = "Comunicarse";
            this.btnComunicar.UseVisualStyleBackColor = true;
            this.btnComunicar.Click += new System.EventHandler(this.btnComunicar_Click);
            // 
            // gprAve
            // 
            this.gprAve.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gprAve.Controls.Add(this.rdoNoVoladora);
            this.gprAve.Controls.Add(this.rdoVoladora);
            this.gprAve.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gprAve.Location = new System.Drawing.Point(52, 19);
            this.gprAve.Name = "gprAve";
            this.gprAve.Size = new System.Drawing.Size(360, 100);
            this.gprAve.TabIndex = 2;
            this.gprAve.TabStop = false;
            this.gprAve.Text = "AVE";
            // 
            // rdoVoladora
            // 
            this.rdoVoladora.AutoSize = true;
            this.rdoVoladora.Location = new System.Drawing.Point(29, 42);
            this.rdoVoladora.Name = "rdoVoladora";
            this.rdoVoladora.Size = new System.Drawing.Size(106, 24);
            this.rdoVoladora.TabIndex = 3;
            this.rdoVoladora.TabStop = true;
            this.rdoVoladora.Text = "Voladora";
            this.rdoVoladora.UseVisualStyleBackColor = true;
            this.rdoVoladora.CheckedChanged += new System.EventHandler(this.rdoVoladora_CheckedChanged);
            // 
            // rdoNoVoladora
            // 
            this.rdoNoVoladora.AutoSize = true;
            this.rdoNoVoladora.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoNoVoladora.Location = new System.Drawing.Point(198, 42);
            this.rdoNoVoladora.Name = "rdoNoVoladora";
            this.rdoNoVoladora.Size = new System.Drawing.Size(133, 24);
            this.rdoNoVoladora.TabIndex = 4;
            this.rdoNoVoladora.TabStop = true;
            this.rdoNoVoladora.Text = "No Voladora";
            this.rdoNoVoladora.UseVisualStyleBackColor = true;
            this.rdoNoVoladora.CheckedChanged += new System.EventHandler(this.rdoNoVoladora_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Coral;
            this.panel1.Controls.Add(this.btnAccion);
            this.panel1.Controls.Add(this.picAve);
            this.panel1.Controls.Add(this.btnComunicar);
            this.panel1.Controls.Add(this.gprAve);
            this.panel1.Controls.Add(this.btnDormir);
            this.panel1.Location = new System.Drawing.Point(81, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(478, 495);
            this.panel1.TabIndex = 3;
            // 
            // picAve
            // 
            this.picAve.Location = new System.Drawing.Point(62, 125);
            this.picAve.Name = "picAve";
            this.picAve.Size = new System.Drawing.Size(350, 265);
            this.picAve.TabIndex = 3;
            this.picAve.TabStop = false;
            // 
            // grpDetalles
            // 
            this.grpDetalles.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.grpDetalles.Controls.Add(this.lblcomer);
            this.grpDetalles.Controls.Add(this.lblcome);
            this.grpDetalles.Controls.Add(this.lblAccion2);
            this.grpDetalles.Controls.Add(this.lblEdad2);
            this.grpDetalles.Controls.Add(this.lblTipo);
            this.grpDetalles.Controls.Add(this.lblAccion);
            this.grpDetalles.Controls.Add(this.lblEdad);
            this.grpDetalles.Controls.Add(this.lblNombre);
            this.grpDetalles.Location = new System.Drawing.Point(567, 154);
            this.grpDetalles.Name = "grpDetalles";
            this.grpDetalles.Size = new System.Drawing.Size(200, 216);
            this.grpDetalles.TabIndex = 4;
            this.grpDetalles.TabStop = false;
            this.grpDetalles.Text = "Detalles";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(20, 55);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(68, 20);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = ". Tipo : ";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdad.Location = new System.Drawing.Point(20, 96);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(71, 20);
            this.lblEdad.TabIndex = 1;
            this.lblEdad.Text = ". Edad :";
            // 
            // lblAccion
            // 
            this.lblAccion.AutoSize = true;
            this.lblAccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccion.Location = new System.Drawing.Point(20, 139);
            this.lblAccion.Name = "lblAccion";
            this.lblAccion.Size = new System.Drawing.Size(83, 20);
            this.lblAccion.TabIndex = 2;
            this.lblAccion.Text = ". Accion :";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(103, 55);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(51, 20);
            this.lblTipo.TabIndex = 3;
            this.lblTipo.Text = "label1";
            // 
            // lblEdad2
            // 
            this.lblEdad2.AutoSize = true;
            this.lblEdad2.Location = new System.Drawing.Point(103, 96);
            this.lblEdad2.Name = "lblEdad2";
            this.lblEdad2.Size = new System.Drawing.Size(51, 20);
            this.lblEdad2.TabIndex = 4;
            this.lblEdad2.Text = "label2";
            // 
            // lblAccion2
            // 
            this.lblAccion2.AutoSize = true;
            this.lblAccion2.Location = new System.Drawing.Point(103, 139);
            this.lblAccion2.Name = "lblAccion2";
            this.lblAccion2.Size = new System.Drawing.Size(51, 20);
            this.lblAccion2.TabIndex = 5;
            this.lblAccion2.Text = "label3";
            // 
            // btnAccion
            // 
            this.btnAccion.Location = new System.Drawing.Point(178, 448);
            this.btnAccion.Name = "btnAccion";
            this.btnAccion.Size = new System.Drawing.Size(97, 32);
            this.btnAccion.TabIndex = 4;
            this.btnAccion.Text = "Accion";
            this.btnAccion.UseVisualStyleBackColor = true;
            this.btnAccion.Click += new System.EventHandler(this.btnAccion_Click);
            // 
            // lblcome
            // 
            this.lblcome.AutoSize = true;
            this.lblcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcome.Location = new System.Drawing.Point(20, 177);
            this.lblcome.Name = "lblcome";
            this.lblcome.Size = new System.Drawing.Size(75, 20);
            this.lblcome.TabIndex = 6;
            this.lblcome.Text = ". Come :";
            // 
            // lblcomer
            // 
            this.lblcomer.AutoSize = true;
            this.lblcomer.Location = new System.Drawing.Point(103, 177);
            this.lblcomer.Name = "lblcomer";
            this.lblcomer.Size = new System.Drawing.Size(51, 20);
            this.lblcomer.TabIndex = 7;
            this.lblcomer.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(779, 582);
            this.Controls.Add(this.grpDetalles);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gprAve.ResumeLayout(false);
            this.gprAve.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAve)).EndInit();
            this.grpDetalles.ResumeLayout(false);
            this.grpDetalles.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDormir;
        private System.Windows.Forms.Button btnComunicar;
        private System.Windows.Forms.GroupBox gprAve;
        private System.Windows.Forms.RadioButton rdoNoVoladora;
        private System.Windows.Forms.RadioButton rdoVoladora;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picAve;
        private System.Windows.Forms.GroupBox grpDetalles;
        private System.Windows.Forms.Label lblAccion;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblAccion2;
        private System.Windows.Forms.Label lblEdad2;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Button btnAccion;
        private System.Windows.Forms.Label lblcomer;
        private System.Windows.Forms.Label lblcome;
    }
}

