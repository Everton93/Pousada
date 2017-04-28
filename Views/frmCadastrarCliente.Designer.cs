namespace Views
{
    partial class frmCadastrarCliente
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCadSalvar = new System.Windows.Forms.Button();
            this.btnCadCancelar = new System.Windows.Forms.Button();
            this.txbCadNome = new System.Windows.Forms.TextBox();
            this.txbCadIdade = new System.Windows.Forms.TextBox();
            this.txbCadCpf = new System.Windows.Forms.TextBox();
            this.txbCadRg = new System.Windows.Forms.TextBox();
            this.txbCadEndereco = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(160, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Idade";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "CPF";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "RG";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Endereco";
            // 
            // btnCadSalvar
            // 
            this.btnCadSalvar.Location = new System.Drawing.Point(92, 216);
            this.btnCadSalvar.Name = "btnCadSalvar";
            this.btnCadSalvar.Size = new System.Drawing.Size(102, 27);
            this.btnCadSalvar.TabIndex = 7;
            this.btnCadSalvar.Text = "Salvar";
            this.btnCadSalvar.UseVisualStyleBackColor = true;
            this.btnCadSalvar.Click += new System.EventHandler(this.btnCadSalvar_Click);
            // 
            // btnCadCancelar
            // 
            this.btnCadCancelar.Location = new System.Drawing.Point(216, 216);
            this.btnCadCancelar.Name = "btnCadCancelar";
            this.btnCadCancelar.Size = new System.Drawing.Size(102, 27);
            this.btnCadCancelar.TabIndex = 8;
            this.btnCadCancelar.Text = "Cancelar";
            this.btnCadCancelar.UseVisualStyleBackColor = true;
            this.btnCadCancelar.Click += new System.EventHandler(this.button2_Click);
            // 
            // txbCadNome
            // 
            this.txbCadNome.Location = new System.Drawing.Point(78, 56);
            this.txbCadNome.Name = "txbCadNome";
            this.txbCadNome.Size = new System.Drawing.Size(273, 20);
            this.txbCadNome.TabIndex = 9;
            // 
            // txbCadIdade
            // 
            this.txbCadIdade.Location = new System.Drawing.Point(78, 82);
            this.txbCadIdade.Name = "txbCadIdade";
            this.txbCadIdade.Size = new System.Drawing.Size(45, 20);
            this.txbCadIdade.TabIndex = 10;
            // 
            // txbCadCpf
            // 
            this.txbCadCpf.Location = new System.Drawing.Point(78, 108);
            this.txbCadCpf.Name = "txbCadCpf";
            this.txbCadCpf.Size = new System.Drawing.Size(180, 20);
            this.txbCadCpf.TabIndex = 11;
            // 
            // txbCadRg
            // 
            this.txbCadRg.Location = new System.Drawing.Point(78, 135);
            this.txbCadRg.Name = "txbCadRg";
            this.txbCadRg.Size = new System.Drawing.Size(180, 20);
            this.txbCadRg.TabIndex = 12;
            // 
            // txbCadEndereco
            // 
            this.txbCadEndereco.Location = new System.Drawing.Point(78, 160);
            this.txbCadEndereco.Name = "txbCadEndereco";
            this.txbCadEndereco.Size = new System.Drawing.Size(273, 20);
            this.txbCadEndereco.TabIndex = 13;
            // 
            // frmCadastrarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 268);
            this.Controls.Add(this.txbCadEndereco);
            this.Controls.Add(this.txbCadRg);
            this.Controls.Add(this.txbCadCpf);
            this.Controls.Add(this.txbCadIdade);
            this.Controls.Add(this.txbCadNome);
            this.Controls.Add(this.btnCadCancelar);
            this.Controls.Add(this.btnCadSalvar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmCadastrarCliente";
            this.Text = "Cadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCadSalvar;
        private System.Windows.Forms.Button btnCadCancelar;
        private System.Windows.Forms.TextBox txbCadNome;
        private System.Windows.Forms.TextBox txbCadIdade;
        private System.Windows.Forms.TextBox txbCadCpf;
        private System.Windows.Forms.TextBox txbCadRg;
        private System.Windows.Forms.TextBox txbCadEndereco;
    }
}