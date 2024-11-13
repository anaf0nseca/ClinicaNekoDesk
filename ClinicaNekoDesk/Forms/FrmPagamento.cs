using ClinicaNeko;
using ClinicaNeko.Forms;
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
    public partial class FrmPagamento : Form
    {
        public static Panel MainPanel;
        public int idPedido { get; set; }
        public int idCliente {  get; set; }
        public double totalP { get; set; }



        public FrmPagamento()
        {
            InitializeComponent();
            MainPanel = FrmPrincipal.MainPanel;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            grbFormaPgto.Enabled = false;
        }

        private void guna2HtmlLabel17_Click(object sender, EventArgs e)
        {

        }

        private void FrmPagamento_Load(object sender, EventArgs e)
        {
            Pedido pedido = Pedido.ObterPorId(idPedido);
            Cliente cliente = Cliente.ObterPorId(pedido.Cliente.Id);

            txtIdN.Text = pedido.Id.ToString();
            txtIdCliente.Text = cliente.Id.ToString();
            txtCliente.Text = pedido.Cliente.Nome;
            txtUsuario.Text = Program.UsuarioLogado.Nome;
            txtTotal.Text = totalP.ToString();


        }

        private async Task btnFinalizarPedido_ClickAsync(object sender, EventArgs e)
        { 
        }

        private void rbcredito_CheckedChanged(object sender, EventArgs e)
        {
            if (rbcredito.Checked)
            {
                lblParcelas.Visible = true;
                cmbParcelas.Visible = true;
                cmbParcelas.SelectedIndex = 0;
            }

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            var msg = MessageBox.Show(
                   "Deseja cancelar o pagamento? O status do seu pedido ficará pendente.", //Texto da mensagem 
                   "Pagamento", //Título da caixa de mensagem
                   MessageBoxButtons.YesNo, //Botões exibidos na caixa
                   MessageBoxIcon.Exclamation, //Ícone exibido
                   MessageBoxDefaultButton.Button1); //Botão padrão

            if (msg == DialogResult.Yes)
            {
                //Mudar status do pedido ou agendamento para cancelado
                this.Close();
            }
            else
            {
                
            }


        }

        private void rbDebito_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDebito.Checked)
            {
                lblParcelas.Visible = false;
                cmbParcelas.Visible = false;
            }

        }

        private void rbDinheiro_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDinheiro.Checked)
            {
                lblParcelas.Visible = false;
                cmbParcelas.Visible = false;

            }
        }

        private void rbPix_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPix.Checked)
            {
                lblParcelas.Visible = false;
                cmbParcelas.Visible = false;
            }
        }

        private async void btnFinalizarPedido_Click(object sender, EventArgs e)
        {

            // start the delay, but do not wait yet
            Task delayTask = Task.Delay(TimeSpan.FromSeconds(3));

            // do other useful initializations, this might be shorter or longer than 5 seconds
            pbLoading.Visible = true;

            string status = "F";
            Pedido pedido = new(
                int.Parse(txtIdN.Text),
                status
                );

            pedido.AlterarStatus(Convert.ToInt32(txtIdN.Text), status);

            // now wait for the delay task to finish:
            await delayTask;

            MessageBox.Show(
                   "Pagamento concluído com sucesso! :)", //Texto da mensagem 
                   "Pagamento", //Título da caixa de mensagem
                   MessageBoxButtons.OK, //Botões exibidos na caixa
                   MessageBoxIcon.Information//Ícone exibido
                   );
            this.Close();

            FrmListaPedido frmListaPedido = new FrmListaPedido();
            frmListaPedido.Dock = DockStyle.Fill;
            frmListaPedido.TopLevel = false;
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(frmListaPedido);
            frmListaPedido.Show();
        }
    }
}

