namespace building_organizations.EntityForms
{
    partial class building_material
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
            button4.Location = new Point(778, 386);
            button4.Name = "button4";
            button4.Size = new Size(288, 46);
            button4.TabIndex = 17;
            button4.Text = "Удалить";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(249, 386);
            button3.Name = "button3";
            button3.Size = new Size(263, 46);
            button3.TabIndex = 16;
            button3.Text = "Добавить";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(167, 336);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 15;
            label2.Text = "name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 336);
            label1.Name = "label1";
            label1.Size = new Size(22, 20);
            label1.TabIndex = 14;
            label1.Text = "id";
            // 
            // button2
            // 
            button2.Location = new Point(8, 386);
            button2.Name = "button2";
            button2.Size = new Size(235, 46);
            button2.TabIndex = 13;
            button2.Text = "Обновить";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(518, 386);
            button1.Name = "button1";
            button1.Size = new Size(254, 46);
            button1.TabIndex = 12;
            button1.Text = "Изменить";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(209, 333);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(134, 27);
            textBox2.TabIndex = 11;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(36, 333);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 10;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(17, 18);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1049, 295);
            dataGridView1.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(349, 339);
            label3.Name = "label3";
            label3.Size = new Size(103, 20);
            label3.TabIndex = 19;
            label3.Text = "stock_quantity";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(457, 336);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(134, 27);
            textBox3.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(592, 336);
            label4.Name = "label4";
            label4.Size = new Size(34, 20);
            label4.TabIndex = 21;
            label4.Text = "unit";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(638, 333);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(134, 27);
            textBox4.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(778, 335);
            label5.Name = "label5";
            label5.Size = new Size(107, 20);
            label5.TabIndex = 23;
            label5.Text = "purchase_price";
            label5.Click += label5_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(891, 333);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(134, 27);
            textBox5.TabIndex = 22;
            // 
            // building_material
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1072, 450);
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
            Name = "building_material";
            Text = "Стройматериалы";
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