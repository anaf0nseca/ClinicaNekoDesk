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
        public FrmNovoPedido()
        {
            InitializeComponent();
        }

        private void guna2GroupBox2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmSelecionarProduto frmSelecionarProduto = new FrmSelecionarProduto();
            frmSelecionarProduto.Parent = this;

            //System.Windows.Media.Effects.BlurEffect myBlur = new System.Windows.Media.Effects.BlurEffect();
            //myBlur.Radius = 5; //Set the radius for the blur - the bigger the number the better the blur
            //this.Effect = myBlur;

            frmSelecionarProduto.ShowDialog();

            int produtoId = frmSelecionarProduto.ProdutoId;
            string produtoNome = frmSelecionarProduto.ProdutoNome;
            string produtoDescricao = frmSelecionarProduto.ProdutoDescricao;
            double? produtoValor = frmSelecionarProduto.ProdutoValor;

            txtDescricao.Text = produtoDescricao;
            txtValor.Text = produtoValor.ToString();




        }
    }
}
