namespace building_organizations
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button2 = new Button();
            button1 = new Button();
            panel1 = new Panel();
            label3 = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Impact", 9F);
            textBox1.Location = new Point(302, 123);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(148, 39);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Impact", 9F);
            textBox2.Location = new Point(302, 181);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(148, 39);
            textBox2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 14F);
            label1.Location = new Point(223, 133);
            label1.Name = "label1";
            label1.Size = new Size(73, 29);
            label1.TabIndex = 3;
            label1.Text = "Логин";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Impact", 14F);
            label2.Location = new Point(208, 191);
            label2.Name = "label2";
            label2.Size = new Size(88, 29);
            label2.TabIndex = 4;
            label2.Text = "Пароль";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 128, 128);
            button2.Font = new Font("Impact", 16F);
            button2.Location = new Point(380, 284);
            button2.Name = "button2";
            button2.Size = new Size(160, 73);
            button2.TabIndex = 5;
            button2.Text = "Войти";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 128);
            button1.Font = new Font("Impact", 14F);
            button1.Location = new Point(203, 283);
            button1.Name = "button1";
            button1.Size = new Size(160, 73);
            button1.TabIndex = 6;
            button1.Text = "Регистрация";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 192, 255);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(-3, -5);
            panel1.Name = "panel1";
            panel1.Size = new Size(717, 93);
            panel1.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Impact", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(193, 0);
            label3.Name = "label3";
            label3.Size = new Size(350, 35);
            label3.TabIndex = 0;
            label3.Text = "Строительная организация";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Impact", 16.2F);
            label4.Location = new Point(237, 49);
            label4.Name = "label4";
            label4.Size = new Size(253, 35);
            label4.TabIndex = 1;
            label4.Text = "Добро пожаловать!";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 128, 255);
            ClientSize = new Size(708, 435);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Login";
            Text = "Авторитизация";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Button button2;
        private Button button1;
        private Panel panel1;
        private Label label3;
        private Label label4;
    }
}
