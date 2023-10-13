namespace Ejercicio_10
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
            this.btnGuardar = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.grpPrincipal = new System.Windows.Forms.GroupBox();
            this.lblTraccion = new System.Windows.Forms.Label();
            this.btnTestDrive = new System.Windows.Forms.Button();
            this.txtTraccion = new System.Windows.Forms.TextBox();
            this.lvlVelocidad = new System.Windows.Forms.Label();
            this.lvlPotencia = new System.Windows.Forms.Label();
            this.txtVelocidad = new System.Windows.Forms.TextBox();
            this.txtPotencia = new System.Windows.Forms.TextBox();
            this.lblAceleracion = new System.Windows.Forms.Label();
            this.txtAceleracion = new System.Windows.Forms.TextBox();
            this.lblConsumo = new System.Windows.Forms.Label();
            this.lblCilindrada = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.txtCilindrada = new System.Windows.Forms.TextBox();
            this.txtConsumo = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.btnArrancar = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnAcelerar = new System.Windows.Forms.Button();
            this.btnFrenar = new System.Windows.Forms.Button();
            this.btnDerrapar = new System.Windows.Forms.Button();
            this.btnConvertible = new System.Windows.Forms.Button();
            this.grpTestDrive = new System.Windows.Forms.GroupBox();
            this.grpPrincipal.SuspendLayout();
            this.grpTestDrive.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(134, 639);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(209, 49);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // grpPrincipal
            // 
            this.grpPrincipal.BackColor = System.Drawing.SystemColors.ControlDark;
            this.grpPrincipal.Controls.Add(this.lblTraccion);
            this.grpPrincipal.Controls.Add(this.btnGuardar);
            this.grpPrincipal.Controls.Add(this.btnTestDrive);
            this.grpPrincipal.Controls.Add(this.txtTraccion);
            this.grpPrincipal.Controls.Add(this.lvlVelocidad);
            this.grpPrincipal.Controls.Add(this.lvlPotencia);
            this.grpPrincipal.Controls.Add(this.txtVelocidad);
            this.grpPrincipal.Controls.Add(this.txtPotencia);
            this.grpPrincipal.Controls.Add(this.lblAceleracion);
            this.grpPrincipal.Controls.Add(this.txtAceleracion);
            this.grpPrincipal.Controls.Add(this.lblConsumo);
            this.grpPrincipal.Controls.Add(this.lblCilindrada);
            this.grpPrincipal.Controls.Add(this.lblColor);
            this.grpPrincipal.Controls.Add(this.lblModelo);
            this.grpPrincipal.Controls.Add(this.lblMarca);
            this.grpPrincipal.Controls.Add(this.txtModelo);
            this.grpPrincipal.Controls.Add(this.txtColor);
            this.grpPrincipal.Controls.Add(this.txtCilindrada);
            this.grpPrincipal.Controls.Add(this.txtConsumo);
            this.grpPrincipal.Controls.Add(this.txtMarca);
            this.grpPrincipal.Location = new System.Drawing.Point(770, 0);
            this.grpPrincipal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpPrincipal.Name = "grpPrincipal";
            this.grpPrincipal.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpPrincipal.Size = new System.Drawing.Size(453, 804);
            this.grpPrincipal.TabIndex = 1;
            this.grpPrincipal.TabStop = false;
            this.grpPrincipal.Text = "Especificaciones";
            // 
            // lblTraccion
            // 
            this.lblTraccion.AutoSize = true;
            this.lblTraccion.Location = new System.Drawing.Point(66, 366);
            this.lblTraccion.Name = "lblTraccion";
            this.lblTraccion.Size = new System.Drawing.Size(69, 20);
            this.lblTraccion.TabIndex = 19;
            this.lblTraccion.Text = "Traccion";
            // 
            // btnTestDrive
            // 
            this.btnTestDrive.Location = new System.Drawing.Point(7, 732);
            this.btnTestDrive.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTestDrive.Name = "btnTestDrive";
            this.btnTestDrive.Size = new System.Drawing.Size(215, 64);
            this.btnTestDrive.TabIndex = 26;
            this.btnTestDrive.Text = "Test Drive";
            this.btnTestDrive.UseVisualStyleBackColor = true;
            this.btnTestDrive.Click += new System.EventHandler(this.btnTestDrive_Click);
            // 
            // txtTraccion
            // 
            this.txtTraccion.Location = new System.Drawing.Point(201, 362);
            this.txtTraccion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTraccion.Name = "txtTraccion";
            this.txtTraccion.Size = new System.Drawing.Size(214, 26);
            this.txtTraccion.TabIndex = 18;
            // 
            // lvlVelocidad
            // 
            this.lvlVelocidad.AutoSize = true;
            this.lvlVelocidad.Location = new System.Drawing.Point(38, 471);
            this.lvlVelocidad.Name = "lvlVelocidad";
            this.lvlVelocidad.Size = new System.Drawing.Size(133, 20);
            this.lvlVelocidad.TabIndex = 17;
            this.lvlVelocidad.Text = "VelocidadMaxima";
            // 
            // lvlPotencia
            // 
            this.lvlPotencia.AutoSize = true;
            this.lvlPotencia.Location = new System.Drawing.Point(42, 531);
            this.lvlPotencia.Name = "lvlPotencia";
            this.lvlPotencia.Size = new System.Drawing.Size(125, 20);
            this.lvlPotencia.TabIndex = 16;
            this.lvlPotencia.Text = "PotenciaMaxima";
            // 
            // txtVelocidad
            // 
            this.txtVelocidad.Location = new System.Drawing.Point(201, 468);
            this.txtVelocidad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtVelocidad.Name = "txtVelocidad";
            this.txtVelocidad.Size = new System.Drawing.Size(214, 26);
            this.txtVelocidad.TabIndex = 13;
            // 
            // txtPotencia
            // 
            this.txtPotencia.Location = new System.Drawing.Point(201, 528);
            this.txtPotencia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPotencia.Name = "txtPotencia";
            this.txtPotencia.Size = new System.Drawing.Size(214, 26);
            this.txtPotencia.TabIndex = 12;
            // 
            // lblAceleracion
            // 
            this.lblAceleracion.AutoSize = true;
            this.lblAceleracion.Location = new System.Drawing.Point(57, 418);
            this.lblAceleracion.Name = "lblAceleracion";
            this.lblAceleracion.Size = new System.Drawing.Size(92, 20);
            this.lblAceleracion.TabIndex = 11;
            this.lblAceleracion.Text = "Aceleracion";
            // 
            // txtAceleracion
            // 
            this.txtAceleracion.Location = new System.Drawing.Point(201, 416);
            this.txtAceleracion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAceleracion.Name = "txtAceleracion";
            this.txtAceleracion.Size = new System.Drawing.Size(214, 26);
            this.txtAceleracion.TabIndex = 10;
            // 
            // lblConsumo
            // 
            this.lblConsumo.AutoSize = true;
            this.lblConsumo.Location = new System.Drawing.Point(66, 310);
            this.lblConsumo.Name = "lblConsumo";
            this.lblConsumo.Size = new System.Drawing.Size(77, 20);
            this.lblConsumo.TabIndex = 9;
            this.lblConsumo.Text = "Consumo";
            // 
            // lblCilindrada
            // 
            this.lblCilindrada.AutoSize = true;
            this.lblCilindrada.Location = new System.Drawing.Point(64, 250);
            this.lblCilindrada.Name = "lblCilindrada";
            this.lblCilindrada.Size = new System.Drawing.Size(79, 20);
            this.lblCilindrada.TabIndex = 8;
            this.lblCilindrada.Text = "Cilindrada";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(81, 191);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(46, 20);
            this.lblColor.TabIndex = 7;
            this.lblColor.Text = "Color";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(73, 126);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(61, 20);
            this.lblModelo.TabIndex = 6;
            this.lblModelo.Text = "Modelo";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(78, 68);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(53, 20);
            this.lblMarca.TabIndex = 5;
            this.lblMarca.Text = "Marca";
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(201, 131);
            this.txtModelo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(214, 26);
            this.txtModelo.TabIndex = 4;
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(201, 192);
            this.txtColor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(214, 26);
            this.txtColor.TabIndex = 3;
            // 
            // txtCilindrada
            // 
            this.txtCilindrada.Location = new System.Drawing.Point(201, 251);
            this.txtCilindrada.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCilindrada.Name = "txtCilindrada";
            this.txtCilindrada.Size = new System.Drawing.Size(214, 26);
            this.txtCilindrada.TabIndex = 2;
            // 
            // txtConsumo
            // 
            this.txtConsumo.Location = new System.Drawing.Point(201, 311);
            this.txtConsumo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtConsumo.Name = "txtConsumo";
            this.txtConsumo.Size = new System.Drawing.Size(214, 26);
            this.txtConsumo.TabIndex = 1;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(201, 71);
            this.txtMarca.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(214, 26);
            this.txtMarca.TabIndex = 0;
            // 
            // btnArrancar
            // 
            this.btnArrancar.Location = new System.Drawing.Point(17, 38);
            this.btnArrancar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnArrancar.Name = "btnArrancar";
            this.btnArrancar.Size = new System.Drawing.Size(109, 31);
            this.btnArrancar.TabIndex = 20;
            this.btnArrancar.Text = "Arrancar";
            this.btnArrancar.UseVisualStyleBackColor = true;
            this.btnArrancar.Click += new System.EventHandler(this.btnArrancar_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.Location = new System.Drawing.Point(17, 115);
            this.btnApagar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(109, 31);
            this.btnApagar.TabIndex = 21;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // btnAcelerar
            // 
            this.btnAcelerar.Location = new System.Drawing.Point(17, 192);
            this.btnAcelerar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAcelerar.Name = "btnAcelerar";
            this.btnAcelerar.Size = new System.Drawing.Size(109, 31);
            this.btnAcelerar.TabIndex = 22;
            this.btnAcelerar.Text = "Acelerar";
            this.btnAcelerar.UseVisualStyleBackColor = true;
            this.btnAcelerar.Click += new System.EventHandler(this.btnAcelerar_Click);
            // 
            // btnFrenar
            // 
            this.btnFrenar.Location = new System.Drawing.Point(17, 264);
            this.btnFrenar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFrenar.Name = "btnFrenar";
            this.btnFrenar.Size = new System.Drawing.Size(109, 31);
            this.btnFrenar.TabIndex = 23;
            this.btnFrenar.Text = "Frenar";
            this.btnFrenar.UseVisualStyleBackColor = true;
            this.btnFrenar.Click += new System.EventHandler(this.btnFrenar_Click);
            // 
            // btnDerrapar
            // 
            this.btnDerrapar.Location = new System.Drawing.Point(17, 344);
            this.btnDerrapar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDerrapar.Name = "btnDerrapar";
            this.btnDerrapar.Size = new System.Drawing.Size(109, 31);
            this.btnDerrapar.TabIndex = 24;
            this.btnDerrapar.Text = "Derrapar";
            this.btnDerrapar.UseVisualStyleBackColor = true;
            this.btnDerrapar.Click += new System.EventHandler(this.btnDerrapar_Click);
            // 
            // btnConvertible
            // 
            this.btnConvertible.Location = new System.Drawing.Point(17, 418);
            this.btnConvertible.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnConvertible.Name = "btnConvertible";
            this.btnConvertible.Size = new System.Drawing.Size(109, 31);
            this.btnConvertible.TabIndex = 25;
            this.btnConvertible.Text = "Convertible";
            this.btnConvertible.UseVisualStyleBackColor = true;
            this.btnConvertible.Click += new System.EventHandler(this.btnConvertible_Click);
            // 
            // grpTestDrive
            // 
            this.grpTestDrive.BackColor = System.Drawing.Color.Transparent;
            this.grpTestDrive.Controls.Add(this.btnConvertible);
            this.grpTestDrive.Controls.Add(this.btnArrancar);
            this.grpTestDrive.Controls.Add(this.btnApagar);
            this.grpTestDrive.Controls.Add(this.btnDerrapar);
            this.grpTestDrive.Controls.Add(this.btnAcelerar);
            this.grpTestDrive.Controls.Add(this.btnFrenar);
            this.grpTestDrive.Location = new System.Drawing.Point(14, 96);
            this.grpTestDrive.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpTestDrive.Name = "grpTestDrive";
            this.grpTestDrive.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpTestDrive.Size = new System.Drawing.Size(141, 474);
            this.grpTestDrive.TabIndex = 27;
            this.grpTestDrive.TabStop = false;
            this.grpTestDrive.Text = "TestDrive";
            this.grpTestDrive.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1236, 851);
            this.Controls.Add(this.grpTestDrive);
            this.Controls.Add(this.grpPrincipal);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpPrincipal.ResumeLayout(false);
            this.grpPrincipal.PerformLayout();
            this.grpTestDrive.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.GroupBox grpPrincipal;
        private System.Windows.Forms.Label lblConsumo;
        private System.Windows.Forms.Label lblCilindrada;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.TextBox txtCilindrada;
        private System.Windows.Forms.TextBox txtConsumo;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label lblAceleracion;
        private System.Windows.Forms.TextBox txtAceleracion;
        private System.Windows.Forms.Label lvlVelocidad;
        private System.Windows.Forms.Label lvlPotencia;
        private System.Windows.Forms.TextBox txtVelocidad;
        private System.Windows.Forms.TextBox txtPotencia;
        private System.Windows.Forms.Label lblTraccion;
        private System.Windows.Forms.TextBox txtTraccion;
        private System.Windows.Forms.Button btnArrancar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Button btnAcelerar;
        private System.Windows.Forms.Button btnFrenar;
        private System.Windows.Forms.Button btnDerrapar;
        private System.Windows.Forms.Button btnConvertible;
        private System.Windows.Forms.Button btnTestDrive;
        private System.Windows.Forms.GroupBox grpTestDrive;
    }
}

