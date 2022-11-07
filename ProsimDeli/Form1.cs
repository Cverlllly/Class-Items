using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProsimDeli
{
    public partial class Form1 : Form
    {
        String std = "{0, -5}{1, -10}{2, -10}{3, -10}{4, -10}{5, -10}{6,-6}";
        String std1 = "{0, -7}{1, -9}{2, -12}{3, -12}{4, -9}{5, -9}{6,-6}";
        String std2 = "{0, -5}{1, -10}{2, -10}{3, -10}{4, -15}{5, -4}";
        String std3 = "{0, -5}{1, -10}{2, -10}{3, -10}";
        public Form1()
        {
            InitializeComponent();
            listBox1.Items.Add("Computer:");
            listBox1.Items.Add(String.Format(std, "ID", "Name", "Price", "Weight", "Cores", "RAM", "HDD"));
            ItemsDatabase itemsdatabase = new ItemsDatabase();
            List<Computer> a = itemsdatabase.AllItems();
            foreach(Computer l in a)
            {
                listBox1.Items.Add(String.Format(std1, l.ItemID, l.ItemName, l.Price+"€", l.Weight+"g", l.NoOFCores, l.AmounttOFRam+"MB", l.HDDSize+"GB"));
            }
            listBox1.Items.Add("Monitor:");
            listBox1.Items.Add(String.Format(std2,"ID", "Name", "Price", "Weight", "Resolution", "Type"));
            List<Monitor> monitor=itemsdatabase.AllItems_2();
            foreach(Monitor x in monitor)
            {
                listBox1.Items.Add(String.Format(std2, x.ItemID, x.ItemName, x.Price + "€", x.Weight + "g", x.monType, x.resolution));
            }
            listBox1.Items.Add("Hardware:");
            listBox1.Items.Add(String.Format(std3, "ID", "Name", "Price", "Weight"));
            List<HardwareItem> hard = itemsdatabase.AllItems_3();
            foreach(HardwareItem x in hard)
            {
                listBox1.Items.Add(String.Format(std2, x.ItemID, x.ItemName, x.Price + "€", x.Weight + "g"));
            }


        }
        private string ja;
        private string ime;
        private string cena;
        List<string> list = new List<string>();
        List<string> li = new List<string>();
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            { 
                var neki = listBox1.Text.Split(' ');
                foreach(string x in neki)
                {
                    if (x != "")
                    {
                        list.Add(x);
                    }
                }
                foreach (string i in list)
                {
                    if(i!=" ")
                    {
                        li.Add(i);
                    }
                }
                Console.WriteLine(li);
                ja = li[0];
                ime = li[1];
                cena = li[2];

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
                List<HardwareItem> a = itemdatabase.readItems();
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
            listBox1.Items.Add("Computer:");
            listBox1.Items.Add(String.Format(std, "ID", "Name", "Price", "Weight", "Cores", "RAM", "HDD"));
            ItemsDatabase itemsdatabase = new ItemsDatabase();
            List<Computer> a = itemsdatabase.AllItems();
            foreach (Computer l in a)
            {
                listBox1.Items.Add(String.Format(std1, l.ItemID, l.ItemName, l.Price + "€", l.Weight + "g", l.NoOFCores, l.AmounttOFRam + "MB", l.HDDSize + "GB"));
            }
            listBox1.Items.Add("Monitor:");
            listBox1.Items.Add(String.Format(std2, "ID", "Name", "Price", "Weight", "Resolution", "Type"));
            List<Monitor> monitor = itemsdatabase.AllItems_2();
            foreach (Monitor x in monitor)
            {
                listBox1.Items.Add(String.Format(std2, x.ItemID, x.ItemName, x.Price + "€", x.Weight + "g", x.monType, x.resolution));
            }
            listBox1.Items.Add("Hardware:");
            listBox1.Items.Add(String.Format(std3, "ID", "Name", "Price", "Weight"));
            List<HardwareItem> hard = itemsdatabase.AllItems_3();
            foreach (HardwareItem x in hard)
            {
                listBox1.Items.Add(String.Format(std2, x.ItemID, x.ItemName, x.Price + "€", x.Weight + "g"));
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
            listBox1.Items.Add("Computer:");
            listBox1.Items.Add(String.Format(std, "ID", "Name", "Price", "Weight", "Cores", "RAM", "HDD"));
            ItemsDatabase itemsdatabase = new ItemsDatabase();
            List<Computer> a = itemsdatabase.AllItems();
            foreach (Computer l in a)
            {
                listBox1.Items.Add(String.Format(std1, l.ItemID, l.ItemName, l.Price + "€", l.Weight + "g", l.NoOFCores, l.AmounttOFRam + "MB", l.HDDSize + "GB"));
            }
            listBox1.Items.Add("Monitor:");
            listBox1.Items.Add(String.Format(std2, "ID", "Name", "Price", "Weight", "Resolution", "Type"));
            List<Monitor> monitor = itemsdatabase.AllItems_2();
            foreach (Monitor x in monitor)
            {
                listBox1.Items.Add(String.Format(std2, x.ItemID, x.ItemName, x.Price + "€", x.Weight + "g", x.monType, x.resolution));
            }
            listBox1.Items.Add("Hardware:");
            listBox1.Items.Add(String.Format(std3, "ID", "Name", "Price", "Weight"));
            List<HardwareItem> hard = itemsdatabase.AllItems_3();
            foreach (HardwareItem x in hard)
            {
                listBox1.Items.Add(String.Format(std2, x.ItemID, x.ItemName, x.Price + "€", x.Weight + "g"));
            }

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";

        }


        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
