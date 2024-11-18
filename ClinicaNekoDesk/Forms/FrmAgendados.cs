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
    public partial class FrmAgendados : Form
    {
        public FrmAgendados()
        {
            InitializeComponent();
        }

        private void btnCadProduto_Click(object sender, EventArgs e)
        {

        }

        private void dgvListaAgendamento_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.tpDetalheAgendamento.Enabled = true;

            int id = 0;
            int posicaoLinha = dgvListaAgendados.CurrentRow.Index;
            id = Convert.ToInt32(dgvListaAgendados.Rows[posicaoLinha].Cells[0].Value);

            this.tabConsultaAgend.SelectedTab = tpDetalheAgendamento;


        }

        private void CarregaGridAgendamento()
        {
            var listaAgendamento = Agendamento.ObterListaPorUsuario(Program.UsuarioLogado.Id);

            dgvListaAgendados.Rows.Clear();
            int cont = 0;

            foreach (var agendado in listaAgendamento)
            {


                int rowIndex = dgvListaAgendados.Rows.Add();
                dgvListaAgendados.Rows[cont].Cells[0].Value = agendado.Id;
                dgvListaAgendados.Rows[cont].Cells[1].Value = agendado.Usuario.Nome;
                dgvListaAgendados.Rows[cont].Cells[2].Value = agendado.Paciente.Nome;

                if (Program.UsuarioLogado.Cargo.Id >= 5 && Program.UsuarioLogado.Cargo.Id <= 15)
                {
                    AgendamentoConsulta agendamentoConsulta = new();
                    var consultas = AgendamentoConsulta.ObterListaPorAgendamento(agendado.Id);
                    foreach(var consulta in consultas)
                    {

                        dgvListaAgendados.Rows[cont].Cells[3].Value = consulta.Consulta.Nome;

                    }


                }
                else if (Program.UsuarioLogado.Cargo.Id == 16)
                {
                    AgendamentoCirurgia agendamentoCirurgia = new();
                    var cirurgias = AgendamentoCirurgia.ObterListaPorAgendamento(agendado.Id);

                    foreach (var cirurgia in cirurgias)
                    {

                        dgvListaAgendados.Rows[cont].Cells[3].Value = cirurgia.Cirurgia.Nome;

                    }

                } else if (Program.UsuarioLogado.Cargo.Id == 17)
                {
                    AgendamentoExame agendamentoExame = new();
                    var exames = AgendamentoExame.ObterListaPorAgendamento(agendado.Id);

                    foreach (var exame in exames)
                    {
                        dgvListaAgendados.Rows[cont].Cells[3].Value = exame.Exame.Nome;

                    }
                }
                else if (Program.UsuarioLogado.Cargo.Id >= 20 && Program.UsuarioLogado.Cargo.Id <= 22)
                {
                    AgendamentoServico agendamentoServico = new();
                    var servicos = AgendamentoServico.ObterListaPorAgendamento(agendado.Id);

                    foreach (var servico in servicos)
                    {

                        dgvListaAgendados.Rows[cont].Cells[3].Value = servico.Servico.Nome;

                    }
                }

                dgvListaAgendados.Rows[cont].Cells[4].Value = agendado.Data;
                dgvListaAgendados.Rows[cont].Cells[5].Value = agendado.Hora;
                dgvListaAgendados.Rows[cont].Cells[6].Value = agendado.Status;


                cont++;
            }
        }

        private void FrmAgendados_Load(object sender, EventArgs e)
        {
            CarregaGridAgendamento();
        }
    }
}
