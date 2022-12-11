using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Windows.Forms;


namespace ProsimDeli
{
    public partial class Form1 : Form
    {

        Item i;
        ItemsDatabase id = new ItemsDatabase();
        public Form1()
        {
            InitializeComponent();
            monitor.Enabled=false;
            Software.Enabled = false;
            hardware.Enabled = false;
            Computer.Enabled = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void output_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Computers")
            {
                output.Clear();
                output.View = View.Details;
                output.Columns.Add("ID", 30, HorizontalAlignment.Center);
                output.Columns.Add("Name", 100, HorizontalAlignment.Center);
                output.Columns.Add("Price", 80, HorizontalAlignment.Center);
                output.Columns.Add("Weight", 80, HorizontalAlignment.Center);
                output.Columns.Add("Cores", 80, HorizontalAlignment.Center);
                output.Columns.Add("Ram", 80, HorizontalAlignment.Center);
                output.Columns.Add("HDD", 80, HorizontalAlignment.Center);
                var obj = id.ReadComputers();
                foreach (Computer i in obj)
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = i.ItemID.ToString();
                    lvi.SubItems.Add(i.ItemName);
                    lvi.SubItems.Add(i.Price.ToString() + "€");
                    lvi.SubItems.Add(i.Weight.ToString());
                    lvi.SubItems.Add(i.NoOFCores.ToString());
                    lvi.SubItems.Add(i.AmounttOFRam.ToString());
                    lvi.SubItems.Add(i.HDDSize.ToString());
                    output.Items.Add(lvi);

                }

            }
            else if (comboBox1.Text == "Monitors")
            {
                output.Clear();
                output.View = View.Details;
                output.Columns.Add("ID", 30, HorizontalAlignment.Center);
                output.Columns.Add("Name", 80, HorizontalAlignment.Center);
                output.Columns.Add("Price", 80, HorizontalAlignment.Center);
                output.Columns.Add("Weight", 80, HorizontalAlignment.Center);
                output.Columns.Add("Resolution", 80, HorizontalAlignment.Center);
                output.Columns.Add("Type", 80, HorizontalAlignment.Center);
                var obj = id.ReadMonitors();
                foreach (Monitor i in obj)
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = i.ItemID.ToString();
                    lvi.SubItems.Add(i.ItemName);
                    lvi.SubItems.Add(i.Price.ToString() + "€");
                    lvi.SubItems.Add(i.Weight.ToString());
                    lvi.SubItems.Add(i.resolution.ToString());
                    lvi.SubItems.Add(i.monType.ToString());
                    output.Items.Add(lvi);

                }
            }
            else if (comboBox1.Text == "Hardware")
            {
                output.Clear();
                output.View = View.Details;
                output.Columns.Add("ID", 30, HorizontalAlignment.Center);
                output.Columns.Add("Name", 100, HorizontalAlignment.Center);
                output.Columns.Add("Price", 80, HorizontalAlignment.Center);
                output.Columns.Add("Weight", 80, HorizontalAlignment.Center);
                var obj = id.ReadHardwre();
                foreach (HardwareItem i in obj)
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = i.ItemID.ToString();
                    lvi.SubItems.Add(i.ItemName);
                    lvi.SubItems.Add(i.Price.ToString() + "€");
                    lvi.SubItems.Add(i.Weight.ToString());
                    output.Items.Add(lvi);

                }
            }
            else if (comboBox1.Text == "Software")
            {
                output.Clear();
                output.View = View.Details;
                output.Columns.Add("ID", 30, HorizontalAlignment.Center);
                output.Columns.Add("Name", 100, HorizontalAlignment.Center);
                output.Columns.Add("Price", 80, HorizontalAlignment.Center);
                output.Columns.Add("Licence Key", 80, HorizontalAlignment.Center);
                output.Columns.Add("Size(Mb)", 80, HorizontalAlignment.Center);
                var obj = id.ReadSoftware();
                foreach (SoftwareItem i in obj)
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = i.ItemID.ToString();
                    lvi.SubItems.Add(i.ItemName);
                    lvi.SubItems.Add(i.Price.ToString() + "€");
                    lvi.SubItems.Add(i.LicenceKey);
                    lvi.SubItems.Add(i.SizeInMB.ToString());
                    output.Items.Add(lvi);

                }
            }
            else if (comboBox1.Text == "Items")
            {
                output.Clear();
                output.View = View.Details;
                output.Columns.Add("ID", 30, HorizontalAlignment.Center);
                output.Columns.Add("Name", 100, HorizontalAlignment.Center);
                output.Columns.Add("Price", 80, HorizontalAlignment.Center);
                var obj = id.ReadItems();
                foreach (Item i in obj)
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = i.ItemID.ToString();
                    lvi.SubItems.Add(i.ItemName);
                    lvi.SubItems.Add(i.Price.ToString()+"€");
                    output.Items.Add(lvi);
                }

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label_Click(object sender, EventArgs e)
        {

        }

        private void hardware_radio_CheckedChanged(object sender, EventArgs e)
        {
            if (hardware_radio.Checked == true)
            {
                monitor.Enabled = false;
                Software.Enabled = false;
                hardware.Enabled = true;
                Computer.Enabled = false;
                licence.Text = "";
                size_soft.Value = 0;

            }

        }

        private void computer_radio_CheckedChanged(object sender, EventArgs e)
        {
            if (computer_radio.Checked == true)
            {
                monitor.Enabled = false;
                Software.Enabled = false;
                hardware.Enabled = true;
                Computer.Enabled = true;
                res.Text = "";
                type.Text = "";
            }

        }

        private void software_radio_CheckedChanged(object sender, EventArgs e)
        {
            if (software_radio.Checked == true)
            {
                monitor.Enabled = false;
                Software.Enabled = true;
                hardware.Enabled = false;
                Computer.Enabled = false;
                cores.Value = 0;
                ram.Value = 0;
                hdd.Value = 0;
                res.Text = "";
                type.Text = "";
                weight.Value = 0;
            }
        }

        private void monitor_radio_CheckedChanged(object sender, EventArgs e)
        {
            if (monitor_radio.Checked == true) { }
            {
                monitor.Enabled = true;
                Software.Enabled = false;
                hardware.Enabled = true;
                Computer.Enabled = false;
                cores.Value= 0;
                ram.Value= 0;
                hdd.Value= 0;
            }
        }

        private void insert_but_Click(object sender, EventArgs e)
        {
            string Ime = name.Text;
            string cena = price.Value.ToString();
            int hard = 0;
            int soft = 0;
            int mon = 0;
            int com = 0;
            if (radioButton1.Checked== true)
            {
                hard = 0;
                soft = 0;
            }
            if(hardware.Enabled==true)
            {
                 hard = 1;
                 soft = 0;
            }
            else if(Software.Enabled==true)
            {
                 soft = 1;
                 hard = 0;
            }

            if (hard == 0 && soft == 0)
            {
                id.InsertItems(Ime, cena);
                output.Clear();
                output.View = View.Details;
                output.Columns.Add("ID", 30, HorizontalAlignment.Center);
                output.Columns.Add("Name", 100, HorizontalAlignment.Center);
                output.Columns.Add("Price", 80, HorizontalAlignment.Center);
                output.Columns.Add("Licence Key", 80, HorizontalAlignment.Center);
                output.Columns.Add("Size(Mb)", 80, HorizontalAlignment.Center);
                var obj = id.ReadSoftware();
                foreach (SoftwareItem i in obj)
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = i.ItemID.ToString();
                    lvi.SubItems.Add(i.ItemName);
                    lvi.SubItems.Add(i.Price.ToString() + "€");
                    lvi.SubItems.Add(i.LicenceKey);
                    lvi.SubItems.Add(i.SizeInMB.ToString());
                    output.Items.Add(lvi);

                }

            }

            else if (hard == 1 && soft ==0)
            {
                string teza = weight.Value.ToString();
                string resol = res.Text;
                string tip = type.Text;
                int cor = cores.TabIndex;
                int disk = hdd.TabIndex;
                int memory = ram.TabIndex;
                if (radioButton2.Checked == true)
                {
                    mon = 0;
                    com = 0;
                }
                if(monitor.Enabled==true)
                {

                    mon = 1;
                    com = 0;
                }
                else if (Computer.Enabled == true)
                {
                    com = 1;
                    mon = 0;
                }

                if (mon == 1 && com == 0)
                {
                    //insert monitor
                }
                else if (mon == 0 && com == 1)
                {
                    //insert comp
                }
                else if (mon == 0 && com == 0)
                {
                    id.InsertHardware(Ime, cena, teza);
                }
            }
            else
            {
                //insert soft
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            monitor.Enabled = false;
            Software.Enabled = false;
            hardware.Enabled = false;
            Computer.Enabled = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            monitor.Enabled = false;
            Software.Enabled = false;
            hardware.Enabled = false;
            Computer.Enabled = false;
        }
    }
}
