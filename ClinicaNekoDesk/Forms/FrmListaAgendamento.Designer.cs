namespace ClinicaNekoDesk.Forms
{
    partial class FrmListaAgendamento
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
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            tpListarAgendamentos = new TabPage();
            dgvListaAgendamento = new Guna.UI2.WinForms.Guna2DataGridView();
            clnId = new DataGridViewTextBoxColumn();
            clnUsuario = new DataGridViewTextBoxColumn();
            clnCliente = new DataGridViewTextBoxColumn();
            clnData = new DataGridViewTextBoxColumn();
            clnHora = new DataGridViewTextBoxColumn();
            clnStatus = new DataGridViewTextBoxColumn();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            label1 = new Label();
            tabConsultaAgend = new Guna.UI2.WinForms.Guna2TabControl();
            tpDetalheAgendamento = new TabPage();
            btnCadProduto = new Guna.UI2.WinForms.Guna2Button();
            tpListarAgendamentos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListaAgendamento).BeginInit();
            tabConsultaAgend.SuspendLayout();
            tpDetalheAgendamento.SuspendLayout();
            SuspendLayout();
            // 
            // tpListarAgendamentos
            // 
            tpListarAgendamentos.Controls.Add(dgvListaAgendamento);
            tpListarAgendamentos.Controls.Add(guna2HtmlLabel1);
            tpListarAgendamentos.Controls.Add(label1);
            tpListarAgendamentos.Location = new Point(4, 44);
            tpListarAgendamentos.Name = "tpListarAgendamentos";
            tpListarAgendamentos.Padding = new Padding(3);
            tpListarAgendamentos.Size = new Size(1031, 537);
            tpListarAgendamentos.TabIndex = 1;
            tpListarAgendamentos.Text = "Lista";
            tpListarAgendamentos.UseVisualStyleBackColor = true;
            // 
            // dgvListaAgendamento
            // 
            dgvListaAgendamento.AllowUserToAddRows = false;
            dgvListaAgendamento.AllowUserToDeleteRows = false;
            dgvListaAgendamento.AllowUserToResizeColumns = false;
            dgvListaAgendamento.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(164, 196, 169);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(115, 158, 122);
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            dgvListaAgendamento.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            dgvListaAgendamento.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dgvListaAgendamento.BackgroundColor = Color.FromArgb(200, 219, 203);
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(34, 85, 96);
            dataGridViewCellStyle7.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(34, 85, 96);
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvListaAgendamento.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvListaAgendamento.ColumnHeadersHeight = 32;
            dgvListaAgendamento.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvListaAgendamento.Columns.AddRange(new DataGridViewColumn[] { clnId, clnUsuario, clnCliente, clnData, clnHora, clnStatus });
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.White;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle9.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(115, 158, 122);
            dataGridViewCellStyle9.SelectionForeColor = Color.White;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.False;
            dgvListaAgendamento.DefaultCellStyle = dataGridViewCellStyle9;
            dgvListaAgendamento.GridColor = Color.FromArgb(231, 229, 255);
            dgvListaAgendamento.Location = new Point(20, 64);
            dgvListaAgendamento.Name = "dgvListaAgendamento";
            dgvListaAgendamento.ReadOnly = true;
            dgvListaAgendamento.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = Color.White;
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle10.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = Color.White;
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            dgvListaAgendamento.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            dgvListaAgendamento.RowHeadersVisible = false;
            dgvListaAgendamento.Size = new Size(996, 461);
            dgvListaAgendamento.TabIndex = 28;
            dgvListaAgendamento.ThemeStyle.AlternatingRowsStyle.BackColor = Color.FromArgb(164, 196, 169);
            dgvListaAgendamento.ThemeStyle.AlternatingRowsStyle.Font = new Font("Segoe UI", 9F);
            dgvListaAgendamento.ThemeStyle.AlternatingRowsStyle.ForeColor = SystemColors.ControlText;
            dgvListaAgendamento.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.FromArgb(115, 158, 122);
            dgvListaAgendamento.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dgvListaAgendamento.ThemeStyle.BackColor = Color.FromArgb(200, 219, 203);
            dgvListaAgendamento.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvListaAgendamento.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(115, 158, 122);
            dgvListaAgendamento.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvListaAgendamento.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dgvListaAgendamento.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvListaAgendamento.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvListaAgendamento.ThemeStyle.HeaderStyle.Height = 32;
            dgvListaAgendamento.ThemeStyle.ReadOnly = true;
            dgvListaAgendamento.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvListaAgendamento.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvListaAgendamento.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvListaAgendamento.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvListaAgendamento.ThemeStyle.RowsStyle.Height = 25;
            dgvListaAgendamento.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(115, 158, 122);
            dgvListaAgendamento.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dgvListaAgendamento.CellContentClick += dgvListaPedido_CellContentClick;
            dgvListaAgendamento.CellDoubleClick += dgvListaAgendamento_CellDoubleClick;
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
            clnUsuario.Width = 300;
            // 
            // clnCliente
            // 
            clnCliente.HeaderText = "Cliente";
            clnCliente.Name = "clnCliente";
            clnCliente.ReadOnly = true;
            clnCliente.Width = 300;
            // 
            // clnData
            // 
            clnData.HeaderText = "Data";
            clnData.Name = "clnData";
            clnData.ReadOnly = true;
            clnData.Width = 120;
            // 
            // clnHora
            // 
            dataGridViewCellStyle8.Format = "d";
            dataGridViewCellStyle8.NullValue = null;
            clnHora.DefaultCellStyle = dataGridViewCellStyle8;
            clnHora.HeaderText = "Hora";
            clnHora.Name = "clnHora";
            clnHora.ReadOnly = true;
            clnHora.Width = 120;
            // 
            // clnStatus
            // 
            clnStatus.HeaderText = "Status";
            clnStatus.Name = "clnStatus";
            clnStatus.ReadOnly = true;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2HtmlLabel1.ForeColor = Color.FromArgb(39, 63, 44);
            guna2HtmlLabel1.Location = new Point(348, 17);
            guna2HtmlLabel1.Margin = new Padding(4, 3, 4, 3);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(368, 34);
            guna2HtmlLabel1.TabIndex = 27;
            guna2HtmlLabel1.Text = "LISTA DE AGENDAMENTOS";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(315, 80);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(328, 73);
            label1.TabIndex = 26;
            label1.Text = "SERVIÇO";
            // 
            // tabConsultaAgend
            // 
            tabConsultaAgend.Controls.Add(tpListarAgendamentos);
            tabConsultaAgend.Controls.Add(tpDetalheAgendamento);
            tabConsultaAgend.ItemSize = new Size(180, 40);
            tabConsultaAgend.Location = new Point(-5, 0);
            tabConsultaAgend.Name = "tabConsultaAgend";
            tabConsultaAgend.SelectedIndex = 0;
            tabConsultaAgend.Size = new Size(1039, 585);
            tabConsultaAgend.TabButtonHoverState.BorderColor = Color.Empty;
            tabConsultaAgend.TabButtonHoverState.FillColor = Color.FromArgb(83, 133, 91);
            tabConsultaAgend.TabButtonHoverState.Font = new Font("Segoe UI Semibold", 10F);
            tabConsultaAgend.TabButtonHoverState.ForeColor = Color.White;
            tabConsultaAgend.TabButtonHoverState.InnerColor = Color.FromArgb(38, 62, 41);
            tabConsultaAgend.TabButtonIdleState.BorderColor = Color.Empty;
            tabConsultaAgend.TabButtonIdleState.FillColor = Color.FromArgb(83, 133, 91);
            tabConsultaAgend.TabButtonIdleState.Font = new Font("Segoe UI Semibold", 10F);
            tabConsultaAgend.TabButtonIdleState.ForeColor = Color.FromArgb(64, 64, 64);
            tabConsultaAgend.TabButtonIdleState.InnerColor = Color.FromArgb(83, 133, 91);
            tabConsultaAgend.TabButtonSelectedState.BorderColor = Color.Empty;
            tabConsultaAgend.TabButtonSelectedState.FillColor = Color.FromArgb(38, 62, 41);
            tabConsultaAgend.TabButtonSelectedState.Font = new Font("Segoe UI Semibold", 10F);
            tabConsultaAgend.TabButtonSelectedState.ForeColor = Color.White;
            tabConsultaAgend.TabButtonSelectedState.InnerColor = Color.FromArgb(102, 162, 109);
            tabConsultaAgend.TabButtonSize = new Size(180, 40);
            tabConsultaAgend.TabButtonTextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            tabConsultaAgend.TabIndex = 5;
            tabConsultaAgend.TabMenuBackColor = Color.FromArgb(83, 133, 91);
            tabConsultaAgend.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            // 
            // tpDetalheAgendamento
            // 
            tpDetalheAgendamento.BackColor = Color.FromArgb(159, 187, 164);
            tpDetalheAgendamento.Controls.Add(btnCadProduto);
            tpDetalheAgendamento.Location = new Point(4, 44);
            tpDetalheAgendamento.Name = "tpDetalheAgendamento";
            tpDetalheAgendamento.Padding = new Padding(3);
            tpDetalheAgendamento.Size = new Size(1031, 537);
            tpDetalheAgendamento.TabIndex = 2;
            tpDetalheAgendamento.Text = "Detalhes do Agendamento";
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
            btnCadProduto.Location = new Point(815, 464);
            btnCadProduto.Margin = new Padding(4, 3, 4, 3);
            btnCadProduto.Name = "btnCadProduto";
            btnCadProduto.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnCadProduto.Size = new Size(195, 52);
            btnCadProduto.TabIndex = 77;
            btnCadProduto.Text = "Salvar alterações";
            // 
            // FrmListaAgendamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1034, 581);
            Controls.Add(tabConsultaAgend);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmListaAgendamento";
            Text = "FrmListaAgendamento";
            Load += FrmListaAgendamento_Load;
            tpListarAgendamentos.ResumeLayout(false);
            tpListarAgendamentos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListaAgendamento).EndInit();
            tabConsultaAgend.ResumeLayout(false);
            tpDetalheAgendamento.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabPage tpListarAgendamentos;
        private Guna.UI2.WinForms.Guna2DataGridView dgvListaAgendamento;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Label label1;
        private Guna.UI2.WinForms.Guna2TabControl tabConsultaAgend;
        private TabPage tpDetalheAgendamento;
        private Guna.UI2.WinForms.Guna2Button btnCadProduto;
        private DataGridViewTextBoxColumn clnId;
        private DataGridViewTextBoxColumn clnUsuario;
        private DataGridViewTextBoxColumn clnCliente;
        private DataGridViewTextBoxColumn clnData;
        private DataGridViewTextBoxColumn clnHora;
        private DataGridViewTextBoxColumn clnStatus;
    }
}