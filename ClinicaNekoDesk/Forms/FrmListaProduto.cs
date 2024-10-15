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
    }
}
