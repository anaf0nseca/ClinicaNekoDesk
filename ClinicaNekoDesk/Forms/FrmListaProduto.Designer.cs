namespace ClinicaNekoDesk.Forms
{
    partial class FrmListaProduto
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
            dgvListaProduto = new Guna.UI2.WinForms.Guna2DataGridView();
            clnId = new DataGridViewTextBoxColumn();
            clnCategoria = new DataGridViewTextBoxColumn();
            clnMarca = new DataGridViewTextBoxColumn();
            clnNome = new DataGridViewTextBoxColumn();
            clnDescricao = new DataGridViewTextBoxColumn();
            clnDataNascimento = new DataGridViewTextBoxColumn();
            clnValor = new DataGridViewTextBoxColumn();
            clnPeso = new DataGridViewTextBoxColumn();
            clnQtdeEstoque = new DataGridViewTextBoxColumn();
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
            dataGridViewCellStyle2.BackColor = Color.FromArgb(115, 158, 122);
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(115, 158, 122);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvListaProduto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvListaProduto.ColumnHeadersHeight = 32;
            dgvListaProduto.Columns.AddRange(new DataGridViewColumn[] { clnId, clnCategoria, clnMarca, clnNome, clnDescricao, clnDataNascimento, clnValor, clnPeso, clnQtdeEstoque });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(115, 158, 122);
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvListaProduto.DefaultCellStyle = dataGridViewCellStyle5;
            dgvListaProduto.GridColor = Color.FromArgb(231, 229, 255);
            dgvListaProduto.Location = new Point(12, 64);
            dgvListaProduto.Name = "dgvListaProduto";
            dgvListaProduto.ReadOnly = true;
            dgvListaProduto.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = Color.White;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvListaProduto.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgvListaProduto.RowHeadersVisible = false;
            dgvListaProduto.Size = new Size(1026, 511);
            dgvListaProduto.TabIndex = 5;
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
            dgvListaProduto.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvListaProduto.ThemeStyle.HeaderStyle.Height = 32;
            dgvListaProduto.ThemeStyle.ReadOnly = true;
            dgvListaProduto.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvListaProduto.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvListaProduto.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvListaProduto.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvListaProduto.ThemeStyle.RowsStyle.Height = 25;
            dgvListaProduto.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(115, 158, 122);
            dgvListaProduto.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dgvListaProduto.CellContentClick += dgvListaProduto_CellContentClick;
            // 
            // clnId
            // 
            clnId.HeaderText = "ID";
            clnId.Name = "clnId";
            clnId.ReadOnly = true;
            clnId.Width = 50;
            // 
            // clnCategoria
            // 
            clnCategoria.HeaderText = "Categoria";
            clnCategoria.Name = "clnCategoria";
            clnCategoria.ReadOnly = true;
            clnCategoria.Width = 150;
            // 
            // clnMarca
            // 
            clnMarca.HeaderText = "Marca";
            clnMarca.Name = "clnMarca";
            clnMarca.ReadOnly = true;
            clnMarca.Width = 150;
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
            clnDescricao.Width = 250;
            // 
            // clnDataNascimento
            // 
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            clnDataNascimento.DefaultCellStyle = dataGridViewCellStyle3;
            clnDataNascimento.HeaderText = "Data de Nascimento";
            clnDataNascimento.Name = "clnDataNascimento";
            clnDataNascimento.ReadOnly = true;
            clnDataNascimento.Width = 135;
            // 
            // clnValor
            // 
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            clnValor.DefaultCellStyle = dataGridViewCellStyle4;
            clnValor.HeaderText = "Valor";
            clnValor.Name = "clnValor";
            clnValor.ReadOnly = true;
            clnValor.Width = 120;
            // 
            // clnPeso
            // 
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
            // FrmListaProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1044, 587);
            ControlBox = false;
            Controls.Add(dgvListaProduto);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmListaProduto";
            Text = "FrmListaProduto";
            ((System.ComponentModel.ISupportInitialize)dgvListaProduto).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgvListaProduto;
        private DataGridViewTextBoxColumn clnId;
        private DataGridViewTextBoxColumn clnCategoria;
        private DataGridViewTextBoxColumn clnMarca;
        private DataGridViewTextBoxColumn clnNome;
        private DataGridViewTextBoxColumn clnDescricao;
        private DataGridViewTextBoxColumn clnDataNascimento;
        private DataGridViewTextBoxColumn clnValor;
        private DataGridViewTextBoxColumn clnPeso;
        private DataGridViewTextBoxColumn clnQtdeEstoque;
    }
}