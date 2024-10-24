using ClinicaNekoLib;
using Google.Protobuf.WellKnownTypes;
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
    public partial class FrmListaUsuario : Form
    {
        public FrmListaUsuario()
        {
            InitializeComponent();
        }

        private void FrmListaUsuario_Load(object sender, EventArgs e)
        {


            //Carrega a lista de setores
            var setores = Setor.ObterLista();
            //Associa as listas ao combobox
            cmbSetor.DataSource = setores;
            //Exibe o nome para o usuario
            cmbSetor.DisplayMember = "Nome";
            //Retorna para o banco o valor contido na coluna ID
            cmbSetor.ValueMember = "Id";

            this.tpEditarUsuarios.Enabled = false;
            CarregaGridUsuarios();
        }
        private void cmbSetor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSetor.SelectedItem != null)
            {
                Setor setor = cmbSetor.SelectedItem as Setor;
                int id = setor.Id;

                //Carrega a lista de cargos de acordo com o setor selecionado
                var cargos = Cargo.ObterListaPorSetor(id);

                //Associa as listas ao combobox
                cmbCargo.DataSource = cargos;

                //Exibe o nome para o usuario
                cmbCargo.DisplayMember = "Nome";

                //Retorna para o banco o valor contido na coluna ID
                cmbCargo.ValueMember = "Id";

            }
        }

        private void CarregaGridUsuarios(string? nome = "")
        {
            var listaUsuarios = Usuario.ObterLista(nome);

            dgvListaUsuarios.Rows.Clear();
            int cont = 0;

            foreach (var usuario in listaUsuarios)
            {
                int rowIndex = dgvListaUsuarios.Rows.Add();
                dgvListaUsuarios.Rows[cont].Cells[0].Value = usuario.Id;
                dgvListaUsuarios.Rows[cont].Cells[1].Value = usuario.Nome;
                dgvListaUsuarios.Rows[cont].Cells[2].Value = usuario.Cpf;
                dgvListaUsuarios.Rows[cont].Cells[3].Value = usuario.DataNascimento;
                dgvListaUsuarios.Rows[cont].Cells[4].Value = usuario.Setor.Nome;
                dgvListaUsuarios.Rows[cont].Cells[5].Value = usuario.Cargo.Nome;
                dgvListaUsuarios.Rows[cont].Cells[6].Value = usuario.Email;
                dgvListaUsuarios.Rows[cont].Cells[7].Value = usuario.Ativo;

                cont++;
            }
        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void tpListarUsuarios_Click(object sender, EventArgs e)
        {

        }

        private void tpEditarUsuarios_Click(object sender, EventArgs e)
        {

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvListaUsuarios_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            this.tpEditarUsuarios.Enabled = true;


            int id = 0;
            int posicaoLinha = dgvListaUsuarios.CurrentRow.Index;
            id = Convert.ToInt32(dgvListaUsuarios.Rows[posicaoLinha].Cells[0].Value);

            this.tabConsultaUsuario.SelectedTab = tpEditarUsuarios;

            Usuario usuario = Usuario.ObterPorId(id);

            txtId.Text = usuario.Id.ToString();
            txtNome.Text = usuario.Nome;
            txtCpf.Text = usuario.Cpf;
            dtpNascimento.Value = usuario.DataNascimento.Value;
            txtEmail.Text = usuario.Email;
            txtCpf.ReadOnly = true;

            cmbSetor.SelectedIndex = usuario.Setor.Id - 1;
            //cmbCargo.SelectedIndex = usuario.Cargo.Id - 1;


        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            gpEndereco.Enabled = true;


        }

        private void btnAddEndereco_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvarUsuario_Click(object sender, EventArgs e)
        {

            if (txtNome.Text != null && txtEmail.Text != null && cmbCargo.SelectedValue != null && cmbSetor.SelectedValue != null)
            {
                Usuario usuario = new(
                    int.Parse(txtId.Text),
                    txtNome.Text,
                    dtpNascimento.Value,
                    Setor.ObterPorId(Convert.ToInt32(cmbSetor.SelectedValue)),
                    Cargo.ObterPorId(Convert.ToInt32(cmbCargo.SelectedValue)),
                    txtEmail.Text
                    );

                usuario.Atualizar();

                MessageBox.Show($"Dados do usuário {usuario.Nome}, atualizados com sucesso.");
                FrmListaUsuario_Load(sender, e);
                this.tabConsultaUsuario.SelectedTab = tpListarUsuarios;

            }
            else
            {
                MessageBox.Show("Preencha todos os campos antes de salvar as alterações!");

            }

        }

        private void dgvListaUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtBusca_TextChanged_1(object sender, EventArgs e)
        {
            if (txtBusca.Text.Length > 0)
            {
                CarregaGridUsuarios(txtBusca.Text);

            }
            else
            {
                CarregaGridUsuarios();
            }
        }
    }
}
