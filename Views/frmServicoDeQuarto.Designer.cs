namespace Views
{
    partial class frmServicoDeQuarto
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
            this.rbServ1 = new System.Windows.Forms.RadioButton();
            this.rbServ2 = new System.Windows.Forms.RadioButton();
            this.rbServ3 = new System.Windows.Forms.RadioButton();
            this.btnServSalvar = new System.Windows.Forms.Button();
            this.btnServCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Servicos";
            // 
            // rbServ1
            // 
            this.rbServ1.AutoSize = true;
            this.rbServ1.Location = new System.Drawing.Point(23, 79);
            this.rbServ1.Name = "rbServ1";
            this.rbServ1.Size = new System.Drawing.Size(70, 17);
            this.rbServ1.TabIndex = 1;
            this.rbServ1.TabStop = true;
            this.rbServ1.Text = "Servico 1";
            this.rbServ1.UseVisualStyleBackColor = true;
            this.rbServ1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbServ2
            // 
            this.rbServ2.AutoSize = true;
            this.rbServ2.Location = new System.Drawing.Point(23, 114);
            this.rbServ2.Name = "rbServ2";
            this.rbServ2.Size = new System.Drawing.Size(70, 17);
            this.rbServ2.TabIndex = 2;
            this.rbServ2.TabStop = true;
            this.rbServ2.Text = "Servico 2";
            this.rbServ2.UseVisualStyleBackColor = true;
            this.rbServ2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rbServ3
            // 
            this.rbServ3.AutoSize = true;
            this.rbServ3.Location = new System.Drawing.Point(23, 147);
            this.rbServ3.Name = "rbServ3";
            this.rbServ3.Size = new System.Drawing.Size(70, 17);
            this.rbServ3.TabIndex = 3;
            this.rbServ3.TabStop = true;
            this.rbServ3.Text = "Servico 3";
            this.rbServ3.UseVisualStyleBackColor = true;
            this.rbServ3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // btnServSalvar
            // 
            this.btnServSalvar.Location = new System.Drawing.Point(40, 207);
            this.btnServSalvar.Name = "btnServSalvar";
            this.btnServSalvar.Size = new System.Drawing.Size(108, 31);
            this.btnServSalvar.TabIndex = 4;
            this.btnServSalvar.Text = "Salvar";
            this.btnServSalvar.UseVisualStyleBackColor = true;
            this.btnServSalvar.Click += new System.EventHandler(this.btnServSalvar_Click);
            // 
            // btnServCancelar
            // 
            this.btnServCancelar.Location = new System.Drawing.Point(175, 207);
            this.btnServCancelar.Name = "btnServCancelar";
            this.btnServCancelar.Size = new System.Drawing.Size(109, 31);
            this.btnServCancelar.TabIndex = 5;
            this.btnServCancelar.Text = "Cancelar";
            this.btnServCancelar.UseVisualStyleBackColor = true;
            this.btnServCancelar.Click += new System.EventHandler(this.btnServCancelar_Click);
            // 
            // frmServicoDeQuarto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 276);
            this.Controls.Add(this.btnServCancelar);
            this.Controls.Add(this.btnServSalvar);
            this.Controls.Add(this.rbServ3);
            this.Controls.Add(this.rbServ2);
            this.Controls.Add(this.rbServ1);
            this.Controls.Add(this.label1);
            this.Name = "frmServicoDeQuarto";
            this.Text = "Servicos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbServ1;
        private System.Windows.Forms.RadioButton rbServ2;
        private System.Windows.Forms.RadioButton rbServ3;
        private System.Windows.Forms.Button btnServSalvar;
        private System.Windows.Forms.Button btnServCancelar;
    }
}