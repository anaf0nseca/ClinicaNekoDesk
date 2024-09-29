namespace ClinicaNekoDesk.Forms
{
    partial class FrmListaUsuario
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            dgvListaUsuarios = new Guna.UI2.WinForms.Guna2DataGridView();
            clnId = new DataGridViewTextBoxColumn();
            clnNome = new DataGridViewTextBoxColumn();
            clnCpf = new DataGridViewTextBoxColumn();
            clnDataNascimento = new DataGridViewTextBoxColumn();
            clnSetor = new DataGridViewTextBoxColumn();
            clnCargo = new DataGridViewTextBoxColumn();
            clnEmail = new DataGridViewTextBoxColumn();
            clnAtivo = new DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvListaUsuarios).BeginInit();
            SuspendLayout();
            // 
            // dgvListaUsuarios
            // 
            dgvListaUsuarios.AllowUserToAddRows = false;
            dgvListaUsuarios.AllowUserToDeleteRows = false;
            dgvListaUsuarios.AllowUserToResizeColumns = false;
            dgvListaUsuarios.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(164, 196, 169);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(115, 158, 122);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dgvListaUsuarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvListaUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(115, 158, 122);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(115, 158, 122);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvListaUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvListaUsuarios.ColumnHeadersHeight = 32;
            dgvListaUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvListaUsuarios.Columns.AddRange(new DataGridViewColumn[] { clnId, clnNome, clnCpf, clnDataNascimento, clnSetor, clnCargo, clnEmail, clnAtivo });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(115, 158, 122);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvListaUsuarios.DefaultCellStyle = dataGridViewCellStyle3;
            dgvListaUsuarios.GridColor = Color.FromArgb(231, 229, 255);
            dgvListaUsuarios.Location = new Point(25, 24);
            dgvListaUsuarios.Name = "dgvListaUsuarios";
            dgvListaUsuarios.ReadOnly = true;
            dgvListaUsuarios.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.White;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvListaUsuarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvListaUsuarios.RowHeadersVisible = false;
            dgvListaUsuarios.Size = new Size(992, 397);
            dgvListaUsuarios.TabIndex = 0;
            dgvListaUsuarios.ThemeStyle.AlternatingRowsStyle.BackColor = Color.FromArgb(164, 196, 169);
            dgvListaUsuarios.ThemeStyle.AlternatingRowsStyle.Font = new Font("Segoe UI", 9F);
            dgvListaUsuarios.ThemeStyle.AlternatingRowsStyle.ForeColor = SystemColors.ControlText;
            dgvListaUsuarios.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.FromArgb(115, 158, 122);
            dgvListaUsuarios.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dgvListaUsuarios.ThemeStyle.BackColor = Color.White;
            dgvListaUsuarios.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvListaUsuarios.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(115, 158, 122);
            dgvListaUsuarios.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvListaUsuarios.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dgvListaUsuarios.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvListaUsuarios.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvListaUsuarios.ThemeStyle.HeaderStyle.Height = 32;
            dgvListaUsuarios.ThemeStyle.ReadOnly = true;
            dgvListaUsuarios.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvListaUsuarios.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvListaUsuarios.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvListaUsuarios.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvListaUsuarios.ThemeStyle.RowsStyle.Height = 25;
            dgvListaUsuarios.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(115, 158, 122);
            dgvListaUsuarios.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // clnId
            // 
            clnId.HeaderText = "ID";
            clnId.Name = "clnId";
            clnId.ReadOnly = true;
            clnId.Width = 124;
            // 
            // clnNome
            // 
            clnNome.HeaderText = "Nome Completo";
            clnNome.Name = "clnNome";
            clnNome.ReadOnly = true;
            clnNome.Width = 124;
            // 
            // clnCpf
            // 
            clnCpf.HeaderText = "CPF";
            clnCpf.Name = "clnCpf";
            clnCpf.ReadOnly = true;
            clnCpf.Width = 124;
            // 
            // clnDataNascimento
            // 
            clnDataNascimento.HeaderText = "Data de Nascimento";
            clnDataNascimento.Name = "clnDataNascimento";
            clnDataNascimento.ReadOnly = true;
            clnDataNascimento.Width = 124;
            // 
            // clnSetor
            // 
            clnSetor.HeaderText = "Setor";
            clnSetor.Name = "clnSetor";
            clnSetor.ReadOnly = true;
            clnSetor.Width = 124;
            // 
            // clnCargo
            // 
            clnCargo.HeaderText = "Cargo";
            clnCargo.Name = "clnCargo";
            clnCargo.ReadOnly = true;
            clnCargo.Width = 124;
            // 
            // clnEmail
            // 
            clnEmail.HeaderText = "Email";
            clnEmail.Name = "clnEmail";
            clnEmail.ReadOnly = true;
            clnEmail.Width = 124;
            // 
            // clnAtivo
            // 
            clnAtivo.HeaderText = "Ativo";
            clnAtivo.Name = "clnAtivo";
            clnAtivo.ReadOnly = true;
            clnAtivo.Width = 124;
            // 
            // FrmListaUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1050, 620);
            ControlBox = false;
            Controls.Add(dgvListaUsuarios);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmListaUsuario";
            Load += FrmListaUsuario_Load;
            ((System.ComponentModel.ISupportInitialize)dgvListaUsuarios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgvListaUsuarios;
        private DataGridViewTextBoxColumn clnId;
        private DataGridViewTextBoxColumn clnNome;
        private DataGridViewTextBoxColumn clnCpf;
        private DataGridViewTextBoxColumn clnDataNascimento;
        private DataGridViewTextBoxColumn clnSetor;
        private DataGridViewTextBoxColumn clnCargo;
        private DataGridViewTextBoxColumn clnEmail;
        private DataGridViewCheckBoxColumn clnAtivo;
    }
}