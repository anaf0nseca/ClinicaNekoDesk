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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            tpListarAgendamentos = new TabPage();
            dgvListaAgendamento = new Guna.UI2.WinForms.Guna2DataGridView();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            label1 = new Label();
            tabConsultaAgend = new Guna.UI2.WinForms.Guna2TabControl();
            clnId = new DataGridViewTextBoxColumn();
            clnUsuario = new DataGridViewTextBoxColumn();
            clnCliente = new DataGridViewTextBoxColumn();
            clnData = new DataGridViewTextBoxColumn();
            clnHora = new DataGridViewTextBoxColumn();
            clnStatus = new DataGridViewTextBoxColumn();
            tpListarAgendamentos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListaAgendamento).BeginInit();
            tabConsultaAgend.SuspendLayout();
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
            dataGridViewCellStyle1.BackColor = Color.FromArgb(164, 196, 169);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(115, 158, 122);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dgvListaAgendamento.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvListaAgendamento.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dgvListaAgendamento.BackgroundColor = Color.FromArgb(200, 219, 203);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(34, 85, 96);
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(34, 85, 96);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvListaAgendamento.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvListaAgendamento.ColumnHeadersHeight = 32;
            dgvListaAgendamento.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvListaAgendamento.Columns.AddRange(new DataGridViewColumn[] { clnId, clnUsuario, clnCliente, clnData, clnHora, clnStatus });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(115, 158, 122);
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvListaAgendamento.DefaultCellStyle = dataGridViewCellStyle5;
            dgvListaAgendamento.GridColor = Color.FromArgb(231, 229, 255);
            dgvListaAgendamento.Location = new Point(18, 64);
            dgvListaAgendamento.Name = "dgvListaAgendamento";
            dgvListaAgendamento.ReadOnly = true;
            dgvListaAgendamento.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = Color.White;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvListaAgendamento.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
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
            clnCliente.HeaderText = "Paciente";
            clnCliente.Name = "clnCliente";
            clnCliente.ReadOnly = true;
            clnCliente.Width = 300;
            // 
            // clnData
            // 
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            clnData.DefaultCellStyle = dataGridViewCellStyle3;
            clnData.HeaderText = "Data";
            clnData.Name = "clnData";
            clnData.ReadOnly = true;
            clnData.Width = 120;
            // 
            // clnHora
            // 
            dataGridViewCellStyle4.Format = "t";
            dataGridViewCellStyle4.NullValue = null;
            clnHora.DefaultCellStyle = dataGridViewCellStyle4;
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
            ResumeLayout(false);
        }

        #endregion

        private TabPage tpListarAgendamentos;
        private Guna.UI2.WinForms.Guna2DataGridView dgvListaAgendamento;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Label label1;
        private Guna.UI2.WinForms.Guna2TabControl tabConsultaAgend;
        private DataGridViewTextBoxColumn clnId;
        private DataGridViewTextBoxColumn clnUsuario;
        private DataGridViewTextBoxColumn clnCliente;
        private DataGridViewTextBoxColumn clnData;
        private DataGridViewTextBoxColumn clnHora;
        private DataGridViewTextBoxColumn clnStatus;
    }
}