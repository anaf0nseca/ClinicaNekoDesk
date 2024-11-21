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
    public partial class FrmSelecionarProduto : Form
    {
        public int ProdutoId { get; set; }
        public Categoria ProdutoCategoria { get; set; }

        public string? ProdutoNome { get; set; }
        public string? ProdutoDescricao { get; set; }
        public decimal? ProdutoValor { get; set; }




        public FrmSelecionarProduto()
        {
            InitializeComponent();
        }

        private void FrmSelecionarProduto_Load(object sender, EventArgs e)
        {
            //Carrega a lista de categorias
            var categorias = Categoria.ObterLista();
            //Associa as listas ao combobox
            cmbBuscaCat.DataSource = categorias;
            //Exibe o nome para o usuario
            cmbBuscaCat.DisplayMember = "Nome";
            //Retorna para o banco o valor contido na coluna ID
            cmbBuscaCat.ValueMember = "Id";

            CarregaGridProduto();
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

        private void dgvListaProduto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = 0;

            int posicaoLinha = dgvListaProduto.CurrentRow.Index;

            id = Convert.ToInt32(dgvListaProduto.Rows[posicaoLinha].Cells[0].Value);

            Produto produto = Produto.ObterPorId(id);

            ProdutoId = produto.Id;
            ProdutoCategoria = produto.Categoria;
            ProdutoNome = produto.Nome;
            ProdutoDescricao = produto.Descricao;
            ProdutoValor = produto.Valor;

            Close();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        //private void cmbBuscaCat_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (cmbBuscaCat.SelectedItem != null)
        //    {
        //        //categoria categoria = cmbbuscacat.selecteditem as categoria;
        //        //int id = categoria.id;
        //        //var produtos = produto.obterlistaporcategoria(id);

        //        //cmbBuscaCat.DataSource = produtos;

        //        cmbBuscaCat.DisplayMember = "Nome";
        //        //Retorna para o banco o valor contido na coluna ID
        //        cmbBuscaCat.ValueMember = "Id";

        //    }
        //    else
        //    {
        //        var categorias = Categoria.ObterLista();
        //        //Associa as listas ao combobox
        //        cmbBuscaCat.DataSource = categorias;
        //        //Exibe o nome para o usuario
        //        cmbBuscaCat.DisplayMember = "Nome";
        //        //Retorna para o banco o valor contido na coluna ID
        //        cmbBuscaCat.ValueMember = "Id";
        //    }
        //}
    }
}
