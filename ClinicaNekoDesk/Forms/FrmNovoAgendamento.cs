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

        //public static Panel PanelAgenda;

        public FrmNovoAgendamento()
        {
            InitializeComponent();
        }
        private void FrmNovoAgendamento_Load(object sender, EventArgs e)
        {

        }


        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            string dia = monthCalendar1.SelectionRange.Start.ToString();
            MessageBox.Show($"Data selecionada: {dia}");



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
                gpbEspecialidade.Enabled = true;
                cmbEspecialidade.Enabled = false;
                cmbTipo.Enabled = false;

                //Carrega a lista de usuarios de acordo com o serviço selecionado
                var usuarios = Usuario.ObterListaPorCargo(11);

                //Associa as listas ao combobox
                cmbProfissional.DataSource = usuarios;

                //Exibe o nome para o usuario
                cmbProfissional.DisplayMember = "Nome";

                //Retorna para o banco o valor contido na coluna ID
                cmbProfissional.ValueMember = "Id";

            }
            else
            {

            }

        }

        private void rbVacinacao_CheckedChanged(object sender, EventArgs e)
        {
            if (rbVacinacao.Checked)
            {
                gpbEspecialidade.Enabled = true;
                cmbEspecialidade.Enabled = false;
                cmbTipo.Enabled = false;

                //Carrega a lista de usuarios de acordo com o serviço selecionado
                var usuarios = Usuario.ObterListaPorCargo(7);

                //Associa as listas ao combobox
                cmbProfissional.DataSource = usuarios;

                //Exibe o nome para o usuario
                cmbProfissional.DisplayMember = "Nome";

                //Retorna para o banco o valor contido na coluna ID
                cmbProfissional.ValueMember = "Id";
            }
            else
            {

            }
        }

        private void rbAdestramento_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAdestramento.Checked)
            {
                gpbEspecialidade.Enabled = true;
                cmbEspecialidade.Enabled = false;
                cmbTipo.Enabled = false;
                
                //Carrega a lista de usuarios de acordo com o serviço selecionado
                var usuarios = Usuario.ObterListaPorCargo(10);

                //Associa as listas ao combobox
                cmbProfissional.DataSource = usuarios;

                //Exibe o nome para o usuario
                cmbProfissional.DisplayMember = "Nome";

                //Retorna para o banco o valor contido na coluna ID
                cmbProfissional.ValueMember = "Id";
            }
            else
            {

            }
        }

        private void rbConsulta_CheckedChanged(object sender, EventArgs e)
        {
            if (rbConsulta.Checked)
            {
                gpbEspecialidade.Enabled = true;
                cmbEspecialidade.Enabled = true;

                // ----- Especialidade
                //Carrega a lista de especialidades
                var especialidades = Especialidade.ObterLista();
                //Associa as listas ao combobox
                cmbEspecialidade.DataSource = especialidades;
                //Exibe o nome para o usuario
                cmbEspecialidade.DisplayMember = "Nome";
                //Retorna para o banco o valor contido na coluna ID
                cmbEspecialidade.ValueMember = "Id";


  
            }
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

        private void rbCirurgia_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCirurgia.Checked)
            {
                gpbEspecialidade.Enabled = true;
                cmbEspecialidade.Enabled = true;

                // ----- Especialidade
                //Carrega a lista de especialidades
                var especialidades = Especialidade.ObterLista();
                //Associa as listas ao combobox
                cmbEspecialidade.DataSource = especialidades;
                //Exibe o nome para o usuario
                cmbEspecialidade.DisplayMember = "Nome";
                //Retorna para o banco o valor contido na coluna ID
                cmbEspecialidade.ValueMember = "Id";





                // ----- Profissional
                //Carrega a lista de usuários de acordo com o serviço selecionado
                var usuarios = Usuario.ObterListaPorCargo(16);
                //Associa as listas ao combobox
                cmbProfissional.DataSource = usuarios;
                //Exibe o nome para o usuario
                cmbProfissional.DisplayMember = "Nome";
                //Retorna para o banco o valor contido na coluna ID
                cmbProfissional.ValueMember = "Id";

            }
        }

        private void rbExame_CheckedChanged(object sender, EventArgs e)
        {
            if (rbExame.Checked)
            {
                gpbEspecialidade.Enabled = true;
                cmbEspecialidade.Enabled = true;

                // ----- Especialidade
                //Carrega a lista de especialidades
                var especialidades = Especialidade.ObterLista();
                //Associa as listas ao combobox
                cmbEspecialidade.DataSource = especialidades;
                //Exibe o nome para o usuario
                cmbEspecialidade.DisplayMember = "Nome";
                //Retorna para o banco o valor contido na coluna ID
                cmbEspecialidade.ValueMember = "Id";


                // ----- Profissional
                //Carrega a lista de usuários de acordo com o serviço selecionado
                var usuarios = Usuario.ObterListaPorCargo(16);
                //Associa as listas ao combobox
                cmbProfissional.DataSource = usuarios;
                //Exibe o nome para o usuario
                cmbProfissional.DisplayMember = "Nome";
                //Retorna para o banco o valor contido na coluna ID
                cmbProfissional.ValueMember = "Id";
            }
        }

        private void cmbEspecialidade_SelectedIndexChanged(object sender, EventArgs e)
        {
            Especialidade especialidade = cmbEspecialidade.SelectedItem as Especialidade;
            int id = especialidade.Id;
            cmbTipo.Enabled = true;

            if (cmbEspecialidade.SelectedItem != null)
            {
                if (rbConsulta.Checked)
                {
                    // ----- Tipo
                    //Carrega a lista de consultas de acordo com a especialidade selecionada
                    var consultas = Consulta.ObterListaPorEspecialidade(id);
                    //Associa as listas ao combobox
                    cmbTipo.DataSource = consultas;
                    //Exibe o nome para o usuario
                    cmbTipo.DisplayMember = "Nome";
                    //Retorna para o banco o valor contido na coluna ID
                    cmbTipo.ValueMember = "Id";

                    if(id == 1)
                    {
                        // ----- Profissional
                        //Carrega a lista de usuários de acordo com o serviço selecionado
                        var usuarios = Usuario.ObterListaPorCargo(6);
                        //Associa as listas ao combobox
                        cmbProfissional.DataSource = usuarios;
                        //Exibe o nome para o usuario
                        cmbProfissional.DisplayMember = "Nome";
                        //Retorna para o banco o valor contido na coluna ID
                        cmbProfissional.ValueMember = "Id";
                    }else if(id == 2)
                    {
                        // ----- Profissional
                        //Carrega a lista de usuários de acordo com o serviço selecionado
                        var usuarios = Usuario.ObterListaPorCargo(7);
                        //Associa as listas ao combobox
                        cmbProfissional.DataSource = usuarios;
                        //Exibe o nome para o usuario
                        cmbProfissional.DisplayMember = "Nome";
                        //Retorna para o banco o valor contido na coluna ID
                        cmbProfissional.ValueMember = "Id";
                    }else if (id == 3)
                    {
                        // ----- Profissional
                        //Carrega a lista de usuários de acordo com o serviço selecionado
                        var usuarios = Usuario.ObterListaPorCargo(8);
                        //Associa as listas ao combobox
                        cmbProfissional.DataSource = usuarios;
                        //Exibe o nome para o usuario
                        cmbProfissional.DisplayMember = "Nome";
                        //Retorna para o banco o valor contido na coluna ID
                        cmbProfissional.ValueMember = "Id";
                    }else if( id == 4)
                    {
                        // ----- Profissional
                        //Carrega a lista de usuários de acordo com o serviço selecionado
                        var usuarios = Usuario.ObterListaPorCargo(9);
                        //Associa as listas ao combobox
                        cmbProfissional.DataSource = usuarios;
                        //Exibe o nome para o usuario
                        cmbProfissional.DisplayMember = "Nome";
                        //Retorna para o banco o valor contido na coluna ID
                        cmbProfissional.ValueMember = "Id";
                    }else if(id == 5) 
                    {
                        // ----- Profissional
                        //Carrega a lista de usuários de acordo com o serviço selecionado
                        var usuarios = Usuario.ObterListaPorCargo(10);
                        //Associa as listas ao combobox
                        cmbProfissional.DataSource = usuarios;
                        //Exibe o nome para o usuario
                        cmbProfissional.DisplayMember = "Nome";
                        //Retorna para o banco o valor contido na coluna ID
                        cmbProfissional.ValueMember = "Id";
                    }else if(id == 6)
                    {
                        // ----- Profissional
                        //Carrega a lista de usuários de acordo com o serviço selecionado
                        var usuarios = Usuario.ObterListaPorCargo(11);
                        //Associa as listas ao combobox
                        cmbProfissional.DataSource = usuarios;
                        //Exibe o nome para o usuario
                        cmbProfissional.DisplayMember = "Nome";
                        //Retorna para o banco o valor contido na coluna ID
                        cmbProfissional.ValueMember = "Id";
                    }else if (id == 7)
                     {
                        // ----- Profissional
                        //Carrega a lista de usuários de acordo com o serviço selecionado
                        var usuarios = Usuario.ObterListaPorCargo(12);
                        //Associa as listas ao combobox
                        cmbProfissional.DataSource = usuarios;
                        //Exibe o nome para o usuario
                        cmbProfissional.DisplayMember = "Nome";
                        //Retorna para o banco o valor contido na coluna ID
                        cmbProfissional.ValueMember = "Id";
                    }
                    else if (id == 8)
                    {
                        // ----- Profissional
                        //Carrega a lista de usuários de acordo com o serviço selecionado
                        var usuarios = Usuario.ObterListaPorCargo(13);
                        //Associa as listas ao combobox
                        cmbProfissional.DataSource = usuarios;
                        //Exibe o nome para o usuario
                        cmbProfissional.DisplayMember = "Nome";
                        //Retorna para o banco o valor contido na coluna ID
                        cmbProfissional.ValueMember = "Id";
                    }else if(id == 9)
                    {
                        // ----- Profissional
                        //Carrega a lista de usuários de acordo com o serviço selecionado
                        var usuarios = Usuario.ObterListaPorCargo(14);
                        //Associa as listas ao combobox
                        cmbProfissional.DataSource = usuarios;
                        //Exibe o nome para o usuario
                        cmbProfissional.DisplayMember = "Nome";
                        //Retorna para o banco o valor contido na coluna ID
                        cmbProfissional.ValueMember = "Id";
                    }
                    else if (id == 10)
                    {
                        // ----- Profissional
                        //Carrega a lista de usuários de acordo com o serviço selecionado
                        var usuarios = Usuario.ObterListaPorCargo(15);
                        //Associa as listas ao combobox
                        cmbProfissional.DataSource = usuarios;
                        //Exibe o nome para o usuario
                        cmbProfissional.DisplayMember = "Nome";
                        //Retorna para o banco o valor contido na coluna ID
                        cmbProfissional.ValueMember = "Id";
                    }
                    else if(id == 11)
                    {
                        // ----- Profissional
                        //Carrega a lista de usuários de acordo com o serviço selecionado
                        var usuarios = Usuario.ObterListaPorCargo(5);
                        //Associa as listas ao combobox
                        cmbProfissional.DataSource = usuarios;
                        //Exibe o nome para o usuario
                        cmbProfissional.DisplayMember = "Nome";
                        //Retorna para o banco o valor contido na coluna ID
                        cmbProfissional.ValueMember = "Id";
                    }


                }
                else if (rbCirurgia.Checked)
                {
                    // ----- Tipo
                    //Carrega a lista de cirurgias de acordo com a especialidade selecionada
                    var cirurgias = Cirurgia.ObterListaPorEspecialidade(id);
                    //Associa as listas ao combobox
                    cmbTipo.DataSource = cirurgias;
                    //Exibe o nome para o usuario
                    cmbTipo.DisplayMember = "Nome";
                    //Retorna para o banco o valor contido na coluna ID
                    cmbTipo.ValueMember = "Id";

                }
                else if (rbExame.Checked)
                {
                    // ----- Tipo
                    //Carrega a lista de exames de acordo com a especialidade selecionada
                    var exames = Exame.ObterListaPorEspecialidade(id);
                    //Associa as listas ao combobox
                    cmbTipo.DataSource = exames;
                    //Exibe o nome para o usuario
                    cmbTipo.DisplayMember = "Nome";
                    //Retorna para o banco o valor contido na coluna ID
                    cmbTipo.ValueMember = "Id";

                }
                else
                {

                }
            }
            else
            {

            }
        }

        private void txtIdTutor_TextChanged(object sender, EventArgs e)
        {
            if (txtIdTutor.Text != string.Empty)
            {
                int id = Convert.ToInt32(txtIdTutor.Text);

                //Carrega a lista de pacientes de acordo com o cliente selecionado
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


        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            gpbEspecialidade.Enabled = false;   
        }

    
    }



}