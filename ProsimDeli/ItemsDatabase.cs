using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SQLite;
using System.Windows.Forms;

namespace ProsimDeli
{
    public class ItemsDatabase
    {
        private SQLiteConnection conn;

        public ItemsDatabase()
        {
            conn = new SQLiteConnection(@"data source=itemss.db");
        }
        public List<Computer> ReadComputers()
        {
            List<Computer> list = new List<Computer>();
            //using (conn)
            {
                conn.Open();
                using (SQLiteCommand com = new SQLiteCommand(conn))
                {
                    com.CommandText = "SELECT i.id_i,i.name,i.price,h.weight,c.noofcores,c.ram,c.hddsize FROM items i INNER JOIN hardwareitem h ON i.id_i=h.id_i INNER JOIN " +
                        "computer c ON h.id_h=c.id_h";
                    SQLiteDataReader reader = com.ExecuteReader();
                    while (reader.Read())
                    {
                        list.Add(new Computer(reader.GetInt32(0), reader.GetString(1), reader.GetDouble(2), reader.GetDouble(3), reader.GetInt32(4), reader.GetInt32(5), reader.GetInt32(6)));
                    }
                    Console.WriteLine(list);
                    com.Dispose();
                }
                conn.Close();
            }
            return list;
        }
        public List<Monitor> ReadMonitors()
        {
            List<Monitor> list = new List<Monitor>();
            //using (conn)
            {
                conn.Open();
                using (SQLiteCommand com = new SQLiteCommand(conn))
                {
                    com.CommandText = "SELECT i.id_i,i.name,i.price,h.weight,m.resolution,m.monitortype FROM items i INNER JOIN hardwareitem h ON i.id_i=h.id_i INNER JOIN " +
                        "monitor m ON h.id_h=m.id_h";
                    SQLiteDataReader reader = com.ExecuteReader();
                    while (reader.Read())
                    {
                        list.Add(new Monitor(reader.GetInt32(0),reader.GetString(1),reader.GetDouble(2),reader.GetDouble(3),reader.GetString(4),reader.GetString(5)));
                    }
                    Console.WriteLine(list);
                    com.Dispose();
                }
                conn.Close();
            }
            return list;
        }
        public List<HardwareItem> ReadHardwre()
        {
            List<HardwareItem> list = new List<HardwareItem>();
            //using (conn)
            {
                conn.Open();
                using (SQLiteCommand com = new SQLiteCommand(conn))
                {
                    com.CommandText = "SELECT i.id_i,i.name,i.price,h.weight FROM items i INNER JOIN hardwareitem h ON i.id_i=h.id_i WHERE is_computer=0 and is_monitor=0 ";
                    SQLiteDataReader reader = com.ExecuteReader();
                    while (reader.Read())
                    {
                        list.Add(new HardwareItem(reader.GetInt32(0), reader.GetString(1), reader.GetDouble(2), reader.GetDouble(3)));
                    }
                    Console.WriteLine(list);
                    com.Dispose();
                }
                conn.Close();
            }
            return list;
        }
        public List<SoftwareItem> ReadSoftware()
        {
            List<SoftwareItem> list = new List<SoftwareItem>();
            //using (conn)
            {
                conn.Open();
                using (SQLiteCommand com = new SQLiteCommand(conn))
                {
                    com.CommandText = "SELECT i.id_i,i.name,i.price,s.licencekey,s.sizeinMb FROM items i INNER JOIN softwareitem s ON s.id_i=i.id_i WHERE i.is_soft=1;";
                    SQLiteDataReader reader = com.ExecuteReader();
                    while (reader.Read())
                    {
                        list.Add(new SoftwareItem(reader.GetInt32(0), reader.GetString(1), reader.GetDouble(2), reader.GetString(3),reader.GetInt32(4)));
                    }
                    Console.WriteLine(list);
                    com.Dispose();
                }
                conn.Close();
            }
            return list;
        }
        public List<Item> ReadItems()
        {
            List<Item> list = new List<Item>();
            //using (conn)
            {
                conn.Open();
                using (SQLiteCommand com = new SQLiteCommand(conn))
                {
                    com.CommandText = "SELECT i.id_i,i.name,i.price FROM items i WHERE i.is_soft=0 and i.is_hard=0;";
                    SQLiteDataReader reader = com.ExecuteReader();
                    while (reader.Read())
                    {
                        list.Add(new Item(reader.GetInt32(0), reader.GetString(1), reader.GetDouble(2)));
                    }
                    Console.WriteLine(list);
                    com.Dispose();
                }
                conn.Close();
            }
            return list;
        }
        public void InsertItems(string itemToSave, string Price)
        {
            //using (conn)
            {
                conn.Open();
                using (SQLiteCommand com = new SQLiteCommand(conn))
                {
                    com.CommandText = "INSERT INTO Items (name,price,is_soft,is_hard) VALUES ('" + itemToSave + "'," + "'" + Price + "'" + ",0,0);";
                    com.ExecuteNonQuery();
                    com.Dispose();
                }
                conn.Close();
            }
        }
        public void InsertHardware(string ime, string cena,string weight)
        {
            //using (conn)
            {
                conn.Open();
                using (SQLiteCommand com = new SQLiteCommand(conn))
                {
                    com.CommandText = "INSERT INTO items (name,price,is_soft,is_hard) VALUES ('" + ime + "'," + "'" + cena + "'" + ",0,1);";
                    com.CommandText = "INSERT INTO hardwareitem (weight,is_computer,is_monitor,id_i) VALUES ("+weight+",0,0,(SELECT id_i FROM items WHERE name="+"'"+ime+"'"+" and price="+cena+"));";
                    com.ExecuteNonQuery();
                    com.Dispose();
                }
                conn.Close();
            }
        }
    }
}



