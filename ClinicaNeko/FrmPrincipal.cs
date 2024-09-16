using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicaNeko.Forms;

namespace ClinicaNeko
{
    public partial class Form1 : Form
    {
        private Boolean showPanelMarket = false;
        public static Panel MainPanel;
        public Form1()
        {
            InitializeComponent();
            MainPanel = panel1;

            tooglePanels();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FrmTeste frmTeste = new FrmTeste();
            frmTeste.Dock = DockStyle.Fill;
            frmTeste.TopLevel = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(frmTeste);
            frmTeste.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmTestinho frmTestinho = new FrmTestinho();
            frmTestinho.Dock = DockStyle.Fill;
            frmTestinho.TopLevel = false;
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(frmTestinho);
            frmTestinho.Show();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            FrmUsuario frmUsuario = new FrmUsuario();
            frmUsuario.Dock = DockStyle.Fill;
            frmUsuario.TopLevel = false;
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(frmUsuario);
            frmUsuario.Show();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            FrmProduto frmProduto = new FrmProduto();
            frmProduto.Dock = DockStyle.Fill;
            frmProduto.TopLevel = false;
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(frmProduto);
            frmProduto.Show();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            FrmCliente frmCliente = new FrmCliente();
            frmCliente.Dock = DockStyle.Fill;
            frmCliente.TopLevel = false;
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(frmCliente);
            frmCliente.Show();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            FrmPedido frmPedido = new FrmPedido();
            frmPedido.Dock = DockStyle.Fill;
            frmPedido.TopLevel = false;
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(frmPedido);
            frmPedido.Show();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            FrmVeterinario frmVeterinario = new FrmVeterinario();
            frmVeterinario.Dock = DockStyle.Fill;
            frmVeterinario.TopLevel = false;
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(frmVeterinario);
            frmVeterinario.Show();
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            FrmServico frmServico = new FrmServico();
            frmServico.Dock = DockStyle.Fill;
            frmServico.TopLevel = false;
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(frmServico);
            frmServico.Show();
        }

        private void tooglePanels()
        {
            if (showPanelMarket) 
            { 
            
            }

        }
    }
}
