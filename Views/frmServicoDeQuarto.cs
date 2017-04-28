using Models;
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
    public partial class frmServicoDeQuarto : Form
    {
        public frmServicoDeQuarto()
        {
            InitializeComponent();
        }

        private void btnServCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnServSalvar_Click(object sender, EventArgs e)
        {
            
            Servicos servico1 = new Servicos();
            Servicos servico2 = new Servicos();
            Servicos servico3 = new Servicos();
            try
            {
                if (rbServ1.Checked == true)
                {
                    servico1.nomeServico = "";
                    servico1.valor = 130;
                    servico1.descricao = "";

                }
                if (rbServ2.Checked == true)
                {

                }
                else
                {
                        
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
