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
    public partial class FrmNovoProduto : Form
    {
        public FrmNovoProduto()
        {
            InitializeComponent();
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmNovoProduto_Load(object sender, EventArgs e)
        {
            var categorias = Categoria.ObterLista();
            cmbCategoria.DataSource = categorias;
            cmbCategoria.DisplayMember = "Nome";
            cmbCategoria.ValueMember = "Id";

            var marcas = Marca.ObterLista();
            cmbMarca.DataSource = marcas;
            cmbMarca.DisplayMember = "Nome";
            cmbMarca.ValueMember = "Id";

        }

        private void btnCadProduto_Click(object sender, EventArgs e)
        {
            Produto produto = new(
                Categoria.ObterPorId(Convert.ToInt32(cmbCategoria.SelectedValue)),
                Marca.ObterPorId(Convert.ToInt32(cmbMarca.SelectedValue)),
                txtNomeProduto.Text,
                txtDescricao.Text,
                dtpVencimento.Value,
                double.Parse(txtValor.Text),
                double.Parse(txtPeso.Text),
                int.Parse(txtQtdeEstoque.Text)

                );

            produto.Inserir();

            MessageBox.Show("Produto cadastrado com sucesso!");
        }
    }
}
