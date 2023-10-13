namespace Ejercici3
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
            this.grpAutoMoviles = new System.Windows.Forms.GroupBox();
            this.rdoAuto3 = new System.Windows.Forms.RadioButton();
            this.rdoAuto2 = new System.Windows.Forms.RadioButton();
            this.rdoFiat = new System.Windows.Forms.RadioButton();
            this.btnAuto = new System.Windows.Forms.Button();
            this.btnMotor = new System.Windows.Forms.Button();
            this.btnArrancar = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblAuto = new System.Windows.Forms.Label();
            this.picAuto1 = new System.Windows.Forms.PictureBox();
            this.lblMotor = new System.Windows.Forms.Label();
            this.lblPotencia = new System.Windows.Forms.Label();
            this.lblConsumo = new System.Windows.Forms.Label();
            this.lblCilindrada = new System.Windows.Forms.Label();
            this.txtCilindrada = new System.Windows.Forms.TextBox();
            this.txtConsumo = new System.Windows.Forms.TextBox();
            this.txtPotencia = new System.Windows.Forms.TextBox();
            this.picAuto2 = new System.Windows.Forms.PictureBox();
            this.grpAutoMoviles.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAuto1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAuto2)).BeginInit();
            this.SuspendLayout();
            // 
            // grpAutoMoviles
            // 
            this.grpAutoMoviles.Controls.Add(this.rdoAuto3);
            this.grpAutoMoviles.Controls.Add(this.rdoAuto2);
            this.grpAutoMoviles.Controls.Add(this.rdoFiat);
            this.grpAutoMoviles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAutoMoviles.Location = new System.Drawing.Point(12, 30);
            this.grpAutoMoviles.Name = "grpAutoMoviles";
            this.grpAutoMoviles.Size = new System.Drawing.Size(161, 253);
            this.grpAutoMoviles.TabIndex = 0;
            this.grpAutoMoviles.TabStop = false;
            this.grpAutoMoviles.Text = "AutoMoviles";
            // 
            // rdoAuto3
            // 
            this.rdoAuto3.AutoSize = true;
            this.rdoAuto3.Location = new System.Drawing.Point(17, 184);
            this.rdoAuto3.Name = "rdoAuto3";
            this.rdoAuto3.Size = new System.Drawing.Size(93, 26);
            this.rdoAuto3.TabIndex = 2;
            this.rdoAuto3.TabStop = true;
            this.rdoAuto3.Text = "Cobalt";
            this.rdoAuto3.UseVisualStyleBackColor = true;
            this.rdoAuto3.CheckedChanged += new System.EventHandler(this.rdoAuto3_CheckedChanged);
            // 
            // rdoAuto2
            // 
            this.rdoAuto2.AutoSize = true;
            this.rdoAuto2.Location = new System.Drawing.Point(17, 116);
            this.rdoAuto2.Name = "rdoAuto2";
            this.rdoAuto2.Size = new System.Drawing.Size(94, 26);
            this.rdoAuto2.TabIndex = 1;
            this.rdoAuto2.TabStop = true;
            this.rdoAuto2.Text = "Sentra";
            this.rdoAuto2.UseVisualStyleBackColor = true;
            this.rdoAuto2.CheckedChanged += new System.EventHandler(this.rdoAuto2_CheckedChanged);
            // 
            // rdoFiat
            // 
            this.rdoFiat.AutoSize = true;
            this.rdoFiat.Location = new System.Drawing.Point(17, 48);
            this.rdoFiat.Name = "rdoFiat";
            this.rdoFiat.Size = new System.Drawing.Size(99, 26);
            this.rdoFiat.TabIndex = 0;
            this.rdoFiat.TabStop = true;
            this.rdoFiat.Text = "Cronos";
            this.rdoFiat.UseVisualStyleBackColor = true;
            this.rdoFiat.CheckedChanged += new System.EventHandler(this.rdoFiat_CheckedChanged);
            // 
            // btnAuto
            // 
            this.btnAuto.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAuto.Location = new System.Drawing.Point(283, 30);
            this.btnAuto.Name = "btnAuto";
            this.btnAuto.Size = new System.Drawing.Size(183, 38);
            this.btnAuto.TabIndex = 1;
            this.btnAuto.Text = "Detalle AutoMovil";
            this.btnAuto.UseVisualStyleBackColor = false;
            this.btnAuto.Click += new System.EventHandler(this.btnAuto_Click);
            // 
            // btnMotor
            // 
            this.btnMotor.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnMotor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMotor.Location = new System.Drawing.Point(741, 29);
            this.btnMotor.Name = "btnMotor";
            this.btnMotor.Size = new System.Drawing.Size(183, 39);
            this.btnMotor.TabIndex = 2;
            this.btnMotor.Text = "Detalle del Motor";
            this.btnMotor.UseVisualStyleBackColor = false;
            this.btnMotor.Click += new System.EventHandler(this.btnMotor_Click);
            // 
            // btnArrancar
            // 
            this.btnArrancar.BackColor = System.Drawing.Color.Silver;
            this.btnArrancar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArrancar.Location = new System.Drawing.Point(51, 519);
            this.btnArrancar.Name = "btnArrancar";
            this.btnArrancar.Size = new System.Drawing.Size(103, 38);
            this.btnArrancar.TabIndex = 3;
            this.btnArrancar.Text = "Arrancar";
            this.btnArrancar.UseVisualStyleBackColor = false;
            this.btnArrancar.Click += new System.EventHandler(this.btnArrancar_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.BackColor = System.Drawing.Color.Silver;
            this.btnApagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagar.Location = new System.Drawing.Point(634, 519);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(103, 38);
            this.btnApagar.TabIndex = 4;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = false;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(87, 65);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(183, 26);
            this.txtMarca.TabIndex = 5;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(89, 123);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(183, 26);
            this.txtModelo.TabIndex = 6;
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(89, 185);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(183, 26);
            this.txtColor.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.picAuto2);
            this.panel1.Controls.Add(this.lblPotencia);
            this.panel1.Controls.Add(this.lblConsumo);
            this.panel1.Controls.Add(this.lblCilindrada);
            this.panel1.Controls.Add(this.txtCilindrada);
            this.panel1.Controls.Add(this.txtConsumo);
            this.panel1.Controls.Add(this.txtPotencia);
            this.panel1.Controls.Add(this.lblMotor);
            this.panel1.Controls.Add(this.picAuto1);
            this.panel1.Controls.Add(this.lblAuto);
            this.panel1.Controls.Add(this.btnApagar);
            this.panel1.Controls.Add(this.lblModelo);
            this.panel1.Controls.Add(this.btnArrancar);
            this.panel1.Controls.Add(this.lblColor);
            this.panel1.Controls.Add(this.lblMarca);
            this.panel1.Controls.Add(this.txtMarca);
            this.panel1.Controls.Add(this.txtColor);
            this.panel1.Controls.Add(this.txtModelo);
            this.panel1.Location = new System.Drawing.Point(232, 101);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(810, 593);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(9, 71);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(58, 20);
            this.lblMarca.TabIndex = 8;
            this.lblMarca.Text = "Marca";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor.Location = new System.Drawing.Point(9, 191);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(51, 20);
            this.lblColor.TabIndex = 9;
            this.lblColor.Text = "Color";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelo.Location = new System.Drawing.Point(9, 129);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(67, 20);
            this.lblModelo.TabIndex = 10;
            this.lblModelo.Text = "Modelo";
            // 
            // lblAuto
            // 
            this.lblAuto.AutoSize = true;
            this.lblAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuto.Location = new System.Drawing.Point(127, 14);
            this.lblAuto.Name = "lblAuto";
            this.lblAuto.Size = new System.Drawing.Size(78, 32);
            this.lblAuto.TabIndex = 11;
            this.lblAuto.Text = "Auto";
            // 
            // picAuto1
            // 
            this.picAuto1.Location = new System.Drawing.Point(22, 283);
            this.picAuto1.Name = "picAuto1";
            this.picAuto1.Size = new System.Drawing.Size(364, 230);
            this.picAuto1.TabIndex = 12;
            this.picAuto1.TabStop = false;
            // 
            // lblMotor
            // 
            this.lblMotor.AutoSize = true;
            this.lblMotor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotor.Location = new System.Drawing.Point(486, 14);
            this.lblMotor.Name = "lblMotor";
            this.lblMotor.Size = new System.Drawing.Size(92, 32);
            this.lblMotor.TabIndex = 13;
            this.lblMotor.Text = "Motor";
            // 
            // lblPotencia
            // 
            this.lblPotencia.AutoSize = true;
            this.lblPotencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPotencia.Location = new System.Drawing.Point(340, 129);
            this.lblPotencia.Name = "lblPotencia";
            this.lblPotencia.Size = new System.Drawing.Size(79, 20);
            this.lblPotencia.TabIndex = 19;
            this.lblPotencia.Text = "Potencia";
            // 
            // lblConsumo
            // 
            this.lblConsumo.AutoSize = true;
            this.lblConsumo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsumo.Location = new System.Drawing.Point(340, 191);
            this.lblConsumo.Name = "lblConsumo";
            this.lblConsumo.Size = new System.Drawing.Size(84, 20);
            this.lblConsumo.TabIndex = 18;
            this.lblConsumo.Text = "Consumo";
            // 
            // lblCilindrada
            // 
            this.lblCilindrada.AutoSize = true;
            this.lblCilindrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCilindrada.Location = new System.Drawing.Point(340, 71);
            this.lblCilindrada.Name = "lblCilindrada";
            this.lblCilindrada.Size = new System.Drawing.Size(89, 20);
            this.lblCilindrada.TabIndex = 17;
            this.lblCilindrada.Text = "Cilindrada";
            // 
            // txtCilindrada
            // 
            this.txtCilindrada.Location = new System.Drawing.Point(446, 65);
            this.txtCilindrada.Name = "txtCilindrada";
            this.txtCilindrada.Size = new System.Drawing.Size(183, 26);
            this.txtCilindrada.TabIndex = 14;
            // 
            // txtConsumo
            // 
            this.txtConsumo.Location = new System.Drawing.Point(446, 185);
            this.txtConsumo.Name = "txtConsumo";
            this.txtConsumo.Size = new System.Drawing.Size(183, 26);
            this.txtConsumo.TabIndex = 16;
            // 
            // txtPotencia
            // 
            this.txtPotencia.Location = new System.Drawing.Point(446, 126);
            this.txtPotencia.Name = "txtPotencia";
            this.txtPotencia.Size = new System.Drawing.Size(183, 26);
            this.txtPotencia.TabIndex = 15;
            // 
            // picAuto2
            // 
            this.picAuto2.Location = new System.Drawing.Point(425, 283);
            this.picAuto2.Name = "picAuto2";
            this.picAuto2.Size = new System.Drawing.Size(369, 230);
            this.picAuto2.TabIndex = 20;
            this.picAuto2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1137, 706);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnMotor);
            this.Controls.Add(this.btnAuto);
            this.Controls.Add(this.grpAutoMoviles);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpAutoMoviles.ResumeLayout(false);
            this.grpAutoMoviles.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAuto1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAuto2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAutoMoviles;
        private System.Windows.Forms.RadioButton rdoAuto3;
        private System.Windows.Forms.RadioButton rdoAuto2;
        private System.Windows.Forms.RadioButton rdoFiat;
        private System.Windows.Forms.Button btnAuto;
        private System.Windows.Forms.Button btnMotor;
        private System.Windows.Forms.Button btnArrancar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picAuto1;
        private System.Windows.Forms.Label lblAuto;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblPotencia;
        private System.Windows.Forms.Label lblConsumo;
        private System.Windows.Forms.Label lblCilindrada;
        private System.Windows.Forms.TextBox txtCilindrada;
        private System.Windows.Forms.TextBox txtConsumo;
        private System.Windows.Forms.TextBox txtPotencia;
        private System.Windows.Forms.Label lblMotor;
        private System.Windows.Forms.PictureBox picAuto2;
    }
}

