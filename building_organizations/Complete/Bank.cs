﻿using building_organizations.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace building_organizations.EntityForms
{

    public partial class Bank : Form
    {
        DatabaseController database = new DatabaseController();
        public Bank()
        {
            InitializeComponent();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                object[] values = { Convert.ToInt32(textBox1.Text), textBox2.Text };
                string[] columns = { label1.Text, label2.Text };

                //database.Add_to_DataBase("bank", values, columns);

                MessageBox.Show("Record added successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] strings = { label2.Text };
            object[] ob = { textBox2.Text };
            try
            {
                //database.UpdatetFromDataBase("bank", strings, textBox1.Text, ob);
            }
            catch
            {
                MessageBox.Show("Invalid bank: ");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //database.SelectRawFromDataBase("bank", dataGridView1);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
