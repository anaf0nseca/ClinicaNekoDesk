using ClinicaNekoDesk.Forms;
using ClinicaNekoLib;
using Org.BouncyCastle.Crypto.Macs;
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
    public partial class FrmNovoPedido : Form
    {
        Produto produto;

        public int produtoId;
        public int clienteId;

        public FrmNovoPedido()
        {
            InitializeComponent();
        }

        private void guna2GroupBox2_Click(object sender, EventArgs e)
        {

        }

        private void PreencheGridItens(int idPedido = 0)
        {
            //Obtem lista de clientes
            var itens = ItemPedido.ObterListaPorPedido(int.Parse(txtNPedido.Text));

            //Limpa as linhas da tabela antes de consultar as informações de cada campo
            dgvItensPedido.Rows.Clear();
            //contador para alterar o índice a cada cliente da lista
            int cont = 0;
            double desconto = 0;
            double total = 0;
            foreach (var item in itens)
            {
                //Adiciona uma nova linha a tabela
                dgvItensPedido.Rows.Add();

                //Preenche a linha com as colunas e seus respectivos dados
                dgvItensPedido.Rows[cont].Cells[0].Value = $"#{cont + 1}";
                dgvItensPedido.Rows[cont].Cells[1].Value = item.Produto.Nome;
                dgvItensPedido.Rows[cont].Cells[2].Value = item.Produto.Descricao;
                dgvItensPedido.Rows[cont].Cells[3].Value = item.Valor.ToString("#0.00");
                dgvItensPedido.Rows[cont].Cells[4].Value = item.Quantidade.ToString("#00");
                dgvItensPedido.Rows[cont].Cells[5].Value = item.Desconto.ToString("#0.00");

                //Soma +1 ao contador de cliente
                cont++;

                //a cada item inserido, o valor total é atualizado
                total += (item.Valor * item.Quantidade) - item.Desconto;

                //a cada item inserido, o valor de desconto total dos itens é atualizado
                desconto += item.Desconto;

            }

            txtSubtotalPedido.Text = (total + desconto).ToString("#0.00");
            txtDescontoItens.Text = desconto.ToString("#0.00");

            if (cmbDescPedido.SelectedItem != null)
            {
                if (cmbDescPedido.Text == "5%")
                {
                    txtTotalPedido.Text = (total - ((5 * total) / 100)).ToString("#0.00");
                }
                else if (cmbDescPedido.Text == "10%")
                {
                    txtTotalPedido.Text = (total - ((10 * total) / 100)).ToString("#0.00");
                }
                else if (cmbDescPedido.Text == "15%")
                {
                    txtTotalPedido.Text = (total - ((15 * total) / 100)).ToString("#0.00");
                }
                else if (cmbDescPedido.Text == "20%")
                {
                    txtTotalPedido.Text = (total - ((20 * total) / 100)).ToString("#0.00");
                }
                else if (cmbDescPedido.Text == "50%")
                {
                    txtTotalPedido.Text = (total - ((50 * total) / 100)).ToString("#0.00");
                }
                else
                {
                    txtTotalPedido.Text = total.ToString("#0.00");
                }
            }

        }
        private void button3_Click(object sender, EventArgs e)
        {
            FrmSelecionarProduto frmSelecionarProduto = new FrmSelecionarProduto();
            //frmSelecionarProduto.Parent = this;

            //System.Windows.Media.Effects.BlurEffect myBlur = new System.Windows.Media.Effects.BlurEffect();
            //myBlur.Radius = 5; //Set the radius for the blur - the bigger the number the better the blur
            //this.Effect = myBlur;

            frmSelecionarProduto.ShowDialog();

            produtoId = frmSelecionarProduto.ProdutoId;
            string produtoNome = frmSelecionarProduto.ProdutoNome;
            string produtoDescricao = frmSelecionarProduto.ProdutoDescricao;
            double? produtoValor = frmSelecionarProduto.ProdutoValor;

            txtDescricao.Text = produtoNome;
            txtQuantidade.Text = 1.ToString();
            txtValor.Text = produtoValor.ToString();
        }

        private void btnAbrirPedido_Click(object sender, EventArgs e)
        {
            Pedido pedido = new(
                Program.UsuarioLogado,
                Cliente.ObterPorId(int.Parse(txtIdCliente.Text)));

            pedido.Inserir();

            txtNPedido.Text = pedido.Id.ToString();
            txtIdCliente.Enabled = false;
            txtCliente.Enabled = false;
            btnSelecionarCliente.Enabled = false;
            grbItens.Enabled = true;
            grbFinalizacao.Enabled = true;
            txtDescricao.Focus();

        }

        private void FrmNovoPedido_Load(object sender, EventArgs e)
        {
            txtUsuario.Text = Program.UsuarioLogado.Id + " - " + Program.UsuarioLogado.Nome;
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            double descontoItem = Convert.ToDouble(txtDesconto.Text);

            Produto produto = Produto.ObterPorId(produtoId);
            Estoque estoque = Estoque.ObterPorProduto(produto.Id);
            double qtdeProduto = double.Parse(txtQuantidade.Text);

            if (qtdeProduto > estoque.Quantidade)
            {
                MessageBox.Show($"Não é possível incluir essa quantidade, há {estoque.Quantidade} unidades desse produto disponíveis em estoque.");
            }
            else
            {
                ItemPedido item = new(
                    int.Parse(txtNPedido.Text),
                    produto,
                    produto.Valor,
                    int.Parse(txtQuantidade.Text),
                    double.Parse(txtDesconto.Text)
                    );

                item.Inserir();
                PreencheGridItens();
            }

            txtDescricao.Clear();
            txtDesconto.Clear();
            txtQuantidade.Clear();
            txtValor.Clear();
        }

        private void btnSelecionarCliente_Click(object sender, EventArgs e)
        {
            FrmSelecionarCliente frmSelecionarCliente = new FrmSelecionarCliente();
            //frmSelecionarCliente.Parent = this;

            //System.Windows.Media.Effects.BlurEffect myBlur = new System.Windows.Media.Effects.BlurEffect();
            //myBlur.Radius = 5; //Set the radius for the blur - the bigger the number the better the blur
            //this.Effect = myBlur;

            frmSelecionarCliente.ShowDialog();

            clienteId = frmSelecionarCliente.ClienteId;
            string clienteNome = frmSelecionarCliente.ClienteNome;

            txtIdCliente.Text = clienteId.ToString();
            txtCliente.Text = clienteNome;
        }
    }
}
