namespace ClinicaNeko.Forms
{
    partial class FrmNovoUsuario
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
            this.dtpNascimento = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.cmbSetor = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbCargo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel8 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnProximo = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel10 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel9 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtNome = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCpf = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSenha = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTelefone = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // dtpNascimento
            // 
            this.dtpNascimento.BorderRadius = 10;
            this.dtpNascimento.Checked = true;
            this.dtpNascimento.FillColor = System.Drawing.Color.White;
            this.dtpNascimento.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNascimento.Location = new System.Drawing.Point(573, 175);
            this.dtpNascimento.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNascimento.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNascimento.Name = "dtpNascimento";
            this.dtpNascimento.Size = new System.Drawing.Size(200, 36);
            this.dtpNascimento.TabIndex = 5;
            this.dtpNascimento.Value = new System.DateTime(2024, 9, 18, 17, 42, 24, 924);
            // 
            // guna2ContextMenuStrip1
            // 
            this.guna2ContextMenuStrip1.Name = "guna2ContextMenuStrip1";
            this.guna2ContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.ColorTable = null;
            this.guna2ContextMenuStrip1.RenderStyle.RoundedEdges = true;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.guna2ContextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // cmbSetor
            // 
            this.cmbSetor.BackColor = System.Drawing.Color.Transparent;
            this.cmbSetor.BorderRadius = 10;
            this.cmbSetor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbSetor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSetor.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbSetor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbSetor.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.cmbSetor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbSetor.ItemHeight = 30;
            this.cmbSetor.Location = new System.Drawing.Point(43, 354);
            this.cmbSetor.Name = "cmbSetor";
            this.cmbSetor.Size = new System.Drawing.Size(201, 36);
            this.cmbSetor.TabIndex = 7;
            this.cmbSetor.SelectedIndexChanged += new System.EventHandler(this.cmbSetor_SelectedIndexChanged);
            // 
            // cmbCargo
            // 
            this.cmbCargo.BackColor = System.Drawing.Color.Transparent;
            this.cmbCargo.BorderRadius = 10;
            this.cmbCargo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbCargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCargo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbCargo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbCargo.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.cmbCargo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbCargo.ItemHeight = 30;
            this.cmbCargo.Location = new System.Drawing.Point(300, 354);
            this.cmbCargo.Name = "cmbCargo";
            this.cmbCargo.Size = new System.Drawing.Size(201, 36);
            this.cmbCargo.TabIndex = 8;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(44)))));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(50, 153);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(116, 20);
            this.guna2HtmlLabel2.TabIndex = 10;
            this.guna2HtmlLabel2.Text = "Nome Completo";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(44)))));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(336, 154);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(33, 20);
            this.guna2HtmlLabel3.TabIndex = 11;
            this.guna2HtmlLabel3.Text = "CPF";
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(44)))));
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(582, 153);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(144, 20);
            this.guna2HtmlLabel4.TabIndex = 12;
            this.guna2HtmlLabel4.Text = "Data de Nascimento";
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(44)))));
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(50, 245);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(41, 20);
            this.guna2HtmlLabel5.TabIndex = 13;
            this.guna2HtmlLabel5.Text = "Email";
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(44)))));
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(573, 245);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(67, 20);
            this.guna2HtmlLabel6.TabIndex = 14;
            this.guna2HtmlLabel6.Text = "Telefone";
            // 
            // guna2HtmlLabel7
            // 
            this.guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel7.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(44)))));
            this.guna2HtmlLabel7.Location = new System.Drawing.Point(54, 334);
            this.guna2HtmlLabel7.Name = "guna2HtmlLabel7";
            this.guna2HtmlLabel7.Size = new System.Drawing.Size(42, 20);
            this.guna2HtmlLabel7.TabIndex = 15;
            this.guna2HtmlLabel7.Text = "Setor";
            // 
            // guna2HtmlLabel8
            // 
            this.guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel8.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(44)))));
            this.guna2HtmlLabel8.Location = new System.Drawing.Point(314, 334);
            this.guna2HtmlLabel8.Name = "guna2HtmlLabel8";
            this.guna2HtmlLabel8.Size = new System.Drawing.Size(46, 20);
            this.guna2HtmlLabel8.TabIndex = 16;
            this.guna2HtmlLabel8.Text = "Cargo";
            // 
            // btnProximo
            // 
            this.btnProximo.Animated = true;
            this.btnProximo.BackColor = System.Drawing.Color.Transparent;
            this.btnProximo.BorderRadius = 20;
            this.btnProximo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnProximo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnProximo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnProximo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnProximo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(133)))), ((int)(((byte)(91)))));
            this.btnProximo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnProximo.ForeColor = System.Drawing.Color.White;
            this.btnProximo.Location = new System.Drawing.Point(606, 354);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(153, 45);
            this.btnProximo.TabIndex = 18;
            this.btnProximo.Text = "Próximo";
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // guna2HtmlLabel10
            // 
            this.guna2HtmlLabel10.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel10.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(44)))));
            this.guna2HtmlLabel10.Location = new System.Drawing.Point(335, 245);
            this.guna2HtmlLabel10.Name = "guna2HtmlLabel10";
            this.guna2HtmlLabel10.Size = new System.Drawing.Size(48, 20);
            this.guna2HtmlLabel10.TabIndex = 21;
            this.guna2HtmlLabel10.Text = "Senha";
            // 
            // guna2HtmlLabel9
            // 
            this.guna2HtmlLabel9.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F);
            this.guna2HtmlLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(63)))), ((int)(((byte)(44)))));
            this.guna2HtmlLabel9.Location = new System.Drawing.Point(242, 41);
            this.guna2HtmlLabel9.Name = "guna2HtmlLabel9";
            this.guna2HtmlLabel9.Size = new System.Drawing.Size(436, 42);
            this.guna2HtmlLabel9.TabIndex = 19;
            this.guna2HtmlLabel9.Text = "CADASTRO DE USUÁRIO";
            // 
            // txtNome
            // 
            this.txtNome.BorderRadius = 10;
            this.txtNome.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNome.DefaultText = "";
            this.txtNome.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNome.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNome.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNome.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.ForeColor = System.Drawing.Color.Black;
            this.txtNome.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNome.Location = new System.Drawing.Point(39, 175);
            this.txtNome.Name = "txtNome";
            this.txtNome.PasswordChar = '\0';
            this.txtNome.PlaceholderText = "";
            this.txtNome.SelectedText = "";
            this.txtNome.Size = new System.Drawing.Size(260, 36);
            this.txtNome.TabIndex = 22;
            // 
            // txtCpf
            // 
            this.txtCpf.BorderRadius = 10;
            this.txtCpf.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCpf.DefaultText = "";
            this.txtCpf.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCpf.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCpf.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCpf.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCpf.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCpf.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCpf.ForeColor = System.Drawing.Color.Black;
            this.txtCpf.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCpf.Location = new System.Drawing.Point(329, 175);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.PasswordChar = '\0';
            this.txtCpf.PlaceholderText = "";
            this.txtCpf.SelectedText = "";
            this.txtCpf.Size = new System.Drawing.Size(207, 36);
            this.txtCpf.TabIndex = 23;
            // 
            // txtEmail
            // 
            this.txtEmail.BorderRadius = 10;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.DefaultText = "";
            this.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.Location = new System.Drawing.Point(39, 266);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PlaceholderText = "";
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(260, 36);
            this.txtEmail.TabIndex = 24;
            // 
            // txtSenha
            // 
            this.txtSenha.BorderRadius = 10;
            this.txtSenha.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSenha.DefaultText = "";
            this.txtSenha.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSenha.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSenha.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSenha.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSenha.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSenha.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.ForeColor = System.Drawing.Color.Black;
            this.txtSenha.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSenha.Location = new System.Drawing.Point(329, 266);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '\0';
            this.txtSenha.PlaceholderText = "";
            this.txtSenha.SelectedText = "";
            this.txtSenha.Size = new System.Drawing.Size(207, 36);
            this.txtSenha.TabIndex = 25;
            // 
            // txtTelefone
            // 
            this.txtTelefone.BorderRadius = 10;
            this.txtTelefone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTelefone.DefaultText = "";
            this.txtTelefone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTelefone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTelefone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTelefone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTelefone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTelefone.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone.ForeColor = System.Drawing.Color.Black;
            this.txtTelefone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTelefone.Location = new System.Drawing.Point(573, 266);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.PasswordChar = '\0';
            this.txtTelefone.PlaceholderText = "";
            this.txtTelefone.SelectedText = "";
            this.txtTelefone.Size = new System.Drawing.Size(200, 36);
            this.txtTelefone.TabIndex = 26;
            // 
            // FrmNovoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(187)))), ((int)(((byte)(164)))));
            this.ClientSize = new System.Drawing.Size(960, 510);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.guna2HtmlLabel10);
            this.Controls.Add(this.guna2HtmlLabel9);
            this.Controls.Add(this.btnProximo);
            this.Controls.Add(this.guna2HtmlLabel8);
            this.Controls.Add(this.guna2HtmlLabel7);
            this.Controls.Add(this.guna2HtmlLabel6);
            this.Controls.Add(this.guna2HtmlLabel5);
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.cmbCargo);
            this.Controls.Add(this.cmbSetor);
            this.Controls.Add(this.dtpNascimento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmNovoUsuario";
            this.Text = "FrmUsuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpNascimento;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
        private Guna.UI2.WinForms.Guna2ComboBox cmbSetor;
        private Guna.UI2.WinForms.Guna2ComboBox cmbCargo;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel7;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel8;
        private Guna.UI2.WinForms.Guna2Button btnProximo;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel10;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel9;
        private Guna.UI2.WinForms.Guna2TextBox txtNome;
        private Guna.UI2.WinForms.Guna2TextBox txtCpf;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private Guna.UI2.WinForms.Guna2TextBox txtSenha;
        private Guna.UI2.WinForms.Guna2TextBox txtTelefone;
    }
}