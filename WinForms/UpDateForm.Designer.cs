namespace WinForms
{
    partial class UpDateForm
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
            exbutton = new Button();
            changebutton = new Button();
            listButton = new Button();
            idlabel = new Label();
            idtextBox = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Controls.Add(exbutton);
            panel1.Controls.Add(changebutton);
            panel1.Controls.Add(listButton);
            panel1.Controls.Add(idlabel);
            panel1.Controls.Add(idtextBox);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(418, 197);
            panel1.TabIndex = 0;
            // 
            // exbutton
            // 
            exbutton.Location = new Point(113, 145);
            exbutton.Name = "exbutton";
            exbutton.Size = new Size(179, 29);
            exbutton.TabIndex = 4;
            exbutton.Text = "Назад";
            exbutton.UseVisualStyleBackColor = true;
            exbutton.Click += exbutton_Click;
            // 
            // changebutton
            // 
            changebutton.Location = new Point(217, 110);
            changebutton.Name = "changebutton";
            changebutton.Size = new Size(179, 29);
            changebutton.TabIndex = 3;
            changebutton.Text = "Изменить";
            changebutton.UseVisualStyleBackColor = true;
            changebutton.Click += button2_Click;
            // 
            // listButton
            // 
            listButton.Location = new Point(12, 110);
            listButton.Name = "listButton";
            listButton.Size = new Size(179, 29);
            listButton.TabIndex = 2;
            listButton.Text = "Показать список";
            listButton.UseVisualStyleBackColor = true;
            listButton.Click += listButton_Click;
            // 
            // idlabel
            // 
            idlabel.AutoSize = true;
            idlabel.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            idlabel.Location = new Point(30, 32);
            idlabel.Name = "idlabel";
            idlabel.Size = new Size(238, 25);
            idlabel.TabIndex = 1;
            idlabel.Text = "Введите id для изменения";
            
            // 
            // idtextBox
            // 
            idtextBox.Location = new Point(12, 77);
            idtextBox.Name = "idtextBox";
            idtextBox.Size = new Size(384, 27);
            idtextBox.TabIndex = 0;
            // 
            // UpDateForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(418, 197);
            Controls.Add(panel1);
            Name = "UpDateForm";
            Text = "UpDateForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label idlabel;
        private TextBox idtextBox;
        private Button exbutton;
        private Button changebutton;
        private Button listButton;
    }
}