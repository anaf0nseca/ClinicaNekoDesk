namespace ClinicaNekoDesk.Forms
{
    partial class FrmNovoAgendamento
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
            monthCalendar1 = new MonthCalendar();
            guna2HtmlLabel9 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            guna2RadioButton1 = new Guna.UI2.WinForms.Guna2RadioButton();
            guna2RadioButton5 = new Guna.UI2.WinForms.Guna2RadioButton();
            guna2RadioButton2 = new Guna.UI2.WinForms.Guna2RadioButton();
            guna2RadioButton3 = new Guna.UI2.WinForms.Guna2RadioButton();
            guna2RadioButton4 = new Guna.UI2.WinForms.Guna2RadioButton();
            guna2RadioButton6 = new Guna.UI2.WinForms.Guna2RadioButton();
            guna2GroupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // monthCalendar1
            // 
            monthCalendar1.AnnuallyBoldedDates = new DateTime[]
    {
    new DateTime(2024, 10, 24, 17, 1, 31, 0)
    };
            monthCalendar1.BackColor = SystemColors.ControlLightLight;
            monthCalendar1.BoldedDates = new DateTime[]
    {
    new DateTime(2024, 10, 24, 0, 0, 0, 0)
    };
            monthCalendar1.CalendarDimensions = new Size(3, 1);
            monthCalendar1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            monthCalendar1.Location = new Point(309, 111);
            monthCalendar1.MaxDate = new DateTime(2025, 3, 31, 0, 0, 0, 0);
            monthCalendar1.MaxSelectionCount = 1;
            monthCalendar1.MinDate = new DateTime(2024, 10, 24, 0, 0, 0, 0);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.RightToLeft = RightToLeft.No;
            monthCalendar1.TabIndex = 1;
            monthCalendar1.TitleBackColor = SystemColors.ControlDarkDark;
            monthCalendar1.TrailingForeColor = SystemColors.ControlText;
            monthCalendar1.DateSelected += monthCalendar1_DateSelected;
            // 
            // guna2HtmlLabel9
            // 
            guna2HtmlLabel9.BackColor = Color.Transparent;
            guna2HtmlLabel9.Font = new Font("Arial Rounded MT Bold", 26.25F);
            guna2HtmlLabel9.ForeColor = Color.FromArgb(39, 63, 44);
            guna2HtmlLabel9.Location = new Point(297, 43);
            guna2HtmlLabel9.Margin = new Padding(4, 3, 4, 3);
            guna2HtmlLabel9.Name = "guna2HtmlLabel9";
            guna2HtmlLabel9.Size = new Size(402, 42);
            guna2HtmlLabel9.TabIndex = 27;
            guna2HtmlLabel9.Text = "NOVO AGENDAMENTO";
            // 
            // guna2GroupBox1
            // 
            guna2GroupBox1.BorderColor = Color.FromArgb(83, 133, 91);
            guna2GroupBox1.BorderRadius = 15;
            guna2GroupBox1.Controls.Add(guna2RadioButton3);
            guna2GroupBox1.Controls.Add(guna2RadioButton6);
            guna2GroupBox1.Controls.Add(guna2RadioButton2);
            guna2GroupBox1.Controls.Add(guna2RadioButton4);
            guna2GroupBox1.Controls.Add(guna2RadioButton1);
            guna2GroupBox1.Controls.Add(guna2RadioButton5);
            guna2GroupBox1.CustomBorderColor = Color.FromArgb(83, 133, 91);
            guna2GroupBox1.CustomBorderThickness = new Padding(0, 30, 0, 0);
            guna2GroupBox1.CustomizableEdges = customizableEdges1;
            guna2GroupBox1.Font = new Font("Segoe UI", 9F);
            guna2GroupBox1.ForeColor = Color.White;
            guna2GroupBox1.Location = new Point(14, 111);
            guna2GroupBox1.Margin = new Padding(5, 3, 5, 3);
            guna2GroupBox1.Name = "guna2GroupBox1";
            guna2GroupBox1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2GroupBox1.Size = new Size(215, 354);
            guna2GroupBox1.TabIndex = 29;
            guna2GroupBox1.Text = "Selecione o tipo de agendamento";
            // 
            // guna2RadioButton1
            // 
            guna2RadioButton1.AutoSize = true;
            guna2RadioButton1.BackColor = Color.Transparent;
            guna2RadioButton1.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2RadioButton1.CheckedState.BorderThickness = 0;
            guna2RadioButton1.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            guna2RadioButton1.CheckedState.InnerColor = Color.White;
            guna2RadioButton1.CheckedState.InnerOffset = -4;
            guna2RadioButton1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            guna2RadioButton1.ForeColor = Color.Black;
            guna2RadioButton1.Location = new Point(31, 52);
            guna2RadioButton1.Name = "guna2RadioButton1";
            guna2RadioButton1.Size = new Size(123, 25);
            guna2RadioButton1.TabIndex = 0;
            guna2RadioButton1.Text = "Banho e Tosa";
            guna2RadioButton1.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            guna2RadioButton1.UncheckedState.BorderThickness = 2;
            guna2RadioButton1.UncheckedState.FillColor = Color.Transparent;
            guna2RadioButton1.UncheckedState.InnerColor = Color.Transparent;
            guna2RadioButton1.UseVisualStyleBackColor = false;
            // 
            // guna2RadioButton5
            // 
            guna2RadioButton5.AutoSize = true;
            guna2RadioButton5.BackColor = Color.Transparent;
            guna2RadioButton5.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2RadioButton5.CheckedState.BorderThickness = 0;
            guna2RadioButton5.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            guna2RadioButton5.CheckedState.InnerColor = Color.White;
            guna2RadioButton5.CheckedState.InnerOffset = -4;
            guna2RadioButton5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            guna2RadioButton5.ForeColor = Color.Black;
            guna2RadioButton5.Location = new Point(31, 197);
            guna2RadioButton5.Name = "guna2RadioButton5";
            guna2RadioButton5.Size = new Size(91, 25);
            guna2RadioButton5.TabIndex = 4;
            guna2RadioButton5.Text = "Consulta";
            guna2RadioButton5.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            guna2RadioButton5.UncheckedState.BorderThickness = 2;
            guna2RadioButton5.UncheckedState.FillColor = Color.Transparent;
            guna2RadioButton5.UncheckedState.InnerColor = Color.Transparent;
            guna2RadioButton5.UseVisualStyleBackColor = false;
            // 
            // guna2RadioButton2
            // 
            guna2RadioButton2.AutoSize = true;
            guna2RadioButton2.BackColor = Color.Transparent;
            guna2RadioButton2.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2RadioButton2.CheckedState.BorderThickness = 0;
            guna2RadioButton2.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            guna2RadioButton2.CheckedState.InnerColor = Color.White;
            guna2RadioButton2.CheckedState.InnerOffset = -4;
            guna2RadioButton2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            guna2RadioButton2.ForeColor = Color.Black;
            guna2RadioButton2.Location = new Point(31, 249);
            guna2RadioButton2.Name = "guna2RadioButton2";
            guna2RadioButton2.Size = new Size(75, 25);
            guna2RadioButton2.TabIndex = 5;
            guna2RadioButton2.Text = "Exame";
            guna2RadioButton2.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            guna2RadioButton2.UncheckedState.BorderThickness = 2;
            guna2RadioButton2.UncheckedState.FillColor = Color.Transparent;
            guna2RadioButton2.UncheckedState.InnerColor = Color.Transparent;
            guna2RadioButton2.UseVisualStyleBackColor = false;
            // 
            // guna2RadioButton3
            // 
            guna2RadioButton3.AutoSize = true;
            guna2RadioButton3.BackColor = Color.Transparent;
            guna2RadioButton3.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2RadioButton3.CheckedState.BorderThickness = 0;
            guna2RadioButton3.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            guna2RadioButton3.CheckedState.InnerColor = Color.White;
            guna2RadioButton3.CheckedState.InnerOffset = -4;
            guna2RadioButton3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            guna2RadioButton3.ForeColor = Color.Black;
            guna2RadioButton3.Location = new Point(31, 300);
            guna2RadioButton3.Name = "guna2RadioButton3";
            guna2RadioButton3.Size = new Size(85, 25);
            guna2RadioButton3.TabIndex = 6;
            guna2RadioButton3.Text = "Cirurgia";
            guna2RadioButton3.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            guna2RadioButton3.UncheckedState.BorderThickness = 2;
            guna2RadioButton3.UncheckedState.FillColor = Color.Transparent;
            guna2RadioButton3.UncheckedState.InnerColor = Color.Transparent;
            guna2RadioButton3.UseVisualStyleBackColor = false;
            // 
            // guna2RadioButton4
            // 
            guna2RadioButton4.AutoSize = true;
            guna2RadioButton4.BackColor = Color.Transparent;
            guna2RadioButton4.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2RadioButton4.CheckedState.BorderThickness = 0;
            guna2RadioButton4.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            guna2RadioButton4.CheckedState.InnerColor = Color.White;
            guna2RadioButton4.CheckedState.InnerOffset = -4;
            guna2RadioButton4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            guna2RadioButton4.ForeColor = Color.Black;
            guna2RadioButton4.Location = new Point(31, 98);
            guna2RadioButton4.Name = "guna2RadioButton4";
            guna2RadioButton4.Size = new Size(133, 25);
            guna2RadioButton4.TabIndex = 1;
            guna2RadioButton4.Text = "Adestramento";
            guna2RadioButton4.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            guna2RadioButton4.UncheckedState.BorderThickness = 2;
            guna2RadioButton4.UncheckedState.FillColor = Color.Transparent;
            guna2RadioButton4.UncheckedState.InnerColor = Color.Transparent;
            guna2RadioButton4.UseVisualStyleBackColor = false;
            // 
            // guna2RadioButton6
            // 
            guna2RadioButton6.AutoSize = true;
            guna2RadioButton6.BackColor = Color.Transparent;
            guna2RadioButton6.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2RadioButton6.CheckedState.BorderThickness = 0;
            guna2RadioButton6.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            guna2RadioButton6.CheckedState.InnerColor = Color.White;
            guna2RadioButton6.CheckedState.InnerOffset = -4;
            guna2RadioButton6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            guna2RadioButton6.ForeColor = Color.Black;
            guna2RadioButton6.Location = new Point(31, 146);
            guna2RadioButton6.Name = "guna2RadioButton6";
            guna2RadioButton6.Size = new Size(100, 25);
            guna2RadioButton6.TabIndex = 2;
            guna2RadioButton6.Text = "Vacinação";
            guna2RadioButton6.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            guna2RadioButton6.UncheckedState.BorderThickness = 2;
            guna2RadioButton6.UncheckedState.FillColor = Color.Transparent;
            guna2RadioButton6.UncheckedState.InnerColor = Color.Transparent;
            guna2RadioButton6.UseVisualStyleBackColor = false;
            // 
            // FrmNovoAgendamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(159, 187, 164);
            ClientSize = new Size(1034, 581);
            ControlBox = false;
            Controls.Add(guna2GroupBox1);
            Controls.Add(guna2HtmlLabel9);
            Controls.Add(monthCalendar1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmNovoAgendamento";
            Text = "FrmNovoAgendamento";
            guna2GroupBox1.ResumeLayout(false);
            guna2GroupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public MonthCalendar monthCalendar1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel9;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2RadioButton guna2RadioButton2;
        private Guna.UI2.WinForms.Guna2RadioButton guna2RadioButton5;
        private Guna.UI2.WinForms.Guna2RadioButton guna2RadioButton1;
        private Guna.UI2.WinForms.Guna2RadioButton guna2RadioButton3;
        private Guna.UI2.WinForms.Guna2RadioButton guna2RadioButton6;
        private Guna.UI2.WinForms.Guna2RadioButton guna2RadioButton4;
    }
}