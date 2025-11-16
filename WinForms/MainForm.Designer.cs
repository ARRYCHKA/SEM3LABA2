namespace WinForms
{
    partial class MainForm
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
            panel2 = new Panel();
            yaerButton = new Button();
            colorButton = new Button();
            updateButton = new Button();
            readButton = new Button();
            removeButton = new Button();
            closeButton = new Button();
            addButton = new Button();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.RosyBrown;
            panel2.Controls.Add(yaerButton);
            panel2.Controls.Add(colorButton);
            panel2.Controls.Add(updateButton);
            panel2.Controls.Add(readButton);
            panel2.Controls.Add(removeButton);
            panel2.Controls.Add(closeButton);
            panel2.Controls.Add(addButton);
            panel2.Dock = DockStyle.Fill;
            panel2.ForeColor = SystemColors.ControlText;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(280, 417);
            panel2.TabIndex = 0;
            // 
            // yaerButton
            // 
            yaerButton.BackColor = Color.White;
            yaerButton.Font = new Font("Bauhaus 93", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            yaerButton.Location = new Point(33, 232);
            yaerButton.Name = "yaerButton";
            yaerButton.Size = new Size(207, 38);
            yaerButton.TabIndex = 6;
            yaerButton.Text = "Поиск по году";
            yaerButton.UseVisualStyleBackColor = false;
            yaerButton.Click += yaerButton_Click;
            // 
            // colorButton
            // 
            colorButton.BackColor = Color.White;
            colorButton.Font = new Font("Bauhaus 93", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            colorButton.Location = new Point(33, 188);
            colorButton.Name = "colorButton";
            colorButton.Size = new Size(207, 38);
            colorButton.TabIndex = 5;
            colorButton.Text = "Поиск по цвету";
            colorButton.UseVisualStyleBackColor = false;
            colorButton.Click += colorButton_Click;
            // 
            // updateButton
            // 
            updateButton.BackColor = Color.White;
            updateButton.Font = new Font("Bauhaus 93", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            updateButton.Location = new Point(33, 144);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(207, 38);
            updateButton.TabIndex = 4;
            updateButton.Text = "Изменение";
            updateButton.UseVisualStyleBackColor = false;
            updateButton.Click += updateButton_Click;
            // 
            // readButton
            // 
            readButton.BackColor = Color.White;
            readButton.Font = new Font("Bauhaus 93", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            readButton.Location = new Point(33, 100);
            readButton.Name = "readButton";
            readButton.Size = new Size(207, 38);
            readButton.TabIndex = 3;
            readButton.Text = "Чтение";
            readButton.UseVisualStyleBackColor = false;
            readButton.Click += readButton_Click;
            // 
            // removeButton
            // 
            removeButton.BackColor = Color.White;
            removeButton.Font = new Font("Bauhaus 93", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            removeButton.Location = new Point(33, 56);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(207, 38);
            removeButton.TabIndex = 2;
            removeButton.Text = "Удалить";
            removeButton.UseVisualStyleBackColor = false;
            removeButton.Click += removeButton_Click;
            // 
            // closeButton
            // 
            closeButton.BackColor = Color.White;
            closeButton.Font = new Font("Showcard Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            closeButton.Location = new Point(33, 362);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(207, 34);
            closeButton.TabIndex = 1;
            closeButton.Text = "Выход:(";
            closeButton.UseVisualStyleBackColor = false;
            closeButton.Click += closeButton_Click;
            // 
            // addButton
            // 
            addButton.BackColor = Color.White;
            addButton.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addButton.Location = new Point(33, 12);
            addButton.Name = "addButton";
            addButton.Size = new Size(207, 38);
            addButton.TabIndex = 0;
            addButton.Text = "Добавить";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += addButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(280, 417);
            Controls.Add(panel2);
            Name = "MainForm";
            Text = "MainForm";
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Button closeButton;
        private Button addButton;
        private Button removeButton;
        private Button readButton;
        private Button colorButton;
        private Button updateButton;
        private Button yaerButton;
    }
}