namespace Views
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hospereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hospedagemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarCadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarHospedesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hospereToolStripMenuItem,
            this.hospedagemToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(662, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hospereToolStripMenuItem
            // 
            this.hospereToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem,
            this.listarToolStripMenuItem});
            this.hospereToolStripMenuItem.Name = "hospereToolStripMenuItem";
            this.hospereToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.hospereToolStripMenuItem.Text = "Hospede";
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cadastrarToolStripMenuItem.Text = "Cadastrar";
            this.cadastrarToolStripMenuItem.Click += new System.EventHandler(this.cadastrarToolStripMenuItem_Click);
            // 
            // listarToolStripMenuItem
            // 
            this.listarToolStripMenuItem.Name = "listarToolStripMenuItem";
            this.listarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.listarToolStripMenuItem.Text = "Listar";
            this.listarToolStripMenuItem.Click += new System.EventHandler(this.listarToolStripMenuItem_Click);
            // 
            // hospedagemToolStripMenuItem
            // 
            this.hospedagemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarCadastrosToolStripMenuItem,
            this.listarHospedesToolStripMenuItem});
            this.hospedagemToolStripMenuItem.Name = "hospedagemToolStripMenuItem";
            this.hospedagemToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.hospedagemToolStripMenuItem.Text = "Hospedagem";
            // 
            // listarCadastrosToolStripMenuItem
            // 
            this.listarCadastrosToolStripMenuItem.Name = "listarCadastrosToolStripMenuItem";
            this.listarCadastrosToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.listarCadastrosToolStripMenuItem.Text = "Reserva";
            this.listarCadastrosToolStripMenuItem.Click += new System.EventHandler(this.listarCadastrosToolStripMenuItem_Click);
            // 
            // listarHospedesToolStripMenuItem
            // 
            this.listarHospedesToolStripMenuItem.Name = "listarHospedesToolStripMenuItem";
            this.listarHospedesToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.listarHospedesToolStripMenuItem.Text = "Listar Hospedes";
            this.listarHospedesToolStripMenuItem.Click += new System.EventHandler(this.listarHospedesToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 408);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Pousada";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hospereToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hospedagemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarCadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarHospedesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
    }
}

