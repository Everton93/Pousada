using Controllers;
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
    public partial class frmCadastrarCliente : Form
    {
        public frmCadastrarCliente()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void limparCampos()
        {
            txbCadNome.Clear();
            txbCadIdade.Clear();
            txbCadCpf.Clear();
            txbCadRg.Clear();
            txbCadEndereco.Clear();
        }

        private void btnCadSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if ((!string.IsNullOrEmpty(txbCadNome.Text)) || (!txbCadIdade.Equals(""))
                    || (!string.IsNullOrEmpty(txbCadCpf.Text)) || (!string.IsNullOrEmpty(txbCadRg.Text)) ||
                    (!string.IsNullOrEmpty(txbCadEndereco.Text)))
                {
                    Hospede hosp = new Hospede();
                    hosp.nomeCliente = txbCadNome.Text;
                    hosp.idadeCliente = Convert.ToInt32(txbCadIdade.Text);
                    hosp.cpfCliente = txbCadCpf.Text;
                    hosp.rgCliente = txbCadRg.Text;
                    hosp.endereco = txbCadEndereco.Text;
                    HospedeController.adicionarCliente(hosp);
                    limparCampos();
                }
                else
                {
                    MessageBox.Show("Todos os Campos Sao Obrigatorios");
                }
            }
            catch (Exception er)
            {

                MessageBox.Show(er.Message, "Erro");
            }
        }
    }
}
