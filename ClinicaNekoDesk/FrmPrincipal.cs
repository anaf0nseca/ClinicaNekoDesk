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
using ClinicaNekoDesk.Forms;

namespace ClinicaNeko
{
    public partial class FrmPrincipal : Form
    {
        //todos os paineis de submenus ocultos
        private Boolean showPanelUsuarios = false;
        private Boolean showPanelProdutos = false;
        private Boolean showPanelClientes = false;
        private Boolean showPanelPedidos = false;
        private Boolean showPanelVet = false;
        private Boolean showPanelServicos = false;
        private Boolean showPanelAgend = false;

        public static Panel MainPanel;
        public FrmPrincipal()
        {
            InitializeComponent();
            MainPanel = panelFormularios;

            tooglePanels();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FrmLogo frmLogo = new FrmLogo();
            frmLogo.Dock = DockStyle.Fill;
            frmLogo.TopLevel = false;
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(frmLogo);
            frmLogo.Show();
        }



        private void guna2Button7_Click(object sender, EventArgs e)
        {

            //Exibe o formulário de serviço 
            FrmServico frmServico = new FrmServico();
            frmServico.Dock = DockStyle.Fill;
            frmServico.TopLevel = false;
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(frmServico);
            frmServico.Show();
        }

        private void tooglePanels()
        {
            //Exibe painel de pedidos
            if (showPanelPedidos)
            {
                panelPedidos.Height = 90;
            }
            else
            {
                panelPedidos.Height = 0;
            }


            //Exibe painel de agendamentos
            if (showPanelAgend)
            {
                panelAgend.Height = 90;

            }
            else
            {
                panelAgend.Height = 0;
            }

            //Exibe painel de clientes
            if (showPanelClientes)
            {
                panelClientes.Height = 90;
            }
            else
            {
                panelClientes.Height = 0;
            }

            //Exibe painel de produtos
            if (showPanelProdutos)
            {
                panelProdutos.Height = 90;
            }
            else
            {
                panelProdutos.Height = 0;
            }

            //Exibe painel veterinário
            if (showPanelVet)
            {
                panelVet.Height = 120;
            }
            else
            {
                panelVet.Height = 0;
            }


            //Exibe painel de serviços
            if (showPanelServicos)
            {
                panelServicos.Height = 120;
            }
            else
            {
                panelServicos.Height = 0;
            }

            //Exibe painel de usuarios
            if (showPanelUsuarios)
            {

                panelUsuarios.Height = 90;
            }
            else
            {
                panelUsuarios.Height = 0;

            }

        }

        private void btnNovoUsuario_Click(object sender, EventArgs e)
        {


        }



        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            //exibe o formulário para cadastro de produto
            FrmNovoProduto frmProduto = new FrmNovoProduto();
            frmProduto.Dock = DockStyle.Fill;
            frmProduto.TopLevel = false;
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(frmProduto);
            frmProduto.Show();
        }

        private void guna2Button3_Click_1(object sender, EventArgs e)
        {
            //exibe o formulário para cadastro de cliente
            FrmNovoCliente frmCliente = new FrmNovoCliente();
            frmCliente.Dock = DockStyle.Fill;
            frmCliente.TopLevel = false;
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(frmCliente);
            frmCliente.Show();
        }

        private void guna2Button6_Click_1(object sender, EventArgs e)
        {
            //exibe o formulário para cadastro de pedido
            FrmNovoPedido frmPedido = new FrmNovoPedido();
            frmPedido.Dock = DockStyle.Fill;
            frmPedido.TopLevel = false;
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(frmPedido);
            frmPedido.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            var msg = MessageBox.Show(
                    "Deseja sair do sistema?", //Texto da mensagem 
                    "Clínica Veterinária Neko", //Título da caixa de mensagem
                    MessageBoxButtons.YesNo, //Botões exibidos na caixa
                    MessageBoxIcon.Exclamation, //Ícone exibido
                    MessageBoxDefaultButton.Button1); //Botão padrão

            if (msg == DialogResult.Yes) this.Close();
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }


        private void guna2Button4_Click_1(object sender, EventArgs e)
        {
            FrmListaCliente frmListaCliente = new FrmListaCliente();
            frmListaCliente.Dock = DockStyle.Fill;
            frmListaCliente.TopLevel = false;
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(frmListaCliente);
            frmListaCliente.Show();
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            showPanelAgend = false;
            showPanelProdutos = false;
            showPanelClientes = false;
            showPanelUsuarios = false;
            showPanelServicos = false;
            showPanelVet = false;

            //Ao clicar no botão pedidos, o submenu é exibido e todos os outros ficam ocultos
            showPanelPedidos = !showPanelPedidos;
            tooglePanels();
        }

        private void btnAgend_Click(object sender, EventArgs e)
        {
            showPanelProdutos = false;
            showPanelClientes = false;
            showPanelUsuarios = false;
            showPanelServicos = false;
            showPanelVet = false;
            showPanelPedidos = false;
            //Ao clicar no botão agendamentos, o submenu é exibido e todos os outros ficam ocultos
            showPanelAgend = !showPanelAgend;
            tooglePanels();
        }

        private void btnClientes_Click_1(object sender, EventArgs e)
        {
            showPanelAgend = false;

            showPanelProdutos = false;
            showPanelPedidos = false;
            showPanelUsuarios = false;
            showPanelServicos = false;
            showPanelVet = false;

            //Ao clicar no botão clientes, o submenu é exibido e todos os outros ficam ocultos
            showPanelClientes = !showPanelClientes;
            tooglePanels();
        }


        private void btnVeterinario_Click(object sender, EventArgs e)
        {
            showPanelAgend = false;
            showPanelProdutos = false;
            showPanelPedidos = false;
            showPanelUsuarios = false;
            showPanelServicos = false;
            showPanelClientes = false;

            //Ao clicar no botão veterinario, o submenu é exibido e todos os outros ficam ocultos
            showPanelVet = !showPanelVet;
            tooglePanels();
        }

        private void btnServico_Click(object sender, EventArgs e)
        {

        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {

            showPanelAgend = false;
            showPanelClientes = false;
            showPanelPedidos = false;
            showPanelProdutos = false;
            showPanelServicos = false;
            showPanelVet = false;
            //Ao clicar no botão usuarios, o submenu é exibido e todos os outros ficam ocultos
            showPanelUsuarios = !showPanelUsuarios;
            tooglePanels();
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {

            showPanelAgend = false;
            showPanelClientes = false;
            showPanelPedidos = false;
            showPanelUsuarios = false;
            showPanelServicos = false;
            showPanelVet = false;

            //Ao clicar no botão produtos, o submenu é exibido e todos os outros ficam ocultos
            showPanelProdutos = !showPanelProdutos;
            tooglePanels();
        }

        private void btnNovoUsuario_Click_1(object sender, EventArgs e)
        {
            //exibe o formulário para cadastro de usuario
            FrmNovoUsuario frmUsuario = new FrmNovoUsuario();
            frmUsuario.Dock = DockStyle.Fill;
            frmUsuario.TopLevel = false;
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(frmUsuario);
            frmUsuario.Show();


        }

        private void btnListaUsuarios_Click(object sender, EventArgs e)
        {
            FrmListaUsuario frmListaUsuario = new FrmListaUsuario();
            frmListaUsuario.Dock = DockStyle.Fill;
            frmListaUsuario.TopLevel = false;
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(frmListaUsuario);
            frmListaUsuario.Show();
        }

        private void guna2Separator1_Click(object sender, EventArgs e)
        {

        }
    }
}
