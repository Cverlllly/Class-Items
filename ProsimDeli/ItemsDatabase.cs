using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SQLite;

namespace ProsimDeli
{
    public class ItemsDatabase
    {
        private SQLiteConnection conn;

        public ItemsDatabase()
        {
            conn = new SQLiteConnection(@"data source=itemss.db");
        }

        public void SaveItem(string itemToSave,string Price)
        {
            try
            {
                using (conn)
                {
                    conn.Open();
                    using (SQLiteCommand com = new SQLiteCommand(conn))
                    {
                        com.CommandText = "INSERT INTO Items (ItemName,Price) VALUES ('" + itemToSave + "'," +"'"+ Price+"'" + ");";
                        com.ExecuteNonQuery();

                        com.Dispose();
                    }
                    conn.Close();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public List<HardwareItem> readItems()
        {
                List<HardwareItem> list = new List<HardwareItem>();
                using (conn)
                {
                    conn.Open();
                    using (SQLiteCommand com = new SQLiteCommand(conn))
                    {
                        com.CommandText = "SELECT * FROM Items";
                        SQLiteDataReader reader = com.ExecuteReader();
                        while (reader.Read())
                        {
                            list.Add(new HardwareItem(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(5)));
                        }
                        Console.WriteLine(list);
                        com.Dispose();
                    }
                    conn.Close();
                }
            return list;

        }

        public List<Item> Readitem(int ID)
        {
            try
            {
                List<Item> list = new List<Item>();
                using (conn)
                {
                    conn.Open();
                    using (SQLiteCommand com = new SQLiteCommand(conn))
                    {
                        com.CommandText = "SELECT * FROM Items WHERE ItemID=" + ID;
                        SQLiteDataReader reader = com.ExecuteReader();
                        while (reader.Read())
                        {
                            list.Add(new Item(reader.GetInt32(0), reader.GetString(1), reader.GetString(2)));
                        }
                        Console.WriteLine(list);
                        com.Dispose();

                    }
                    conn.Close();
                }
                return list;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void UpdateItem(int ID, string itemtoupdate,string price)
        {
            try
            {
                using (conn)
                {
                    conn.Open();
                    using (SQLiteCommand com = new SQLiteCommand(conn))
                    {
                        com.CommandText = "UPDATE Items SET ItemName=" + "'" + itemtoupdate + "'" + ", Price=" +"'" +price +"'"+ " " + "WHERE ItemID=" + ID;
                        com.ExecuteNonQuery();

                        com.Dispose();
                    }
                    conn.Close();
                }
            }
            catch (Exception)
            {

                throw;
            }

        }
        public void DeleteItem(int ID)
        {
            try
            {
                conn.Open();
                using (SQLiteCommand com = new SQLiteCommand(conn))
                {
                    com.CommandText = "DELETE FROM Items WHERE ItemID=" + ID;
                    com.ExecuteNonQuery();

                    com.Dispose();
                }
                conn.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public List<Computer> AllItems()
        {
            List<Computer> list = new List<Computer>();
            //using (conn)
            {
                conn.Open();
                using (SQLiteCommand com = new SQLiteCommand(conn))
                {
                    com.CommandText = "SELECT i.ItemID,i.ItemName,i.Price,i.Weight,c.NoOfCores,c.Ram,c.HDDSize FROM Items i Inner join Computer c on i.ItemID=c.ItemID";
                    SQLiteDataReader reader = com.ExecuteReader();
                    while (reader.Read())
                    {
                        list.Add(new Computer(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetInt32(4), reader.GetInt32(5), reader.GetInt32(6)));
                    }
                    Console.WriteLine(list);
                    com.Dispose();
                }
                conn.Close();
            }
            return list;
        }
        public List<Monitor> AllItems_2()
        {
            List<Monitor> list = new List<Monitor>();
            //using (conn)
            {
                conn.Open();
                using (SQLiteCommand com = new SQLiteCommand(conn))
                {
                    com.CommandText = "SELECT i.ItemID,i.ItemName,i.Price,i.Weight,m.MonitorType,m.Resolution FROM Items i Inner join Monitors m on i.ItemID=m.ItemID";
                    SQLiteDataReader reader = com.ExecuteReader();
                    while (reader.Read())
                    {
                        list.Add(new Monitor(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5)));
                    }
                    Console.WriteLine(list);
                    com.Dispose();
                }
                conn.Close();
            }
            return list;
        }
        public List<HardwareItem> Allitems_3()
        {
            List<HardwareItem> list=new List<HardwareItem>();
            {
                conn.Open();
                using (SQLiteCommand com = new SQLiteCommand(conn))
                {
                    com.CommandText = "SELECT i.ItemID,i.ItemName,i.Price,i.Weight FROM Items i WHERE ";
                    SQLiteDataReader reader = com.ExecuteReader();
                    while (reader.Read())
                    {
                        list.Add(new HardwareItem(reader.GetInt32(0), reader.GetString(1), reader.GetString(2),reader.GetString(3)));
                    }
                    Console.WriteLine(list);
                    com.Dispose();
                }
                conn.Close();

            }
            return list;
        }

    }
}





