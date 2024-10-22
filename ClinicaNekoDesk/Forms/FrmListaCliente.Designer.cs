namespace ClinicaNeko.Forms
{
    partial class FrmListaCliente
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            clnAtivo = new DataGridViewCheckBoxColumn();
            clnEmail = new DataGridViewTextBoxColumn();
            clnCargo = new DataGridViewTextBoxColumn();
            clnSetor = new DataGridViewTextBoxColumn();
            clnDataNascimento = new DataGridViewTextBoxColumn();
            clnCpf = new DataGridViewTextBoxColumn();
            clnNome = new DataGridViewTextBoxColumn();
            clnId = new DataGridViewTextBoxColumn();
            dgvListaClientes = new Guna.UI2.WinForms.Guna2DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvListaClientes).BeginInit();
            SuspendLayout();
            // 
            // clnAtivo
            // 
            clnAtivo.HeaderText = "Ativo";
            clnAtivo.Name = "clnAtivo";
            clnAtivo.ReadOnly = true;
            clnAtivo.Width = 51;
            // 
            // clnEmail
            // 
            clnEmail.HeaderText = "Email";
            clnEmail.Name = "clnEmail";
            clnEmail.ReadOnly = true;
            clnEmail.Width = 180;
            // 
            // clnCargo
            // 
            clnCargo.HeaderText = "Cargo";
            clnCargo.Name = "clnCargo";
            clnCargo.ReadOnly = true;
            clnCargo.Width = 115;
            // 
            // clnSetor
            // 
            clnSetor.HeaderText = "Setor";
            clnSetor.Name = "clnSetor";
            clnSetor.ReadOnly = true;
            clnSetor.Width = 115;
            // 
            // clnDataNascimento
            // 
            clnDataNascimento.HeaderText = "Data de Nascimento";
            clnDataNascimento.Name = "clnDataNascimento";
            clnDataNascimento.ReadOnly = true;
            clnDataNascimento.Width = 150;
            // 
            // clnCpf
            // 
            clnCpf.HeaderText = "CPF";
            clnCpf.Name = "clnCpf";
            clnCpf.ReadOnly = true;
            clnCpf.Width = 120;
            // 
            // clnNome
            // 
            clnNome.HeaderText = "Nome Completo";
            clnNome.Name = "clnNome";
            clnNome.ReadOnly = true;
            clnNome.Width = 245;
            // 
            // clnId
            // 
            clnId.HeaderText = "ID";
            clnId.Name = "clnId";
            clnId.ReadOnly = true;
            clnId.Width = 50;
            // 
            // dgvListaClientes
            // 
            dgvListaClientes.AllowUserToAddRows = false;
            dgvListaClientes.AllowUserToDeleteRows = false;
            dgvListaClientes.AllowUserToResizeColumns = false;
            dgvListaClientes.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvListaClientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvListaClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvListaClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvListaClientes.ColumnHeadersHeight = 17;
            dgvListaClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvListaClientes.Columns.AddRange(new DataGridViewColumn[] { clnId, clnNome, clnCpf, clnDataNascimento, clnSetor, clnCargo, clnEmail, clnAtivo });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvListaClientes.DefaultCellStyle = dataGridViewCellStyle3;
            dgvListaClientes.GridColor = Color.FromArgb(231, 229, 255);
            dgvListaClientes.Location = new Point(12, 51);
            dgvListaClientes.Name = "dgvListaClientes";
            dgvListaClientes.ReadOnly = true;
            dgvListaClientes.RowHeadersVisible = false;
            dgvListaClientes.Size = new Size(1026, 367);
            dgvListaClientes.TabIndex = 1;
            dgvListaClientes.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvListaClientes.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvListaClientes.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvListaClientes.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvListaClientes.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvListaClientes.ThemeStyle.BackColor = Color.White;
            dgvListaClientes.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvListaClientes.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvListaClientes.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvListaClientes.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dgvListaClientes.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvListaClientes.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvListaClientes.ThemeStyle.HeaderStyle.Height = 17;
            dgvListaClientes.ThemeStyle.ReadOnly = true;
            dgvListaClientes.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvListaClientes.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvListaClientes.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvListaClientes.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvListaClientes.ThemeStyle.RowsStyle.Height = 25;
            dgvListaClientes.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvListaClientes.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // FrmListaCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1050, 620);
            ControlBox = false;
            Controls.Add(dgvListaClientes);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmListaCliente";
            Load += FrmListaCliente_Load;
            ((System.ComponentModel.ISupportInitialize)dgvListaClientes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridViewCheckBoxColumn clnAtivo;
        private DataGridViewTextBoxColumn clnEmail;
        private DataGridViewTextBoxColumn clnCargo;
        private DataGridViewTextBoxColumn clnSetor;
        private DataGridViewTextBoxColumn clnDataNascimento;
        private DataGridViewTextBoxColumn clnCpf;
        private DataGridViewTextBoxColumn clnNome;
        private DataGridViewTextBoxColumn clnId;
        private Guna.UI2.WinForms.Guna2DataGridView dgvListaClientes;
    }
}