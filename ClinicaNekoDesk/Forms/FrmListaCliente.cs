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
using static System.Net.Mime.MediaTypeNames;

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
            CarregaGridClientes();
        }

        private void CarregaGridClientes(string nome = "")
        {
            var listaClientes = Cliente.ObterLista(nome);

            dgvListaClientes.Rows.Clear();
            int cont = 0;

            foreach (var cliente in listaClientes)
            {
                int rowIndex = dgvListaClientes.Rows.Add();
                dgvListaClientes.Rows[cont].Cells[0].Value = cliente.Id;
                dgvListaClientes.Rows[cont].Cells[1].Value = cliente.Nome;
                dgvListaClientes.Rows[cont].Cells[2].Value = cliente.Cpf;
                dgvListaClientes.Rows[cont].Cells[3].Value = cliente.Data_Nascimento;
                dgvListaClientes.Rows[cont].Cells[4].Value = cliente.Email;

                cont++;
            }



        }

        private void CarregaGridPacientes(int id)
        {
            var listaPacientes = Paciente.ObterListaPorCliente(id);

            dgvListaPacientes.Rows.Clear();
            int cont = 0;

            foreach (var paciente in listaPacientes)
            {
                int rowIndex = dgvListaPacientes.Rows.Add();
                dgvListaPacientes.Rows[cont].Cells[0].Value = paciente.Id;
                dgvListaPacientes.Rows[cont].Cells[1].Value = paciente.Nome;
                dgvListaPacientes.Rows[cont].Cells[2].Value = paciente.Raca.Nome;
                dgvListaPacientes.Rows[cont].Cells[3].Value = paciente.Cor;
                dgvListaPacientes.Rows[cont].Cells[4].Value = paciente.Idade;
                dgvListaPacientes.Rows[cont].Cells[5].Value = paciente.Peso;


                cont++;
            }



        }

        private void CarregaGridEnderecos()
        {
            var listaClientes = Cliente.ObterLista();

            dgvListaClientes.Rows.Clear();
            int cont = 0;

            foreach (var cliente in listaClientes)
            {
                int rowIndex = dgvListaClientes.Rows.Add();
                dgvListaClientes.Rows[cont].Cells[0].Value = cliente.Id;
                dgvListaClientes.Rows[cont].Cells[1].Value = cliente.Nome;
                dgvListaClientes.Rows[cont].Cells[2].Value = cliente.Cpf;
                dgvListaClientes.Rows[cont].Cells[3].Value = cliente.Data_Nascimento;
                dgvListaClientes.Rows[cont].Cells[4].Value = cliente.Email;

                cont++;
            }



        }

        private void btnSalvarUsuario_Click(object sender, EventArgs e)
        {

        }

        private void dgvListaUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.tpEditarClientes.Enabled = true;


            int id = 0;
            int posicaoLinha = dgvListaClientes.CurrentRow.Index;
            id = Convert.ToInt32(dgvListaClientes.Rows[posicaoLinha].Cells[0].Value);

            this.tabConsultaCliente.SelectedTab = tpEditarClientes;


            Cliente cliente = Cliente.ObterPorId(id);
            CarregaGridPacientes(cliente.Id);
            txtId.Text = cliente.Id.ToString();
            txtNome.Text = cliente.Nome;
            txtCpf.Text = cliente.Cpf;
            dtpNascimento.Value = cliente.Data_Nascimento.Value;
            txtEmail.Text = cliente.Email;
            txtCpf.ReadOnly = true;


        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            if (txtBusca.Text.Length > 0)
            {
                CarregaGridClientes(txtBusca.Text);

            }
            else
            {
                CarregaGridClientes();
            }
        }

        private void dgvListaClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tpListarClientes_Click(object sender, EventArgs e)
        {

        }

        private void dgvListaPacientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tpEditarClientes_Click(object sender, EventArgs e)
        {

        }
    }
}
