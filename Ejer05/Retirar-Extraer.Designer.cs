namespace Ejer05
{
    partial class Retirar
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
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtRetirar = new System.Windows.Forms.TextBox();
            this.lblMonto = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblticket = new System.Windows.Forms.Label();
            this.grpMovimiento = new System.Windows.Forms.GroupBox();
            this.lblfinal = new System.Windows.Forms.Label();
            this.lblSalInicial = new System.Windows.Forms.Label();
            this.lblsacar = new System.Windows.Forms.Label();
            this.lbllineas = new System.Windows.Forms.Label();
            this.lblSaldoActual = new System.Windows.Forms.Label();
            this.lblRetiro = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.lblCancelar = new System.Windows.Forms.Label();
            this.lblAceptar = new System.Windows.Forms.Label();
            this.lblVolver = new System.Windows.Forms.Label();
            this.btnTICKET = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.grpMovimiento.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnVolver.Location = new System.Drawing.Point(3, 481);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(129, 61);
            this.btnVolver.TabIndex = 0;
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnAceptar.Location = new System.Drawing.Point(801, 259);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(134, 66);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtRetirar
            // 
            this.txtRetirar.Location = new System.Drawing.Point(71, 115);
            this.txtRetirar.Name = "txtRetirar";
            this.txtRetirar.Size = new System.Drawing.Size(205, 26);
            this.txtRetirar.TabIndex = 2;
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonto.ForeColor = System.Drawing.Color.Yellow;
            this.lblMonto.Location = new System.Drawing.Point(34, 64);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(287, 29);
            this.lblMonto.TabIndex = 3;
            this.lblMonto.Text = "Ingrese Monto a Retirar";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnCancelar.Location = new System.Drawing.Point(801, 369);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(134, 65);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.lblticket);
            this.panel1.Controls.Add(this.grpMovimiento);
            this.panel1.Controls.Add(this.lblCancelar);
            this.panel1.Controls.Add(this.lblAceptar);
            this.panel1.Controls.Add(this.lblVolver);
            this.panel1.Controls.Add(this.txtRetirar);
            this.panel1.Controls.Add(this.lblMonto);
            this.panel1.Location = new System.Drawing.Point(138, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(660, 485);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblticket
            // 
            this.lblticket.AutoSize = true;
            this.lblticket.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblticket.ForeColor = System.Drawing.Color.Yellow;
            this.lblticket.Location = new System.Drawing.Point(383, 436);
            this.lblticket.Name = "lblticket";
            this.lblticket.Size = new System.Drawing.Size(277, 25);
            this.lblticket.TabIndex = 8;
            this.lblticket.Text = "RETIRAR TICKET - - - - - >";
            // 
            // grpMovimiento
            // 
            this.grpMovimiento.BackColor = System.Drawing.Color.GhostWhite;
            this.grpMovimiento.Controls.Add(this.lblfinal);
            this.grpMovimiento.Controls.Add(this.lblSalInicial);
            this.grpMovimiento.Controls.Add(this.lblsacar);
            this.grpMovimiento.Controls.Add(this.lbllineas);
            this.grpMovimiento.Controls.Add(this.lblSaldoActual);
            this.grpMovimiento.Controls.Add(this.lblRetiro);
            this.grpMovimiento.Controls.Add(this.lblSaldo);
            this.grpMovimiento.Location = new System.Drawing.Point(8, 167);
            this.grpMovimiento.Name = "grpMovimiento";
            this.grpMovimiento.Size = new System.Drawing.Size(386, 244);
            this.grpMovimiento.TabIndex = 7;
            this.grpMovimiento.TabStop = false;
            this.grpMovimiento.Text = "Movimiento en la Cuenta";
            // 
            // lblfinal
            // 
            this.lblfinal.AutoSize = true;
            this.lblfinal.Location = new System.Drawing.Point(148, 188);
            this.lblfinal.Name = "lblfinal";
            this.lblfinal.Size = new System.Drawing.Size(0, 20);
            this.lblfinal.TabIndex = 6;
            // 
            // lblSalInicial
            // 
            this.lblSalInicial.AutoSize = true;
            this.lblSalInicial.Location = new System.Drawing.Point(148, 69);
            this.lblSalInicial.Name = "lblSalInicial";
            this.lblSalInicial.Size = new System.Drawing.Size(0, 20);
            this.lblSalInicial.TabIndex = 5;
            // 
            // lblsacar
            // 
            this.lblsacar.AutoSize = true;
            this.lblsacar.Location = new System.Drawing.Point(148, 112);
            this.lblsacar.Name = "lblsacar";
            this.lblsacar.Size = new System.Drawing.Size(0, 20);
            this.lblsacar.TabIndex = 4;
            // 
            // lbllineas
            // 
            this.lbllineas.AutoSize = true;
            this.lbllineas.Location = new System.Drawing.Point(8, 150);
            this.lbllineas.Name = "lbllineas";
            this.lbllineas.Size = new System.Drawing.Size(294, 20);
            this.lbllineas.TabIndex = 3;
            this.lbllineas.Text = "---------------------------------------------------------";
            // 
            // lblSaldoActual
            // 
            this.lblSaldoActual.AutoSize = true;
            this.lblSaldoActual.Location = new System.Drawing.Point(6, 188);
            this.lblSaldoActual.Name = "lblSaldoActual";
            this.lblSaldoActual.Size = new System.Drawing.Size(99, 20);
            this.lblSaldoActual.TabIndex = 2;
            this.lblSaldoActual.Text = "Saldo Actual";
            // 
            // lblRetiro
            // 
            this.lblRetiro.AutoSize = true;
            this.lblRetiro.Location = new System.Drawing.Point(8, 112);
            this.lblRetiro.Name = "lblRetiro";
            this.lblRetiro.Size = new System.Drawing.Size(76, 20);
            this.lblRetiro.TabIndex = 1;
            this.lblRetiro.Text = "Retiro:     ";
            this.lblRetiro.Click += new System.EventHandler(this.lblRetiro_Click);
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(6, 69);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(102, 20);
            this.lblSaldo.TabIndex = 0;
            this.lblSaldo.Text = "Saldo Inicial :";
            // 
            // lblCancelar
            // 
            this.lblCancelar.AutoSize = true;
            this.lblCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCancelar.ForeColor = System.Drawing.Color.Yellow;
            this.lblCancelar.Location = new System.Drawing.Point(428, 328);
            this.lblCancelar.Name = "lblCancelar";
            this.lblCancelar.Size = new System.Drawing.Size(232, 25);
            this.lblCancelar.TabIndex = 6;
            this.lblCancelar.Text = "CANCERLAR - - - - - >";
            // 
            // lblAceptar
            // 
            this.lblAceptar.AutoSize = true;
            this.lblAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAceptar.ForeColor = System.Drawing.Color.Yellow;
            this.lblAceptar.Location = new System.Drawing.Point(431, 219);
            this.lblAceptar.Name = "lblAceptar";
            this.lblAceptar.Size = new System.Drawing.Size(217, 25);
            this.lblAceptar.TabIndex = 5;
            this.lblAceptar.Text = "ACEPTAR - - - - - - >";
            // 
            // lblVolver
            // 
            this.lblVolver.AutoSize = true;
            this.lblVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVolver.ForeColor = System.Drawing.Color.Yellow;
            this.lblVolver.Location = new System.Drawing.Point(3, 438);
            this.lblVolver.Name = "lblVolver";
            this.lblVolver.Size = new System.Drawing.Size(188, 25);
            this.lblVolver.TabIndex = 4;
            this.lblVolver.Text = "< - - - - - VOLVER";
            // 
            // btnTICKET
            // 
            this.btnTICKET.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnTICKET.Location = new System.Drawing.Point(801, 477);
            this.btnTICKET.Name = "btnTICKET";
            this.btnTICKET.Size = new System.Drawing.Size(134, 65);
            this.btnTICKET.TabIndex = 6;
            this.btnTICKET.UseVisualStyleBackColor = false;
            this.btnTICKET.Click += new System.EventHandler(this.btnTICKET_Click);
            // 
            // Retirar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(937, 588);
            this.Controls.Add(this.btnTICKET);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnVolver);
            this.Name = "Retirar";
            this.Text = "Retirar";
            this.Load += new System.EventHandler(this.Retirar_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grpMovimiento.ResumeLayout(false);
            this.grpMovimiento.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txtRetirar;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCancelar;
        private System.Windows.Forms.Label lblAceptar;
        private System.Windows.Forms.Label lblVolver;
        private System.Windows.Forms.GroupBox grpMovimiento;
        private System.Windows.Forms.Label lbllineas;
        private System.Windows.Forms.Label lblSaldoActual;
        private System.Windows.Forms.Label lblRetiro;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label lblfinal;
        private System.Windows.Forms.Label lblSalInicial;
        private System.Windows.Forms.Label lblsacar;
        private System.Windows.Forms.Label lblticket;
        private System.Windows.Forms.Button btnTICKET;
    }
}