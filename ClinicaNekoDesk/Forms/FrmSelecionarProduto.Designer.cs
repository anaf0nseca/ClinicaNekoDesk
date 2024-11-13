namespace ClinicaNekoDesk.Forms
{
    partial class FrmSelecionarProduto
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
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSelecionarProduto));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            dgvListaProduto = new Guna.UI2.WinForms.Guna2DataGridView();
            clnId = new DataGridViewTextBoxColumn();
            clnCategoria = new DataGridViewTextBoxColumn();
            clnMarca = new DataGridViewTextBoxColumn();
            clnNome = new DataGridViewTextBoxColumn();
            clnDescricao = new DataGridViewTextBoxColumn();
            clnDataVencimento = new DataGridViewTextBoxColumn();
            clnValor = new DataGridViewTextBoxColumn();
            clnPeso = new DataGridViewTextBoxColumn();
            clnQtdeEstoque = new DataGridViewTextBoxColumn();
            guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            cmbBuscaCat = new Guna.UI2.WinForms.Guna2ComboBox();
            btnFechar = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)dgvListaProduto).BeginInit();
            SuspendLayout();
            // 
            // dgvListaProduto
            // 
            dgvListaProduto.AllowUserToAddRows = false;
            dgvListaProduto.AllowUserToDeleteRows = false;
            dgvListaProduto.AllowUserToResizeColumns = false;
            dgvListaProduto.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(164, 196, 169);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(115, 158, 122);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dgvListaProduto.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvListaProduto.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dgvListaProduto.BackgroundColor = Color.FromArgb(200, 219, 203);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(34, 85, 96);
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(34, 85, 96);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvListaProduto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvListaProduto.ColumnHeadersHeight = 32;
            dgvListaProduto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvListaProduto.Columns.AddRange(new DataGridViewColumn[] { clnId, clnCategoria, clnMarca, clnNome, clnDescricao, clnDataVencimento, clnValor, clnPeso, clnQtdeEstoque });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(115, 158, 122);
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvListaProduto.DefaultCellStyle = dataGridViewCellStyle6;
            dgvListaProduto.GridColor = Color.FromArgb(231, 229, 255);
            dgvListaProduto.Location = new Point(0, 39);
            dgvListaProduto.Name = "dgvListaProduto";
            dgvListaProduto.ReadOnly = true;
            dgvListaProduto.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.White;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = Color.White;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvListaProduto.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvListaProduto.RowHeadersVisible = false;
            dgvListaProduto.Size = new Size(802, 412);
            dgvListaProduto.TabIndex = 22;
            dgvListaProduto.ThemeStyle.AlternatingRowsStyle.BackColor = Color.FromArgb(164, 196, 169);
            dgvListaProduto.ThemeStyle.AlternatingRowsStyle.Font = new Font("Segoe UI", 9F);
            dgvListaProduto.ThemeStyle.AlternatingRowsStyle.ForeColor = SystemColors.ControlText;
            dgvListaProduto.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.FromArgb(115, 158, 122);
            dgvListaProduto.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dgvListaProduto.ThemeStyle.BackColor = Color.FromArgb(200, 219, 203);
            dgvListaProduto.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvListaProduto.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(115, 158, 122);
            dgvListaProduto.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvListaProduto.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dgvListaProduto.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvListaProduto.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvListaProduto.ThemeStyle.HeaderStyle.Height = 32;
            dgvListaProduto.ThemeStyle.ReadOnly = true;
            dgvListaProduto.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvListaProduto.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvListaProduto.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvListaProduto.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvListaProduto.ThemeStyle.RowsStyle.Height = 25;
            dgvListaProduto.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(115, 158, 122);
            dgvListaProduto.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dgvListaProduto.CellDoubleClick += dgvListaProduto_CellDoubleClick;
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
            clnCategoria.HeaderText = "Categoria";
            clnCategoria.Name = "clnCategoria";
            clnCategoria.ReadOnly = true;
            clnCategoria.Width = 113;
            // 
            // clnMarca
            // 
            clnMarca.FillWeight = 1.1099546F;
            clnMarca.HeaderText = "Marca";
            clnMarca.Name = "clnMarca";
            clnMarca.ReadOnly = true;
            clnMarca.Width = 113;
            // 
            // clnNome
            // 
            clnNome.FillWeight = 7.452319F;
            clnNome.HeaderText = "Nome";
            clnNome.Name = "clnNome";
            clnNome.ReadOnly = true;
            clnNome.Width = 180;
            // 
            // clnDescricao
            // 
            clnDescricao.FillWeight = 36.5599022F;
            clnDescricao.HeaderText = "Descrição";
            clnDescricao.Name = "clnDescricao";
            clnDescricao.ReadOnly = true;
            clnDescricao.Width = 280;
            // 
            // clnDataVencimento
            // 
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            clnDataVencimento.DefaultCellStyle = dataGridViewCellStyle3;
            clnDataVencimento.FillWeight = 61.6632233F;
            clnDataVencimento.HeaderText = "Vencimento";
            clnDataVencimento.Name = "clnDataVencimento";
            clnDataVencimento.ReadOnly = true;
            clnDataVencimento.Width = 113;
            // 
            // clnValor
            // 
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            clnValor.DefaultCellStyle = dataGridViewCellStyle4;
            clnValor.FillWeight = 110.788666F;
            clnValor.HeaderText = "Valor";
            clnValor.Name = "clnValor";
            clnValor.ReadOnly = true;
            // 
            // clnPeso
            // 
            dataGridViewCellStyle5.NullValue = null;
            clnPeso.DefaultCellStyle = dataGridViewCellStyle5;
            clnPeso.FillWeight = 224.966309F;
            clnPeso.HeaderText = "Peso";
            clnPeso.Name = "clnPeso";
            clnPeso.ReadOnly = true;
            // 
            // clnQtdeEstoque
            // 
            clnQtdeEstoque.FillWeight = 456.852875F;
            clnQtdeEstoque.HeaderText = "Estoque";
            clnQtdeEstoque.Name = "clnQtdeEstoque";
            clnQtdeEstoque.ReadOnly = true;
            // 
            // guna2HtmlLabel4
            // 
            guna2HtmlLabel4.BackColor = Color.Transparent;
            guna2HtmlLabel4.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel4.ForeColor = Color.FromArgb(39, 63, 44);
            guna2HtmlLabel4.Location = new Point(13, 12);
            guna2HtmlLabel4.Margin = new Padding(4, 3, 4, 3);
            guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            guna2HtmlLabel4.Size = new Size(145, 18);
            guna2HtmlLabel4.TabIndex = 55;
            guna2HtmlLabel4.Text = "Selecione a Categoria";
            guna2HtmlLabel4.Visible = false;
            // 
            // cmbBuscaCat
            // 
            cmbBuscaCat.BackColor = Color.Transparent;
            cmbBuscaCat.BorderRadius = 10;
            cmbBuscaCat.CustomizableEdges = customizableEdges1;
            cmbBuscaCat.DrawMode = DrawMode.OwnerDrawFixed;
            cmbBuscaCat.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBuscaCat.FocusedColor = Color.FromArgb(94, 148, 255);
            cmbBuscaCat.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cmbBuscaCat.Font = new Font("Segoe UI", 10F);
            cmbBuscaCat.ForeColor = Color.FromArgb(68, 88, 112);
            cmbBuscaCat.ItemHeight = 20;
            cmbBuscaCat.Items.AddRange(new object[] { "5%", "10%", "15%", "20%", "50%" });
            cmbBuscaCat.Location = new Point(165, 7);
            cmbBuscaCat.Name = "cmbBuscaCat";
            cmbBuscaCat.ShadowDecoration.CustomizableEdges = customizableEdges2;
            cmbBuscaCat.Size = new Size(340, 26);
            cmbBuscaCat.TabIndex = 62;
            cmbBuscaCat.Visible = false;
            //cmbBuscaCat.SelectedIndexChanged += cmbBuscaCat_SelectedIndexChanged;
            // 
            // btnFechar
            // 
            btnFechar.BackgroundImage = (Image)resources.GetObject("btnFechar.BackgroundImage");
            btnFechar.BackgroundImageLayout = ImageLayout.Stretch;
            btnFechar.BorderColor = Color.Transparent;
            btnFechar.Cursor = Cursors.Hand;
            btnFechar.CustomizableEdges = customizableEdges3;
            btnFechar.DisabledState.BorderColor = Color.DarkGray;
            btnFechar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnFechar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnFechar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnFechar.FillColor = Color.Transparent;
            btnFechar.Font = new Font("Segoe UI", 9F);
            btnFechar.ForeColor = Color.White;
            btnFechar.Location = new Point(760, 7);
            btnFechar.Name = "btnFechar";
            btnFechar.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnFechar.Size = new Size(27, 27);
            btnFechar.TabIndex = 63;
            btnFechar.Click += btnFechar_Click;
            // 
            // FrmSelecionarProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(btnFechar);
            Controls.Add(cmbBuscaCat);
            Controls.Add(guna2HtmlLabel4);
            Controls.Add(dgvListaProduto);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmSelecionarProduto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmSelecionarProduto";
            Load += FrmSelecionarProduto_Load;
            ((System.ComponentModel.ISupportInitialize)dgvListaProduto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgvListaProduto;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2ComboBox cmbBuscaCat;
        private Guna.UI2.WinForms.Guna2Button btnFechar;
        private DataGridViewTextBoxColumn clnId;
        private DataGridViewTextBoxColumn clnCategoria;
        private DataGridViewTextBoxColumn clnMarca;
        private DataGridViewTextBoxColumn clnNome;
        private DataGridViewTextBoxColumn clnDescricao;
        private DataGridViewTextBoxColumn clnDataVencimento;
        private DataGridViewTextBoxColumn clnValor;
        private DataGridViewTextBoxColumn clnPeso;
        private DataGridViewTextBoxColumn clnQtdeEstoque;
    }
}