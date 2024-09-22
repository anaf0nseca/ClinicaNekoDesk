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


namespace ClinicaNeko.Forms
{
    public partial class FrmNovoUsuario : Form
    {
        public static Panel MainPanel;

        public FrmNovoUsuario()
        {
            InitializeComponent();
            MainPanel = FrmPrincipal.MainPanel;

        }
        private void FrmNovoUsuario_Load(object sender, EventArgs e)
        {
            //var setores = Setor.ObterLista();
            //var cargos = Cargo.ObterLista();
   
        }

        private void cmbSetor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            if (VerificaControles())
            {
                FrmNovoEndereco frmNovoEndereco = new FrmNovoEndereco();
                frmNovoEndereco.Dock = DockStyle.Fill;
                frmNovoEndereco.TopLevel = false;
                MainPanel.Controls.Clear();
                MainPanel.Controls.Add(frmNovoEndereco);
                frmNovoEndereco.Show();

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
