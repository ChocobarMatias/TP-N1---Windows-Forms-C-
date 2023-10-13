namespace Ejercic7
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
            this.rdotriangulo = new System.Windows.Forms.RadioButton();
            this.rdocuadrado = new System.Windows.Forms.RadioButton();
            this.rdocirculo = new System.Windows.Forms.RadioButton();
            this.gpFiguras = new System.Windows.Forms.GroupBox();
            this.btnarea = new System.Windows.Forms.Button();
            this.txtDato1 = new System.Windows.Forms.TextBox();
            this.txtDato2 = new System.Windows.Forms.TextBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.lblDato1 = new System.Windows.Forms.Label();
            this.lblDato2 = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.rdoArea = new System.Windows.Forms.RadioButton();
            this.rdoPerimetro = new System.Windows.Forms.RadioButton();
            this.grpOperacion = new System.Windows.Forms.GroupBox();
            this.txtDato3 = new System.Windows.Forms.TextBox();
            this.lblDato3 = new System.Windows.Forms.Label();
            this.picCuadrado = new System.Windows.Forms.PictureBox();
            this.picTriangulo = new System.Windows.Forms.PictureBox();
            this.picCirculo = new System.Windows.Forms.PictureBox();
            this.lblCalculo = new System.Windows.Forms.Label();
            this.gpFiguras.SuspendLayout();
            this.grpOperacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCuadrado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTriangulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCirculo)).BeginInit();
            this.SuspendLayout();
            // 
            // rdotriangulo
            // 
            this.rdotriangulo.AutoSize = true;
            this.rdotriangulo.Location = new System.Drawing.Point(23, 40);
            this.rdotriangulo.Name = "rdotriangulo";
            this.rdotriangulo.Size = new System.Drawing.Size(128, 24);
            this.rdotriangulo.TabIndex = 0;
            this.rdotriangulo.TabStop = true;
            this.rdotriangulo.Text = "TRIANGULO";
            this.rdotriangulo.UseVisualStyleBackColor = true;
            this.rdotriangulo.CheckedChanged += new System.EventHandler(this.rdotriangulo_CheckedChanged);
            // 
            // rdocuadrado
            // 
            this.rdocuadrado.AutoSize = true;
            this.rdocuadrado.Location = new System.Drawing.Point(24, 83);
            this.rdocuadrado.Name = "rdocuadrado";
            this.rdocuadrado.Size = new System.Drawing.Size(127, 24);
            this.rdocuadrado.TabIndex = 1;
            this.rdocuadrado.TabStop = true;
            this.rdocuadrado.Text = "CUADRADO";
            this.rdocuadrado.UseVisualStyleBackColor = true;
            this.rdocuadrado.CheckedChanged += new System.EventHandler(this.rdocuadrado_CheckedChanged);
            // 
            // rdocirculo
            // 
            this.rdocirculo.AutoSize = true;
            this.rdocirculo.Location = new System.Drawing.Point(23, 130);
            this.rdocirculo.Name = "rdocirculo";
            this.rdocirculo.Size = new System.Drawing.Size(106, 24);
            this.rdocirculo.TabIndex = 2;
            this.rdocirculo.TabStop = true;
            this.rdocirculo.Text = "CIRCULO";
            this.rdocirculo.UseVisualStyleBackColor = true;
            this.rdocirculo.CheckedChanged += new System.EventHandler(this.rdocirculo_CheckedChanged);
            // 
            // gpFiguras
            // 
            this.gpFiguras.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gpFiguras.Controls.Add(this.rdocirculo);
            this.gpFiguras.Controls.Add(this.rdotriangulo);
            this.gpFiguras.Controls.Add(this.rdocuadrado);
            this.gpFiguras.Location = new System.Drawing.Point(12, 120);
            this.gpFiguras.Name = "gpFiguras";
            this.gpFiguras.Size = new System.Drawing.Size(200, 194);
            this.gpFiguras.TabIndex = 3;
            this.gpFiguras.TabStop = false;
            this.gpFiguras.Text = "Figuras Geograficas";
            // 
            // btnarea
            // 
            this.btnarea.Location = new System.Drawing.Point(492, 599);
            this.btnarea.Name = "btnarea";
            this.btnarea.Size = new System.Drawing.Size(172, 39);
            this.btnarea.TabIndex = 5;
            this.btnarea.Text = "Calculo";
            this.btnarea.UseVisualStyleBackColor = true;
            this.btnarea.Click += new System.EventHandler(this.btnarea_Click);
            // 
            // txtDato1
            // 
            this.txtDato1.Location = new System.Drawing.Point(263, 177);
            this.txtDato1.Name = "txtDato1";
            this.txtDato1.Size = new System.Drawing.Size(144, 26);
            this.txtDato1.TabIndex = 6;
            // 
            // txtDato2
            // 
            this.txtDato2.Location = new System.Drawing.Point(263, 262);
            this.txtDato2.Name = "txtDato2";
            this.txtDato2.Size = new System.Drawing.Size(144, 26);
            this.txtDato2.TabIndex = 7;
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(508, 558);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(156, 26);
            this.txtArea.TabIndex = 8;
            // 
            // lblDato1
            // 
            this.lblDato1.AutoSize = true;
            this.lblDato1.Location = new System.Drawing.Point(306, 134);
            this.lblDato1.Name = "lblDato1";
            this.lblDato1.Size = new System.Drawing.Size(66, 20);
            this.lblDato1.TabIndex = 9;
            this.lblDato1.Text = "DATO 1";
            // 
            // lblDato2
            // 
            this.lblDato2.AutoSize = true;
            this.lblDato2.Location = new System.Drawing.Point(306, 226);
            this.lblDato2.Name = "lblDato2";
            this.lblDato2.Size = new System.Drawing.Size(66, 20);
            this.lblDato2.TabIndex = 10;
            this.lblDato2.Text = "DATO 2";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.Location = new System.Drawing.Point(397, 558);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(78, 20);
            this.lblArea.TabIndex = 11;
            this.lblArea.Text = "AREA = ";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(35, 545);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(106, 30);
            this.btnCerrar.TabIndex = 12;
            this.btnCerrar.Text = "CERRAR";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // rdoArea
            // 
            this.rdoArea.AutoSize = true;
            this.rdoArea.Location = new System.Drawing.Point(23, 25);
            this.rdoArea.Name = "rdoArea";
            this.rdoArea.Size = new System.Drawing.Size(83, 24);
            this.rdoArea.TabIndex = 3;
            this.rdoArea.TabStop = true;
            this.rdoArea.Text = "AREA";
            this.rdoArea.UseVisualStyleBackColor = true;
            this.rdoArea.CheckedChanged += new System.EventHandler(this.rdoArea_CheckedChanged);
            // 
            // rdoPerimetro
            // 
            this.rdoPerimetro.AutoSize = true;
            this.rdoPerimetro.Location = new System.Drawing.Point(202, 25);
            this.rdoPerimetro.Name = "rdoPerimetro";
            this.rdoPerimetro.Size = new System.Drawing.Size(138, 24);
            this.rdoPerimetro.TabIndex = 4;
            this.rdoPerimetro.TabStop = true;
            this.rdoPerimetro.Text = "PERIMETRO";
            this.rdoPerimetro.UseVisualStyleBackColor = true;
            this.rdoPerimetro.CheckedChanged += new System.EventHandler(this.rdoPerimetro_CheckedChanged);
            // 
            // grpOperacion
            // 
            this.grpOperacion.BackColor = System.Drawing.Color.LightBlue;
            this.grpOperacion.Controls.Add(this.rdoPerimetro);
            this.grpOperacion.Controls.Add(this.rdoArea);
            this.grpOperacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpOperacion.Location = new System.Drawing.Point(310, 26);
            this.grpOperacion.Name = "grpOperacion";
            this.grpOperacion.Size = new System.Drawing.Size(354, 58);
            this.grpOperacion.TabIndex = 13;
            this.grpOperacion.TabStop = false;
            this.grpOperacion.Text = "Selecciones Operacion";
            // 
            // txtDato3
            // 
            this.txtDato3.Location = new System.Drawing.Point(263, 342);
            this.txtDato3.Name = "txtDato3";
            this.txtDato3.Size = new System.Drawing.Size(144, 26);
            this.txtDato3.TabIndex = 14;
            this.txtDato3.Visible = false;
            // 
            // lblDato3
            // 
            this.lblDato3.AutoSize = true;
            this.lblDato3.Location = new System.Drawing.Point(306, 306);
            this.lblDato3.Name = "lblDato3";
            this.lblDato3.Size = new System.Drawing.Size(66, 20);
            this.lblDato3.TabIndex = 15;
            this.lblDato3.Text = "DATO 3";
            this.lblDato3.Visible = false;
            // 
            // picCuadrado
            // 
            this.picCuadrado.Image = ((System.Drawing.Image)(resources.GetObject("picCuadrado.Image")));
            this.picCuadrado.Location = new System.Drawing.Point(431, 145);
            this.picCuadrado.Name = "picCuadrado";
            this.picCuadrado.Size = new System.Drawing.Size(297, 217);
            this.picCuadrado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picCuadrado.TabIndex = 16;
            this.picCuadrado.TabStop = false;
            this.picCuadrado.Visible = false;
            // 
            // picTriangulo
            // 
            this.picTriangulo.Image = ((System.Drawing.Image)(resources.GetObject("picTriangulo.Image")));
            this.picTriangulo.Location = new System.Drawing.Point(483, 145);
            this.picTriangulo.Name = "picTriangulo";
            this.picTriangulo.Size = new System.Drawing.Size(214, 236);
            this.picTriangulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picTriangulo.TabIndex = 17;
            this.picTriangulo.TabStop = false;
            this.picTriangulo.Visible = false;
            // 
            // picCirculo
            // 
            this.picCirculo.Image = ((System.Drawing.Image)(resources.GetObject("picCirculo.Image")));
            this.picCirculo.Location = new System.Drawing.Point(489, 145);
            this.picCirculo.Name = "picCirculo";
            this.picCirculo.Size = new System.Drawing.Size(165, 223);
            this.picCirculo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picCirculo.TabIndex = 18;
            this.picCirculo.TabStop = false;
            this.picCirculo.Visible = false;
            // 
            // lblCalculo
            // 
            this.lblCalculo.AutoSize = true;
            this.lblCalculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalculo.Location = new System.Drawing.Point(373, 496);
            this.lblCalculo.Name = "lblCalculo";
            this.lblCalculo.Size = new System.Drawing.Size(124, 32);
            this.lblCalculo.TabIndex = 19;
            this.lblCalculo.Text = "Muestra";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(845, 650);
            this.Controls.Add(this.lblCalculo);
            this.Controls.Add(this.picCirculo);
            this.Controls.Add(this.picTriangulo);
            this.Controls.Add(this.picCuadrado);
            this.Controls.Add(this.lblDato3);
            this.Controls.Add(this.txtDato3);
            this.Controls.Add(this.grpOperacion);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblDato2);
            this.Controls.Add(this.lblDato1);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.txtDato2);
            this.Controls.Add(this.txtDato1);
            this.Controls.Add(this.btnarea);
            this.Controls.Add(this.gpFiguras);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gpFiguras.ResumeLayout(false);
            this.gpFiguras.PerformLayout();
            this.grpOperacion.ResumeLayout(false);
            this.grpOperacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCuadrado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTriangulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCirculo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdotriangulo;
        private System.Windows.Forms.RadioButton rdocuadrado;
        private System.Windows.Forms.RadioButton rdocirculo;
        private System.Windows.Forms.GroupBox gpFiguras;
        private System.Windows.Forms.Button btnarea;
        private System.Windows.Forms.TextBox txtDato1;
        private System.Windows.Forms.TextBox txtDato2;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Label lblDato1;
        private System.Windows.Forms.Label lblDato2;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.RadioButton rdoArea;
        private System.Windows.Forms.RadioButton rdoPerimetro;
        private System.Windows.Forms.GroupBox grpOperacion;
        private System.Windows.Forms.TextBox txtDato3;
        private System.Windows.Forms.Label lblDato3;
        private System.Windows.Forms.PictureBox picCuadrado;
        private System.Windows.Forms.PictureBox picTriangulo;
        private System.Windows.Forms.PictureBox picCirculo;
        private System.Windows.Forms.Label lblCalculo;
    }
}

