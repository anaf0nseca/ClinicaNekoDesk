namespace ClinicaNeko
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.panelUsuarios = new System.Windows.Forms.Panel();
            this.btnSetores = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelVet = new System.Windows.Forms.Panel();
            this.panelPedidos = new System.Windows.Forms.Panel();
            this.panelClientes = new System.Windows.Forms.Panel();
            this.guna2Button5 = new Guna.UI2.WinForms.Guna2Button();
            this.panelProdutos = new System.Windows.Forms.Panel();
            this.btnCategoria = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2CirclePictureBox2 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btnServicos = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button11 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button10 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button9 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button8 = new Guna.UI2.WinForms.Guna2Button();
            this.btnVeterinario = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button7 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button6 = new Guna.UI2.WinForms.Guna2Button();
            this.btnPedidos = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.btnClientes = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.btnProdutos = new Guna.UI2.WinForms.Guna2Button();
            this.btnListaUsuarios = new Guna.UI2.WinForms.Guna2Button();
            this.btnNovoUsuario = new Guna.UI2.WinForms.Guna2Button();
            this.btnUsuarios = new Guna.UI2.WinForms.Guna2Button();
            this.panel3.SuspendLayout();
            this.panelUsuarios.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelVet.SuspendLayout();
            this.panelPedidos.SuspendLayout();
            this.panelClientes.SuspendLayout();
            this.panelProdutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Font = new System.Drawing.Font("Broadway", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(218, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(962, 512);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.guna2HtmlLabel1);
            this.panel3.Controls.Add(this.guna2CirclePictureBox2);
            this.panel3.Controls.Add(this.guna2Button1);
            this.panel3.Location = new System.Drawing.Point(12, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1168, 73);
            this.panel3.TabIndex = 2;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderRadius = 15;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(187)))), ((int)(((byte)(164)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(1007, 15);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(147, 45);
            this.guna2Button1.TabIndex = 0;
            this.guna2Button1.Text = "Sair";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // panelUsuarios
            // 
            this.panelUsuarios.BackColor = System.Drawing.Color.Transparent;
            this.panelUsuarios.Controls.Add(this.btnSetores);
            this.panelUsuarios.Controls.Add(this.btnListaUsuarios);
            this.panelUsuarios.Controls.Add(this.btnNovoUsuario);
            this.panelUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUsuarios.Location = new System.Drawing.Point(0, 57);
            this.panelUsuarios.Name = "panelUsuarios";
            this.panelUsuarios.Size = new System.Drawing.Size(196, 10);
            this.panelUsuarios.TabIndex = 0;
            // 
            // btnSetores
            // 
            this.btnSetores.BorderColor = System.Drawing.Color.Transparent;
            this.btnSetores.BorderRadius = 15;
            this.btnSetores.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSetores.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSetores.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSetores.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSetores.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSetores.FillColor = System.Drawing.Color.LightGray;
            this.btnSetores.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetores.ForeColor = System.Drawing.Color.Black;
            this.btnSetores.Location = new System.Drawing.Point(0, 60);
            this.btnSetores.Name = "btnSetores";
            this.btnSetores.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(133)))), ((int)(((byte)(91)))));
            this.btnSetores.Size = new System.Drawing.Size(196, 30);
            this.btnSetores.TabIndex = 5;
            this.btnSetores.Text = "Setores e Cargos";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnServicos);
            this.panel2.Controls.Add(this.panelVet);
            this.panel2.Controls.Add(this.btnVeterinario);
            this.panel2.Controls.Add(this.panelPedidos);
            this.panel2.Controls.Add(this.btnPedidos);
            this.panel2.Controls.Add(this.panelClientes);
            this.panel2.Controls.Add(this.btnClientes);
            this.panel2.Controls.Add(this.panelProdutos);
            this.panel2.Controls.Add(this.btnProdutos);
            this.panel2.Controls.Add(this.panelUsuarios);
            this.panel2.Controls.Add(this.btnUsuarios);
            this.panel2.Location = new System.Drawing.Point(12, 107);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 490);
            this.panel2.TabIndex = 1;
            // 
            // panelVet
            // 
            this.panelVet.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelVet.Controls.Add(this.guna2Button11);
            this.panelVet.Controls.Add(this.guna2Button10);
            this.panelVet.Controls.Add(this.guna2Button9);
            this.panelVet.Controls.Add(this.guna2Button8);
            this.panelVet.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelVet.Location = new System.Drawing.Point(0, 301);
            this.panelVet.Name = "panelVet";
            this.panelVet.Size = new System.Drawing.Size(196, 10);
            this.panelVet.TabIndex = 20;
            // 
            // panelPedidos
            // 
            this.panelPedidos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelPedidos.Controls.Add(this.guna2Button7);
            this.panelPedidos.Controls.Add(this.guna2Button6);
            this.panelPedidos.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPedidos.Location = new System.Drawing.Point(0, 240);
            this.panelPedidos.Name = "panelPedidos";
            this.panelPedidos.Size = new System.Drawing.Size(196, 10);
            this.panelPedidos.TabIndex = 18;
            this.panelPedidos.Paint += new System.Windows.Forms.PaintEventHandler(this.panelPedidos_Paint);
            // 
            // panelClientes
            // 
            this.panelClientes.BackColor = System.Drawing.Color.White;
            this.panelClientes.Controls.Add(this.guna2Button5);
            this.panelClientes.Controls.Add(this.guna2Button4);
            this.panelClientes.Controls.Add(this.guna2Button3);
            this.panelClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelClientes.Location = new System.Drawing.Point(0, 179);
            this.panelClientes.Name = "panelClientes";
            this.panelClientes.Size = new System.Drawing.Size(196, 10);
            this.panelClientes.TabIndex = 16;
            // 
            // guna2Button5
            // 
            this.guna2Button5.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Button5.BorderRadius = 15;
            this.guna2Button5.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button5.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Button5.FillColor = System.Drawing.Color.LightGray;
            this.guna2Button5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button5.ForeColor = System.Drawing.Color.Black;
            this.guna2Button5.Location = new System.Drawing.Point(0, 60);
            this.guna2Button5.Name = "guna2Button5";
            this.guna2Button5.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(133)))), ((int)(((byte)(91)))));
            this.guna2Button5.Size = new System.Drawing.Size(196, 30);
            this.guna2Button5.TabIndex = 7;
            // 
            // panelProdutos
            // 
            this.panelProdutos.BackColor = System.Drawing.Color.White;
            this.panelProdutos.Controls.Add(this.btnCategoria);
            this.panelProdutos.Controls.Add(this.guna2Button2);
            this.panelProdutos.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelProdutos.Location = new System.Drawing.Point(0, 118);
            this.panelProdutos.Name = "panelProdutos";
            this.panelProdutos.Size = new System.Drawing.Size(196, 10);
            this.panelProdutos.TabIndex = 14;
            // 
            // btnCategoria
            // 
            this.btnCategoria.BorderColor = System.Drawing.Color.Transparent;
            this.btnCategoria.BorderRadius = 15;
            this.btnCategoria.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCategoria.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCategoria.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCategoria.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCategoria.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCategoria.FillColor = System.Drawing.Color.LightGray;
            this.btnCategoria.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategoria.ForeColor = System.Drawing.Color.Black;
            this.btnCategoria.Location = new System.Drawing.Point(0, 30);
            this.btnCategoria.Name = "btnCategoria";
            this.btnCategoria.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(133)))), ((int)(((byte)(91)))));
            this.btnCategoria.Size = new System.Drawing.Size(196, 30);
            this.btnCategoria.TabIndex = 5;
            this.btnCategoria.Text = "Categorias e Marcas";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(85)))), ((int)(((byte)(96)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(83, 22);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(490, 34);
            this.guna2HtmlLabel1.TabIndex = 2;
            this.guna2HtmlLabel1.Text = "CLÍNICA VETERINÁRIA NEKO  Clínica ";
            // 
            // guna2CirclePictureBox2
            // 
            this.guna2CirclePictureBox2.Image = global::ClinicaNeko.Properties.Resources.Logo1;
            this.guna2CirclePictureBox2.ImageRotate = 0F;
            this.guna2CirclePictureBox2.Location = new System.Drawing.Point(0, 0);
            this.guna2CirclePictureBox2.Name = "guna2CirclePictureBox2";
            this.guna2CirclePictureBox2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox2.Size = new System.Drawing.Size(76, 73);
            this.guna2CirclePictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox2.TabIndex = 1;
            this.guna2CirclePictureBox2.TabStop = false;
            // 
            // btnServicos
            // 
            this.btnServicos.BorderColor = System.Drawing.Color.Transparent;
            this.btnServicos.BorderRadius = 15;
            this.btnServicos.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnServicos.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnServicos.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnServicos.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnServicos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnServicos.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(241)))), ((int)(((byte)(178)))));
            this.btnServicos.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServicos.ForeColor = System.Drawing.Color.Black;
            this.btnServicos.Image = global::ClinicaNeko.Properties.Resources.chevron_down;
            this.btnServicos.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnServicos.Location = new System.Drawing.Point(0, 311);
            this.btnServicos.Name = "btnServicos";
            this.btnServicos.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(133)))), ((int)(((byte)(91)))));
            this.btnServicos.Size = new System.Drawing.Size(196, 51);
            this.btnServicos.TabIndex = 21;
            this.btnServicos.Text = "Serviços";
            this.btnServicos.Click += new System.EventHandler(this.guna2Button7_Click);
            // 
            // guna2Button11
            // 
            this.guna2Button11.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Button11.BorderRadius = 15;
            this.guna2Button11.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button11.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button11.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button11.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button11.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Button11.FillColor = System.Drawing.Color.LightGray;
            this.guna2Button11.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button11.ForeColor = System.Drawing.Color.Black;
            this.guna2Button11.Image = global::ClinicaNeko.Properties.Resources.microscope;
            this.guna2Button11.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.guna2Button11.Location = new System.Drawing.Point(0, 90);
            this.guna2Button11.Name = "guna2Button11";
            this.guna2Button11.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(133)))), ((int)(((byte)(91)))));
            this.guna2Button11.Size = new System.Drawing.Size(196, 30);
            this.guna2Button11.TabIndex = 10;
            this.guna2Button11.Text = "Consultas e Exames";
            // 
            // guna2Button10
            // 
            this.guna2Button10.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Button10.BorderRadius = 15;
            this.guna2Button10.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button10.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button10.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button10.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button10.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Button10.FillColor = System.Drawing.Color.LightGray;
            this.guna2Button10.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button10.ForeColor = System.Drawing.Color.Black;
            this.guna2Button10.Image = global::ClinicaNeko.Properties.Resources.heart_pulse;
            this.guna2Button10.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.guna2Button10.Location = new System.Drawing.Point(0, 60);
            this.guna2Button10.Name = "guna2Button10";
            this.guna2Button10.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(133)))), ((int)(((byte)(91)))));
            this.guna2Button10.Size = new System.Drawing.Size(196, 30);
            this.guna2Button10.TabIndex = 9;
            this.guna2Button10.Text = "Especialidades";
            // 
            // guna2Button9
            // 
            this.guna2Button9.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Button9.BorderRadius = 15;
            this.guna2Button9.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button9.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button9.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button9.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button9.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Button9.FillColor = System.Drawing.Color.LightGray;
            this.guna2Button9.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button9.ForeColor = System.Drawing.Color.Black;
            this.guna2Button9.Image = global::ClinicaNeko.Properties.Resources.stethoscope;
            this.guna2Button9.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.guna2Button9.Location = new System.Drawing.Point(0, 30);
            this.guna2Button9.Name = "guna2Button9";
            this.guna2Button9.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(133)))), ((int)(((byte)(91)))));
            this.guna2Button9.Size = new System.Drawing.Size(196, 30);
            this.guna2Button9.TabIndex = 8;
            this.guna2Button9.Text = "Med. Veterinários";
            // 
            // guna2Button8
            // 
            this.guna2Button8.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Button8.BorderRadius = 15;
            this.guna2Button8.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button8.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button8.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button8.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button8.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Button8.FillColor = System.Drawing.Color.LightGray;
            this.guna2Button8.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button8.ForeColor = System.Drawing.Color.Black;
            this.guna2Button8.Image = global::ClinicaNeko.Properties.Resources.calendar_days;
            this.guna2Button8.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.guna2Button8.Location = new System.Drawing.Point(0, 0);
            this.guna2Button8.Name = "guna2Button8";
            this.guna2Button8.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(133)))), ((int)(((byte)(91)))));
            this.guna2Button8.Size = new System.Drawing.Size(196, 30);
            this.guna2Button8.TabIndex = 7;
            this.guna2Button8.Text = "Agendados";
            // 
            // btnVeterinario
            // 
            this.btnVeterinario.BorderColor = System.Drawing.Color.Transparent;
            this.btnVeterinario.BorderRadius = 15;
            this.btnVeterinario.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnVeterinario.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnVeterinario.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnVeterinario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnVeterinario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVeterinario.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(241)))), ((int)(((byte)(178)))));
            this.btnVeterinario.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVeterinario.ForeColor = System.Drawing.Color.Black;
            this.btnVeterinario.Image = global::ClinicaNeko.Properties.Resources.chevron_down;
            this.btnVeterinario.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnVeterinario.Location = new System.Drawing.Point(0, 250);
            this.btnVeterinario.Name = "btnVeterinario";
            this.btnVeterinario.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(133)))), ((int)(((byte)(91)))));
            this.btnVeterinario.Size = new System.Drawing.Size(196, 51);
            this.btnVeterinario.TabIndex = 19;
            this.btnVeterinario.Text = "Veterinário";
            this.btnVeterinario.Click += new System.EventHandler(this.guna2Button6_Click);
            // 
            // guna2Button7
            // 
            this.guna2Button7.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Button7.BorderRadius = 15;
            this.guna2Button7.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button7.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button7.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button7.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button7.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Button7.FillColor = System.Drawing.Color.LightGray;
            this.guna2Button7.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button7.ForeColor = System.Drawing.Color.Black;
            this.guna2Button7.Image = global::ClinicaNeko.Properties.Resources.list;
            this.guna2Button7.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.guna2Button7.Location = new System.Drawing.Point(0, 30);
            this.guna2Button7.Name = "guna2Button7";
            this.guna2Button7.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(133)))), ((int)(((byte)(91)))));
            this.guna2Button7.Size = new System.Drawing.Size(196, 30);
            this.guna2Button7.TabIndex = 7;
            this.guna2Button7.Text = "Lista de Pedidos";
            // 
            // guna2Button6
            // 
            this.guna2Button6.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Button6.BorderRadius = 15;
            this.guna2Button6.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button6.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button6.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button6.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button6.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Button6.FillColor = System.Drawing.Color.LightGray;
            this.guna2Button6.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button6.ForeColor = System.Drawing.Color.Black;
            this.guna2Button6.Image = global::ClinicaNeko.Properties.Resources.circle_plus;
            this.guna2Button6.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.guna2Button6.Location = new System.Drawing.Point(0, 0);
            this.guna2Button6.Name = "guna2Button6";
            this.guna2Button6.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(133)))), ((int)(((byte)(91)))));
            this.guna2Button6.Size = new System.Drawing.Size(196, 30);
            this.guna2Button6.TabIndex = 6;
            this.guna2Button6.Text = "Novo";
            this.guna2Button6.Click += new System.EventHandler(this.guna2Button6_Click_1);
            // 
            // btnPedidos
            // 
            this.btnPedidos.BorderColor = System.Drawing.Color.Transparent;
            this.btnPedidos.BorderRadius = 15;
            this.btnPedidos.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPedidos.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPedidos.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPedidos.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPedidos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPedidos.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(241)))), ((int)(((byte)(178)))));
            this.btnPedidos.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPedidos.ForeColor = System.Drawing.Color.Black;
            this.btnPedidos.Image = global::ClinicaNeko.Properties.Resources.chevron_down;
            this.btnPedidos.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnPedidos.Location = new System.Drawing.Point(0, 189);
            this.btnPedidos.Name = "btnPedidos";
            this.btnPedidos.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(133)))), ((int)(((byte)(91)))));
            this.btnPedidos.Size = new System.Drawing.Size(196, 51);
            this.btnPedidos.TabIndex = 17;
            this.btnPedidos.Text = "Pedidos";
            this.btnPedidos.Click += new System.EventHandler(this.guna2Button5_Click);
            // 
            // guna2Button4
            // 
            this.guna2Button4.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Button4.BorderRadius = 15;
            this.guna2Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Button4.FillColor = System.Drawing.Color.LightGray;
            this.guna2Button4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button4.ForeColor = System.Drawing.Color.Black;
            this.guna2Button4.Image = global::ClinicaNeko.Properties.Resources.list;
            this.guna2Button4.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.guna2Button4.Location = new System.Drawing.Point(0, 30);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(133)))), ((int)(((byte)(91)))));
            this.guna2Button4.Size = new System.Drawing.Size(196, 30);
            this.guna2Button4.TabIndex = 6;
            this.guna2Button4.Text = "Lista de Clientes";
            // 
            // guna2Button3
            // 
            this.guna2Button3.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Button3.BorderRadius = 15;
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Button3.FillColor = System.Drawing.Color.LightGray;
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button3.ForeColor = System.Drawing.Color.Black;
            this.guna2Button3.Image = global::ClinicaNeko.Properties.Resources.circle_plus;
            this.guna2Button3.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.guna2Button3.Location = new System.Drawing.Point(0, 0);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(133)))), ((int)(((byte)(91)))));
            this.guna2Button3.Size = new System.Drawing.Size(196, 30);
            this.guna2Button3.TabIndex = 5;
            this.guna2Button3.Text = "Novo";
            this.guna2Button3.Click += new System.EventHandler(this.guna2Button3_Click_1);
            // 
            // btnClientes
            // 
            this.btnClientes.BorderColor = System.Drawing.Color.Transparent;
            this.btnClientes.BorderRadius = 15;
            this.btnClientes.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClientes.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClientes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClientes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClientes.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(241)))), ((int)(((byte)(178)))));
            this.btnClientes.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.ForeColor = System.Drawing.Color.Black;
            this.btnClientes.Image = global::ClinicaNeko.Properties.Resources.chevron_down;
            this.btnClientes.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnClientes.Location = new System.Drawing.Point(0, 128);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(133)))), ((int)(((byte)(91)))));
            this.btnClientes.Size = new System.Drawing.Size(196, 51);
            this.btnClientes.TabIndex = 15;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.Click += new System.EventHandler(this.guna2Button4_Click);
            // 
            // guna2Button2
            // 
            this.guna2Button2.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Button2.BorderRadius = 15;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Button2.FillColor = System.Drawing.Color.LightGray;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.ForeColor = System.Drawing.Color.Black;
            this.guna2Button2.Image = global::ClinicaNeko.Properties.Resources.circle_plus;
            this.guna2Button2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.guna2Button2.Location = new System.Drawing.Point(0, 0);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(133)))), ((int)(((byte)(91)))));
            this.guna2Button2.Size = new System.Drawing.Size(196, 30);
            this.guna2Button2.TabIndex = 4;
            this.guna2Button2.Text = "Novo";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click_1);
            // 
            // btnProdutos
            // 
            this.btnProdutos.BorderColor = System.Drawing.Color.Transparent;
            this.btnProdutos.BorderRadius = 15;
            this.btnProdutos.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnProdutos.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnProdutos.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnProdutos.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnProdutos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProdutos.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(241)))), ((int)(((byte)(178)))));
            this.btnProdutos.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProdutos.ForeColor = System.Drawing.Color.Black;
            this.btnProdutos.Image = global::ClinicaNeko.Properties.Resources.chevron_down;
            this.btnProdutos.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnProdutos.Location = new System.Drawing.Point(0, 67);
            this.btnProdutos.Name = "btnProdutos";
            this.btnProdutos.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(133)))), ((int)(((byte)(91)))));
            this.btnProdutos.Size = new System.Drawing.Size(196, 51);
            this.btnProdutos.TabIndex = 13;
            this.btnProdutos.Text = "Produtos";
            this.btnProdutos.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // btnListaUsuarios
            // 
            this.btnListaUsuarios.BorderColor = System.Drawing.Color.Transparent;
            this.btnListaUsuarios.BorderRadius = 15;
            this.btnListaUsuarios.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnListaUsuarios.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnListaUsuarios.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnListaUsuarios.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnListaUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnListaUsuarios.FillColor = System.Drawing.Color.LightGray;
            this.btnListaUsuarios.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListaUsuarios.ForeColor = System.Drawing.Color.Black;
            this.btnListaUsuarios.Image = global::ClinicaNeko.Properties.Resources.list;
            this.btnListaUsuarios.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnListaUsuarios.Location = new System.Drawing.Point(0, 30);
            this.btnListaUsuarios.Name = "btnListaUsuarios";
            this.btnListaUsuarios.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(133)))), ((int)(((byte)(91)))));
            this.btnListaUsuarios.Size = new System.Drawing.Size(196, 30);
            this.btnListaUsuarios.TabIndex = 4;
            this.btnListaUsuarios.Text = "Funcionários";
            // 
            // btnNovoUsuario
            // 
            this.btnNovoUsuario.BorderColor = System.Drawing.Color.Transparent;
            this.btnNovoUsuario.BorderRadius = 15;
            this.btnNovoUsuario.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNovoUsuario.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNovoUsuario.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNovoUsuario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNovoUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNovoUsuario.FillColor = System.Drawing.Color.LightGray;
            this.btnNovoUsuario.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnNovoUsuario.ForeColor = System.Drawing.Color.Black;
            this.btnNovoUsuario.Image = global::ClinicaNeko.Properties.Resources.circle_plus;
            this.btnNovoUsuario.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnNovoUsuario.Location = new System.Drawing.Point(0, 0);
            this.btnNovoUsuario.Name = "btnNovoUsuario";
            this.btnNovoUsuario.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(133)))), ((int)(((byte)(91)))));
            this.btnNovoUsuario.Size = new System.Drawing.Size(196, 30);
            this.btnNovoUsuario.TabIndex = 3;
            this.btnNovoUsuario.Text = "Novo";
            this.btnNovoUsuario.Click += new System.EventHandler(this.btnNovoUsuario_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.BorderColor = System.Drawing.Color.Transparent;
            this.btnUsuarios.BorderRadius = 15;
            this.btnUsuarios.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUsuarios.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUsuarios.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUsuarios.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsuarios.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(241)))), ((int)(((byte)(178)))));
            this.btnUsuarios.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.ForeColor = System.Drawing.Color.Black;
            this.btnUsuarios.Image = global::ClinicaNeko.Properties.Resources.chevron_down;
            this.btnUsuarios.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnUsuarios.Location = new System.Drawing.Point(0, 0);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(133)))), ((int)(((byte)(91)))));
            this.btnUsuarios.Size = new System.Drawing.Size(196, 57);
            this.btnUsuarios.TabIndex = 2;
            this.btnUsuarios.Text = "Usuários";
            this.btnUsuarios.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1190, 607);
            this.ControlBox = false;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panelUsuarios.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panelVet.ResumeLayout(false);
            this.panelPedidos.ResumeLayout(false);
            this.panelClientes.ResumeLayout(false);
            this.panelProdutos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox2;
        private Guna.UI2.WinForms.Guna2Button btnUsuarios;
        private System.Windows.Forms.Panel panelUsuarios;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btnServicos;
        private System.Windows.Forms.Panel panelVet;
        private Guna.UI2.WinForms.Guna2Button btnVeterinario;
        private System.Windows.Forms.Panel panelPedidos;
        private Guna.UI2.WinForms.Guna2Button btnPedidos;
        private System.Windows.Forms.Panel panelClientes;
        private Guna.UI2.WinForms.Guna2Button btnClientes;
        private System.Windows.Forms.Panel panelProdutos;
        private Guna.UI2.WinForms.Guna2Button btnProdutos;
        private Guna.UI2.WinForms.Guna2Button btnSetores;
        private Guna.UI2.WinForms.Guna2Button btnListaUsuarios;
        private Guna.UI2.WinForms.Guna2Button btnNovoUsuario;
        private Guna.UI2.WinForms.Guna2Button btnCategoria;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button5;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button guna2Button7;
        private Guna.UI2.WinForms.Guna2Button guna2Button6;
        private Guna.UI2.WinForms.Guna2Button guna2Button11;
        private Guna.UI2.WinForms.Guna2Button guna2Button10;
        private Guna.UI2.WinForms.Guna2Button guna2Button9;
        private Guna.UI2.WinForms.Guna2Button guna2Button8;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
    }
}

