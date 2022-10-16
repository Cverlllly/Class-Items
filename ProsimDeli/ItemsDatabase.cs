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
            conn = new SQLiteConnection(@"data source=items.db");
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
        public List<Item> ReadItems()
        {
            try
            {
                List<Item> list = new List<Item>();
                using (conn)
                {
                    conn.Open();
                    using (SQLiteCommand com = new SQLiteCommand(conn))
                    {
                        com.CommandText = "SELECT * FROM Items";
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
    }
}





