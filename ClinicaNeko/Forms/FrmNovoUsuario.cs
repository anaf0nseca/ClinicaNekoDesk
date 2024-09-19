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

        private void cmbSetor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            FrmNovoEndereco frmNovoEndereco = new FrmNovoEndereco();
            frmNovoEndereco.Dock = DockStyle.Fill;
            frmNovoEndereco.TopLevel = false;
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(frmNovoEndereco);
            frmNovoEndereco.Show();
        }
    }
}
