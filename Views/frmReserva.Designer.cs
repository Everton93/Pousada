namespace Views
{
    partial class frmReserva
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
            this.dtpEntrada = new System.Windows.Forms.DateTimePicker();
            this.dtpSaida = new System.Windows.Forms.DateTimePicker();
            this.rbResSimples = new System.Windows.Forms.RadioButton();
            this.rbResMedio = new System.Windows.Forms.RadioButton();
            this.rbResCompleto = new System.Windows.Forms.RadioButton();
            this.btnReservar = new System.Windows.Forms.Button();
            this.btnResCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dtpEntrada
            // 
            this.dtpEntrada.Location = new System.Drawing.Point(12, 54);
            this.dtpEntrada.Name = "dtpEntrada";
            this.dtpEntrada.Size = new System.Drawing.Size(236, 20);
            this.dtpEntrada.TabIndex = 0;
            // 
            // dtpSaida
            // 
            this.dtpSaida.Location = new System.Drawing.Point(12, 114);
            this.dtpSaida.Name = "dtpSaida";
            this.dtpSaida.Size = new System.Drawing.Size(236, 20);
            this.dtpSaida.TabIndex = 1;
            // 
            // rbResSimples
            // 
            this.rbResSimples.AutoSize = true;
            this.rbResSimples.Location = new System.Drawing.Point(12, 181);
            this.rbResSimples.Name = "rbResSimples";
            this.rbResSimples.Size = new System.Drawing.Size(61, 17);
            this.rbResSimples.TabIndex = 2;
            this.rbResSimples.TabStop = true;
            this.rbResSimples.Text = "Simples";
            this.rbResSimples.UseVisualStyleBackColor = true;
            // 
            // rbResMedio
            // 
            this.rbResMedio.AutoSize = true;
            this.rbResMedio.Location = new System.Drawing.Point(12, 215);
            this.rbResMedio.Name = "rbResMedio";
            this.rbResMedio.Size = new System.Drawing.Size(54, 17);
            this.rbResMedio.TabIndex = 3;
            this.rbResMedio.TabStop = true;
            this.rbResMedio.Text = "Medio";
            this.rbResMedio.UseVisualStyleBackColor = true;
            // 
            // rbResCompleto
            // 
            this.rbResCompleto.AutoSize = true;
            this.rbResCompleto.Location = new System.Drawing.Point(12, 248);
            this.rbResCompleto.Name = "rbResCompleto";
            this.rbResCompleto.Size = new System.Drawing.Size(69, 17);
            this.rbResCompleto.TabIndex = 4;
            this.rbResCompleto.TabStop = true;
            this.rbResCompleto.Text = "Completo";
            this.rbResCompleto.UseVisualStyleBackColor = true;
            // 
            // btnReservar
            // 
            this.btnReservar.Location = new System.Drawing.Point(42, 302);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.Size = new System.Drawing.Size(114, 28);
            this.btnReservar.TabIndex = 5;
            this.btnReservar.Text = "Reservar";
            this.btnReservar.UseVisualStyleBackColor = true;
            // 
            // btnResCancelar
            // 
            this.btnResCancelar.Location = new System.Drawing.Point(196, 302);
            this.btnResCancelar.Name = "btnResCancelar";
            this.btnResCancelar.Size = new System.Drawing.Size(114, 28);
            this.btnResCancelar.TabIndex = 6;
            this.btnResCancelar.Text = "Cancelar";
            this.btnResCancelar.UseVisualStyleBackColor = true;
            this.btnResCancelar.Click += new System.EventHandler(this.btnResCancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Reserva";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Data Saida";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(127, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "TIpos de Quarto";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Data Entrada";
            // 
            // frmReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 342);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnResCancelar);
            this.Controls.Add(this.btnReservar);
            this.Controls.Add(this.rbResCompleto);
            this.Controls.Add(this.rbResMedio);
            this.Controls.Add(this.rbResSimples);
            this.Controls.Add(this.dtpSaida);
            this.Controls.Add(this.dtpEntrada);
            this.Name = "frmReserva";
            this.Text = "Reserva";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpEntrada;
        private System.Windows.Forms.DateTimePicker dtpSaida;
        private System.Windows.Forms.RadioButton rbResSimples;
        private System.Windows.Forms.RadioButton rbResMedio;
        private System.Windows.Forms.RadioButton rbResCompleto;
        private System.Windows.Forms.Button btnReservar;
        private System.Windows.Forms.Button btnResCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}