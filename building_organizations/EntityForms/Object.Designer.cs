﻿namespace building_organizations.EntityForms
{
    partial class Object
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
            button4 = new Button();
            button3 = new Button();
            label2 = new Label();
            label1 = new Label();
            button2 = new Button();
            button1 = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            label5 = new Label();
            textBox5 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button4
            // 
            button4.Location = new Point(743, 392);
            button4.Name = "button4";
            button4.Size = new Size(255, 46);
            button4.TabIndex = 25;
            button4.Text = "Удалить";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(256, 392);
            button3.Name = "button3";
            button3.Size = new Size(243, 46);
            button3.TabIndex = 24;
            button3.Text = "Добавить";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(114, 342);
            label2.Name = "label2";
            label2.Size = new Size(94, 20);
            label2.TabIndex = 23;
            label2.Text = "object_name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(-2, 342);
            label1.Name = "label1";
            label1.Size = new Size(22, 20);
            label1.TabIndex = 22;
            label1.Text = "id";
            // 
            // button2
            // 
            button2.Location = new Point(18, 392);
            button2.Name = "button2";
            button2.Size = new Size(232, 46);
            button2.TabIndex = 21;
            button2.Text = "Найти";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(505, 392);
            button1.Name = "button1";
            button1.Size = new Size(232, 46);
            button1.TabIndex = 20;
            button1.Text = "Изменить";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(214, 339);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(96, 27);
            textBox2.TabIndex = 19;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(18, 339);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(90, 27);
            textBox1.TabIndex = 18;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(7, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1011, 295);
            dataGridView1.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(315, 338);
            label3.Name = "label3";
            label3.Size = new Size(105, 20);
            label3.TabIndex = 27;
            label3.Text = "house_number";
            label3.Click += label3_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(420, 339);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(79, 27);
            textBox3.TabIndex = 26;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(505, 341);
            label4.Name = "label4";
            label4.Size = new Size(89, 20);
            label4.TabIndex = 29;
            label4.Text = "street_name";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(600, 339);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(147, 27);
            textBox4.TabIndex = 28;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(758, 344);
            label5.Name = "label5";
            label5.Size = new Size(75, 20);
            label5.TabIndex = 31;
            label5.Text = "city_name";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(839, 338);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(134, 27);
            textBox5.TabIndex = 30;
            // 
            // Object
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1024, 450);
            Controls.Add(label5);
            Controls.Add(textBox5);
            Controls.Add(label4);
            Controls.Add(textBox4);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Name = "Object";
            Text = "Объект";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button4;
        private Button button3;
        private Label label2;
        private Label label1;
        private Button button2;
        private Button button1;
        private TextBox textBox2;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox4;
        private Label label5;
        private TextBox textBox5;
    }
}