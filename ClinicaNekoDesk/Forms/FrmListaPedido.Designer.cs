namespace ClinicaNekoDesk.Forms
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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            tabConsultaProduto = new Guna.UI2.WinForms.Guna2TabControl();
            tpListarPedidos = new TabPage();
            dgvListaPedido = new Guna.UI2.WinForms.Guna2DataGridView();
            clnId = new DataGridViewTextBoxColumn();
            clnUsuario = new DataGridViewTextBoxColumn();
            clnCliente = new DataGridViewTextBoxColumn();
            clnData = new DataGridViewTextBoxColumn();
            clnStatus = new DataGridViewTextBoxColumn();
            clnDesconto = new DataGridViewTextBoxColumn();
            clnValor = new DataGridViewTextBoxColumn();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            label1 = new Label();
            tpDetalhePedido = new TabPage();
            btnCadProduto = new Guna.UI2.WinForms.Guna2Button();
            tabConsultaProduto.SuspendLayout();
            tpListarPedidos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListaPedido).BeginInit();
            tpDetalhePedido.SuspendLayout();
            SuspendLayout();
            // 
            // tabConsultaProduto
            // 
            tabConsultaProduto.Controls.Add(tpListarPedidos);
            tabConsultaProduto.Controls.Add(tpDetalhePedido);
            tabConsultaProduto.ItemSize = new Size(180, 40);
            tabConsultaProduto.Location = new Point(-1, -1);
            tabConsultaProduto.Name = "tabConsultaProduto";
            tabConsultaProduto.SelectedIndex = 0;
            tabConsultaProduto.Size = new Size(1052, 622);
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
            tpListarPedidos.Controls.Add(dgvListaPedido);
            tpListarPedidos.Controls.Add(guna2HtmlLabel1);
            tpListarPedidos.Controls.Add(label1);
            tpListarPedidos.Location = new Point(4, 44);
            tpListarPedidos.Name = "tpListarPedidos";
            tpListarPedidos.Padding = new Padding(3);
            tpListarPedidos.Size = new Size(1044, 574);
            tpListarPedidos.TabIndex = 1;
            tpListarPedidos.Text = "Lista";
            tpListarPedidos.UseVisualStyleBackColor = true;
            // 
            // dgvListaPedido
            // 
            dgvListaPedido.AllowUserToAddRows = false;
            dgvListaPedido.AllowUserToDeleteRows = false;
            dgvListaPedido.AllowUserToResizeColumns = false;
            dgvListaPedido.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(164, 196, 169);
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(115, 158, 122);
            dataGridViewCellStyle7.SelectionForeColor = Color.White;
            dgvListaPedido.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dgvListaPedido.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dgvListaPedido.BackgroundColor = Color.FromArgb(200, 219, 203);
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(34, 85, 96);
            dataGridViewCellStyle8.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle8.ForeColor = Color.White;
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(34, 85, 96);
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dgvListaPedido.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dgvListaPedido.ColumnHeadersHeight = 32;
            dgvListaPedido.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvListaPedido.Columns.AddRange(new DataGridViewColumn[] { clnId, clnUsuario, clnCliente, clnData, clnStatus, clnDesconto, clnValor });
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = Color.White;
            dataGridViewCellStyle11.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle11.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle11.SelectionBackColor = Color.FromArgb(115, 158, 122);
            dataGridViewCellStyle11.SelectionForeColor = Color.White;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.False;
            dgvListaPedido.DefaultCellStyle = dataGridViewCellStyle11;
            dgvListaPedido.GridColor = Color.FromArgb(231, 229, 255);
            dgvListaPedido.Location = new Point(13, 64);
            dgvListaPedido.Name = "dgvListaPedido";
            dgvListaPedido.ReadOnly = true;
            dgvListaPedido.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = Color.White;
            dataGridViewCellStyle12.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle12.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = Color.White;
            dataGridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.True;
            dgvListaPedido.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            dgvListaPedido.RowHeadersVisible = false;
            dgvListaPedido.Size = new Size(1017, 501);
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
            dataGridViewCellStyle9.Format = "d";
            dataGridViewCellStyle9.NullValue = null;
            clnDesconto.DefaultCellStyle = dataGridViewCellStyle9;
            clnDesconto.HeaderText = "Desconto";
            clnDesconto.Name = "clnDesconto";
            clnDesconto.ReadOnly = true;
            clnDesconto.Width = 113;
            // 
            // clnValor
            // 
            dataGridViewCellStyle10.Format = "C2";
            dataGridViewCellStyle10.NullValue = null;
            clnValor.DefaultCellStyle = dataGridViewCellStyle10;
            clnValor.HeaderText = "Valor";
            clnValor.Name = "clnValor";
            clnValor.ReadOnly = true;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2HtmlLabel1.ForeColor = Color.FromArgb(39, 63, 44);
            guna2HtmlLabel1.Location = new Point(362, 14);
            guna2HtmlLabel1.Margin = new Padding(4, 3, 4, 3);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(256, 34);
            guna2HtmlLabel1.TabIndex = 27;
            guna2HtmlLabel1.Text = "LISTA DE PEDIDOS";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(312, 77);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(328, 73);
            label1.TabIndex = 26;
            label1.Text = "SERVIÇO";
            // 
            // tpDetalhePedido
            // 
            tpDetalhePedido.BackColor = Color.FromArgb(159, 187, 164);
            tpDetalhePedido.Controls.Add(btnCadProduto);
            tpDetalhePedido.Location = new Point(4, 44);
            tpDetalhePedido.Name = "tpDetalhePedido";
            tpDetalhePedido.Padding = new Padding(3);
            tpDetalhePedido.Size = new Size(1044, 574);
            tpDetalhePedido.TabIndex = 2;
            tpDetalhePedido.Text = "Detalhes do Pedido";
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
            tabConsultaProduto.ResumeLayout(false);
            tpListarPedidos.ResumeLayout(false);
            tpListarPedidos.PerformLayout();
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
        private DataGridViewTextBoxColumn clnId;
        private DataGridViewTextBoxColumn clnUsuario;
        private DataGridViewTextBoxColumn clnCliente;
        private DataGridViewTextBoxColumn clnData;
        private DataGridViewTextBoxColumn clnStatus;
        private DataGridViewTextBoxColumn clnDesconto;
        private DataGridViewTextBoxColumn clnValor;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Label label1;
    }
}