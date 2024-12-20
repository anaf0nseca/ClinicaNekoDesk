﻿using ClinicaNeko.Forms;
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
    public partial class FrmListaPedido : Form
    {
        public FrmListaPedido()
        {
            InitializeComponent();
        }

        private void dgvListaProduto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CarregaGridPedidos()
        {
            var listaPedido = Pedido.ObterLista();

            dgvListaPedido.Rows.Clear();
            int cont = 0;

            foreach (var pedido in listaPedido)
            {
                var listaItens = ItemPedido.ObterListaPorPedido(pedido.Id);
                decimal valor = 0;

                //Para cada pedido, somar o valor de todos os itens relacionados a ele para exibir o valor total do pedido.
                foreach (var item in listaItens)
                {
                    valor += item.Valor * item.Quantidade;
                }

                int rowIndex = dgvListaPedido.Rows.Add();
                dgvListaPedido.Rows[cont].Cells[0].Value = pedido.Id;
                dgvListaPedido.Rows[cont].Cells[1].Value = pedido.Usuario.Nome;
                dgvListaPedido.Rows[cont].Cells[2].Value = pedido.Cliente.Nome;
                dgvListaPedido.Rows[cont].Cells[3].Value = pedido.Data;
                dgvListaPedido.Rows[cont].Cells[4].Value = pedido.Status;
                dgvListaPedido.Rows[cont].Cells[5].Value = pedido.Desconto;
                dgvListaPedido.Rows[cont].Cells[6].Value = valor - pedido.Desconto;


                cont++;
            }
        }

        private void FrmListaPedido_Load(object sender, EventArgs e)
        {

        }

        private void FrmListaPedido_Load_1(object sender, EventArgs e)
        {
            CarregaGridPedidos();
        }

        private void tpDetalhePedido_Click(object sender, EventArgs e)
        {

        }

        private void dgvListaPedido_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.tpDetalhePedido.Enabled = true;
            int id = 0;
            int posicaoLinha = dgvListaPedido.CurrentRow.Index;
            id = Convert.ToInt32(dgvListaPedido.Rows[posicaoLinha].Cells[0].Value);

            this.tabConsultaPedido.SelectedTab = tpDetalhePedido;

            Pedido pedido = Pedido.ObterPorId(id);

            txtNPedido.Text = pedido.Id.ToString();

            txtUsuario.Text = pedido.Usuario.Nome;
            txtIdCliente.Text = pedido.Cliente.Id.ToString();
            txtCliente.Text = pedido.Cliente.Nome;

            var listaItens = ItemPedido.ObterListaPorPedido(id);
            dgvItensPedido.Rows.Clear();

            int cont = 0;
            decimal valor = 0;

            foreach (var item in listaItens)
            {
                valor += item.Valor * item.Quantidade;

                int rowIndex = dgvItensPedido.Rows.Add();
                dgvItensPedido.Rows[cont].Cells[0].Value = item.Id;
                dgvItensPedido.Rows[cont].Cells[1].Value = item.Produto.Nome;
                dgvItensPedido.Rows[cont].Cells[2].Value = item.Produto.Descricao;
                dgvItensPedido.Rows[cont].Cells[3].Value = item.Valor;
                dgvItensPedido.Rows[cont].Cells[4].Value = item.Quantidade;

                cont++;
            }

            txtDesconto.Text = pedido.Desconto.ToString();
            txtTotal.Text = (valor - pedido.Desconto).ToString();

            if (pedido.Status == "P")
            {
                btnPgto.Visible = true;
            }
            else
            {
                btnPgto.Visible = false;
            }


        }

        private void guna2HtmlLabel14_Click(object sender, EventArgs e)
        {

        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
