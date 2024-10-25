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
    public partial class FrmNovoAgendamento : Form
    {
        public FrmNovoAgendamento()
        {
            InitializeComponent();
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            string dia = monthCalendar1.SelectionRange.Start.ToString();
            MessageBox.Show($"Data selecionada: {dia}");
        }
    }
}
