using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Views
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastrarCliente frmCas = new frmCadastrarCliente();
            frmCas.MdiParent = this;
            frmCas.Show();
        }

        private void listarCadastrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReserva frmRes = new frmReserva();
            frmRes.MdiParent = this;
            frmRes.Show();
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListarClientes frmLisCli = new FrmListarClientes();
            frmLisCli.MdiParent = this;
            frmLisCli.Show();
        }

        private void listarHospedesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHospedes frmLisHos = new frmHospedes();
            frmLisHos.MdiParent = this;
            frmLisHos.Show();
        }
    }
}
