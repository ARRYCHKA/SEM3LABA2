namespace WinForms
{
    partial class RemoveForm
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
            delitButton = new Button();
            listButton = new Button();
            Labell = new Label();
            idText = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Controls.Add(exButton);
            panel1.Controls.Add(delitButton);
            panel1.Controls.Add(listButton);
            panel1.Controls.Add(Labell);
            panel1.Controls.Add(idText);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(393, 186);
            panel1.TabIndex = 0;
            // 
            // exButton
            // 
            exButton.Location = new Point(114, 148);
            exButton.Name = "exButton";
            exButton.Size = new Size(159, 29);
            exButton.TabIndex = 4;
            exButton.Text = "Назад";
            exButton.UseVisualStyleBackColor = true;
            exButton.Click += exButton_Click;
            // 
            // delitButton
            // 
            delitButton.Location = new Point(215, 113);
            delitButton.Name = "delitButton";
            delitButton.Size = new Size(159, 29);
            delitButton.TabIndex = 3;
            delitButton.Text = "Удалить";
            delitButton.UseVisualStyleBackColor = true;
            delitButton.Click += delitButton_Click;
            // 
            // listButton
            // 
            listButton.Location = new Point(14, 113);
            listButton.Name = "listButton";
            listButton.Size = new Size(159, 29);
            listButton.TabIndex = 2;
            listButton.Text = "Показать список";
            listButton.UseVisualStyleBackColor = true;
            listButton.Click += listButton_Click;
            // 
            // Labell
            // 
            Labell.AutoSize = true;
            Labell.Location = new Point(13, 23);
            Labell.Name = "Labell";
            Labell.Size = new Size(361, 20);
            Labell.TabIndex = 1;
            Labell.Text = "Введите id автомобиля которого хотитите удалить";
            // 
            // idText
            // 
            idText.Location = new Point(14, 68);
            idText.Name = "idText";
            idText.Size = new Size(360, 27);
            idText.TabIndex = 0;
            // 
            // RemoveForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(393, 186);
            Controls.Add(panel1);
            Name = "RemoveForm";
            Text = "RemoveForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox idText;
        private Label Labell;
        private Button exButton;
        private Button delitButton;
        private Button listButton;
    }
}