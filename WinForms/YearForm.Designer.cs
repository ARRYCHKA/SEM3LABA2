namespace WinForms
{
    partial class YearForm
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
            panel1 = new Panel();
            yearLabel = new Label();
            yearTextBox = new TextBox();
            searchButton = new Button();
            exButton = new Button();
            CarList = new ListBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Controls.Add(CarList);
            panel1.Controls.Add(exButton);
            panel1.Controls.Add(searchButton);
            panel1.Controls.Add(yearTextBox);
            panel1.Controls.Add(yearLabel);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(658, 168);
            panel1.TabIndex = 0;
            // 
            // yearLabel
            // 
            yearLabel.AutoSize = true;
            yearLabel.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 204);
            yearLabel.ForeColor = SystemColors.ControlText;
            yearLabel.Location = new Point(12, 9);
            yearLabel.Name = "yearLabel";
            yearLabel.Size = new Size(261, 31);
            yearLabel.TabIndex = 0;
            yearLabel.Text = "Введите год для поиска";
            // 
            // yearTextBox
            // 
            yearTextBox.Location = new Point(12, 43);
            yearTextBox.Name = "yearTextBox";
            yearTextBox.Size = new Size(273, 27);
            yearTextBox.TabIndex = 1;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(12, 97);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(135, 40);
            searchButton.TabIndex = 2;
            searchButton.Text = "Поиск";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += button1_Click;
            // 
            // exButton
            // 
            exButton.Location = new Point(150, 97);
            exButton.Name = "exButton";
            exButton.Size = new Size(135, 40);
            exButton.TabIndex = 3;
            exButton.Text = "Назад";
            exButton.UseVisualStyleBackColor = true;
            exButton.Click += exButton_Click;
            // 
            // CarList
            // 
            CarList.FormattingEnabled = true;
            CarList.Location = new Point(338, 25);
            CarList.Name = "CarList";
            CarList.Size = new Size(294, 104);
            CarList.TabIndex = 4;
            // 
            // YearForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(658, 168);
            Controls.Add(panel1);
            Name = "YearForm";
            Text = "YearForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label yearLabel;
        private TextBox yearTextBox;
        private Button exButton;
        private Button searchButton;
        private ListBox CarList;
    }
}