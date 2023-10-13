namespace Ejercicio_05
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblRetiro = new System.Windows.Forms.Label();
            this.lbloDeposito = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.lblSalir = new System.Windows.Forms.Label();
            this.lblCuentaBancaria = new System.Windows.Forms.Label();
            this.lblBanco = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnDeposito = new System.Windows.Forms.Button();
            this.btnSaldo = new System.Windows.Forms.Button();
            this.btnRetiro = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.lblRetiro);
            this.panel1.Controls.Add(this.lbloDeposito);
            this.panel1.Controls.Add(this.lblSaldo);
            this.panel1.Controls.Add(this.lblSalir);
            this.panel1.Controls.Add(this.lblCuentaBancaria);
            this.panel1.Controls.Add(this.lblBanco);
            this.panel1.Location = new System.Drawing.Point(101, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(596, 420);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblRetiro
            // 
            this.lblRetiro.AutoSize = true;
            this.lblRetiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRetiro.ForeColor = System.Drawing.Color.Yellow;
            this.lblRetiro.Location = new System.Drawing.Point(370, 314);
            this.lblRetiro.Name = "lblRetiro";
            this.lblRetiro.Size = new System.Drawing.Size(208, 25);
            this.lblRetiro.TabIndex = 11;
            this.lblRetiro.Text = "RETIRO - - - - - - - >";
            // 
            // lbloDeposito
            // 
            this.lbloDeposito.AutoSize = true;
            this.lbloDeposito.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbloDeposito.ForeColor = System.Drawing.Color.Yellow;
            this.lbloDeposito.Location = new System.Drawing.Point(370, 237);
            this.lbloDeposito.Name = "lbloDeposito";
            this.lbloDeposito.Size = new System.Drawing.Size(213, 25);
            this.lbloDeposito.TabIndex = 10;
            this.lbloDeposito.Text = "DEPOSITO - - - - - >";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.ForeColor = System.Drawing.Color.Yellow;
            this.lblSaldo.Location = new System.Drawing.Point(380, 165);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(203, 25);
            this.lblSaldo.TabIndex = 9;
            this.lblSaldo.Text = "SALDO - - - - - - - >";
            // 
            // lblSalir
            // 
            this.lblSalir.AutoSize = true;
            this.lblSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalir.ForeColor = System.Drawing.Color.Yellow;
            this.lblSalir.Location = new System.Drawing.Point(3, 314);
            this.lblSalir.Name = "lblSalir";
            this.lblSalir.Size = new System.Drawing.Size(185, 25);
            this.lblSalir.TabIndex = 8;
            this.lblSalir.Text = "<- - - - - - - SALIR";
            // 
            // lblCuentaBancaria
            // 
            this.lblCuentaBancaria.AutoSize = true;
            this.lblCuentaBancaria.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuentaBancaria.ForeColor = System.Drawing.Color.Yellow;
            this.lblCuentaBancaria.Location = new System.Drawing.Point(98, 32);
            this.lblCuentaBancaria.Name = "lblCuentaBancaria";
            this.lblCuentaBancaria.Size = new System.Drawing.Size(378, 27);
            this.lblCuentaBancaria.TabIndex = 4;
            this.lblCuentaBancaria.Text = "SELECCIONE EL TIPO DE OPERACION";
            // 
            // lblBanco
            // 
            this.lblBanco.AutoSize = true;
            this.lblBanco.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBanco.ForeColor = System.Drawing.Color.Yellow;
            this.lblBanco.Location = new System.Drawing.Point(168, 59);
            this.lblBanco.Name = "lblBanco";
            this.lblBanco.Size = new System.Drawing.Size(242, 27);
            this.lblBanco.TabIndex = 3;
            this.lblBanco.Text = " QUE DESEA EFECTUAR";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(4, 350);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(94, 47);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDeposito
            // 
            this.btnDeposito.Location = new System.Drawing.Point(703, 274);
            this.btnDeposito.Name = "btnDeposito";
            this.btnDeposito.Size = new System.Drawing.Size(110, 45);
            this.btnDeposito.TabIndex = 2;
            this.btnDeposito.UseVisualStyleBackColor = true;
            this.btnDeposito.Click += new System.EventHandler(this.btnDeposito_Click);
            // 
            // btnSaldo
            // 
            this.btnSaldo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSaldo.Location = new System.Drawing.Point(703, 188);
            this.btnSaldo.Name = "btnSaldo";
            this.btnSaldo.Size = new System.Drawing.Size(110, 47);
            this.btnSaldo.TabIndex = 1;
            this.btnSaldo.UseVisualStyleBackColor = false;
            this.btnSaldo.Click += new System.EventHandler(this.btnSaldo_Click);
            // 
            // btnRetiro
            // 
            this.btnRetiro.Location = new System.Drawing.Point(703, 353);
            this.btnRetiro.Name = "btnRetiro";
            this.btnRetiro.Size = new System.Drawing.Size(110, 44);
            this.btnRetiro.TabIndex = 0;
            this.btnRetiro.UseVisualStyleBackColor = true;
            this.btnRetiro.Click += new System.EventHandler(this.btnRetiro_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(814, 526);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnRetiro);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnDeposito);
            this.Controls.Add(this.btnSaldo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDeposito;
        private System.Windows.Forms.Button btnSaldo;
        private System.Windows.Forms.Button btnRetiro;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblCuentaBancaria;
        private System.Windows.Forms.Label lblBanco;
        private System.Windows.Forms.Label lblRetiro;
        private System.Windows.Forms.Label lbloDeposito;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label lblSalir;
    }
}

