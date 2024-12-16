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
            настройкаToolStripMenuItem = new ToolStripMenuItem();
            поменятьЯзыкToolStripMenuItem = new ToolStripMenuItem();
            changeToolStripMenuItem = new ToolStripMenuItem();
            PeopleToolStripMenuItem = new ToolStripMenuItem();
            DocumentToolStripMenuItem = new ToolStripMenuItem();
            SpravochnicToolStripMenuItem = new ToolStripMenuItem();
            City = new ToolStripMenuItem();
            Street = new ToolStripMenuItem();
            bank = new ToolStripMenuItem();
            Supplyer = new ToolStripMenuItem();
            delivery = new ToolStripMenuItem();
            Bulding_materials = new ToolStripMenuItem();
            work_type = new ToolStripMenuItem();
            work_on_object = new ToolStripMenuItem();
            workers = new ToolStripMenuItem();
            brigade = new ToolStripMenuItem();
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
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { разноеToolStripMenuItem, PeopleToolStripMenuItem, DocumentToolStripMenuItem, SpravochnicToolStripMenuItem, windowToolStripMenuItem, справкаToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1006, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // разноеToolStripMenuItem
            // 
            разноеToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { changeRoleToolStripMenuItem, настройкаToolStripMenuItem, changeToolStripMenuItem });
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
            // настройкаToolStripMenuItem
            // 
            настройкаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { поменятьЯзыкToolStripMenuItem });
            настройкаToolStripMenuItem.Name = "настройкаToolStripMenuItem";
            настройкаToolStripMenuItem.Size = new Size(207, 26);
            настройкаToolStripMenuItem.Text = "Настройка";
            // 
            // поменятьЯзыкToolStripMenuItem
            // 
            поменятьЯзыкToolStripMenuItem.Name = "поменятьЯзыкToolStripMenuItem";
            поменятьЯзыкToolStripMenuItem.Size = new Size(199, 26);
            поменятьЯзыкToolStripMenuItem.Text = "Поменять язык";
            // 
            // changeToolStripMenuItem
            // 
            changeToolStripMenuItem.Name = "changeToolStripMenuItem";
            changeToolStripMenuItem.Size = new Size(207, 26);
            changeToolStripMenuItem.Text = "Сменить пароль";
            changeToolStripMenuItem.Click += сменитьПарольToolStripMenuItem_Click;
            // 
            // PeopleToolStripMenuItem
            // 
            PeopleToolStripMenuItem.Name = "PeopleToolStripMenuItem";
            PeopleToolStripMenuItem.Size = new Size(105, 24);
            PeopleToolStripMenuItem.Text = "Сотрудники";
            // 
            // DocumentToolStripMenuItem
            // 
            DocumentToolStripMenuItem.Name = "DocumentToolStripMenuItem";
            DocumentToolStripMenuItem.Size = new Size(101, 24);
            DocumentToolStripMenuItem.Text = "Документы";
            // 
            // SpravochnicToolStripMenuItem
            // 
            SpravochnicToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { City, Street, bank, Supplyer, delivery, Bulding_materials, work_type, work_on_object, workers, brigade, unit_of_measurement, specialization });
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
            // Supplyer
            // 
            Supplyer.Name = "Supplyer";
            Supplyer.Size = new Size(300, 26);
            Supplyer.Text = "Поставщик";
            Supplyer.Click += Supply_Click;
            // 
            // delivery
            // 
            delivery.Name = "delivery";
            delivery.Size = new Size(300, 26);
            delivery.Text = "Поставка";
            delivery.Click += delivery_Click;
            // 
            // Bulding_materials
            // 
            Bulding_materials.Name = "Bulding_materials";
            Bulding_materials.Size = new Size(300, 26);
            Bulding_materials.Text = "Стройматериалы";
            Bulding_materials.Click += Bulding_materials_Click;
            // 
            // work_type
            // 
            work_type.Name = "work_type";
            work_type.Size = new Size(300, 26);
            work_type.Text = "Вид работы";
            work_type.Click += work_type_Click;
            // 
            // work_on_object
            // 
            work_on_object.Name = "work_on_object";
            work_on_object.Size = new Size(300, 26);
            work_on_object.Text = "Учет работ";
            work_on_object.Click += work_on_object_Click;
            // 
            // workers
            // 
            workers.Name = "workers";
            workers.Size = new Size(300, 26);
            workers.Text = "Рабочие";
            workers.Click += workers_Click;
            // 
            // brigade
            // 
            brigade.Name = "brigade";
            brigade.Size = new Size(300, 26);
            brigade.Text = "Бригада";
            brigade.Click += brigade_Click;
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
            windowToolStripMenuItem.Size = new Size(82, 24);
            windowToolStripMenuItem.Text = "Консоль";
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
            dataGridView1.Location = new Point(0, 31);
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
            // 
            // button3
            // 
            button3.Location = new Point(794, 189);
            button3.Name = "button3";
            button3.Size = new Size(200, 45);
            button3.TabIndex = 4;
            button3.Text = "Изменить";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(794, 108);
            button4.Name = "button4";
            button4.Size = new Size(200, 45);
            button4.TabIndex = 5;
            button4.Text = "Поиск";
            button4.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(794, 53);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 27);
            textBox1.TabIndex = 6;
            // 
            // MainMenucs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 386);
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
        private ToolStripMenuItem PeopleToolStripMenuItem;
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
        private ToolStripMenuItem настройкаToolStripMenuItem;
        private ToolStripMenuItem поменятьЯзыкToolStripMenuItem;
        private DataGridView dataGridView1;
        private ToolStripMenuItem changeToolStripMenuItem;
        private ToolStripMenuItem Supplyer;
        private ToolStripMenuItem delivery;
        private ToolStripMenuItem Bulding_materials;
        private ToolStripMenuItem work_type;
        private ToolStripMenuItem work_on_object;
        private ToolStripMenuItem workers;
        private ToolStripMenuItem brigade;
        private ToolStripMenuItem unit_of_measurement;
        private ToolStripMenuItem specialization;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private TextBox textBox1;
    }
}