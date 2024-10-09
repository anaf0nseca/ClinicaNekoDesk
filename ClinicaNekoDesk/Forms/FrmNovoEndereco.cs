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

namespace ClinicaNeko.Forms
{
    public partial class FrmNovoEndereco : Form
    {
        
        public FrmNovoEndereco()
        {
            InitializeComponent();
        }

        private void btnSalvarEnd_Click(object sender, EventArgs e)
        {
            Endereco endereco = new(
                txtCep.Text,
                txtLogradouro.Text,
                txtNumero.Text,
                txtComplemento.Text,
                txtBairro.Text,
                txtCidade.Text,
                cmbUf.Text,
                cmbTipoEnd.Text
                );

            endereco.Inserir();

            if (endereco.Id > 0)
            {

                FrmNovoUsuario frmNovoUsuario = new();
                MessageBox.Show($"{frmNovoUsuario.UsuarioId}");
                int idUsuario = frmNovoUsuario.UsuarioId;
                EnderecoUsuario enderecoUsuario = new(
                    Endereco.ObterPorId(Convert.ToInt32(endereco.Id)),
                    Usuario.ObterPorId(Convert.ToInt32(idUsuario))
                    );

                enderecoUsuario.Inserir();
            }
        }

        private void FrmNovoEndereco_Load(object sender, EventArgs e)
        {

        }
    }
}
