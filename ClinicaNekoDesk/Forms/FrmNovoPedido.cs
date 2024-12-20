﻿using ClinicaNekoDesk.Forms;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ClinicaNeko.Forms
{
    public partial class FrmNovoPedido : Form
    {
        Produto produto;

        public int produtoId;
        public int clienteId;
        public int idPedido {  get; set; }
        public decimal total;
        public decimal totalP;
        public decimal descontoTotal;

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
            decimal desconto = 0;
            total = 0;
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

                //a cada item inserido, o valor de desconto total dos itens é atualizado
                if(item.Quantidade > 1)
                {
                    item.Desconto = item.Desconto * item.Quantidade;
                    desconto += item.Desconto;
                    //a cada item inserido, o valor total é atualizado
                    total += (item.Valor * item.Quantidade) - item.Desconto;
                }
                else
                {
                    desconto += item.Desconto;
                    //a cada item inserido, o valor total é atualizado
                    total += (item.Valor * item.Quantidade) - item.Desconto;
                }



            }

            txtSubtotalPedido.Text = (total + desconto).ToString("#0.00");
            txtDescontoItens.Text = desconto.ToString("#0.00");
            txtTotalPedido.Text = total.ToString("#0.00");




        }
        private void button3_Click(object sender, EventArgs e)
        {
            Form Background = new Form();

            FrmSelecionarProduto frmSelecionarProduto = new FrmSelecionarProduto();

            //Código utilizado para criar o efeito de "escurecimento" do formulário principal ao abrir uma janela secundária
            using (frmSelecionarProduto)
            {
                Background.StartPosition = FormStartPosition.CenterScreen;
                Background.FormBorderStyle = FormBorderStyle.None;
                Background.Opacity = 0.5d;
                Background.BackColor = Color.Black;
                Background.Size = new Size(1310, 722);
                Background.Location = this.Location;
                Background.ShowInTaskbar = false;
                Background.Show(this);
                frmSelecionarProduto.Owner = Background;
                frmSelecionarProduto.ShowDialog(Background);
                Background.Dispose();
            }


            produtoId = frmSelecionarProduto.ProdutoId;
            string produtoNome = frmSelecionarProduto.ProdutoNome;
            string produtoDescricao = frmSelecionarProduto.ProdutoDescricao;
            decimal? produtoValor = frmSelecionarProduto.ProdutoValor;

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


            //frmPagamento.idUsuario = 

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
                    decimal.Parse(txtDesconto.Text)
                    );

                item.Inserir();
                PreencheGridItens();
            }

            txtDescricao.Clear();
            txtQuantidade.Clear();
            txtValor.Clear();
            cmbDescPedido.SelectedIndex = 0;

        }

        private void btnSelecionarCliente_Click(object sender, EventArgs e)
        {
            Form Background = new Form();

            FrmSelecionarCliente frmSelecionarCliente = new FrmSelecionarCliente();

            //Código utilizado para criar o efeito de "escurecimento" do formulário principal ao abrir uma janela secundária
            using (frmSelecionarCliente)
            {
                Background.StartPosition = FormStartPosition.CenterScreen;
                Background.FormBorderStyle = FormBorderStyle.None;
                Background.Opacity = 0.7d;
                Background.BackColor = Color.Black;
                Background.Size = new Size(1310, 722);
                Background.Location = this.Location;
                Background.ShowInTaskbar = false;
                Background.Show(this);
                frmSelecionarCliente.Owner = Background;
                frmSelecionarCliente.ShowDialog(Background);
                Background.Dispose();
            }

            clienteId = frmSelecionarCliente.ClienteId;
            string clienteNome = frmSelecionarCliente.ClienteNome;


            txtIdCliente.Text = clienteId.ToString();
            txtCliente.Text = clienteNome;

            FrmPagamento frmPagamento = new FrmPagamento();
            frmPagamento.idCliente = clienteId;
         

        }

        private void cmbDescPedido_SelectedIndexChanged(object sender, EventArgs e)
        {
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

        private void btnFinalizarPedido_Click(object sender, EventArgs e)
        {
            //string status = "P";


            //// Converte os valores dos campos para decimal
            //if (decimal.TryParse(txtSubtotalPedido.Text, out decimal subtotalPedido) &&
            //    decimal.TryParse(txtTotalPedido.Text, out decimal totalPedido))
            //{
            //    // Calcula o desconto com base nos valores
            //    decimal descontoPedido = subtotalPedido - totalPedido;

            //    // Cria um objeto Pedido com os valores calculados
            //    Pedido pedido = new(
            //        Convert.ToInt32(txtNPedido.Text),
            //        status,
            //        descontoPedido
            //    );

            //    // Verifica se o ID do pedido é válido
            //    if (pedido.Id > 0)
            //    {
            //        //altera o status e o desconto
            //        pedido.AlterarStatus(pedido.Id, status);
            //        pedido.AtualizarDesconto(pedido.Id, descontoPedido);
            //    }


            string status = "P";
          
            // Converte os valores dos campos para decimal
            if (decimal.TryParse(txtSubtotalPedido.Text, out decimal subtotalPedido) &&
                decimal.TryParse(txtTotalPedido.Text, out decimal totalPedido))
            {
                // Verifica se os valores são válidos e se o subtotal é maior que o total
                if (subtotalPedido < 0 || totalPedido < 0)
                {
                    MessageBox.Show("Os valores de subtotal e total não podem ser negativos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Calcula o desconto com base nos valores
                decimal descontoPedido = subtotalPedido - totalPedido;
                totalP = totalPedido;
                // Cria um objeto Pedido com os valores calculados
                if (int.TryParse(txtNPedido.Text, out int pedidoId)) // Verifica se o ID do pedido é válido
                {
                    Pedido pedido = new(pedidoId, status, descontoPedido);

                    // Verifica se o ID do pedido é válido
                    if (pedido.Id > 0)
                    {
                        // Chama os métodos de atualização para alterar o status e o desconto
                        pedido.AlterarStatus(pedido.Id, status);
                        pedido.AtualizarDesconto();  // Passando descontoPedido como decimal
                    }

                    Form Background = new Form();

                    FrmPagamento frmPagamento = new FrmPagamento();
                    frmPagamento.totalP = totalP;
                    frmPagamento.idPedido = pedido.Id;

                    //Código utilizado para criar o efeito de "escurecimento" do formulário principal ao abrir uma janela secundária
                    using (frmPagamento)
                    {
                        Background.StartPosition = FormStartPosition.CenterScreen;
                        Background.FormBorderStyle = FormBorderStyle.None;
                        Background.Opacity = 0.7d;
                        Background.BackColor = Color.Black;
                        Background.Size = new Size(1310, 722);
                        Background.Location = this.Location;
                        Background.ShowInTaskbar = false;
                        Background.Show(this);
                        frmPagamento.Owner = Background;
                        frmPagamento.ShowDialog(Background);
                        Background.Dispose();


                    }
                }


            }


        }
    }
}
 
