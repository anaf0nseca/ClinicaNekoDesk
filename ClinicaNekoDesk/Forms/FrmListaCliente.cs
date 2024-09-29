using ClinicaNekoLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaNeko.Forms
{
    public partial class FrmListaCliente : Form
    {
        public FrmListaCliente()
        {
            InitializeComponent();
        }

        private void FrmListaCliente_Load(object sender, EventArgs e)
        {

        }

        private void CarregaGrid(string nome = "")
        {
            var usuarios = Usuario.ObterLista(nome);



        }
    }
}
