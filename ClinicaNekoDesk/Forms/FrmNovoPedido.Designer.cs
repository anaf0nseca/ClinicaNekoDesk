namespace ClinicaNeko.Forms
{
    partial class FrmNovoPedido
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
            guna2HtmlLabel9 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            SuspendLayout();
            // 
            // guna2HtmlLabel9
            // 
            guna2HtmlLabel9.BackColor = Color.Transparent;
            guna2HtmlLabel9.Font = new Font("Arial Rounded MT Bold", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2HtmlLabel9.ForeColor = Color.FromArgb(39, 63, 44);
            guna2HtmlLabel9.Location = new Point(385, 12);
            guna2HtmlLabel9.Margin = new Padding(4, 3, 4, 3);
            guna2HtmlLabel9.Name = "guna2HtmlLabel9";
            guna2HtmlLabel9.Size = new Size(210, 35);
            guna2HtmlLabel9.TabIndex = 20;
            guna2HtmlLabel9.Text = "NOVO PEDIDO";
            // 
            // guna2GroupBox1
            // 
            guna2GroupBox1.BorderColor = Color.FromArgb(83, 133, 91);
            guna2GroupBox1.BorderRadius = 15;
            guna2GroupBox1.CustomBorderColor = Color.FromArgb(83, 133, 91);
            guna2GroupBox1.CustomizableEdges = customizableEdges1;
            guna2GroupBox1.Font = new Font("Segoe UI", 9F);
            guna2GroupBox1.ForeColor = Color.White;
            guna2GroupBox1.Location = new Point(50, 53);
            guna2GroupBox1.Margin = new Padding(5, 3, 5, 3);
            guna2GroupBox1.Name = "guna2GroupBox1";
            guna2GroupBox1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2GroupBox1.Size = new Size(944, 148);
            guna2GroupBox1.TabIndex = 21;
            guna2GroupBox1.Text = "Identificação";
            // 
            // guna2GroupBox2
            // 
            guna2GroupBox2.BorderColor = Color.FromArgb(83, 133, 91);
            guna2GroupBox2.BorderRadius = 15;
            guna2GroupBox2.CustomBorderColor = Color.FromArgb(83, 133, 91);
            guna2GroupBox2.CustomizableEdges = customizableEdges3;
            guna2GroupBox2.Font = new Font("Segoe UI", 9F);
            guna2GroupBox2.ForeColor = Color.White;
            guna2GroupBox2.Location = new Point(50, 234);
            guna2GroupBox2.Margin = new Padding(5, 3, 5, 3);
            guna2GroupBox2.Name = "guna2GroupBox2";
            guna2GroupBox2.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2GroupBox2.Size = new Size(944, 312);
            guna2GroupBox2.TabIndex = 22;
            guna2GroupBox2.Text = "Itens do Pedido";
            // 
            // FrmNovoPedido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(159, 187, 164);
            ClientSize = new Size(1050, 620);
            Controls.Add(guna2GroupBox2);
            Controls.Add(guna2GroupBox1);
            Controls.Add(guna2HtmlLabel9);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmNovoPedido";
            Text = "FrmPedido";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel9;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
    }
}