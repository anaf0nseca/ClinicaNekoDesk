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
    public partial class FrmListaAgendamento : Form
    {
        public FrmListaAgendamento()
        {
            InitializeComponent();
        }

        private void dgvListaPedido_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmListaAgendamento_Load(object sender, EventArgs e)
        {
            CarregaGridAgendamento();
        }

        private void CarregaGridAgendamento()
        {
            var listaAgendamento = Agendamento.ObterLista();

            dgvListaAgendamento.Rows.Clear();
            int cont = 0;

            foreach (var agendamento in listaAgendamento)
            {
                int rowIndex = dgvListaAgendamento.Rows.Add();
                dgvListaAgendamento.Rows[cont].Cells[0].Value = agendamento.Id;
                dgvListaAgendamento.Rows[cont].Cells[1].Value = agendamento.Usuario.Nome;
                dgvListaAgendamento.Rows[cont].Cells[2].Value = agendamento.Paciente.Nome;
                dgvListaAgendamento.Rows[cont].Cells[3].Value = agendamento.Data;
                dgvListaAgendamento.Rows[cont].Cells[4].Value = agendamento.Hora;
                dgvListaAgendamento.Rows[cont].Cells[5].Value = agendamento.Status;


                cont++;
            }
        }

        private void dgvListaAgendamento_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.tpDetalheAgendamento.Enabled = true;
            int id = 0;
            int posicaoLinha = dgvListaAgendamento.CurrentRow.Index;
            id = Convert.ToInt32(dgvListaAgendamento.Rows[posicaoLinha].Cells[0].Value);

            this.tabConsultaAgend.SelectedTab = tpDetalheAgendamento;

            Agendamento agendamento = Agendamento.ObterPorId(id);
        }
    }
}
