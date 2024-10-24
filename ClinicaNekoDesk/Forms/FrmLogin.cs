using ClinicaNeko;
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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //Caso o formulário de login seja cancelado, a aplicação é encerrada.
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Verifica se os campos estão preenchidos
            if (txtEmail.Text != string.Empty && txtSenha.Text != string.Empty)
            {
                //realiza o login 
                var usuario = Usuario.EfetuarLogin(txtEmail.Text, txtSenha.Text);

                if (usuario.Id > 0)
                {
                    if (usuario.Ativo)
                    {

                        Program.UsuarioLogado = usuario;

                        //o formulário de login é fechado e é possível ter acesso ao formulário principal
                        FrmPrincipal frmPrincipal  = new FrmPrincipal();   
                        frmPrincipal.Show();
                        

                    }
                    else
                    {
                        //Caso o usuário esteja inativo, a mensagem é exibida e a aplicação é encerrada.
                        MessageBox.Show("Seu usuário está inativo. \n Entre em contato com a gerência.");
                        Application.Exit();
                    }


                }
                else
                {
                    //Se os dados inseridos forem incorretos, a mensagem é exibida.
                    MessageBox.Show("Usuário ou senha incorretos, ou inexistente. \n Entre em contato com a gerência.");
                    txtEmail.Focus();
                }
            }
            else
            {
                //Se o usuário tentar logar sem inserir nenhum dado, a mensagem é exibida
                MessageBox.Show("Você deve inserir seu email e senha para logar no sistema.");
                //o foco volta para a caixa de texto do email
                txtEmail.Focus();
            }
        }
        }
    }

