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
    public partial class FrmNovoPaciente : Form
    {
        public int idCliente { get; set; }

        public FrmNovoPaciente()
        {
            InitializeComponent();
        }

        private void FrmNovoPaciente_Load(object sender, EventArgs e)
        {
            Cliente cliente = Cliente.ObterPorId(idCliente);

            txtIdTutor.Text = cliente.Id.ToString();
            txtNomeTutor.Text = cliente.Nome;

            var especies = Especie.ObterLista();

            cmbEspecie.DataSource = especies;
            cmbEspecie.DisplayMember = "Nome";
            cmbEspecie.ValueMember = "Id";


        }

        private void btnCadPaciente_Click(object sender, EventArgs e)
        {
            if (VerificaControles())
            {
                Paciente paciente = new(
                    Cliente.ObterPorId(Convert.ToInt32(txtIdTutor.Text)),
                    Raca.ObterPorId(Convert.ToInt32(cmbRaca.SelectedValue)),
                    txtNome.Text,
                    cmbCor.Text,
                    Convert.ToInt32(txtIdade.Text),
                    Convert.ToDouble(txtPeso.Text)
                );
                paciente.Inserir();

                if(paciente.Id > 0)
                {
                    MessageBox.Show($"O paciente {paciente.Nome} " + $"foi cadastrado com sucesso, associado ao tutor {txtNomeTutor.Text}.");

                }
            }
            else
            {
                MessageBox.Show("Preencha todos os campos antes de continuar");

            }
        }

        private void cmbEspecie_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEspecie.SelectedItem != null)
            {
                Especie especie = cmbEspecie.SelectedItem as Especie;
                int id = especie.Id;

                //Carrega a lista de raças de acordo com a especie selecionada
                var cargos = Raca.ObterListaPorEspecie(id);

                //Associa as listas ao combobox
                cmbRaca.DataSource = cargos;

                //Exibe o nome para o usuario
                cmbRaca.DisplayMember = "Nome";

                //Retorna para o banco o valor contido na coluna ID
                cmbRaca.ValueMember = "Id";

            }
        }

        private bool VerificaControles()
        {
            if (txtNome.Text != string.Empty &&
                cmbEspecie.SelectedItem != null &&
                cmbRaca.SelectedItem != null &&
                cmbCor.SelectedItem != null &&
                txtIdade.Text != string.Empty &&
                txtPeso.Text != string.Empty)
            {
                return true;
            }
            else { return false; }
        }
    }
}
