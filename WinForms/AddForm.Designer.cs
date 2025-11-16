namespace WinForms
{
    partial class AddForm
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
            exitButton = new Button();
            saveCarButton = new Button();
            yearTextBox = new TextBox();
            colorTextBox = new TextBox();
            brandTextBox = new TextBox();
            idTextBox = new TextBox();
            yearLabel = new Label();
            colorLabel = new Label();
            brandLabel = new Label();
            idLabel = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Controls.Add(exitButton);
            panel1.Controls.Add(saveCarButton);
            panel1.Controls.Add(yearTextBox);
            panel1.Controls.Add(colorTextBox);
            panel1.Controls.Add(brandTextBox);
            panel1.Controls.Add(idTextBox);
            panel1.Controls.Add(yearLabel);
            panel1.Controls.Add(colorLabel);
            panel1.Controls.Add(brandLabel);
            panel1.Controls.Add(idLabel);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(241, 421);
            panel1.TabIndex = 0;
            // 
            // exitButton
            // 
            exitButton.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            exitButton.Location = new Point(12, 372);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(206, 37);
            exitButton.TabIndex = 9;
            exitButton.Text = "ВЕРНУТЬСЯ НАЗАД";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // saveCarButton
            // 
            saveCarButton.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            saveCarButton.Location = new Point(12, 322);
            saveCarButton.Name = "saveCarButton";
            saveCarButton.Size = new Size(206, 44);
            saveCarButton.TabIndex = 8;
            saveCarButton.Text = "Сохранить";
            saveCarButton.UseVisualStyleBackColor = true;
            saveCarButton.Click += button1_Click;
            // 
            // yearTextBox
            // 
            yearTextBox.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            yearTextBox.Location = new Point(12, 275);
            yearTextBox.Name = "yearTextBox";
            yearTextBox.Size = new Size(206, 31);
            yearTextBox.TabIndex = 7;
            // 
            // colorTextBox
            // 
            colorTextBox.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            colorTextBox.Location = new Point(12, 200);
            colorTextBox.Name = "colorTextBox";
            colorTextBox.Size = new Size(206, 31);
            colorTextBox.TabIndex = 6;
            // 
            // brandTextBox
            // 
            brandTextBox.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            brandTextBox.Location = new Point(12, 128);
            brandTextBox.Name = "brandTextBox";
            brandTextBox.Size = new Size(206, 31);
            brandTextBox.TabIndex = 5;
            // 
            // idTextBox
            // 
            idTextBox.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            idTextBox.Location = new Point(12, 43);
            idTextBox.Name = "idTextBox";
            idTextBox.Size = new Size(206, 31);
            idTextBox.TabIndex = 4;
            idTextBox.TextChanged += idTextBox_TextChanged;
            // 
            // yearLabel
            // 
            yearLabel.AutoSize = true;
            yearLabel.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            yearLabel.Location = new Point(12, 241);
            yearLabel.Name = "yearLabel";
            yearLabel.Size = new Size(108, 31);
            yearLabel.TabIndex = 3;
            yearLabel.Text = "Введите ";
            // 
            // colorLabel
            // 
            colorLabel.AutoSize = true;
            colorLabel.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            colorLabel.Location = new Point(12, 166);
            colorLabel.Name = "colorLabel";
            colorLabel.Size = new Size(157, 31);
            colorLabel.TabIndex = 2;
            colorLabel.Text = "Введите цвет";
            // 
            // brandLabel
            // 
            brandLabel.AutoSize = true;
            brandLabel.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            brandLabel.Location = new Point(12, 94);
            brandLabel.Name = "brandLabel";
            brandLabel.Size = new Size(181, 31);
            brandLabel.TabIndex = 1;
            brandLabel.Text = "Введите бренд ";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            idLabel.Location = new Point(12, 9);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(128, 31);
            idLabel.TabIndex = 0;
            idLabel.Text = "Введите id";
            // 
            // AddForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(241, 421);
            Controls.Add(panel1);
            Name = "AddForm";
            Text = "AddForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label yearLabel;
        private Label colorLabel;
        private Label brandLabel;
        private Label idLabel;
        private TextBox yearTextBox;
        private TextBox colorTextBox;
        private TextBox brandTextBox;
        private TextBox idTextBox;
        private Button saveCarButton;
        private Button exitButton;
    }
}