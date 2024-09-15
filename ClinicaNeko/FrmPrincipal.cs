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

namespace ClinicaNeko
{
    public partial class Form1 : Form
    {
        public static Panel MainPanel;
        public Form1()
        {
            InitializeComponent();
            MainPanel = panel1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FrmTeste frmTeste = new FrmTeste();
            frmTeste.Dock = DockStyle.Fill;
            frmTeste.TopLevel = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(frmTeste);
            frmTeste.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmTestinho frmTestinho = new FrmTestinho();
            frmTestinho.Dock = DockStyle.Fill;
            frmTestinho.TopLevel = false;
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(frmTestinho);
            frmTestinho.Show();
        }



    }
}
