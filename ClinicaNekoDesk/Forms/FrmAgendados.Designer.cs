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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            tpListarAgendamentos = new TabPage();
            dgvListaAgendados = new Guna.UI2.WinForms.Guna2DataGridView();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            label1 = new Label();
            tabConsultaAgend = new Guna.UI2.WinForms.Guna2TabControl();
            tpDetalheAgendamento = new TabPage();
            btnCancelarAgend = new Guna.UI2.WinForms.Guna2Button();
            btnConcluirAgend = new Guna.UI2.WinForms.Guna2Button();
            clnId = new DataGridViewTextBoxColumn();
            clnUsuario = new DataGridViewTextBoxColumn();
            clnCliente = new DataGridViewTextBoxColumn();
            clbEspecialidade = new DataGridViewTextBoxColumn();
            clnTipo = new DataGridViewTextBoxColumn();
            clnData = new DataGridViewTextBoxColumn();
            clnHora = new DataGridViewTextBoxColumn();
            clnStatus = new DataGridViewTextBoxColumn();
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
            dataGridViewCellStyle1.BackColor = Color.FromArgb(164, 196, 169);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(115, 158, 122);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dgvListaAgendados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvListaAgendados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dgvListaAgendados.BackgroundColor = Color.FromArgb(200, 219, 203);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(34, 85, 96);
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(34, 85, 96);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvListaAgendados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvListaAgendados.ColumnHeadersHeight = 32;
            dgvListaAgendados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvListaAgendados.Columns.AddRange(new DataGridViewColumn[] { clnId, clnUsuario, clnCliente, clbEspecialidade, clnTipo, clnData, clnHora, clnStatus });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(115, 158, 122);
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvListaAgendados.DefaultCellStyle = dataGridViewCellStyle5;
            dgvListaAgendados.GridColor = Color.FromArgb(231, 229, 255);
            dgvListaAgendados.Location = new Point(20, 64);
            dgvListaAgendados.Name = "dgvListaAgendados";
            dgvListaAgendados.ReadOnly = true;
            dgvListaAgendados.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = Color.White;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvListaAgendados.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
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
            tabConsultaAgend.Location = new Point(0, 0);
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
            tpDetalheAgendamento.Controls.Add(btnCancelarAgend);
            tpDetalheAgendamento.Controls.Add(btnConcluirAgend);
            tpDetalheAgendamento.Location = new Point(4, 44);
            tpDetalheAgendamento.Name = "tpDetalheAgendamento";
            tpDetalheAgendamento.Padding = new Padding(3);
            tpDetalheAgendamento.Size = new Size(1033, 541);
            tpDetalheAgendamento.TabIndex = 2;
            tpDetalheAgendamento.Text = "Detalhes do Agendamento";
            // 
            // btnCancelarAgend
            // 
            btnCancelarAgend.Animated = true;
            btnCancelarAgend.BackColor = Color.Transparent;
            btnCancelarAgend.BorderRadius = 20;
            btnCancelarAgend.CustomizableEdges = customizableEdges1;
            btnCancelarAgend.DisabledState.BorderColor = Color.DarkGray;
            btnCancelarAgend.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCancelarAgend.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCancelarAgend.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCancelarAgend.FillColor = Color.FromArgb(34, 85, 96);
            btnCancelarAgend.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnCancelarAgend.ForeColor = Color.White;
            btnCancelarAgend.ImageAlign = HorizontalAlignment.Right;
            btnCancelarAgend.ImageSize = new Size(24, 24);
            btnCancelarAgend.Location = new Point(26, 464);
            btnCancelarAgend.Margin = new Padding(4, 3, 4, 3);
            btnCancelarAgend.Name = "btnCancelarAgend";
            btnCancelarAgend.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnCancelarAgend.Size = new Size(221, 52);
            btnCancelarAgend.TabIndex = 78;
            btnCancelarAgend.Text = "Cancelar Agendamento";
            // 
            // btnConcluirAgend
            // 
            btnConcluirAgend.Animated = true;
            btnConcluirAgend.BackColor = Color.Transparent;
            btnConcluirAgend.BorderRadius = 20;
            btnConcluirAgend.CustomizableEdges = customizableEdges3;
            btnConcluirAgend.DisabledState.BorderColor = Color.DarkGray;
            btnConcluirAgend.DisabledState.CustomBorderColor = Color.DarkGray;
            btnConcluirAgend.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnConcluirAgend.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnConcluirAgend.FillColor = Color.FromArgb(34, 85, 96);
            btnConcluirAgend.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnConcluirAgend.ForeColor = Color.White;
            btnConcluirAgend.ImageAlign = HorizontalAlignment.Right;
            btnConcluirAgend.ImageSize = new Size(24, 24);
            btnConcluirAgend.Location = new Point(802, 464);
            btnConcluirAgend.Margin = new Padding(4, 3, 4, 3);
            btnConcluirAgend.Name = "btnConcluirAgend";
            btnConcluirAgend.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnConcluirAgend.Size = new Size(208, 52);
            btnConcluirAgend.TabIndex = 77;
            btnConcluirAgend.Text = "Concluir Agendamento";
            btnConcluirAgend.Click += btnCadProduto_Click;
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
            clnUsuario.Width = 200;
            // 
            // clnCliente
            // 
            clnCliente.HeaderText = "Cliente";
            clnCliente.Name = "clnCliente";
            clnCliente.ReadOnly = true;
            clnCliente.Width = 200;
            // 
            // clbEspecialidade
            // 
            clbEspecialidade.HeaderText = "Especialidade";
            clbEspecialidade.Name = "clbEspecialidade";
            clbEspecialidade.ReadOnly = true;
            clbEspecialidade.Width = 150;
            // 
            // clnTipo
            // 
            clnTipo.HeaderText = "Tipo";
            clnTipo.Name = "clnTipo";
            clnTipo.ReadOnly = true;
            clnTipo.Width = 150;
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
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Label label1;
        private Guna.UI2.WinForms.Guna2TabControl tabConsultaAgend;
        private TabPage tpDetalheAgendamento;
        private Guna.UI2.WinForms.Guna2Button btnCancelarAgend;
        private Guna.UI2.WinForms.Guna2Button btnConcluirAgend;
        private DataGridViewTextBoxColumn clnId;
        private DataGridViewTextBoxColumn clnUsuario;
        private DataGridViewTextBoxColumn clnCliente;
        private DataGridViewTextBoxColumn clbEspecialidade;
        private DataGridViewTextBoxColumn clnTipo;
        private DataGridViewTextBoxColumn clnData;
        private DataGridViewTextBoxColumn clnHora;
        private DataGridViewTextBoxColumn clnStatus;
    }
}