namespace ClinicaNekoDesk.Forms
{
    partial class FrmSelecionarCliente
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSelecionarCliente));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            dgvListaCliente = new Guna.UI2.WinForms.Guna2DataGridView();
            clnId = new DataGridViewTextBoxColumn();
            clnCategoria = new DataGridViewTextBoxColumn();
            clnCpf = new DataGridViewTextBoxColumn();
            clnDataNascimento = new DataGridViewTextBoxColumn();
            clnEmail = new DataGridViewTextBoxColumn();
            btnFechar = new Guna.UI2.WinForms.Guna2Button();
            guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            txtBusca = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvListaCliente).BeginInit();
            SuspendLayout();
            // 
            // dgvListaCliente
            // 
            dgvListaCliente.AllowUserToAddRows = false;
            dgvListaCliente.AllowUserToDeleteRows = false;
            dgvListaCliente.AllowUserToResizeColumns = false;
            dgvListaCliente.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(164, 196, 169);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(115, 158, 122);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dgvListaCliente.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvListaCliente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dgvListaCliente.BackgroundColor = Color.FromArgb(200, 219, 203);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(115, 158, 122);
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(115, 158, 122);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvListaCliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvListaCliente.ColumnHeadersHeight = 32;
            dgvListaCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvListaCliente.Columns.AddRange(new DataGridViewColumn[] { clnId, clnCategoria, clnCpf, clnDataNascimento, clnEmail });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(115, 158, 122);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvListaCliente.DefaultCellStyle = dataGridViewCellStyle4;
            dgvListaCliente.GridColor = Color.FromArgb(231, 229, 255);
            dgvListaCliente.Location = new Point(0, 37);
            dgvListaCliente.Name = "dgvListaCliente";
            dgvListaCliente.ReadOnly = true;
            dgvListaCliente.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = Color.White;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvListaCliente.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvListaCliente.RowHeadersVisible = false;
            dgvListaCliente.ScrollBars = ScrollBars.None;
            dgvListaCliente.Size = new Size(802, 414);
            dgvListaCliente.TabIndex = 64;
            dgvListaCliente.ThemeStyle.AlternatingRowsStyle.BackColor = Color.FromArgb(164, 196, 169);
            dgvListaCliente.ThemeStyle.AlternatingRowsStyle.Font = new Font("Segoe UI", 9F);
            dgvListaCliente.ThemeStyle.AlternatingRowsStyle.ForeColor = SystemColors.ControlText;
            dgvListaCliente.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.FromArgb(115, 158, 122);
            dgvListaCliente.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dgvListaCliente.ThemeStyle.BackColor = Color.FromArgb(200, 219, 203);
            dgvListaCliente.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvListaCliente.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(115, 158, 122);
            dgvListaCliente.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvListaCliente.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dgvListaCliente.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvListaCliente.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvListaCliente.ThemeStyle.HeaderStyle.Height = 32;
            dgvListaCliente.ThemeStyle.ReadOnly = true;
            dgvListaCliente.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvListaCliente.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvListaCliente.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvListaCliente.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvListaCliente.ThemeStyle.RowsStyle.Height = 25;
            dgvListaCliente.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(115, 158, 122);
            dgvListaCliente.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dgvListaCliente.CellDoubleClick += dgvListaCliente_CellDoubleClick;
            // 
            // clnId
            // 
            clnId.HeaderText = "ID";
            clnId.Name = "clnId";
            clnId.ReadOnly = true;
            clnId.Width = 55;
            // 
            // clnCategoria
            // 
            clnCategoria.HeaderText = "Nome";
            clnCategoria.Name = "clnCategoria";
            clnCategoria.ReadOnly = true;
            clnCategoria.Width = 220;
            // 
            // clnCpf
            // 
            dataGridViewCellStyle3.NullValue = null;
            clnCpf.DefaultCellStyle = dataGridViewCellStyle3;
            clnCpf.HeaderText = "CPF";
            clnCpf.Name = "clnCpf";
            clnCpf.ReadOnly = true;
            clnCpf.Width = 180;
            // 
            // clnDataNascimento
            // 
            clnDataNascimento.HeaderText = "Data de Nascimento";
            clnDataNascimento.Name = "clnDataNascimento";
            clnDataNascimento.ReadOnly = true;
            clnDataNascimento.Width = 150;
            // 
            // clnEmail
            // 
            clnEmail.HeaderText = "Email";
            clnEmail.Name = "clnEmail";
            clnEmail.ReadOnly = true;
            clnEmail.Width = 200;
            // 
            // btnFechar
            // 
            btnFechar.BackgroundImage = (Image)resources.GetObject("btnFechar.BackgroundImage");
            btnFechar.BackgroundImageLayout = ImageLayout.Stretch;
            btnFechar.BorderColor = Color.Transparent;
            btnFechar.Cursor = Cursors.Hand;
            btnFechar.CustomizableEdges = customizableEdges1;
            btnFechar.DisabledState.BorderColor = Color.DarkGray;
            btnFechar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnFechar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnFechar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnFechar.FillColor = Color.Transparent;
            btnFechar.Font = new Font("Segoe UI", 9F);
            btnFechar.ForeColor = Color.White;
            btnFechar.Location = new Point(761, 5);
            btnFechar.Name = "btnFechar";
            btnFechar.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnFechar.Size = new Size(27, 27);
            btnFechar.TabIndex = 67;
            btnFechar.Click += btnFechar_Click;
            // 
            // guna2HtmlLabel4
            // 
            guna2HtmlLabel4.BackColor = Color.Transparent;
            guna2HtmlLabel4.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel4.ForeColor = Color.FromArgb(39, 63, 44);
            guna2HtmlLabel4.Location = new Point(14, 8);
            guna2HtmlLabel4.Margin = new Padding(4, 3, 4, 3);
            guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            guna2HtmlLabel4.Size = new Size(93, 18);
            guna2HtmlLabel4.TabIndex = 65;
            guna2HtmlLabel4.Text = "Buscar cliente";
            // 
            // txtBusca
            // 
            txtBusca.CustomizableEdges = customizableEdges3;
            txtBusca.DefaultText = "";
            txtBusca.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtBusca.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtBusca.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtBusca.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtBusca.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtBusca.Font = new Font("Segoe UI", 9F);
            txtBusca.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtBusca.Location = new Point(113, 6);
            txtBusca.Name = "txtBusca";
            txtBusca.PasswordChar = '\0';
            txtBusca.PlaceholderText = "";
            txtBusca.SelectedText = "";
            txtBusca.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtBusca.Size = new Size(498, 26);
            txtBusca.TabIndex = 68;
            txtBusca.TextChanged += txtBusca_TextChanged;
            // 
            // FrmSelecionarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(txtBusca);
            Controls.Add(dgvListaCliente);
            Controls.Add(btnFechar);
            Controls.Add(guna2HtmlLabel4);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmSelecionarCliente";
            Text = "FrmSelecionarCliente";
            Load += FrmSelecionarCliente_Load;
            ((System.ComponentModel.ISupportInitialize)dgvListaCliente).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgvListaCliente;
        private Guna.UI2.WinForms.Guna2Button btnFechar;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2TextBox txtBusca;
        private DataGridViewTextBoxColumn clnId;
        private DataGridViewTextBoxColumn clnCategoria;
        private DataGridViewTextBoxColumn clnCpf;
        private DataGridViewTextBoxColumn clnDataNascimento;
        private DataGridViewTextBoxColumn clnEmail;
    }
}