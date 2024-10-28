namespace form_Excursion
{
    partial class Form_Excursion
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
            comboBox1 = new ComboBox();
            button3 = new Button();
            button4 = new Button();
            label1 = new Label();
            button5 = new Button();
            button1 = new Button();
            button2 = new Button();
            button6 = new Button();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FlatStyle = FlatStyle.Popup;
            comboBox1.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(11, 53);
            comboBox1.Margin = new Padding(2, 1, 2, 1);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(234, 27);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button3
            // 
            button3.BackColor = Color.Honeydew;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(11, 154);
            button3.Margin = new Padding(2, 1, 2, 1);
            button3.Name = "button3";
            button3.Size = new Size(234, 40);
            button3.TabIndex = 4;
            button3.Text = "Ознакомиться с персоналом";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Honeydew;
            button4.FlatStyle = FlatStyle.Popup;
            button4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(11, 102);
            button4.Margin = new Padding(2, 1, 2, 1);
            button4.Name = "button4";
            button4.Size = new Size(234, 41);
            button4.TabIndex = 5;
            button4.Text = "Ознакомиться с кораблями";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(11, 32);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(153, 20);
            label1.TabIndex = 6;
            label1.Text = "Выберете экскурсию";
            // 
            // button5
            // 
            button5.FlatAppearance.BorderSize = 0;
            button5.ForeColor = Color.MidnightBlue;
            button5.Location = new Point(385, 1);
            button5.Name = "button5";
            button5.Size = new Size(100, 23);
            button5.TabIndex = 7;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Honeydew;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(262, 49);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(212, 40);
            button1.TabIndex = 8;
            button1.Text = "Посмотреть маршрут";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Honeydew;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(263, 102);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(212, 40);
            button2.TabIndex = 9;
            button2.Text = "Просмотреть рейсы";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.MistyRose;
            button6.FlatStyle = FlatStyle.Popup;
            button6.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            button6.Location = new Point(263, 154);
            button6.Margin = new Padding(2);
            button6.Name = "button6";
            button6.Size = new Size(212, 40);
            button6.TabIndex = 10;
            button6.Text = "Выход из сессии";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // Form_Excursion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(486, 208);
            Controls.Add(button6);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(button5);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(comboBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2, 1, 2, 1);
            Name = "Form_Excursion";
            Text = "Form_Excursion";
            Load += Form_Excursion_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Button button3;
        private Button button4;
        private Label label1;
        private Button button5;
        private Button button1;
        private Button button2;
        private Button button6;
    }
}