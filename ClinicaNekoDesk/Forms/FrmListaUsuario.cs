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
    public partial class FrmListaUsuario : Form
    {
        public FrmListaUsuario()
        {
            InitializeComponent();
        }

        private void FrmListaUsuario_Load(object sender, EventArgs e)
        {
            CarregaGridUsuarios();
        }

        private void CarregaGridUsuarios()
        {
            var listaUsuarios = Usuario.ObterLista();

            int cont = 0;
            dgvListaUsuarios.Rows.Clear();

            foreach(var usuario in listaUsuarios)
            {
                int rowIndex = dgvListaUsuarios.Rows.Add();
                dgvListaUsuarios.Rows[cont].Cells[0].Value = usuario.Id;
                dgvListaUsuarios.Rows[cont].Cells[1].Value = usuario.Nome;
                dgvListaUsuarios.Rows[cont].Cells[2].Value = usuario.Cpf;
                dgvListaUsuarios.Rows[cont].Cells[3].Value = usuario.DataNascimento;
                dgvListaUsuarios.Rows[cont].Cells[4].Value = usuario.Setor.Nome;
                dgvListaUsuarios.Rows[cont].Cells[5].Value = usuario.Cargo.Nome;
                dgvListaUsuarios.Rows[cont].Cells[6].Value = usuario.Email;
                dgvListaUsuarios.Rows[cont].Cells[7].Value = usuario.Ativo;

                cont++;
            }
        }
    }
}
