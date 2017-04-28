namespace Views
{
    partial class FrmListarClientes
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
            this.dgvLisClientes = new System.Windows.Forms.DataGridView();
            this.btnLisAtualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLisClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLisClientes
            // 
            this.dgvLisClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLisClientes.Location = new System.Drawing.Point(-2, 2);
            this.dgvLisClientes.Name = "dgvLisClientes";
            this.dgvLisClientes.Size = new System.Drawing.Size(551, 321);
            this.dgvLisClientes.TabIndex = 0;
            // 
            // btnLisAtualizar
            // 
            this.btnLisAtualizar.Location = new System.Drawing.Point(205, 333);
            this.btnLisAtualizar.Name = "btnLisAtualizar";
            this.btnLisAtualizar.Size = new System.Drawing.Size(111, 32);
            this.btnLisAtualizar.TabIndex = 1;
            this.btnLisAtualizar.Text = "Atualizar";
            this.btnLisAtualizar.UseVisualStyleBackColor = true;
            // 
            // FrmListarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 377);
            this.Controls.Add(this.btnLisAtualizar);
            this.Controls.Add(this.dgvLisClientes);
            this.Name = "FrmListarClientes";
            this.Text = "FrmListarClientes";
            this.Load += new System.EventHandler(this.FrmListarClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLisClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLisClientes;
        private System.Windows.Forms.Button btnLisAtualizar;
    }
}