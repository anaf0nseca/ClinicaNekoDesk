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
using MySql.Data.MySqlClient;
using System.Collections;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrayNotify;
using System.Diagnostics.Eventing.Reader;

namespace ClinicaNekoDesk.Forms
{
    public partial class FrmNovoAgendamento : Form
    {
        public int clienteId;

        public string diaSelecionado;

        //public string Tipo;
        private string connectionString = "Data Source=127.0.0.1;Initial Catalog=clinicanekodb";

        public List<string> horariosDisponiveis { get; set; }
        //public static Panel PanelAgenda;

        public FrmNovoAgendamento()
        {
            InitializeComponent();
        }
        private void FrmNovoAgendamento_Load(object sender, EventArgs e)
        {

        }

        private void ConsultarHorariosDisponíveis(string Tipo)
        {
            // Lista de horários disponíveis de acordo com o serviço selecionado
            if (rbBanhoETosa.Checked)
            {
                // Definir os horários possíveis em um array
                string[] horariosPossiveis = new string[]
                {
                "07:00:00", "08:00:00", "09:00:00", "10:00:00",  "11:00:00", "12:00:00",  "13:00:00",  "14:00:00",  "15:00:00",
                "16:00:00",  "17:00:00",  "18:00:00", "19:00:00", "20:00:00"
                };

                horariosDisponiveis = new List<string>(horariosPossiveis);
                Tipo = "Banho e Tosa";
            }
            else if (rbAdestramento.Checked)
            {
                // Definir os horários possíveis em um array
                string[] horariosPossiveis = new string[]
                {
                "07:00:00", "08:00:00", "09:00:00", "10:00:00",  "11:00:00", "12:00:00",  "13:00:00",  "14:00:00",  "15:00:00",
                "16:00:00",  "17:00:00",  "18:00:00", "19:00:00", "20:00:00"
                };

                Tipo = "Adestramento";

                horariosDisponiveis = new List<string>(horariosPossiveis);

            }
            else if (rbVacinacao.Checked)
            {
                // Definir os horários possíveis em um array
                string[] horariosPossiveis = new string[]
                {
                "07:00:00", "07:30:00", "08:00:00", "08:30:00", "09:00:00", "09:30:00", "10:00:00", "10:30:00", "11:00:00", "11:30:00",
                "12:00:00", "12:30:00", "13:00:00", "13:30:00", "14:00:00", "14:30:00", "15:00:00", "15:30:00",
                "16:00:00", "16:30:00", "17:00:00", "17:30:00", "18:00:00", "18:30:00"
                };

                Tipo = "Vacinação";

                horariosDisponiveis = new List<string>(horariosPossiveis);

            }
            else if (rbConsulta.Checked)
            {
                // Definir os horários possíveis em um array
                string[] horariosPossiveis = new string[]
                {
                "07:00:00", "08:00:00", "09:00:00", "10:00:00",  "11:00:00", "12:00:00",  "13:00:00",  "14:00:00",  "15:00:00",
                "16:00:00",  "17:00:00",  "18:00:00", "19:00:00", "20:00:00", "21:00:00"
                };

                Tipo = "Consulta";

                horariosDisponiveis = new List<string>(horariosPossiveis);
            }
            else if (rbExame.Checked)
            {
                // Definir os horários possíveis em um array
                string[] horariosPossiveis = new string[]
                {
                "07:00:00", "07:30:00", "08:00:00", "08:30:00", "09:00:00", "09:30:00", "10:00:00", "10:30:00", "11:00:00", "11:30:00",
                "12:00:00", "12:30:00", "13:00:00", "13:30:00", "14:00:00", "14:30:00", "15:00:00", "15:30:00",
                "16:00:00", "16:30:00", "17:00:00", "17:30:00", "18:00:00", "18:30:00"
                };

                Tipo = "Exame";

                horariosDisponiveis = new List<string>(horariosPossiveis);

            }
            else if (rbCirurgia.Checked)
            {
                // Definir os horários possíveis em um array
                string[] horariosPossiveis = new string[]
                {
                "07:00:00", "09:00:00", "11:00:00", "13:00:00",  "15:00:00", "17:00:00",  "19:00:00"
                };

                Tipo = "Cirurgia";

                horariosDisponiveis = new List<string>(horariosPossiveis);
            }

            var cmd = Banco.Abrir();
            string comando = $"select hora from agendamento where tipo = {Tipo} and data = @diaSelecionado";

            //Obter a data selecionada
            diaSelecionado = monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd");


            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {

                // Criar o comando SQL com o parâmetro da data
                using (MySqlCommand mysql = new MySqlCommand(comando, connection))
                {
                    cmd.Parameters.AddWithValue("@diaSelecionado", diaSelecionado);
                    cmd.CommandType = System.Data.CommandType.Text;

                    // Consulta para pegar os horários já agendados
                    cmd.CommandText = $"select hora from agendamento where tipo = '{Tipo}' and data = @diaSelecionado";

                    // Executar a consulta e obter os horários já agendados
                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            string horarioAgendado = dr["hora"].ToString();
                            // Se o horário já foi agendado, é removido da lista de horários disponíveis
                            horariosDisponiveis.Remove(horarioAgendado);
                        }
                    }

                }

                // Atualizar o ComboBox com os horários disponíveis
                cmbHorarios.Items.Clear();
                foreach (var horario in horariosDisponiveis)
                {
                    //cmbHorarios.Items.Add(horario).ToString("HH:mm");
                    //cmbHorarios.Items.Add(horario).ToString("t");

                    //Adiciona cada horário ainda não agendado, no combobox
                    cmbHorarios.Items.Add(horario);

                }

                // Se não houver horários disponíveis, mostrar uma mensagem
                if (cmbHorarios.Items.Count == 0)
                {
                    MessageBox.Show("Não há horários disponíveis para agendamento nesta data.");
                }




            }
        }


        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void monthCalendar1_DateSelected_1(object sender, DateRangeEventArgs e)
        {

            cmbHorarios.Enabled = true;

            if (rbBanhoETosa.Checked)
            {
                ConsultarHorariosDisponíveis("Banho e Tosa");
                MessageBox.Show($"Dia selecionado para banho e tosa: {diaSelecionado}");

            }
            else if (rbAdestramento.Checked)
            {
                ConsultarHorariosDisponíveis("Banho e Tosa");
                MessageBox.Show($"Dia selecionado para adestramento: {diaSelecionado}");

            }
            else if (rbVacinacao.Checked)
            {
                ConsultarHorariosDisponíveis("Banho e Tosa");
                MessageBox.Show($"Dia selecionado para vacinacao: {diaSelecionado}");
            }
            else if (rbConsulta.Checked)
            {
                ConsultarHorariosDisponíveis("consulta");

                MessageBox.Show($"Dia selecionado para consulta: {diaSelecionado}");
            }
            else if (rbExame.Checked)
            {
                ConsultarHorariosDisponíveis("Banho e Tosa");
                MessageBox.Show($"Dia selecionado para Exame: {diaSelecionado}");
            }
            else if (rbCirurgia.Checked)
            {
                ConsultarHorariosDisponíveis("Banho e Tosa");
                MessageBox.Show($"Dia selecionado para cirurgia: {diaSelecionado}");
            }
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
                var usuarios = Usuario.ObterListaPorCargo(17);
                //Associa as listas ao combobox
                cmbProfissional.DataSource = usuarios;
                //Exibe o nome para o usuario
                cmbProfissional.DisplayMember = "Nome";
                //Retorna para o banco o valor contido na coluna ID
                cmbProfissional.ValueMember = "Id";
            }
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

                    if (id == 1)
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
                    }
                    else if (id == 2)
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
                    }
                    else if (id == 3)
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
                    }
                    else if (id == 4)
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
                    }
                    else if (id == 5)
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
                    }
                    else if (id == 6)
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
                    }
                    else if (id == 7)
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
                    }
                    else if (id == 9)
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
                    else if (id == 11)
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


        private void guna2Button1_Click(object sender, EventArgs e)
        {
            gpbEspecialidade.Enabled = false;
            gpbDataHora.Enabled = true;
        }

        private void cmbHorarios_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (rbBanhoETosa.Checked)
            {


            }
            else if (rbAdestramento.Checked)
            {
                ConsultarHorariosDisponíveis("Banho e Tosa");
                MessageBox.Show($"Dia selecionado para adestramento: {diaSelecionado}");

            }
            else if (rbVacinacao.Checked)
            {
                ConsultarHorariosDisponíveis("Banho e Tosa");
                MessageBox.Show($"Dia selecionado para vacinacao: {diaSelecionado}");
            }
            else if (rbConsulta.Checked)
            {
                ConsultarHorariosDisponíveis("consulta");

                MessageBox.Show($"Dia selecionado para consulta: {diaSelecionado}");
            }
            else if (rbExame.Checked)
            {
                ConsultarHorariosDisponíveis("Banho e Tosa");
                MessageBox.Show($"Dia selecionado para Exame: {diaSelecionado}");
            }
            else if (rbCirurgia.Checked)
            {
                ConsultarHorariosDisponíveis("Banho e Tosa");
                MessageBox.Show($"Dia selecionado para cirurgia: {diaSelecionado}");
            }
        }
    }


}







