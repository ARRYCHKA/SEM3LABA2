namespace WinForms
{
    partial class ChangeForm
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
            newBrandText = new TextBox();
            newColorText = new TextBox();
            newYearText = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            savebutton = new Button();
            exbutton = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Controls.Add(exbutton);
            panel1.Controls.Add(savebutton);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(newYearText);
            panel1.Controls.Add(newColorText);
            panel1.Controls.Add(newBrandText);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(294, 310);
            panel1.TabIndex = 0;
            // 
            // newBrandText
            // 
            newBrandText.Location = new Point(9, 52);
            newBrandText.Name = "newBrandText";
            newBrandText.Size = new Size(270, 27);
            newBrandText.TabIndex = 0;
            // 
            // newColorText
            // 
            newColorText.Location = new Point(9, 123);
            newColorText.Name = "newColorText";
            newColorText.Size = new Size(270, 27);
            newColorText.TabIndex = 1;
            // 
            // newYearText
            // 
            newYearText.Location = new Point(9, 197);
            newYearText.Name = "newYearText";
            newYearText.Size = new Size(270, 27);
            newYearText.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 29);
            label1.Name = "label1";
            label1.Size = new Size(162, 20);
            label1.TabIndex = 3;
            label1.Text = "Введите новый бренд";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 100);
            label2.Name = "label2";
            label2.Size = new Size(150, 20);
            label2.TabIndex = 4;
            label2.Text = "Введите новый цвет";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 174);
            label3.Name = "label3";
            label3.Size = new Size(142, 20);
            label3.TabIndex = 5;
            label3.Text = "Введите новый год";
            // 
            // savebutton
            // 
            savebutton.Location = new Point(12, 239);
            savebutton.Name = "savebutton";
            savebutton.Size = new Size(270, 29);
            savebutton.TabIndex = 6;
            savebutton.Text = "Сохранить";
            savebutton.UseVisualStyleBackColor = true;
            savebutton.Click += button1_Click;
            // 
            // exbutton
            // 
            exbutton.Location = new Point(12, 274);
            exbutton.Name = "exbutton";
            exbutton.Size = new Size(270, 29);
            exbutton.TabIndex = 7;
            exbutton.Text = "Назад";
            exbutton.UseVisualStyleBackColor = true;
            // 
            // ChangeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(294, 310);
            Controls.Add(panel1);
            Name = "ChangeForm";
            Text = "ChangeForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button exbutton;
        private Button savebutton;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox newYearText;
        private TextBox newColorText;
        private TextBox newBrandText;
    }
}