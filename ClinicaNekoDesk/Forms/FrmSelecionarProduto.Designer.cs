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
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSelecionarProduto));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
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
            dataGridViewCellStyle8.BackColor = Color.FromArgb(164, 196, 169);
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(115, 158, 122);
            dataGridViewCellStyle8.SelectionForeColor = Color.White;
            dgvListaProduto.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle8;
            dgvListaProduto.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dgvListaProduto.BackgroundColor = Color.FromArgb(200, 219, 203);
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(115, 158, 122);
            dataGridViewCellStyle9.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle9.ForeColor = Color.White;
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(115, 158, 122);
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dgvListaProduto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dgvListaProduto.ColumnHeadersHeight = 32;
            dgvListaProduto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvListaProduto.Columns.AddRange(new DataGridViewColumn[] { clnId, clnCategoria, clnMarca, clnNome, clnDescricao, clnDataVencimento, clnValor, clnPeso, clnQtdeEstoque });
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = Color.White;
            dataGridViewCellStyle13.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle13.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle13.SelectionBackColor = Color.FromArgb(115, 158, 122);
            dataGridViewCellStyle13.SelectionForeColor = Color.White;
            dataGridViewCellStyle13.WrapMode = DataGridViewTriState.False;
            dgvListaProduto.DefaultCellStyle = dataGridViewCellStyle13;
            dgvListaProduto.GridColor = Color.FromArgb(231, 229, 255);
            dgvListaProduto.Location = new Point(0, 39);
            dgvListaProduto.Name = "dgvListaProduto";
            dgvListaProduto.ReadOnly = true;
            dgvListaProduto.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = Color.White;
            dataGridViewCellStyle14.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle14.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = Color.White;
            dataGridViewCellStyle14.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = DataGridViewTriState.True;
            dgvListaProduto.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
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
            clnMarca.HeaderText = "Marca";
            clnMarca.Name = "clnMarca";
            clnMarca.ReadOnly = true;
            clnMarca.Width = 113;
            // 
            // clnNome
            // 
            clnNome.HeaderText = "Nome";
            clnNome.Name = "clnNome";
            clnNome.ReadOnly = true;
            clnNome.Width = 180;
            // 
            // clnDescricao
            // 
            clnDescricao.HeaderText = "Descrição";
            clnDescricao.Name = "clnDescricao";
            clnDescricao.ReadOnly = true;
            clnDescricao.Width = 280;
            // 
            // clnDataVencimento
            // 
            dataGridViewCellStyle10.Format = "d";
            dataGridViewCellStyle10.NullValue = null;
            clnDataVencimento.DefaultCellStyle = dataGridViewCellStyle10;
            clnDataVencimento.HeaderText = "Vencimento";
            clnDataVencimento.Name = "clnDataVencimento";
            clnDataVencimento.ReadOnly = true;
            clnDataVencimento.Width = 113;
            // 
            // clnValor
            // 
            dataGridViewCellStyle11.Format = "C2";
            dataGridViewCellStyle11.NullValue = null;
            clnValor.DefaultCellStyle = dataGridViewCellStyle11;
            clnValor.HeaderText = "Valor";
            clnValor.Name = "clnValor";
            clnValor.ReadOnly = true;
            // 
            // clnPeso
            // 
            dataGridViewCellStyle12.NullValue = null;
            clnPeso.DefaultCellStyle = dataGridViewCellStyle12;
            clnPeso.HeaderText = "Peso";
            clnPeso.Name = "clnPeso";
            clnPeso.ReadOnly = true;
            // 
            // clnQtdeEstoque
            // 
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
            // 
            // cmbBuscaCat
            // 
            cmbBuscaCat.BackColor = Color.Transparent;
            cmbBuscaCat.BorderRadius = 10;
            cmbBuscaCat.CustomizableEdges = customizableEdges5;
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
            cmbBuscaCat.ShadowDecoration.CustomizableEdges = customizableEdges6;
            cmbBuscaCat.Size = new Size(340, 26);
            cmbBuscaCat.TabIndex = 62;
            // 
            // btnFechar
            // 
            btnFechar.BackgroundImage = (Image)resources.GetObject("btnFechar.BackgroundImage");
            btnFechar.BackgroundImageLayout = ImageLayout.Stretch;
            btnFechar.BorderColor = Color.Transparent;
            btnFechar.Cursor = Cursors.Hand;
            btnFechar.CustomizableEdges = customizableEdges7;
            btnFechar.DisabledState.BorderColor = Color.DarkGray;
            btnFechar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnFechar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnFechar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnFechar.FillColor = Color.Transparent;
            btnFechar.Font = new Font("Segoe UI", 9F);
            btnFechar.ForeColor = Color.White;
            btnFechar.Location = new Point(760, 7);
            btnFechar.Name = "btnFechar";
            btnFechar.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnFechar.Size = new Size(28, 23);
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
        private DataGridViewTextBoxColumn clnId;
        private DataGridViewTextBoxColumn clnCategoria;
        private DataGridViewTextBoxColumn clnMarca;
        private DataGridViewTextBoxColumn clnNome;
        private DataGridViewTextBoxColumn clnDescricao;
        private DataGridViewTextBoxColumn clnDataVencimento;
        private DataGridViewTextBoxColumn clnValor;
        private DataGridViewTextBoxColumn clnPeso;
        private DataGridViewTextBoxColumn clnQtdeEstoque;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2ComboBox cmbBuscaCat;
        private Guna.UI2.WinForms.Guna2Button btnFechar;
    }
}