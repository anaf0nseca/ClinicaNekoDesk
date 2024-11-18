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
                dgvListaAgendados.Rows[cont].Cells[3].Value = agendado.Data;
                dgvListaAgendados.Rows[cont].Cells[4].Value = agendado.Hora;
                dgvListaAgendados.Rows[cont].Cells[5].Value = agendado.Status;


                cont++;
            }
        }

        private void FrmAgendados_Load(object sender, EventArgs e)
        {

        }
    }
}
