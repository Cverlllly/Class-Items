using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProsimDeli
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            ItemsDatabase itemsdatabase = new ItemsDatabase();
            List<Item> a = itemsdatabase.ReadItems();
            foreach(var l in a)
            {
                listBox1.Items.Add(l);

            }

        }
        private string ja;
        private string ime;
        private string cena;
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                var neki = listBox1.Text.Split(' ');
                ja = neki[0];
                ime = neki[3];
                cena = neki[6];

                textBox2.Text = ime;
                textBox3.Text = cena;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Item doesn't exists", "Index out of bounds",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }   

        private void delete_button_Click(object sender, EventArgs e)
        {
            try
            {
                int ne = int.Parse(ja);
                ItemsDatabase itemdatabase = new ItemsDatabase();
                itemdatabase.DeleteItem(ne);
                listBox1.Items.Clear();
                List<Item> a = itemdatabase.ReadItems();
                foreach (var l in a)
                {
                    listBox1.Items.Add(l);

                }
            }
            catch (Exception ex) { 
                MessageBox.Show(ex.Message);
            }
        }

        private void sv_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(textBox2.Text is "") && !(textBox2.Text is ""))
                {
                    string a = textBox2.Text;
                    string b = textBox3.Text; ;
                    ItemsDatabase itemdatabase = new ItemsDatabase();
                    itemdatabase.SaveItem(a, b); 
                }
                else
                {
                    MessageBox.Show("You left an empty field", "Empty field",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string tb = textBox1.Text;
                int ne = int.Parse(tb);
                listBox1.Items.Clear();
                ItemsDatabase itemsdatabase = new ItemsDatabase();
                List<Item> a = itemsdatabase.Readitem(ne);
                foreach (var l in a)
                {
                    listBox1.Items.Add(l);
                }

                if (listBox1.Items.Count is 0)
                {
                    MessageBox.Show("ID doesn't exist", "ID not found",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ID is either empty or doesn't exist", "ID not found",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void edit_button_Click(object sender, EventArgs e)
        {

            try
            {
                if (!(textBox2.Text is "") && !(textBox2.Text is ""))
                {
                    int ne = int.Parse(ja);
                    string neki = textBox2.Text;
                    string price = textBox3.Text;
                    ItemsDatabase itemdatabase = new ItemsDatabase();
                    itemdatabase.UpdateItem(ne, neki, price);
                }
                else
                {
                    MessageBox.Show("You left an empty field", "Empty field",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            ItemsDatabase itemsdatabase = new ItemsDatabase();
            List<Item> a = itemsdatabase.ReadItems();
            foreach (var l in a)
            {
                listBox1.Items.Add(l);

            }
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";

        }
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, MouseEventArgs e)
        {
            listBox1.Items.Clear();
            ItemsDatabase itemsdatabase = new ItemsDatabase();
            List<Item> a = itemsdatabase.ReadItems();
            foreach (var l in a)
            {
                listBox1.Items.Add(l);

            }
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";

        }
    }
}
