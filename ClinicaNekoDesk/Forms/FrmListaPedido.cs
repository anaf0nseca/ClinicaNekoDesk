using ClinicaNeko.Forms;
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
                double valor = 0;
                foreach (var item in listaItens)
                {
                    valor += item.Valor - item.Desconto;
                }

                int rowIndex = dgvListaPedido.Rows.Add();
                dgvListaPedido.Rows[cont].Cells[0].Value = pedido.Id;
                dgvListaPedido.Rows[cont].Cells[1].Value = pedido.Usuario.Nome;
                dgvListaPedido.Rows[cont].Cells[2].Value = pedido.Cliente.Nome;
                dgvListaPedido.Rows[cont].Cells[3].Value = pedido.Data;
                dgvListaPedido.Rows[cont].Cells[4].Value = pedido.Status;
                dgvListaPedido.Rows[cont].Cells[5].Value = pedido.Desconto;
                dgvListaPedido.Rows[cont].Cells[6].Value = valor;


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


        
    }
}
