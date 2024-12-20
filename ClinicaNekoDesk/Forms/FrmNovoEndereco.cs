﻿using ClinicaNekoDesk.Forms;
using ClinicaNekoLib;
using MySqlX.XDevAPI;
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
        public int idUsuario {  get; set; }
        public int idCliente { get; set; }
        public int idClienteNovoEnd { get; set; }

        public static Panel MainPanel;
        public FrmNovoEndereco()
        {
            InitializeComponent();
            MainPanel = FrmPrincipal.MainPanel;
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

            if (idUsuario > 0 && endereco.Id > 0)
            {

                EnderecoUsuario enderecoUsuario = new(
                    Endereco.ObterPorId(Convert.ToInt32(endereco.Id)),
                    Usuario.ObterPorId(Convert.ToInt32(idUsuario))
                    );

                enderecoUsuario.Inserir();

                MessageBox.Show($"Endereço cadastrado com sucesso!");

                btnSalvarEnd.Enabled = false;

            }
            else if (idCliente > 0 && endereco.Id > 0 && idClienteNovoEnd == 0)
            {
                EnderecoCliente enderecoCliente = new(
                    Endereco.ObterPorId(Convert.ToInt32(endereco.Id)),
                    Cliente.ObterPorId(Convert.ToInt32(idCliente))
                    );

                enderecoCliente.Inserir();

                MessageBox.Show($"Endereço cadastrado com sucesso!");

                FrmNovoPaciente frmNovoPaciente = new FrmNovoPaciente();
                frmNovoPaciente.idCliente = idCliente;

                frmNovoPaciente.Dock = DockStyle.Fill;
                frmNovoPaciente.TopLevel = false;
                MainPanel.Controls.Clear();
                MainPanel.Controls.Add(frmNovoPaciente);
                frmNovoPaciente.Show();


            } else if (idClienteNovoEnd > 0 && endereco.Id > 0)
            
                {
                    EnderecoCliente enderecoCliente = new(
                       Endereco.ObterPorId(Convert.ToInt32(endereco.Id)),
                       Cliente.ObterPorId(idClienteNovoEnd)
                       );

                    enderecoCliente.Inserir();

                    MessageBox.Show($"Endereço cadastrado com sucesso!");

                    FrmListaCliente frmListaCliente = new FrmListaCliente();

                    frmListaCliente.Dock = DockStyle.Fill;
                    frmListaCliente.TopLevel = false;
                    MainPanel.Controls.Clear();
                    MainPanel.Controls.Add(frmListaCliente);
                    frmListaCliente.Show();

            }
        }

        private void FrmNovoEndereco_Load(object sender, EventArgs e)
        {
             
        }
    }
}
