namespace Ejer05
{
    partial class Form2
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
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtDepositar = new System.Windows.Forms.TextBox();
            this.lblDepositar = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.grpMovimiento = new System.Windows.Forms.GroupBox();
            this.lblfinal = new System.Windows.Forms.Label();
            this.lblSalInicial = new System.Windows.Forms.Label();
            this.lbldepo = new System.Windows.Forms.Label();
            this.lbllineas = new System.Windows.Forms.Label();
            this.lblSaldoActual = new System.Windows.Forms.Label();
            this.lblRetiro = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblVolver = new System.Windows.Forms.Label();
            this.lblCancelar = new System.Windows.Forms.Label();
            this.lblAceptar = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.grpMovimiento.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(904, 228);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(151, 57);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtDepositar
            // 
            this.txtDepositar.Location = new System.Drawing.Point(57, 84);
            this.txtDepositar.Name = "txtDepositar";
            this.txtDepositar.Size = new System.Drawing.Size(173, 26);
            this.txtDepositar.TabIndex = 1;
            // 
            // lblDepositar
            // 
            this.lblDepositar.AutoSize = true;
            this.lblDepositar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepositar.ForeColor = System.Drawing.Color.Yellow;
            this.lblDepositar.Location = new System.Drawing.Point(40, 41);
            this.lblDepositar.Name = "lblDepositar";
            this.lblDepositar.Size = new System.Drawing.Size(270, 25);
            this.lblDepositar.TabIndex = 2;
            this.lblDepositar.Text = "Agregar monto a Depositar";
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(1, 489);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(145, 60);
            this.btnVolver.TabIndex = 3;
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.button2_Click);
            // 
            // grpMovimiento
            // 
            this.grpMovimiento.BackColor = System.Drawing.Color.GhostWhite;
            this.grpMovimiento.Controls.Add(this.lblfinal);
            this.grpMovimiento.Controls.Add(this.lblSalInicial);
            this.grpMovimiento.Controls.Add(this.lbldepo);
            this.grpMovimiento.Controls.Add(this.lbllineas);
            this.grpMovimiento.Controls.Add(this.lblSaldoActual);
            this.grpMovimiento.Controls.Add(this.lblRetiro);
            this.grpMovimiento.Controls.Add(this.lblSaldo);
            this.grpMovimiento.Location = new System.Drawing.Point(19, 144);
            this.grpMovimiento.Name = "grpMovimiento";
            this.grpMovimiento.Size = new System.Drawing.Size(386, 244);
            this.grpMovimiento.TabIndex = 8;
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
            // lbldepo
            // 
            this.lbldepo.AutoSize = true;
            this.lbldepo.Location = new System.Drawing.Point(148, 112);
            this.lbldepo.Name = "lbldepo";
            this.lbldepo.Size = new System.Drawing.Size(0, 20);
            this.lbldepo.TabIndex = 4;
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
            this.lblRetiro.Size = new System.Drawing.Size(97, 20);
            this.lblRetiro.TabIndex = 1;
            this.lblRetiro.Text = "Deposito:     ";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(6, 69);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(99, 20);
            this.lblSaldo.TabIndex = 0;
            this.lblSaldo.Text = "Saldo Incial :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.lblVolver);
            this.panel1.Controls.Add(this.lblCancelar);
            this.panel1.Controls.Add(this.lblAceptar);
            this.panel1.Controls.Add(this.grpMovimiento);
            this.panel1.Controls.Add(this.txtDepositar);
            this.panel1.Controls.Add(this.lblDepositar);
            this.panel1.Location = new System.Drawing.Point(152, 98);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(746, 455);
            this.panel1.TabIndex = 9;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblVolver
            // 
            this.lblVolver.AutoSize = true;
            this.lblVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVolver.ForeColor = System.Drawing.Color.Yellow;
            this.lblVolver.Location = new System.Drawing.Point(14, 407);
            this.lblVolver.Name = "lblVolver";
            this.lblVolver.Size = new System.Drawing.Size(188, 25);
            this.lblVolver.TabIndex = 11;
            this.lblVolver.Text = "< - - - - - VOLVER";
            // 
            // lblCancelar
            // 
            this.lblCancelar.AutoSize = true;
            this.lblCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCancelar.ForeColor = System.Drawing.Color.Yellow;
            this.lblCancelar.Location = new System.Drawing.Point(489, 289);
            this.lblCancelar.Name = "lblCancelar";
            this.lblCancelar.Size = new System.Drawing.Size(232, 25);
            this.lblCancelar.TabIndex = 10;
            this.lblCancelar.Text = "CANCERLAR - - - - - >";
            // 
            // lblAceptar
            // 
            this.lblAceptar.AutoSize = true;
            this.lblAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAceptar.ForeColor = System.Drawing.Color.Yellow;
            this.lblAceptar.Location = new System.Drawing.Point(504, 144);
            this.lblAceptar.Name = "lblAceptar";
            this.lblAceptar.Size = new System.Drawing.Size(217, 25);
            this.lblAceptar.TabIndex = 9;
            this.lblAceptar.Text = "ACEPTAR - - - - - - >";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(904, 373);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(151, 57);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1058, 661);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnAceptar);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.grpMovimiento.ResumeLayout(false);
            this.grpMovimiento.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txtDepositar;
        private System.Windows.Forms.Label lblDepositar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.GroupBox grpMovimiento;
        private System.Windows.Forms.Label lblfinal;
        private System.Windows.Forms.Label lblSalInicial;
        private System.Windows.Forms.Label lbldepo;
        private System.Windows.Forms.Label lbllineas;
        private System.Windows.Forms.Label lblSaldoActual;
        private System.Windows.Forms.Label lblRetiro;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCancelar;
        private System.Windows.Forms.Label lblAceptar;
        private System.Windows.Forms.Label lblVolver;
        private System.Windows.Forms.Button btnCancelar;
    }
}