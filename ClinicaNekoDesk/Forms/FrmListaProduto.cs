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
    public partial class FrmListaProduto : Form
    {
        public FrmListaProduto()
        {
            InitializeComponent();
        }
        private void FrmListaProduto_Load(object sender, EventArgs e)
        {
            CarregaGridProduto();
            this.tpEditarProdutos.Enabled = false;

            var categorias = Categoria.ObterLista();
            cmbCategoria.DataSource = categorias;
            cmbCategoria.DisplayMember = "Nome";
            cmbCategoria.ValueMember = "Id";

            var marcas = Marca.ObterLista();
            cmbMarca.DataSource = marcas;
            cmbMarca.DisplayMember = "Nome";
            cmbMarca.ValueMember = "Id";

        }

        private void CarregaGridProduto()
        {
            var listaProduto = Produto.ObterLista();

            dgvListaProduto.Rows.Clear();
            int cont = 0;

            foreach (var produto in listaProduto)
            {
                int rowIndex = dgvListaProduto.Rows.Add();
                dgvListaProduto.Rows[cont].Cells[0].Value = produto.Id;
                dgvListaProduto.Rows[cont].Cells[1].Value = produto.Categoria.Nome;
                dgvListaProduto.Rows[cont].Cells[2].Value = produto.Marca.Nome;
                dgvListaProduto.Rows[cont].Cells[3].Value = produto.Nome;
                dgvListaProduto.Rows[cont].Cells[4].Value = produto.Descricao;
                dgvListaProduto.Rows[cont].Cells[5].Value = produto.Data_Validade;
                dgvListaProduto.Rows[cont].Cells[6].Value = produto.Valor;
                dgvListaProduto.Rows[cont].Cells[7].Value = produto.Peso;
                dgvListaProduto.Rows[cont].Cells[8].Value = produto.Qtde_Estoque;


                cont++;
            }
        }


        private void dgvListaProduto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtNomeProduto_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvListaProduto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.tpEditarProdutos.Enabled = true;
            int id = 0;
            int posicaoLinha = dgvListaProduto.CurrentRow.Index;
            id = Convert.ToInt32(dgvListaProduto.Rows[posicaoLinha].Cells[0].Value);

            this.tabConsultaProduto.SelectedTab = tpEditarProdutos;
            Produto produto = Produto.ObterPorId(id);

            txtIdProduto.Text = produto.Id.ToString();
            txtNomeProduto.Text = produto.Nome;
            txtDescricao.Text = produto.Descricao;
            txtPeso.Text = produto.Peso.ToString();
            txtValor.Text = produto.Valor.ToString();
            txtQtdeEstoque.Text = produto.Qtde_Estoque.ToString();
            dtpVencimento.Value = produto.Data_Validade.Value;


            cmbCategoria.SelectedIndex = produto.Categoria.Id - 1;
            cmbMarca.SelectedIndex = produto.Marca.Id - 1;




        }

        private void btnCadProduto_Click(object sender, EventArgs e)
        {
            Produto produto = new(
               int.Parse(txtIdProduto.Text),
               Categoria.ObterPorId(Convert.ToInt32(cmbCategoria.SelectedValue)),
               Marca.ObterPorId(Convert.ToInt32(cmbMarca.SelectedValue)),
               txtNomeProduto.Text,
               txtDescricao.Text,
               dtpVencimento.Value,
               double.Parse(txtValor.Text)
               );

            produto.Atualizar();
            MessageBox.Show($"Dados do usuário {produto.Nome}, atualizados com sucesso.");
            FrmListaProduto_Load(sender, e);
            this.tabConsultaProduto.SelectedTab = tpListarProdutos;
        }

        private void tpEditarProdutos_Click(object sender, EventArgs e)
        {
           
        }

        private void dgvListaProduto_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
