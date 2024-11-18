using ClinicaNekoDesk.Forms;
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

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            Form Background = new Form();

            FrmCategoria frmCategoria = new FrmCategoria();

            //Código utilizado para criar o efeito de "escurecimento" do formulário principal ao abrir uma janela secundária
            using (frmCategoria)
            {
                Background.StartPosition = FormStartPosition.CenterScreen;
                Background.FormBorderStyle = FormBorderStyle.None;
                Background.Opacity = 0.7d;
                Background.BackColor = Color.Black;
                Background.Size = new Size(1310, 722);
                Background.Location = this.Location;
                Background.ShowInTaskbar = false;
                Background.Show(this);
                frmCategoria.Owner = Background;
                frmCategoria.ShowDialog(Background);
                Background.Dispose();
            }

            FrmNovoProduto_Load(sender, e);

        }

        private void btnAddMarca_Click(object sender, EventArgs e)
        {
            Form Background = new Form();

            FrmMarca frmMarca = new FrmMarca();

            //Código utilizado para criar o efeito de "escurecimento" do formulário principal ao abrir uma janela secundária
            using (frmMarca)
            {
                Background.StartPosition = FormStartPosition.CenterScreen;
                Background.FormBorderStyle = FormBorderStyle.None;
                Background.Opacity = 0.7d;
                Background.BackColor = Color.Black;
                Background.Size = new Size(1310, 722);
                Background.Location = this.Location;
                Background.ShowInTaskbar = false;
                Background.Show(this);
                frmMarca.Owner = Background;
                frmMarca.ShowDialog(Background);
                Background.Dispose();
            }

            FrmNovoProduto_Load(sender,e);

        }
    }
}
