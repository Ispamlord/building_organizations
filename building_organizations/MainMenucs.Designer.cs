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
            материалыИПоставкиToolStripMenuItem = new ToolStripMenuItem();
            материалыToolStripMenuItem = new ToolStripMenuItem();
            бригадаToolStripMenuItem = new ToolStripMenuItem();
            рабочиеToolStripMenuItem = new ToolStripMenuItem();
            ObjectToolStripMenuItem = new ToolStripMenuItem();
            объектToolStripMenuItem = new ToolStripMenuItem();
            работаНаОбъектеToolStripMenuItem = new ToolStripMenuItem();
            поставщикToolStripMenuItem1 = new ToolStripMenuItem();
            заявкаToolStripMenuItem1 = new ToolStripMenuItem();
            tablepromToolStripMenuItem = new ToolStripMenuItem();
            бригадаИОбъектToolStripMenuItem = new ToolStripMenuItem();
            специализацияИРабочиеToolStripMenuItem = new ToolStripMenuItem();
            поставкаПоставщикToolStripMenuItem = new ToolStripMenuItem();
            материалыИОбъектToolStripMenuItem = new ToolStripMenuItem();
            бригадРабочиеToolStripMenuItem = new ToolStripMenuItem();
            DocumentToolStripMenuItem = new ToolStripMenuItem();
            SpravochnicToolStripMenuItem = new ToolStripMenuItem();
            City = new ToolStripMenuItem();
            Street = new ToolStripMenuItem();
            bank = new ToolStripMenuItem();
            delivery = new ToolStripMenuItem();
            work_type = new ToolStripMenuItem();
            unit_of_measurement = new ToolStripMenuItem();
            specialization = new ToolStripMenuItem();
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
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(128, 128, 255);
            menuStrip1.Font = new Font("Impact", 10F);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { разноеToolStripMenuItem, материалыИПоставкиToolStripMenuItem, ObjectToolStripMenuItem, tablepromToolStripMenuItem, DocumentToolStripMenuItem, SpravochnicToolStripMenuItem, справкаToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1006, 29);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // разноеToolStripMenuItem
            // 
            разноеToolStripMenuItem.BackColor = Color.FromArgb(192, 192, 255);
            разноеToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { changeRoleToolStripMenuItem, changeToolStripMenuItem });
            разноеToolStripMenuItem.Name = "разноеToolStripMenuItem";
            разноеToolStripMenuItem.Size = new Size(78, 25);
            разноеToolStripMenuItem.Text = "Разное";
            // 
            // changeRoleToolStripMenuItem
            // 
            changeRoleToolStripMenuItem.Name = "changeRoleToolStripMenuItem";
            changeRoleToolStripMenuItem.Size = new Size(217, 26);
            changeRoleToolStripMenuItem.Text = "Выйти";
            changeRoleToolStripMenuItem.Click += changeRoleToolStripMenuItem_Click;
            // 
            // changeToolStripMenuItem
            // 
            changeToolStripMenuItem.Name = "changeToolStripMenuItem";
            changeToolStripMenuItem.Size = new Size(217, 26);
            changeToolStripMenuItem.Text = "Сменить пароль";
            changeToolStripMenuItem.Click += сменитьПарольToolStripMenuItem_Click;
            // 
            // материалыИПоставкиToolStripMenuItem
            // 
            материалыИПоставкиToolStripMenuItem.BackColor = Color.FromArgb(192, 192, 255);
            материалыИПоставкиToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { материалыToolStripMenuItem, бригадаToolStripMenuItem, рабочиеToolStripMenuItem });
            материалыИПоставкиToolStripMenuItem.Name = "материалыИПоставкиToolStripMenuItem";
            материалыИПоставкиToolStripMenuItem.Size = new Size(218, 25);
            материалыИПоставкиToolStripMenuItem.Text = "Материалы и сотрудники";
            // 
            // материалыToolStripMenuItem
            // 
            материалыToolStripMenuItem.Name = "материалыToolStripMenuItem";
            материалыToolStripMenuItem.Size = new Size(226, 26);
            материалыToolStripMenuItem.Text = "Стройматериалы";
            материалыToolStripMenuItem.Click += Bulding_materials_Click_1;
            // 
            // бригадаToolStripMenuItem
            // 
            бригадаToolStripMenuItem.Name = "бригадаToolStripMenuItem";
            бригадаToolStripMenuItem.Size = new Size(226, 26);
            бригадаToolStripMenuItem.Text = "Бригада";
            бригадаToolStripMenuItem.Click += brigade_Click;
            // 
            // рабочиеToolStripMenuItem
            // 
            рабочиеToolStripMenuItem.Name = "рабочиеToolStripMenuItem";
            рабочиеToolStripMenuItem.Size = new Size(226, 26);
            рабочиеToolStripMenuItem.Text = "Рабочие";
            рабочиеToolStripMenuItem.Click += workers_Click;
            // 
            // ObjectToolStripMenuItem
            // 
            ObjectToolStripMenuItem.BackColor = Color.FromArgb(192, 192, 255);
            ObjectToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { объектToolStripMenuItem, работаНаОбъектеToolStripMenuItem, поставщикToolStripMenuItem1, заявкаToolStripMenuItem1 });
            ObjectToolStripMenuItem.Name = "ObjectToolStripMenuItem";
            ObjectToolStripMenuItem.Size = new Size(136, 25);
            ObjectToolStripMenuItem.Text = "Строительство";
            // 
            // объектToolStripMenuItem
            // 
            объектToolStripMenuItem.Name = "объектToolStripMenuItem";
            объектToolStripMenuItem.Size = new Size(232, 26);
            объектToolStripMenuItem.Text = "Объект";
            объектToolStripMenuItem.Click += объектToolStripMenuItem_Click;
            // 
            // работаНаОбъектеToolStripMenuItem
            // 
            работаНаОбъектеToolStripMenuItem.Name = "работаНаОбъектеToolStripMenuItem";
            работаНаОбъектеToolStripMenuItem.Size = new Size(232, 26);
            работаНаОбъектеToolStripMenuItem.Text = "Работа на объекте";
            работаНаОбъектеToolStripMenuItem.Click += работаНаОбъектеToolStripMenuItem_Click;
            // 
            // поставщикToolStripMenuItem1
            // 
            поставщикToolStripMenuItem1.Name = "поставщикToolStripMenuItem1";
            поставщикToolStripMenuItem1.Size = new Size(232, 26);
            поставщикToolStripMenuItem1.Text = "Поставщик";
            поставщикToolStripMenuItem1.Click += Supplyer_Click;
            // 
            // заявкаToolStripMenuItem1
            // 
            заявкаToolStripMenuItem1.Name = "заявкаToolStripMenuItem1";
            заявкаToolStripMenuItem1.Size = new Size(232, 26);
            заявкаToolStripMenuItem1.Text = "Заявка";
            заявкаToolStripMenuItem1.Click += RequestToolStripMenuItem1_Click;
            // 
            // tablepromToolStripMenuItem
            // 
            tablepromToolStripMenuItem.BackColor = Color.FromArgb(192, 192, 255);
            tablepromToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { бригадаИОбъектToolStripMenuItem, специализацияИРабочиеToolStripMenuItem, поставкаПоставщикToolStripMenuItem, материалыИОбъектToolStripMenuItem, бригадРабочиеToolStripMenuItem });
            tablepromToolStripMenuItem.Name = "tablepromToolStripMenuItem";
            tablepromToolStripMenuItem.Size = new Size(129, 25);
            tablepromToolStripMenuItem.Text = "Пром таблица";
            tablepromToolStripMenuItem.Click += tablepromToolStripMenuItem_Click;
            // 
            // бригадаИОбъектToolStripMenuItem
            // 
            бригадаИОбъектToolStripMenuItem.Name = "бригадаИОбъектToolStripMenuItem";
            бригадаИОбъектToolStripMenuItem.Size = new Size(295, 26);
            бригадаИОбъектToolStripMenuItem.Text = "Бригада и объект";
            бригадаИОбъектToolStripMenuItem.Click += бригадаИОбъектToolStripMenuItem_Click;
            // 
            // специализацияИРабочиеToolStripMenuItem
            // 
            специализацияИРабочиеToolStripMenuItem.Name = "специализацияИРабочиеToolStripMenuItem";
            специализацияИРабочиеToolStripMenuItem.Size = new Size(295, 26);
            специализацияИРабочиеToolStripMenuItem.Text = "Специализация и рабочие";
            специализацияИРабочиеToolStripMenuItem.Click += специализацияИРабочиеToolStripMenuItem_Click;
            // 
            // поставкаПоставщикToolStripMenuItem
            // 
            поставкаПоставщикToolStripMenuItem.Name = "поставкаПоставщикToolStripMenuItem";
            поставкаПоставщикToolStripMenuItem.Size = new Size(295, 26);
            поставкаПоставщикToolStripMenuItem.Text = "Поставка поставщик";
            поставкаПоставщикToolStripMenuItem.Click += поставкаПоставщикToolStripMenuItem_Click;
            // 
            // материалыИОбъектToolStripMenuItem
            // 
            материалыИОбъектToolStripMenuItem.Name = "материалыИОбъектToolStripMenuItem";
            материалыИОбъектToolStripMenuItem.Size = new Size(295, 26);
            материалыИОбъектToolStripMenuItem.Text = "материалы и объект";
            материалыИОбъектToolStripMenuItem.Click += материалыИОбъектToolStripMenuItem_Click;
            // 
            // бригадРабочиеToolStripMenuItem
            // 
            бригадРабочиеToolStripMenuItem.Name = "бригадРабочиеToolStripMenuItem";
            бригадРабочиеToolStripMenuItem.Size = new Size(295, 26);
            бригадРабочиеToolStripMenuItem.Text = "Бригад рабочие";
            бригадРабочиеToolStripMenuItem.Click += бригадРабочиеToolStripMenuItem_Click;
            // 
            // DocumentToolStripMenuItem
            // 
            DocumentToolStripMenuItem.BackColor = Color.FromArgb(192, 192, 255);
            DocumentToolStripMenuItem.Name = "DocumentToolStripMenuItem";
            DocumentToolStripMenuItem.Size = new Size(111, 25);
            DocumentToolStripMenuItem.Text = "Документы";
            DocumentToolStripMenuItem.Click += DocumentToolStripMenuItem_Click;
            // 
            // SpravochnicToolStripMenuItem
            // 
            SpravochnicToolStripMenuItem.BackColor = Color.FromArgb(192, 192, 255);
            SpravochnicToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { City, Street, bank, delivery, work_type, unit_of_measurement, specialization });
            SpravochnicToolStripMenuItem.Name = "SpravochnicToolStripMenuItem";
            SpravochnicToolStripMenuItem.Size = new Size(115, 25);
            SpravochnicToolStripMenuItem.Text = "Справочник";
            // 
            // City
            // 
            City.Name = "City";
            City.Size = new Size(318, 26);
            City.Text = "Город";
            City.Click += cityToolStripMenuItem_Click;
            // 
            // Street
            // 
            Street.Name = "Street";
            Street.Size = new Size(318, 26);
            Street.Text = "Улица";
            Street.Click += Street_Click;
            // 
            // bank
            // 
            bank.Name = "bank";
            bank.Size = new Size(318, 26);
            bank.Text = "Банк";
            bank.Click += bank_Click;
            // 
            // delivery
            // 
            delivery.Name = "delivery";
            delivery.Size = new Size(318, 26);
            delivery.Text = "Поставка";
            delivery.Click += delivery_Click;
            // 
            // work_type
            // 
            work_type.Name = "work_type";
            work_type.Size = new Size(318, 26);
            work_type.Text = "Вид работы";
            work_type.Click += work_type_Click;
            // 
            // unit_of_measurement
            // 
            unit_of_measurement.Name = "unit_of_measurement";
            unit_of_measurement.Size = new Size(318, 26);
            unit_of_measurement.Text = "Измерение стройматериалов";
            unit_of_measurement.Click += unit_of_measurement_Click;
            // 
            // specialization
            // 
            specialization.Name = "specialization";
            specialization.Size = new Size(318, 26);
            specialization.Text = "Специализация(рабочих)";
            specialization.Click += specialization_Click;
            // 
            // справкаToolStripMenuItem
            // 
            справкаToolStripMenuItem.BackColor = Color.FromArgb(192, 192, 255);
            справкаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { AProgrammToolStripMenuItem, SoderzhanieToolStripMenuItem });
            справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            справкаToolStripMenuItem.Size = new Size(87, 25);
            справкаToolStripMenuItem.Text = "Справка";
            // 
            // AProgrammToolStripMenuItem
            // 
            AProgrammToolStripMenuItem.Name = "AProgrammToolStripMenuItem";
            AProgrammToolStripMenuItem.Size = new Size(191, 26);
            AProgrammToolStripMenuItem.Text = "О программе";
            AProgrammToolStripMenuItem.Click += AProgrammToolStripMenuItem_Click;
            // 
            // SoderzhanieToolStripMenuItem
            // 
            SoderzhanieToolStripMenuItem.Name = "SoderzhanieToolStripMenuItem";
            SoderzhanieToolStripMenuItem.Size = new Size(191, 26);
            SoderzhanieToolStripMenuItem.Text = "Содержание";
            SoderzhanieToolStripMenuItem.Click += SoderzhanieToolStripMenuItem_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.FromArgb(192, 192, 255);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.EditMode = DataGridViewEditMode.EditOnEnter;
            dataGridView1.Location = new Point(0, 34);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(788, 359);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 128);
            button1.Font = new Font("Impact", 18F);
            button1.Location = new Point(794, 345);
            button1.Name = "button1";
            button1.Size = new Size(200, 47);
            button1.TabIndex = 2;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 128, 128);
            button2.Font = new Font("Impact", 18F);
            button2.Location = new Point(794, 278);
            button2.Name = "button2";
            button2.Size = new Size(200, 47);
            button2.TabIndex = 3;
            button2.Text = "Удалить";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(255, 128, 128);
            button3.Font = new Font("Impact", 18F);
            button3.Location = new Point(794, 215);
            button3.Name = "button3";
            button3.Size = new Size(200, 47);
            button3.TabIndex = 4;
            button3.Text = "Изменить";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(255, 128, 128);
            button4.Font = new Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(794, 145);
            button4.Name = "button4";
            button4.Size = new Size(200, 47);
            button4.TabIndex = 5;
            button4.Text = "Поиск";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(794, 56);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 28);
            textBox1.TabIndex = 6;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(794, 100);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(200, 29);
            comboBox1.TabIndex = 7;
            // 
            // MainMenucs
            // 
            AutoScaleDimensions = new SizeF(8F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 128, 255);
            ClientSize = new Size(1006, 405);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            Font = new Font("Impact", 10F);
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
        private ToolStripMenuItem объектToolStripMenuItem;
        private ToolStripMenuItem tablepromToolStripMenuItem;
        private ToolStripMenuItem работаНаОбъектеToolStripMenuItem;
        private ToolStripMenuItem бригадаИОбъектToolStripMenuItem;
        private ToolStripMenuItem специализацияИРабочиеToolStripMenuItem;
        private ToolStripMenuItem поставкаПоставщикToolStripMenuItem;
        private ToolStripMenuItem материалыИОбъектToolStripMenuItem;
        private ToolStripMenuItem бригадРабочиеToolStripMenuItem;
        private ToolStripMenuItem материалыИПоставкиToolStripMenuItem;
        private ToolStripMenuItem материалыToolStripMenuItem;
        private ToolStripMenuItem поставщикToolStripMenuItem1;
        private ToolStripMenuItem бригадаToolStripMenuItem;
        private ToolStripMenuItem рабочиеToolStripMenuItem;
        private ToolStripMenuItem заявкаToolStripMenuItem1;
    }
}