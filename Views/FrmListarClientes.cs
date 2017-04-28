using Controllers;
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
    public partial class FrmListarClientes : Form
    {
        public FrmListarClientes()
        {
            InitializeComponent();
        }

        private void FrmListarClientes_Load(object sender, EventArgs e)
        {
            HospedeController.ListarTodos();
        }
    }
}
