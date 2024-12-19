namespace building_organizations
{
    partial class MainMenucs
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
            menuStrip1 = new MenuStrip();
            разноеToolStripMenuItem = new ToolStripMenuItem();
            changeRoleToolStripMenuItem = new ToolStripMenuItem();
            changeToolStripMenuItem = new ToolStripMenuItem();
            ObjectToolStripMenuItem = new ToolStripMenuItem();
            Supplyer = new ToolStripMenuItem();
            Bulding_materials = new ToolStripMenuItem();
            workers = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            DocumentToolStripMenuItem = new ToolStripMenuItem();
            work_on_object = new ToolStripMenuItem();
            заявкаToolStripMenuItem = new ToolStripMenuItem();
            SpravochnicToolStripMenuItem = new ToolStripMenuItem();
            City = new ToolStripMenuItem();
            Street = new ToolStripMenuItem();
            bank = new ToolStripMenuItem();
            delivery = new ToolStripMenuItem();
            work_type = new ToolStripMenuItem();
            unit_of_measurement = new ToolStripMenuItem();
            specialization = new ToolStripMenuItem();
            windowToolStripMenuItem = new ToolStripMenuItem();
            справкаToolStripMenuItem = new ToolStripMenuItem();
            AProgrammToolStripMenuItem = new ToolStripMenuItem();
            SoderzhanieToolStripMenuItem = new ToolStripMenuItem();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            объектToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { разноеToolStripMenuItem, ObjectToolStripMenuItem, DocumentToolStripMenuItem, SpravochnicToolStripMenuItem, windowToolStripMenuItem, справкаToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1006, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // разноеToolStripMenuItem
            // 
            разноеToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { changeRoleToolStripMenuItem, changeToolStripMenuItem });
            разноеToolStripMenuItem.Name = "разноеToolStripMenuItem";
            разноеToolStripMenuItem.Size = new Size(72, 24);
            разноеToolStripMenuItem.Text = "Разное";
            // 
            // changeRoleToolStripMenuItem
            // 
            changeRoleToolStripMenuItem.Name = "changeRoleToolStripMenuItem";
            changeRoleToolStripMenuItem.Size = new Size(207, 26);
            changeRoleToolStripMenuItem.Text = "Сменить роль";
            changeRoleToolStripMenuItem.Click += changeRoleToolStripMenuItem_Click;
            // 
            // changeToolStripMenuItem
            // 
            changeToolStripMenuItem.Name = "changeToolStripMenuItem";
            changeToolStripMenuItem.Size = new Size(207, 26);
            changeToolStripMenuItem.Text = "Сменить пароль";
            changeToolStripMenuItem.Click += сменитьПарольToolStripMenuItem_Click;
            // 
            // ObjectToolStripMenuItem
            // 
            ObjectToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { Supplyer, Bulding_materials, workers, toolStripMenuItem1, объектToolStripMenuItem });
            ObjectToolStripMenuItem.Name = "ObjectToolStripMenuItem";
            ObjectToolStripMenuItem.Size = new Size(125, 24);
            ObjectToolStripMenuItem.Text = "Строительство";
            // 
            // Supplyer
            // 
            Supplyer.Name = "Supplyer";
            Supplyer.Size = new Size(224, 26);
            Supplyer.Text = "Поставщик";
            Supplyer.Click += Supplyer_Click;
            // 
            // Bulding_materials
            // 
            Bulding_materials.Name = "Bulding_materials";
            Bulding_materials.Size = new Size(224, 26);
            Bulding_materials.Text = "Стройматериалы";
            Bulding_materials.Click += Bulding_materials_Click_1;
            // 
            // workers
            // 
            workers.Name = "workers";
            workers.Size = new Size(224, 26);
            workers.Text = "Рабочие";
            workers.Click += workers_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(224, 26);
            toolStripMenuItem1.Text = "Бригада";
            toolStripMenuItem1.Click += brigade_Click;
            // 
            // DocumentToolStripMenuItem
            // 
            DocumentToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { work_on_object, заявкаToolStripMenuItem });
            DocumentToolStripMenuItem.Name = "DocumentToolStripMenuItem";
            DocumentToolStripMenuItem.Size = new Size(101, 24);
            DocumentToolStripMenuItem.Text = "Документы";
            // 
            // work_on_object
            // 
            work_on_object.Name = "work_on_object";
            work_on_object.Size = new Size(168, 26);
            work_on_object.Text = "Учет работ";
            work_on_object.Click += work_on_object_Click_1;
            // 
            // заявкаToolStripMenuItem
            // 
            заявкаToolStripMenuItem.Name = "заявкаToolStripMenuItem";
            заявкаToolStripMenuItem.Size = new Size(168, 26);
            заявкаToolStripMenuItem.Text = "заявка";
            // 
            // SpravochnicToolStripMenuItem
            // 
            SpravochnicToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { City, Street, bank, delivery, work_type, unit_of_measurement, specialization });
            SpravochnicToolStripMenuItem.Name = "SpravochnicToolStripMenuItem";
            SpravochnicToolStripMenuItem.Size = new Size(108, 24);
            SpravochnicToolStripMenuItem.Text = "Справочник";
            // 
            // City
            // 
            City.Name = "City";
            City.Size = new Size(300, 26);
            City.Text = "Город";
            City.Click += cityToolStripMenuItem_Click;
            // 
            // Street
            // 
            Street.Name = "Street";
            Street.Size = new Size(300, 26);
            Street.Text = "Улица";
            Street.Click += Street_Click;
            // 
            // bank
            // 
            bank.Name = "bank";
            bank.Size = new Size(300, 26);
            bank.Text = "Банк";
            bank.Click += bank_Click;
            // 
            // delivery
            // 
            delivery.Name = "delivery";
            delivery.Size = new Size(300, 26);
            delivery.Text = "Поставка";
            delivery.Click += delivery_Click;
            // 
            // work_type
            // 
            work_type.Name = "work_type";
            work_type.Size = new Size(300, 26);
            work_type.Text = "Вид работы";
            work_type.Click += work_type_Click;
            // 
            // unit_of_measurement
            // 
            unit_of_measurement.Name = "unit_of_measurement";
            unit_of_measurement.Size = new Size(300, 26);
            unit_of_measurement.Text = "Измерение стройматериалов";
            unit_of_measurement.Click += unit_of_measurement_Click;
            // 
            // specialization
            // 
            specialization.Name = "specialization";
            specialization.Size = new Size(300, 26);
            specialization.Text = "Специализация(рабочих)";
            specialization.Click += specialization_Click;
            // 
            // windowToolStripMenuItem
            // 
            windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            windowToolStripMenuItem.Size = new Size(59, 24);
            windowToolStripMenuItem.Text = "Окно";
            windowToolStripMenuItem.Click += windowToolStripMenuItem_Click;
            // 
            // справкаToolStripMenuItem
            // 
            справкаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { AProgrammToolStripMenuItem, SoderzhanieToolStripMenuItem });
            справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            справкаToolStripMenuItem.Size = new Size(81, 24);
            справкаToolStripMenuItem.Text = "Справка";
            // 
            // AProgrammToolStripMenuItem
            // 
            AProgrammToolStripMenuItem.Name = "AProgrammToolStripMenuItem";
            AProgrammToolStripMenuItem.Size = new Size(187, 26);
            AProgrammToolStripMenuItem.Text = "О программе";
            // 
            // SoderzhanieToolStripMenuItem
            // 
            SoderzhanieToolStripMenuItem.Name = "SoderzhanieToolStripMenuItem";
            SoderzhanieToolStripMenuItem.Size = new Size(187, 26);
            SoderzhanieToolStripMenuItem.Text = "Содержание";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.EditMode = DataGridViewEditMode.EditOnEnter;
            dataGridView1.Location = new Point(0, 32);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(788, 342);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button1
            // 
            button1.Location = new Point(794, 329);
            button1.Name = "button1";
            button1.Size = new Size(200, 45);
            button1.TabIndex = 2;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(794, 265);
            button2.Name = "button2";
            button2.Size = new Size(200, 45);
            button2.TabIndex = 3;
            button2.Text = "Удалить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(794, 205);
            button3.Name = "button3";
            button3.Size = new Size(200, 45);
            button3.TabIndex = 4;
            button3.Text = "Изменить";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(794, 138);
            button4.Name = "button4";
            button4.Size = new Size(200, 45);
            button4.TabIndex = 5;
            button4.Text = "Поиск";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(794, 53);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 27);
            textBox1.TabIndex = 6;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(794, 95);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(200, 28);
            comboBox1.TabIndex = 7;
            // 
            // объектToolStripMenuItem
            // 
            объектToolStripMenuItem.Name = "объектToolStripMenuItem";
            объектToolStripMenuItem.Size = new Size(224, 26);
            объектToolStripMenuItem.Text = "Объект";
            объектToolStripMenuItem.Click += объектToolStripMenuItem_Click;
            // 
            // MainMenucs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 386);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainMenucs";
            Text = "Строительная организация";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem разноеToolStripMenuItem;
        private ToolStripMenuItem ObjectToolStripMenuItem;
        private ToolStripMenuItem DocumentToolStripMenuItem;
        private ToolStripMenuItem SpravochnicToolStripMenuItem;
        private ToolStripMenuItem windowToolStripMenuItem;
        private ToolStripMenuItem City;
        private ToolStripMenuItem Street;
        private ToolStripMenuItem bank;
        private ToolStripMenuItem changeRoleToolStripMenuItem;
        private ToolStripMenuItem справкаToolStripMenuItem;
        private ToolStripMenuItem AProgrammToolStripMenuItem;
        private ToolStripMenuItem SoderzhanieToolStripMenuItem;
        private DataGridView dataGridView1;
        private ToolStripMenuItem changeToolStripMenuItem;
        private ToolStripMenuItem delivery;
        private ToolStripMenuItem work_type;
        private ToolStripMenuItem unit_of_measurement;
        private ToolStripMenuItem specialization;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private ToolStripMenuItem Supplyer;
        private ToolStripMenuItem Bulding_materials;
        private ToolStripMenuItem workers;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem work_on_object;
        private ToolStripMenuItem заявкаToolStripMenuItem;
        private ToolStripMenuItem объектToolStripMenuItem;
    }
}