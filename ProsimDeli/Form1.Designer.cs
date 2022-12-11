namespace ProsimDeli
{
    partial class Form1
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
            this.output = new System.Windows.Forms.ListView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Software = new System.Windows.Forms.GroupBox();
            this.hardware = new System.Windows.Forms.GroupBox();
            this.Computer = new System.Windows.Forms.GroupBox();
            this.monitor = new System.Windows.Forms.GroupBox();
            this.name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.NumericUpDown();
            this.hardware_radio = new System.Windows.Forms.RadioButton();
            this.software_radio = new System.Windows.Forms.RadioButton();
            this.licence = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.size_soft = new System.Windows.Forms.NumericUpDown();
            this.monitor_radio = new System.Windows.Forms.RadioButton();
            this.computer_radio = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.weight = new System.Windows.Forms.NumericUpDown();
            this.ram = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.cores = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.hdd = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.res = new System.Windows.Forms.TextBox();
            this.type = new System.Windows.Forms.ComboBox();
            this.insert_but = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.Software.SuspendLayout();
            this.hardware.SuspendLayout();
            this.Computer.SuspendLayout();
            this.monitor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.price)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.size_soft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hdd)).BeginInit();
            this.SuspendLayout();
            // 
            // output
            // 
            this.output.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.output.HideSelection = false;
            this.output.Location = new System.Drawing.Point(12, 368);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(495, 180);
            this.output.TabIndex = 0;
            this.output.UseCompatibleStateImageBehavior = false;
            this.output.View = System.Windows.Forms.View.Details;
            this.output.SelectedIndexChanged += new System.EventHandler(this.output_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Computers",
            "Monitors",
            "Software",
            "Hardware",
            "Items"});
            this.comboBox1.Location = new System.Drawing.Point(17, 341);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.label);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(957, 27);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label
            // 
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label.Location = new System.Drawing.Point(0, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(230, 37);
            this.label.TabIndex = 0;
            this.label.Text = "Insert";
            this.label.Click += new System.EventHandler(this.label_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(12, 275);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(957, 27);
            this.panel2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Output";
            // 
            // Software
            // 
            this.Software.Controls.Add(this.size_soft);
            this.Software.Controls.Add(this.label5);
            this.Software.Controls.Add(this.label4);
            this.Software.Controls.Add(this.licence);
            this.Software.Location = new System.Drawing.Point(201, 72);
            this.Software.Name = "Software";
            this.Software.Size = new System.Drawing.Size(171, 164);
            this.Software.TabIndex = 7;
            this.Software.TabStop = false;
            this.Software.Text = "Software";
            // 
            // hardware
            // 
            this.hardware.Controls.Add(this.radioButton2);
            this.hardware.Controls.Add(this.weight);
            this.hardware.Controls.Add(this.label6);
            this.hardware.Controls.Add(this.monitor_radio);
            this.hardware.Controls.Add(this.computer_radio);
            this.hardware.Location = new System.Drawing.Point(393, 72);
            this.hardware.Name = "hardware";
            this.hardware.Size = new System.Drawing.Size(171, 164);
            this.hardware.TabIndex = 7;
            this.hardware.TabStop = false;
            this.hardware.Text = "Hardware";
            // 
            // Computer
            // 
            this.Computer.Controls.Add(this.hdd);
            this.Computer.Controls.Add(this.label9);
            this.Computer.Controls.Add(this.cores);
            this.Computer.Controls.Add(this.label8);
            this.Computer.Controls.Add(this.ram);
            this.Computer.Controls.Add(this.label7);
            this.Computer.Location = new System.Drawing.Point(588, 72);
            this.Computer.Name = "Computer";
            this.Computer.Size = new System.Drawing.Size(171, 164);
            this.Computer.TabIndex = 7;
            this.Computer.TabStop = false;
            this.Computer.Text = "Computer";
            // 
            // monitor
            // 
            this.monitor.Controls.Add(this.type);
            this.monitor.Controls.Add(this.label11);
            this.monitor.Controls.Add(this.res);
            this.monitor.Controls.Add(this.label10);
            this.monitor.Location = new System.Drawing.Point(783, 72);
            this.monitor.Name = "monitor";
            this.monitor.Size = new System.Drawing.Size(171, 164);
            this.monitor.TabIndex = 7;
            this.monitor.TabStop = false;
            this.monitor.Text = "Monitor";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(38, 93);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(100, 20);
            this.name.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Price";
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(38, 135);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(100, 20);
            this.price.TabIndex = 16;
            // 
            // hardware_radio
            // 
            this.hardware_radio.AutoSize = true;
            this.hardware_radio.Location = new System.Drawing.Point(41, 171);
            this.hardware_radio.Name = "hardware_radio";
            this.hardware_radio.Size = new System.Drawing.Size(71, 17);
            this.hardware_radio.TabIndex = 17;
            this.hardware_radio.TabStop = true;
            this.hardware_radio.Text = "Hardware";
            this.hardware_radio.UseVisualStyleBackColor = true;
            this.hardware_radio.CheckedChanged += new System.EventHandler(this.hardware_radio_CheckedChanged);
            // 
            // software_radio
            // 
            this.software_radio.AutoSize = true;
            this.software_radio.Location = new System.Drawing.Point(41, 194);
            this.software_radio.Name = "software_radio";
            this.software_radio.Size = new System.Drawing.Size(67, 17);
            this.software_radio.TabIndex = 18;
            this.software_radio.TabStop = true;
            this.software_radio.Text = "Software";
            this.software_radio.UseVisualStyleBackColor = true;
            this.software_radio.CheckedChanged += new System.EventHandler(this.software_radio_CheckedChanged);
            // 
            // licence
            // 
            this.licence.Location = new System.Drawing.Point(18, 37);
            this.licence.Name = "licence";
            this.licence.Size = new System.Drawing.Size(100, 20);
            this.licence.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Licence key";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Size ( in Mb)";
            // 
            // size_soft
            // 
            this.size_soft.Location = new System.Drawing.Point(18, 75);
            this.size_soft.Name = "size_soft";
            this.size_soft.Size = new System.Drawing.Size(100, 20);
            this.size_soft.TabIndex = 17;
            // 
            // monitor_radio
            // 
            this.monitor_radio.AutoSize = true;
            this.monitor_radio.Location = new System.Drawing.Point(18, 99);
            this.monitor_radio.Name = "monitor_radio";
            this.monitor_radio.Size = new System.Drawing.Size(60, 17);
            this.monitor_radio.TabIndex = 20;
            this.monitor_radio.TabStop = true;
            this.monitor_radio.Text = "Monitor";
            this.monitor_radio.UseVisualStyleBackColor = true;
            this.monitor_radio.CheckedChanged += new System.EventHandler(this.monitor_radio_CheckedChanged);
            // 
            // computer_radio
            // 
            this.computer_radio.AutoSize = true;
            this.computer_radio.Location = new System.Drawing.Point(18, 74);
            this.computer_radio.Name = "computer_radio";
            this.computer_radio.Size = new System.Drawing.Size(70, 17);
            this.computer_radio.TabIndex = 19;
            this.computer_radio.TabStop = true;
            this.computer_radio.Text = "Computer";
            this.computer_radio.UseVisualStyleBackColor = true;
            this.computer_radio.CheckedChanged += new System.EventHandler(this.computer_radio_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Weight";
            // 
            // weight
            // 
            this.weight.Location = new System.Drawing.Point(18, 37);
            this.weight.Name = "weight";
            this.weight.Size = new System.Drawing.Size(100, 20);
            this.weight.TabIndex = 23;
            // 
            // ram
            // 
            this.ram.Location = new System.Drawing.Point(15, 74);
            this.ram.Name = "ram";
            this.ram.Size = new System.Drawing.Size(100, 20);
            this.ram.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "RAM  ( in Gb)";
            // 
            // cores
            // 
            this.cores.Location = new System.Drawing.Point(15, 37);
            this.cores.Name = "cores";
            this.cores.Size = new System.Drawing.Size(100, 20);
            this.cores.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "No. of cores";
            // 
            // hdd
            // 
            this.hdd.Location = new System.Drawing.Point(15, 115);
            this.hdd.Name = "hdd";
            this.hdd.Size = new System.Drawing.Size(100, 20);
            this.hdd.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 99);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "HDD ( in Gb)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 58);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Type";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Resolution";
            // 
            // res
            // 
            this.res.Location = new System.Drawing.Point(9, 37);
            this.res.Name = "res";
            this.res.Size = new System.Drawing.Size(100, 20);
            this.res.TabIndex = 5;
            // 
            // type
            // 
            this.type.FormattingEnabled = true;
            this.type.Location = new System.Drawing.Point(9, 75);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(100, 21);
            this.type.TabIndex = 7;
            // 
            // insert_but
            // 
            this.insert_but.Location = new System.Drawing.Point(878, 243);
            this.insert_but.Name = "insert_but";
            this.insert_but.Size = new System.Drawing.Size(75, 23);
            this.insert_but.TabIndex = 19;
            this.insert_but.Text = "Enter";
            this.insert_but.UseVisualStyleBackColor = true;
            this.insert_but.Click += new System.EventHandler(this.insert_but_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(41, 217);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(51, 17);
            this.radioButton1.TabIndex = 20;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "None";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(18, 122);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(51, 17);
            this.radioButton2.TabIndex = 24;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "None";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 560);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.insert_but);
            this.Controls.Add(this.software_radio);
            this.Controls.Add(this.hardware_radio);
            this.Controls.Add(this.price);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.name);
            this.Controls.Add(this.monitor);
            this.Controls.Add(this.Computer);
            this.Controls.Add(this.hardware);
            this.Controls.Add(this.Software);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.output);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ccccc";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.Software.ResumeLayout(false);
            this.Software.PerformLayout();
            this.hardware.ResumeLayout(false);
            this.hardware.PerformLayout();
            this.Computer.ResumeLayout(false);
            this.Computer.PerformLayout();
            this.monitor.ResumeLayout(false);
            this.monitor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.price)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.size_soft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hdd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListView output;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox Software;
        private System.Windows.Forms.NumericUpDown size_soft;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox licence;
        private System.Windows.Forms.GroupBox hardware;
        private System.Windows.Forms.NumericUpDown weight;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton monitor_radio;
        private System.Windows.Forms.RadioButton computer_radio;
        private System.Windows.Forms.GroupBox Computer;
        private System.Windows.Forms.NumericUpDown hdd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown cores;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown ram;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox monitor;
        private System.Windows.Forms.ComboBox type;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox res;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown price;
        private System.Windows.Forms.RadioButton hardware_radio;
        private System.Windows.Forms.RadioButton software_radio;
        private System.Windows.Forms.Button insert_but;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
    }
}

