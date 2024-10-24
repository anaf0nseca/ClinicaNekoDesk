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

namespace ClinicaNekoDesk.Forms
{
    public partial class FrmSelecionarCliente : Form
    {
        public int ClienteId { get; set; }
        public string? ClienteNome { get; set; }

        public FrmSelecionarCliente()
        {
            InitializeComponent();
        }

        private void CarregaGridCliente(string? nome = "")
        {
            var listaCliente = Cliente.ObterLista(nome);

            dgvListaCliente.Rows.Clear();
            int cont = 0;

            foreach (var cliente in listaCliente)
            {
                int rowIndex = dgvListaCliente.Rows.Add();
                dgvListaCliente.Rows[cont].Cells[0].Value = cliente.Id;
                dgvListaCliente.Rows[cont].Cells[1].Value = cliente.Nome;
                dgvListaCliente.Rows[cont].Cells[2].Value = cliente.Cpf;
                dgvListaCliente.Rows[cont].Cells[3].Value = cliente.Data_Nascimento;
                dgvListaCliente.Rows[cont].Cells[4].Value = cliente.Email;


                cont++;
            }
        }


        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            if (txtBusca.Text.Length > 0)
            {
                CarregaGridCliente(txtBusca.Text);

            }
            else
            {
                CarregaGridCliente();
            }
        }

        private void FrmSelecionarCliente_Load(object sender, EventArgs e)
        {
            CarregaGridCliente();
        }

        private void dgvListaCliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = 0;

            int posicaoLinha = dgvListaCliente.CurrentRow.Index;

            id = Convert.ToInt32(dgvListaCliente.Rows[posicaoLinha].Cells[0].Value);

            Cliente cliente = Cliente.ObterPorId(id);

            ClienteId = cliente.Id;
            ClienteNome = cliente.Nome;

            Close();

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
