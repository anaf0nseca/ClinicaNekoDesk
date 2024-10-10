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
using ClinicaNekoLib;


namespace ClinicaNeko.Forms
{
    public partial class FrmNovoUsuario : Form
    {
        public int UsuarioId { get; set; }
        
        public static Panel MainPanel;

        public FrmNovoUsuario()
        {
            InitializeComponent();
            MainPanel = FrmPrincipal.MainPanel;

        }
        private void FrmNovoUsuario_Load(object sender, EventArgs e)
        {
            //Carrega a lista de setores
            var setores = Setor.ObterLista();
            //Associa as listas ao combobox
            cmbSetor.DataSource = setores;
            //Exibe o nome para o usuario
            cmbSetor.DisplayMember = "Nome";
            //Retorna para o banco o valor contido na coluna ID
            cmbSetor.ValueMember = "Id";

        }

        private void cmbSetor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSetor.SelectedItem != null)
            {
                Setor setor = cmbSetor.SelectedItem as Setor;
                int id = setor.Id;

                //Carrega a lista de cargos de acordo com o setor selecionado
                var cargos = Cargo.ObterListaPorSetor(id);

                //Associa as listas ao combobox
                cmbCargo.DataSource = cargos;

                //Exibe o nome para o usuario
                cmbCargo.DisplayMember = "Nome";

                //Retorna para o banco o valor contido na coluna ID
                cmbCargo.ValueMember = "Id";

            }
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            //Verifica se todos os controles estão preenchidos antes de prosseguir para o cadastro do endereço
            if (VerificaControles())
            {
                Usuario usuario = new(
                    txtNome.Text,
                    txtCpf.Text,
                    dtpNascimento.Value,
                    Setor.ObterPorId(Convert.ToInt32(cmbSetor.SelectedValue)),
                    Cargo.ObterPorId(Convert.ToInt32(cmbCargo.SelectedValue)),
                    txtEmail.Text,
                    txtSenha.Text
                    );

                usuario.Inserir();

                FrmNovoEndereco frmNovoEndereco = new FrmNovoEndereco();
                frmNovoEndereco.idUsuario = usuario.Id;
                UsuarioId = usuario.Id;

                if(usuario.Id > 0)
                {

                    MessageBox.Show($"O usuário {usuario.Nome} " + $"foi inserido com sucesso, com o ID {usuario.Id}.");
                    Telefone telefone = new(
                        txtTelefone.Text,
                        cmbTipoTel.Text
                        );
                    telefone.Inserir();

                    if(telefone.Id > 0) {

                        TelefoneUsuario telefoneUsuario = new(
                            Telefone.ObterPorId(Convert.ToInt32(telefone.Id)),
                            Usuario.ObterPorId(Convert.ToInt32(usuario.Id))
                            );
                        telefoneUsuario.Inserir();
                    }

                    FrmNovoEndereco frmNovoEndereco1 = new FrmNovoEndereco();
                    frmNovoEndereco.Dock = DockStyle.Fill;
                    frmNovoEndereco.TopLevel = false;
                    MainPanel.Controls.Clear();
                    MainPanel.Controls.Add(frmNovoEndereco);
                    frmNovoEndereco.Show();

                }




            }
            else
            {
                MessageBox.Show("Preencha todos os campos antes de continuar");
            }


        }


        //Irá verificar se todos os campos estão preenchidos
        private bool VerificaControles()
        {
            if (txtNome.Text != string.Empty && 
                txtCpf.Text != string.Empty && 
                txtEmail.Text != string.Empty && 
                txtSenha.Text != string.Empty && 
                txtTelefone.Text != string.Empty && 
                cmbCargo.SelectedItem != null &&
                cmbSetor.SelectedItem != null)
            {
                return true;
            }
            else { return false; }
        }

    }
}
