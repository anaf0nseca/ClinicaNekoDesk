using ClinicaNekoLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicaNeko.Forms;
using ClinicaNekoDesk.Forms;

namespace ClinicaNekoDesk.Forms
{
    public partial class FrmNovoAgendamento : Form
    {
        public int clienteId;

        public static Panel PanelAgenda;

        public FrmNovoAgendamento()
        {
            InitializeComponent();
            PanelAgenda = panelHorarios;
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            string dia = monthCalendar1.SelectionRange.Start.ToString();
            MessageBox.Show($"Data selecionada: {dia}");

            if (rbBanhoETosa.Checked)
            {
                FrmAgendAdestra frmAgendAdestra = new FrmAgendAdestra();
                frmAgendAdestra.Dock = DockStyle.Fill;
                frmAgendAdestra.TopLevel = false;
                PanelAgenda.Controls.Clear();
                PanelAgenda.Controls.Add(frmAgendAdestra);
                frmAgendAdestra.Show();
            }


        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void rbBanhoETosa_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBanhoETosa.Checked)
            {
                MessageBox.Show($"Data selecionada:");


            }
            else
            {

            }

        }

        private void rbVacinacao_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbAdestramento_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbConsulta_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbExame_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbCirurgia_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FrmNovoAgendamento_Load(object sender, EventArgs e)
        {
            //Carrega a lista de clientes
            //var clientes = Cliente.ObterLista();
            ////Associa a lista ao combobox
            //cmbCliente.DataSource = clientes;
            ////Exibe o nome do cliente para o usuario
            //cmbCliente.DisplayMember = "Nome";
            ////Retorna para o banco o valor contido na coluna ID
            //cmbCliente.ValueMember = "Id";
        }

        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

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
            //Recupera o ID e o Nome do cliente selecionado na lista
            clienteId = frmSelecionarCliente.ClienteId;
            string clienteNome = frmSelecionarCliente.ClienteNome;

            //Preenche os campos com as informações
            txtIdTutor.Text = clienteId.ToString();
            txtNomeTutor.Text = clienteNome;
        }

        private void txtIdTutor_TextChanged(object sender, EventArgs e)
        {
            if (txtIdTutor.Text != string.Empty)
            {
                int id = Convert.ToInt32(txtIdTutor.Text);

                //Carrega a lista de cargos de acordo com o cliente selecionado
                var pacientes = Paciente.ObterListaPorCliente(id);

                //Associa as listas ao combobox
                cmbPaciente.DataSource = pacientes;

                //Exibe o nome para o usuario
                cmbPaciente.DisplayMember = "Nome";

                //Retorna para o banco o valor contido na coluna ID
                cmbPaciente.ValueMember = "Id";

            }

            if (cmbPaciente.SelectedItem != null)
            {
                gpbTipoAgendamento.Enabled = true;
            }
            else
            {
                gpbTipoAgendamento.Enabled = false;
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            FrmAgendAdestra frmAgendAdestra = new FrmAgendAdestra();
            frmAgendAdestra.Dock = DockStyle.Fill;
            frmAgendAdestra.TopLevel = false;
            PanelAgenda.Controls.Clear();
            PanelAgenda.Controls.Add(frmAgendAdestra);
            frmAgendAdestra.Show();
        }
    }
}
