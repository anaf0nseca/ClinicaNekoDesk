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
            monthCalendar1 = new MonthCalendar();
            SuspendLayout();
            // 
            // monthCalendar1
            // 
            monthCalendar1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            monthCalendar1.BackColor = SystemColors.InactiveCaption;
            monthCalendar1.BoldedDates = new DateTime[]
    {
    new DateTime(2024, 10, 24, 0, 0, 0, 0)
    };
            monthCalendar1.CalendarDimensions = new Size(1, 3);
            monthCalendar1.Location = new Point(36, 52);
            monthCalendar1.MaxDate = new DateTime(2024, 12, 31, 0, 0, 0, 0);
            monthCalendar1.MaxSelectionCount = 1;
            monthCalendar1.MinDate = new DateTime(2024, 10, 1, 0, 0, 0, 0);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.RightToLeft = RightToLeft.No;
            monthCalendar1.TabIndex = 1;
            monthCalendar1.TrailingForeColor = SystemColors.ControlText;
            // 
            // FrmNovoAgendamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1034, 581);
            Controls.Add(monthCalendar1);
            Name = "FrmNovoAgendamento";
            Text = "FrmNovoAgendamento";
            ResumeLayout(false);
        }

        #endregion

        public MonthCalendar monthCalendar1;
    }
}