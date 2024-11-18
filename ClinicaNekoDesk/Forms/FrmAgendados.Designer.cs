namespace ClinicaNekoDesk.Forms
{
    partial class FrmAgendados
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            tpListarAgendamentos = new TabPage();
            dgvListaAgendados = new Guna.UI2.WinForms.Guna2DataGridView();
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
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            btnCadProduto = new Guna.UI2.WinForms.Guna2Button();
            tpListarAgendamentos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListaAgendados).BeginInit();
            tabConsultaAgend.SuspendLayout();
            tpDetalheAgendamento.SuspendLayout();
            SuspendLayout();
            // 
            // tpListarAgendamentos
            // 
            tpListarAgendamentos.Controls.Add(dgvListaAgendados);
            tpListarAgendamentos.Controls.Add(guna2HtmlLabel1);
            tpListarAgendamentos.Controls.Add(label1);
            tpListarAgendamentos.Location = new Point(4, 44);
            tpListarAgendamentos.Name = "tpListarAgendamentos";
            tpListarAgendamentos.Padding = new Padding(3);
            tpListarAgendamentos.Size = new Size(1033, 541);
            tpListarAgendamentos.TabIndex = 1;
            tpListarAgendamentos.Text = "Lista";
            tpListarAgendamentos.UseVisualStyleBackColor = true;
            // 
            // dgvListaAgendados
            // 
            dgvListaAgendados.AllowUserToAddRows = false;
            dgvListaAgendados.AllowUserToDeleteRows = false;
            dgvListaAgendados.AllowUserToResizeColumns = false;
            dgvListaAgendados.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(164, 196, 169);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(115, 158, 122);
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            dgvListaAgendados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            dgvListaAgendados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dgvListaAgendados.BackgroundColor = Color.FromArgb(200, 219, 203);
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(34, 85, 96);
            dataGridViewCellStyle7.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(34, 85, 96);
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvListaAgendados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvListaAgendados.ColumnHeadersHeight = 32;
            dgvListaAgendados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvListaAgendados.Columns.AddRange(new DataGridViewColumn[] { clnId, clnUsuario, clnCliente, clnData, clnHora, clnStatus });
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.White;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle9.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(115, 158, 122);
            dataGridViewCellStyle9.SelectionForeColor = Color.White;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.False;
            dgvListaAgendados.DefaultCellStyle = dataGridViewCellStyle9;
            dgvListaAgendados.GridColor = Color.FromArgb(231, 229, 255);
            dgvListaAgendados.Location = new Point(20, 64);
            dgvListaAgendados.Name = "dgvListaAgendados";
            dgvListaAgendados.ReadOnly = true;
            dgvListaAgendados.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = Color.White;
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle10.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = Color.White;
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            dgvListaAgendados.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            dgvListaAgendados.RowHeadersVisible = false;
            dgvListaAgendados.Size = new Size(996, 461);
            dgvListaAgendados.TabIndex = 28;
            dgvListaAgendados.ThemeStyle.AlternatingRowsStyle.BackColor = Color.FromArgb(164, 196, 169);
            dgvListaAgendados.ThemeStyle.AlternatingRowsStyle.Font = new Font("Segoe UI", 9F);
            dgvListaAgendados.ThemeStyle.AlternatingRowsStyle.ForeColor = SystemColors.ControlText;
            dgvListaAgendados.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.FromArgb(115, 158, 122);
            dgvListaAgendados.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dgvListaAgendados.ThemeStyle.BackColor = Color.FromArgb(200, 219, 203);
            dgvListaAgendados.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvListaAgendados.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(115, 158, 122);
            dgvListaAgendados.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvListaAgendados.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dgvListaAgendados.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvListaAgendados.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvListaAgendados.ThemeStyle.HeaderStyle.Height = 32;
            dgvListaAgendados.ThemeStyle.ReadOnly = true;
            dgvListaAgendados.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvListaAgendados.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvListaAgendados.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvListaAgendados.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvListaAgendados.ThemeStyle.RowsStyle.Height = 25;
            dgvListaAgendados.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(115, 158, 122);
            dgvListaAgendados.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dgvListaAgendados.CellDoubleClick += dgvListaAgendamento_CellDoubleClick;
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
            guna2HtmlLabel1.Location = new Point(351, 20);
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
            label1.Location = new Point(318, 83);
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
            tabConsultaAgend.Location = new Point(-5, -2);
            tabConsultaAgend.Name = "tabConsultaAgend";
            tabConsultaAgend.SelectedIndex = 0;
            tabConsultaAgend.Size = new Size(1041, 589);
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
            tabConsultaAgend.TabIndex = 6;
            tabConsultaAgend.TabMenuBackColor = Color.FromArgb(83, 133, 91);
            tabConsultaAgend.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            // 
            // tpDetalheAgendamento
            // 
            tpDetalheAgendamento.BackColor = Color.FromArgb(159, 187, 164);
            tpDetalheAgendamento.Controls.Add(guna2Button1);
            tpDetalheAgendamento.Controls.Add(btnCadProduto);
            tpDetalheAgendamento.Location = new Point(4, 44);
            tpDetalheAgendamento.Name = "tpDetalheAgendamento";
            tpDetalheAgendamento.Padding = new Padding(3);
            tpDetalheAgendamento.Size = new Size(1031, 537);
            tpDetalheAgendamento.TabIndex = 2;
            tpDetalheAgendamento.Text = "Detalhes do Agendamento";
            // 
            // guna2Button1
            // 
            guna2Button1.Animated = true;
            guna2Button1.BackColor = Color.Transparent;
            guna2Button1.BorderRadius = 20;
            guna2Button1.CustomizableEdges = customizableEdges5;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.FromArgb(34, 85, 96);
            guna2Button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.ImageAlign = HorizontalAlignment.Right;
            guna2Button1.ImageSize = new Size(24, 24);
            guna2Button1.Location = new Point(26, 464);
            guna2Button1.Margin = new Padding(4, 3, 4, 3);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2Button1.Size = new Size(221, 52);
            guna2Button1.TabIndex = 78;
            guna2Button1.Text = "Cancelar Agendamento";
            // 
            // btnCadProduto
            // 
            btnCadProduto.Animated = true;
            btnCadProduto.BackColor = Color.Transparent;
            btnCadProduto.BorderRadius = 20;
            btnCadProduto.CustomizableEdges = customizableEdges7;
            btnCadProduto.DisabledState.BorderColor = Color.DarkGray;
            btnCadProduto.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCadProduto.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCadProduto.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCadProduto.FillColor = Color.FromArgb(34, 85, 96);
            btnCadProduto.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnCadProduto.ForeColor = Color.White;
            btnCadProduto.ImageAlign = HorizontalAlignment.Right;
            btnCadProduto.ImageSize = new Size(24, 24);
            btnCadProduto.Location = new Point(802, 464);
            btnCadProduto.Margin = new Padding(4, 3, 4, 3);
            btnCadProduto.Name = "btnCadProduto";
            btnCadProduto.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnCadProduto.Size = new Size(208, 52);
            btnCadProduto.TabIndex = 77;
            btnCadProduto.Text = "Concluir Agendamento";
            btnCadProduto.Click += btnCadProduto_Click;
            // 
            // FrmAgendados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1034, 581);
            Controls.Add(tabConsultaAgend);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmAgendados";
            Text = "FrmAgendados";
            Load += FrmAgendados_Load;
            tpListarAgendamentos.ResumeLayout(false);
            tpListarAgendamentos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListaAgendados).EndInit();
            tabConsultaAgend.ResumeLayout(false);
            tpDetalheAgendamento.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabPage tpListarAgendamentos;
        private Guna.UI2.WinForms.Guna2DataGridView dgvListaAgendados;
        private DataGridViewTextBoxColumn clnId;
        private DataGridViewTextBoxColumn clnUsuario;
        private DataGridViewTextBoxColumn clnCliente;
        private DataGridViewTextBoxColumn clnData;
        private DataGridViewTextBoxColumn clnHora;
        private DataGridViewTextBoxColumn clnStatus;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Label label1;
        private Guna.UI2.WinForms.Guna2TabControl tabConsultaAgend;
        private TabPage tpDetalheAgendamento;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button btnCadProduto;
    }
}