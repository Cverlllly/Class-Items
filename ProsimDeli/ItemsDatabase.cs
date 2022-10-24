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
            using (conn)
            {
                conn.Open();
                using (SQLiteCommand com = new SQLiteCommand(conn))
                {
                    com.CommandText = "SELECT * FROM Items i Inner join Computer c on i.ItemID=c.ItemID";
                    SQLiteDataReader reader = com.ExecuteReader();
                    while (reader.Read())
                    {
                        list.Add(new Computer(reader.GetInt32(0), reader.GetString(2), reader.GetString(1), reader.GetString(5), reader.GetInt32(9), reader.GetInt32(8), reader.GetInt32(10));
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





