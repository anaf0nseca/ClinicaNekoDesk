﻿namespace ClinicaNekoDesk.Forms
{
    partial class FrmListaPedido
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            tabConsultaProduto = new Guna.UI2.WinForms.Guna2TabControl();
            tpListarPedidos = new TabPage();
            gpbDadosPaciente = new Guna.UI2.WinForms.Guna2GroupBox();
            guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel13 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            dgvListaPedido = new Guna.UI2.WinForms.Guna2DataGridView();
            clnId = new DataGridViewTextBoxColumn();
            clnUsuario = new DataGridViewTextBoxColumn();
            clnCliente = new DataGridViewTextBoxColumn();
            clnData = new DataGridViewTextBoxColumn();
            clnStatus = new DataGridViewTextBoxColumn();
            clnDesconto = new DataGridViewTextBoxColumn();
            clnValor = new DataGridViewTextBoxColumn();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            tpDetalhePedido = new TabPage();
            btnCadProduto = new Guna.UI2.WinForms.Guna2Button();
            tabConsultaProduto.SuspendLayout();
            tpListarPedidos.SuspendLayout();
            gpbDadosPaciente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListaPedido).BeginInit();
            tpDetalhePedido.SuspendLayout();
            SuspendLayout();
            // 
            // tabConsultaProduto
            // 
            tabConsultaProduto.Controls.Add(tpListarPedidos);
            tabConsultaProduto.Controls.Add(tpDetalhePedido);
            tabConsultaProduto.ItemSize = new Size(180, 40);
            tabConsultaProduto.Location = new Point(-3, -2);
            tabConsultaProduto.Name = "tabConsultaProduto";
            tabConsultaProduto.SelectedIndex = 0;
            tabConsultaProduto.Size = new Size(1054, 623);
            tabConsultaProduto.TabButtonHoverState.BorderColor = Color.Empty;
            tabConsultaProduto.TabButtonHoverState.FillColor = Color.FromArgb(83, 133, 91);
            tabConsultaProduto.TabButtonHoverState.Font = new Font("Segoe UI Semibold", 10F);
            tabConsultaProduto.TabButtonHoverState.ForeColor = Color.White;
            tabConsultaProduto.TabButtonHoverState.InnerColor = Color.FromArgb(38, 62, 41);
            tabConsultaProduto.TabButtonIdleState.BorderColor = Color.Empty;
            tabConsultaProduto.TabButtonIdleState.FillColor = Color.FromArgb(83, 133, 91);
            tabConsultaProduto.TabButtonIdleState.Font = new Font("Segoe UI Semibold", 10F);
            tabConsultaProduto.TabButtonIdleState.ForeColor = Color.FromArgb(64, 64, 64);
            tabConsultaProduto.TabButtonIdleState.InnerColor = Color.FromArgb(83, 133, 91);
            tabConsultaProduto.TabButtonSelectedState.BorderColor = Color.Empty;
            tabConsultaProduto.TabButtonSelectedState.FillColor = Color.FromArgb(38, 62, 41);
            tabConsultaProduto.TabButtonSelectedState.Font = new Font("Segoe UI Semibold", 10F);
            tabConsultaProduto.TabButtonSelectedState.ForeColor = Color.White;
            tabConsultaProduto.TabButtonSelectedState.InnerColor = Color.FromArgb(102, 162, 109);
            tabConsultaProduto.TabButtonSize = new Size(180, 40);
            tabConsultaProduto.TabButtonTextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            tabConsultaProduto.TabIndex = 4;
            tabConsultaProduto.TabMenuBackColor = Color.FromArgb(83, 133, 91);
            tabConsultaProduto.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            // 
            // tpListarPedidos
            // 
            tpListarPedidos.Controls.Add(gpbDadosPaciente);
            tpListarPedidos.Controls.Add(dgvListaPedido);
            tpListarPedidos.Controls.Add(guna2HtmlLabel1);
            tpListarPedidos.Location = new Point(4, 44);
            tpListarPedidos.Name = "tpListarPedidos";
            tpListarPedidos.Padding = new Padding(3);
            tpListarPedidos.Size = new Size(1046, 575);
            tpListarPedidos.TabIndex = 1;
            tpListarPedidos.Text = "Lista";
            tpListarPedidos.UseVisualStyleBackColor = true;
            // 
            // gpbDadosPaciente
            // 
            gpbDadosPaciente.BorderColor = Color.FromArgb(83, 133, 91);
            gpbDadosPaciente.BorderRadius = 15;
            gpbDadosPaciente.Controls.Add(guna2HtmlLabel4);
            gpbDadosPaciente.Controls.Add(guna2HtmlLabel3);
            gpbDadosPaciente.Controls.Add(guna2HtmlLabel2);
            gpbDadosPaciente.Controls.Add(guna2HtmlLabel13);
            gpbDadosPaciente.CustomBorderColor = Color.FromArgb(34, 85, 96);
            gpbDadosPaciente.CustomBorderThickness = new Padding(0, 30, 0, 0);
            gpbDadosPaciente.CustomizableEdges = customizableEdges1;
            gpbDadosPaciente.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gpbDadosPaciente.ForeColor = Color.White;
            gpbDadosPaciente.Location = new Point(682, 9);
            gpbDadosPaciente.Margin = new Padding(5, 0, 5, 0);
            gpbDadosPaciente.Name = "gpbDadosPaciente";
            gpbDadosPaciente.ShadowDecoration.CustomizableEdges = customizableEdges2;
            gpbDadosPaciente.Size = new Size(348, 67);
            gpbDadosPaciente.TabIndex = 31;
            gpbDadosPaciente.Text = "Legenda - STATUS";
            // 
            // guna2HtmlLabel4
            // 
            guna2HtmlLabel4.BackColor = Color.Transparent;
            guna2HtmlLabel4.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel4.ForeColor = Color.FromArgb(39, 63, 44);
            guna2HtmlLabel4.Location = new Point(257, 38);
            guna2HtmlLabel4.Margin = new Padding(4, 3, 4, 3);
            guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            guna2HtmlLabel4.Size = new Size(84, 17);
            guna2HtmlLabel4.TabIndex = 54;
            guna2HtmlLabel4.Text = "C = Cancelado";
            // 
            // guna2HtmlLabel3
            // 
            guna2HtmlLabel3.BackColor = Color.Transparent;
            guna2HtmlLabel3.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel3.ForeColor = Color.FromArgb(39, 63, 44);
            guna2HtmlLabel3.Location = new Point(168, 38);
            guna2HtmlLabel3.Margin = new Padding(4, 3, 4, 3);
            guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            guna2HtmlLabel3.Size = new Size(84, 17);
            guna2HtmlLabel3.TabIndex = 53;
            guna2HtmlLabel3.Text = "F = Finalizado | ";
            // 
            // guna2HtmlLabel2
            // 
            guna2HtmlLabel2.BackColor = Color.Transparent;
            guna2HtmlLabel2.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel2.ForeColor = Color.FromArgb(39, 63, 44);
            guna2HtmlLabel2.Location = new Point(79, 38);
            guna2HtmlLabel2.Margin = new Padding(4, 3, 4, 3);
            guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            guna2HtmlLabel2.Size = new Size(84, 17);
            guna2HtmlLabel2.TabIndex = 52;
            guna2HtmlLabel2.Text = "P = Pendente | ";
            // 
            // guna2HtmlLabel13
            // 
            guna2HtmlLabel13.BackColor = Color.Transparent;
            guna2HtmlLabel13.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel13.ForeColor = Color.FromArgb(39, 63, 44);
            guna2HtmlLabel13.Location = new Point(7, 38);
            guna2HtmlLabel13.Margin = new Padding(4, 3, 4, 3);
            guna2HtmlLabel13.Name = "guna2HtmlLabel13";
            guna2HtmlLabel13.Size = new Size(68, 17);
            guna2HtmlLabel13.TabIndex = 51;
            guna2HtmlLabel13.Text = "A = Aberto | ";
            // 
            // dgvListaPedido
            // 
            dgvListaPedido.AllowUserToAddRows = false;
            dgvListaPedido.AllowUserToDeleteRows = false;
            dgvListaPedido.AllowUserToResizeColumns = false;
            dgvListaPedido.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(164, 196, 169);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(115, 158, 122);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dgvListaPedido.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvListaPedido.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dgvListaPedido.BackgroundColor = Color.FromArgb(200, 219, 203);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(34, 85, 96);
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(34, 85, 96);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvListaPedido.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvListaPedido.ColumnHeadersHeight = 32;
            dgvListaPedido.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvListaPedido.Columns.AddRange(new DataGridViewColumn[] { clnId, clnUsuario, clnCliente, clnData, clnStatus, clnDesconto, clnValor });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(115, 158, 122);
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvListaPedido.DefaultCellStyle = dataGridViewCellStyle5;
            dgvListaPedido.GridColor = Color.FromArgb(231, 229, 255);
            dgvListaPedido.Location = new Point(11, 79);
            dgvListaPedido.Name = "dgvListaPedido";
            dgvListaPedido.ReadOnly = true;
            dgvListaPedido.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = Color.White;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvListaPedido.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgvListaPedido.RowHeadersVisible = false;
            dgvListaPedido.Size = new Size(1019, 487);
            dgvListaPedido.TabIndex = 28;
            dgvListaPedido.ThemeStyle.AlternatingRowsStyle.BackColor = Color.FromArgb(164, 196, 169);
            dgvListaPedido.ThemeStyle.AlternatingRowsStyle.Font = new Font("Segoe UI", 9F);
            dgvListaPedido.ThemeStyle.AlternatingRowsStyle.ForeColor = SystemColors.ControlText;
            dgvListaPedido.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.FromArgb(115, 158, 122);
            dgvListaPedido.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dgvListaPedido.ThemeStyle.BackColor = Color.FromArgb(200, 219, 203);
            dgvListaPedido.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvListaPedido.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(115, 158, 122);
            dgvListaPedido.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvListaPedido.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dgvListaPedido.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvListaPedido.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvListaPedido.ThemeStyle.HeaderStyle.Height = 32;
            dgvListaPedido.ThemeStyle.ReadOnly = true;
            dgvListaPedido.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvListaPedido.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvListaPedido.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvListaPedido.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvListaPedido.ThemeStyle.RowsStyle.Height = 25;
            dgvListaPedido.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(115, 158, 122);
            dgvListaPedido.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dgvListaPedido.CellContentClick += dgvListaProduto_CellContentClick;
            // 
            // clnId
            // 
            clnId.HeaderText = "ID";
            clnId.Name = "clnId";
            clnId.ReadOnly = true;
            clnId.Width = 55;
            // 
            // clnUsuario
            // 
            clnUsuario.HeaderText = "Usuário";
            clnUsuario.Name = "clnUsuario";
            clnUsuario.ReadOnly = true;
            clnUsuario.Width = 280;
            // 
            // clnCliente
            // 
            clnCliente.HeaderText = "Cliente";
            clnCliente.Name = "clnCliente";
            clnCliente.ReadOnly = true;
            clnCliente.Width = 280;
            // 
            // clnData
            // 
            clnData.HeaderText = "Data";
            clnData.Name = "clnData";
            clnData.ReadOnly = true;
            clnData.Width = 120;
            // 
            // clnStatus
            // 
            clnStatus.HeaderText = "Status";
            clnStatus.Name = "clnStatus";
            clnStatus.ReadOnly = true;
            // 
            // clnDesconto
            // 
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            clnDesconto.DefaultCellStyle = dataGridViewCellStyle3;
            clnDesconto.HeaderText = "Desconto";
            clnDesconto.Name = "clnDesconto";
            clnDesconto.ReadOnly = true;
            clnDesconto.Width = 113;
            // 
            // clnValor
            // 
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            clnValor.DefaultCellStyle = dataGridViewCellStyle4;
            clnValor.HeaderText = "Valor";
            clnValor.Name = "clnValor";
            clnValor.ReadOnly = true;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2HtmlLabel1.ForeColor = Color.FromArgb(39, 63, 44);
            guna2HtmlLabel1.Location = new Point(384, 27);
            guna2HtmlLabel1.Margin = new Padding(4, 3, 4, 3);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(256, 34);
            guna2HtmlLabel1.TabIndex = 27;
            guna2HtmlLabel1.Text = "LISTA DE PEDIDOS";
            // 
            // tpDetalhePedido
            // 
            tpDetalhePedido.BackColor = Color.FromArgb(159, 187, 164);
            tpDetalhePedido.Controls.Add(btnCadProduto);
            tpDetalhePedido.Location = new Point(4, 44);
            tpDetalhePedido.Name = "tpDetalhePedido";
            tpDetalhePedido.Padding = new Padding(3);
            tpDetalhePedido.Size = new Size(1046, 575);
            tpDetalhePedido.TabIndex = 2;
            tpDetalhePedido.Text = "Detalhes do Pedido";
            tpDetalhePedido.Click += tpDetalhePedido_Click;
            // 
            // btnCadProduto
            // 
            btnCadProduto.Animated = true;
            btnCadProduto.BackColor = Color.Transparent;
            btnCadProduto.BorderRadius = 20;
            btnCadProduto.CustomizableEdges = customizableEdges3;
            btnCadProduto.DisabledState.BorderColor = Color.DarkGray;
            btnCadProduto.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCadProduto.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCadProduto.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCadProduto.FillColor = Color.FromArgb(34, 85, 96);
            btnCadProduto.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnCadProduto.ForeColor = Color.White;
            btnCadProduto.ImageAlign = HorizontalAlignment.Right;
            btnCadProduto.ImageSize = new Size(24, 24);
            btnCadProduto.Location = new Point(874, 487);
            btnCadProduto.Margin = new Padding(4, 3, 4, 3);
            btnCadProduto.Name = "btnCadProduto";
            btnCadProduto.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnCadProduto.Size = new Size(136, 29);
            btnCadProduto.TabIndex = 77;
            btnCadProduto.Text = "Salvar alterações";
            // 
            // FrmListaPedido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(159, 187, 164);
            ClientSize = new Size(1050, 620);
            ControlBox = false;
            Controls.Add(tabConsultaProduto);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmListaPedido";
            Text = "FrmListaPedido";
            Load += FrmListaPedido_Load_1;
            tabConsultaProduto.ResumeLayout(false);
            tpListarPedidos.ResumeLayout(false);
            tpListarPedidos.PerformLayout();
            gpbDadosPaciente.ResumeLayout(false);
            gpbDadosPaciente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListaPedido).EndInit();
            tpDetalhePedido.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2TabControl tabConsultaProduto;
        private TabPage tpListarPedidos;
        private TabPage tpDetalhePedido;
        private Guna.UI2.WinForms.Guna2Button btnCadProduto;
        private Guna.UI2.WinForms.Guna2DataGridView dgvListaPedido;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private DataGridViewTextBoxColumn clnId;
        private DataGridViewTextBoxColumn clnUsuario;
        private DataGridViewTextBoxColumn clnCliente;
        private DataGridViewTextBoxColumn clnData;
        private DataGridViewTextBoxColumn clnStatus;
        private DataGridViewTextBoxColumn clnDesconto;
        private DataGridViewTextBoxColumn clnValor;
        private Guna.UI2.WinForms.Guna2GroupBox gpbDadosPaciente;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel13;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
    }
}