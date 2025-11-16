namespace WinForms
{
    partial class ColorForm
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
            exButton = new Button();
            ColorLabel = new Label();
            colorTextBox = new TextBox();
            searchColorButton = new Button();
            CarList = new ListBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Controls.Add(CarList);
            panel1.Controls.Add(exButton);
            panel1.Controls.Add(ColorLabel);
            panel1.Controls.Add(colorTextBox);
            panel1.Controls.Add(searchColorButton);
            panel1.Dock = DockStyle.Fill;
            panel1.ForeColor = SystemColors.ControlLight;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(658, 168);
            panel1.TabIndex = 0;
            // 
            // exButton
            // 
            exButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            exButton.ForeColor = SystemColors.ActiveCaptionText;
            exButton.Location = new Point(150, 97);
            exButton.Name = "exButton";
            exButton.Size = new Size(135, 40);
            exButton.TabIndex = 3;
            exButton.Text = "Назад";
            exButton.UseVisualStyleBackColor = true;
            exButton.Click += exButton_Click;
            // 
            // ColorLabel
            // 
            ColorLabel.AutoSize = true;
            ColorLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ColorLabel.ForeColor = SystemColors.ActiveCaptionText;
            ColorLabel.Location = new Point(12, 9);
            ColorLabel.Name = "ColorLabel";
            ColorLabel.Size = new Size(273, 31);
            ColorLabel.TabIndex = 2;
            ColorLabel.Text = "Введите цвет для поиска";
            // 
            // colorTextBox
            // 
            colorTextBox.Location = new Point(12, 43);
            colorTextBox.Name = "colorTextBox";
            colorTextBox.Size = new Size(273, 27);
            colorTextBox.TabIndex = 1;
            // 
            // searchColorButton
            // 
            searchColorButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            searchColorButton.ForeColor = SystemColors.ActiveCaptionText;
            searchColorButton.Location = new Point(12, 97);
            searchColorButton.Name = "searchColorButton";
            searchColorButton.Size = new Size(135, 40);
            searchColorButton.TabIndex = 0;
            searchColorButton.Text = "Поиск";
            searchColorButton.UseVisualStyleBackColor = true;
            searchColorButton.Click += searchColorButton_Click;
            // 
            // CarList
            // 
            CarList.FormattingEnabled = true;
            CarList.Location = new Point(338, 25);
            CarList.Name = "CarList";
            CarList.Size = new Size(293, 104);
            CarList.TabIndex = 4;
            // 
            // ColorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(658, 168);
            Controls.Add(panel1);
            Name = "ColorForm";
            Text = "ColorForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button exButton;
        private Label ColorLabel;
        private TextBox colorTextBox;
        private Button searchColorButton;
        private ListBox CarList;
    }
}