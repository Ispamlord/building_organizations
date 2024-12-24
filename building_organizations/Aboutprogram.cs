using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace building_organizations
{
    public partial class Aboutprogram : Form
    {
        public Aboutprogram()
        {
            InitializeComponent();
        }

        private Label label1;

        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 18F);
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(187, 37);
            label1.TabIndex = 0;
            label1.Text = "О программе:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Impact", 16F);
            label2.Location = new Point(81, 91);
            label2.Name = "label2";
            label2.Size = new Size(339, 34);
            label2.TabIndex = 2;
            label2.Text = "Строительная организация";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Impact", 14F);
            label3.Location = new Point(3, 157);
            label3.Name = "label3";
            label3.Size = new Size(135, 29);
            label3.TabIndex = 3;
            label3.Text = "Версия:1.0.0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Impact", 14F);
            label4.Location = new Point(3, 198);
            label4.Name = "label4";
            label4.Size = new Size(378, 29);
            label4.TabIndex = 4;
            label4.Text = "Автор: Серов Данил Александрович";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Impact", 14F);
            label5.Location = new Point(3, 265);
            label5.Name = "label5";
            label5.Size = new Size(445, 29);
            label5.TabIndex = 5;
            label5.Text = "Система для управления строительством";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Impact", 14F);
            label6.Location = new Point(3, 307);
            label6.Name = "label6";
            label6.Size = new Size(444, 29);
            label6.TabIndex = 6;
            label6.Text = "Проверяющий: Антонянц Егор Николаевич";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Impact", 14F);
            label7.Location = new Point(3, 373);
            label7.Name = "label7";
            label7.Size = new Size(361, 29);
            label7.TabIndex = 7;
            label7.Text = "Email: serov-danil-garena@inbox,ru";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Impact", 14F);
            label8.Location = new Point(190, 443);
            label8.Name = "label8";
            label8.Size = new Size(78, 29);
            label8.TabIndex = 8;
            label8.Text = "2024 г.";
            // 
            // Aboutprogram
            // 
            BackColor = Color.Yellow;
            ClientSize = new Size(501, 481);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Aboutprogram";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;

        private void Aboutprogram_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
