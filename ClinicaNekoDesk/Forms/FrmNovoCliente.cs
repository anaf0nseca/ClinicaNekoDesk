using ClinicaNekoDesk.Forms;
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

namespace ClinicaNeko.Forms
{
    public partial class FrmNovoCliente : Form
    {
        public int ClienteId { get; set; }
        public static Panel MainPanel;
        public FrmNovoCliente()
        {
            InitializeComponent();
            MainPanel = FrmPrincipal.MainPanel;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmNovoCliente_Load(object sender, EventArgs e)
        {

        }

        private bool VerificaControles()
        {
            if (txtNome.Text != string.Empty &&
                txtCpf.Text != string.Empty &&
                txtEmail.Text != string.Empty &&
                txtSenha.Text != string.Empty &&
                txtTelefone.Text != string.Empty)
            {
                return true;
            }
            else { return false; }
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            if (VerificaControles())
            {
                Cliente cliente = new(
                    txtNome.Text,
                    txtCpf.Text,
                    dtpNascimento.Value,
                    txtEmail.Text,
                    txtSenha.Text
                    );

                cliente.Inserir();

                
                FrmNovoPaciente frmNovoPaciente = new FrmNovoPaciente();
                frmNovoPaciente.idCliente = cliente.Id;
                ClienteId = cliente.Id;

                if (cliente.Id > 0)
                {

                    MessageBox.Show($"O usuário {cliente.Nome} " + $"foi inserido com sucesso, com o ID {cliente.Id}.");
                    Telefone telefone = new(
                        txtTelefone.Text,
                        cmbTipoTel.Text
                        );
                    telefone.Inserir();

                    if (telefone.Id > 0)
                    {

                        TelefoneCliente telefoneCliente = new(
                            Telefone.ObterPorId(Convert.ToInt32(telefone.Id)),
                            Cliente.ObterPorId(Convert.ToInt32(cliente.Id))
                            );
                        telefoneCliente.Inserir();
                    }

                    frmNovoPaciente.Dock = DockStyle.Fill;
                    frmNovoPaciente.TopLevel = false;
                    MainPanel.Controls.Clear();
                    MainPanel.Controls.Add(frmNovoPaciente);
                    frmNovoPaciente.Show();

                }
            }
            else
            {
                MessageBox.Show("Preencha todos os campos antes de continuar");
            }


        }
    }
}
