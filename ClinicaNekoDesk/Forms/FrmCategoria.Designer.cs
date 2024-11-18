namespace ClinicaNekoDesk.Forms
{
    partial class FrmCategoria
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCategoria));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            btnCadastrar = new Guna.UI2.WinForms.Guna2Button();
            txtCategoria = new Guna.UI2.WinForms.Guna2TextBox();
            btnFechar = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2HtmlLabel1.ForeColor = Color.FromArgb(39, 63, 44);
            guna2HtmlLabel1.Location = new Point(39, 12);
            guna2HtmlLabel1.Margin = new Padding(4, 3, 4, 3);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(252, 34);
            guna2HtmlLabel1.TabIndex = 28;
            guna2HtmlLabel1.Text = "NOVA CATEGORIA";
            // 
            // btnCadastrar
            // 
            btnCadastrar.Animated = true;
            btnCadastrar.BackColor = Color.Transparent;
            btnCadastrar.BorderRadius = 10;
            btnCadastrar.CustomizableEdges = customizableEdges1;
            btnCadastrar.DisabledState.BorderColor = Color.DarkGray;
            btnCadastrar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCadastrar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCadastrar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCadastrar.FillColor = Color.FromArgb(34, 85, 96);
            btnCadastrar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnCadastrar.ForeColor = Color.White;
            btnCadastrar.ImageAlign = HorizontalAlignment.Right;
            btnCadastrar.ImageSize = new Size(24, 24);
            btnCadastrar.Location = new Point(114, 106);
            btnCadastrar.Margin = new Padding(4, 3, 4, 3);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnCadastrar.Size = new Size(101, 35);
            btnCadastrar.TabIndex = 53;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.Click += btnLogin_Click;
            // 
            // txtCategoria
            // 
            txtCategoria.BackColor = Color.Transparent;
            txtCategoria.BorderRadius = 10;
            txtCategoria.Cursor = Cursors.IBeam;
            txtCategoria.CustomizableEdges = customizableEdges3;
            txtCategoria.DefaultText = "";
            txtCategoria.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtCategoria.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtCategoria.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtCategoria.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtCategoria.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtCategoria.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCategoria.ForeColor = Color.FromArgb(39, 63, 44);
            txtCategoria.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtCategoria.Location = new Point(48, 71);
            txtCategoria.Margin = new Padding(5);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.PasswordChar = '\0';
            txtCategoria.PlaceholderText = "Insira a nova categoria";
            txtCategoria.SelectedText = "";
            txtCategoria.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtCategoria.Size = new Size(243, 27);
            txtCategoria.TabIndex = 52;
            // 
            // btnFechar
            // 
            btnFechar.BackgroundImage = (Image)resources.GetObject("btnFechar.BackgroundImage");
            btnFechar.BackgroundImageLayout = ImageLayout.Stretch;
            btnFechar.BorderColor = Color.Transparent;
            btnFechar.Cursor = Cursors.Hand;
            btnFechar.CustomizableEdges = customizableEdges5;
            btnFechar.DisabledState.BorderColor = Color.DarkGray;
            btnFechar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnFechar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnFechar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnFechar.FillColor = Color.Transparent;
            btnFechar.Font = new Font("Segoe UI", 9F);
            btnFechar.ForeColor = Color.White;
            btnFechar.Location = new Point(306, 5);
            btnFechar.Name = "btnFechar";
            btnFechar.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnFechar.Size = new Size(27, 27);
            btnFechar.TabIndex = 65;
            btnFechar.Click += btnFechar_Click;
            // 
            // FrmCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(159, 187, 164);
            ClientSize = new Size(338, 164);
            Controls.Add(btnFechar);
            Controls.Add(btnCadastrar);
            Controls.Add(txtCategoria);
            Controls.Add(guna2HtmlLabel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmCategoria";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmCategoria";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Button btnCadastrar;
        private Guna.UI2.WinForms.Guna2TextBox txtCategoria;
        private Guna.UI2.WinForms.Guna2Button btnFechar;
    }
}