using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace UkrainianLanguage_VirtualSimulator
{
    class DbManager
    {
        SqlConnection connect;
        SqlCommand cmd;
        static DbManager instance;
        public static DbManager getInstance()
        {
            if (instance == null)
            {
                instance = new DbManager();
            }
            return instance;
        }
        DbManager()
        {
           
            connect = new SqlConnection(@"Data Source=DESKTOP-9L7NQAF;Initial Catalog=DataBase;Integrated Security=True;Connect Timeout=30");
            cmd = new SqlCommand();
            cmd.Connection = connect;
        }
        public void ViewTable(List<string> box, string TableName)
        {
            box.Clear();
            cmd.CommandText = $"SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '{TableName}';";
            connect.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                box.Add(reader.GetString(3));
            }
            reader.Close();
            connect.Close();
        }

        public void ComboContent(ComboBox box, string tableName)
        {
            box.Items.Clear();
            cmd.CommandText = $"SELECT Caption FROM {tableName};";
            connect.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                box.Items.Add(reader.GetString(0));
            }
            reader.Close();
            connect.Close();
        }

        public string pk(string TableName, string caption)
        {
            string str = "";
            cmd.CommandText = $"SELECT Id FROM {TableName} WHERE Caption = '{caption}';";
            connect.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                str = reader.GetString(0);
            }

            reader.Close();
            connect.Close();
            return str;
        }

        public string GetInfo(string tableName, string nameField, string nameSearchField, string primaryKey)
        {
            string str = "";
            cmd.CommandText = $"SELECT {nameSearchField} FROM {tableName} WHERE {nameField} = '{primaryKey}';";
            connect.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                if (nameSearchField != "role")
                {
                    str = reader.GetString(0);
                }
                else
                {
                    str = reader.GetByte(0).ToString();
                }
            }

            reader.Close();
            connect.Close();
            return str;
        }

        public List<string> valueList(string TableName, string NameField)
        {
            List<string> str = new List<string>();
            cmd.CommandText = $"SELECT {NameField} FROM {TableName};";
            connect.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                str.Add(reader.GetString(0));
            }

            reader.Close();
            connect.Close();
            return str;
        }

        public List<string> valueList(string TableName, string FindingParam, string NameField)
        {
            List<string> str = new List<string>();
            cmd.CommandText = $"SELECT {NameField} FROM {TableName} WHERE {FindingParam};";
            connect.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                str.Add(reader.GetString(0));
            }

            reader.Close();
            connect.Close();
            return str;
        }

        public void TableRecords(string tableName, DataGridView grid)
        {
            try
            {
                connect.Open();
                SqlDataAdapter adapter = new SqlDataAdapter($"SELECT * FROM {tableName}", connect);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet, tableName);
                grid.DataSource = dataSet.Tables[tableName];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connect.Close();
        }
        public void SearchRecord(string tableName, string[] NameParam, string[] param, DataGridView grid)
        {
            try
            {
                string str = $"SELECT * FROM {tableName} WHERE";
                for (int i = 0; i < param.Length; i++)
                {
                    str += $" {NameParam[i]} LIKE '%{param[i]}%' AND";
                }
                str = str.Remove(str.Length - 4);
                str += ";";
                connect.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(str, connect);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet, tableName);
                grid.DataSource = dataSet.Tables[tableName];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connect.Close();
        }

        public void AddRecord(string table_name, List<string> fieldscontent)
        {
            try
            {
                List<string> list = new List<string>();

                ViewTable(list, table_name);
                cmd.CommandText = $"INSERT INTO {table_name}(";

                foreach (string str in list)
                {
                    cmd.CommandText += str + ", ";
                };
                cmd.CommandText = cmd.CommandText.Remove(cmd.CommandText.Length - 2);
                cmd.CommandText += ") ";
                cmd.CommandText += "VALUES(";
                foreach (string str in fieldscontent)
                {
                    cmd.CommandText += "'" + str + "', ";
                };
                cmd.CommandText = cmd.CommandText.Remove(cmd.CommandText.Length - 2);
                cmd.CommandText += ");";
                connect.Open();
                cmd.ExecuteNonQuery();
                connect.Close();
                MessageBox.Show("Запис додано");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                connect.Close();
            }

        }

        public void DeleteRecord(string table_name, string primarykey)
        {
            try
            {
                cmd.CommandText = $"DELETE FROM {table_name} WHERE {ViewPK(table_name)} = '{primarykey}';";


                connect.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Запис видалено");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            connect.Close();
        }

        public void UpdateRecord(string table_name, List<string> fieldscontent, string primarykey)
        {
            List<string> fieldsName = new List<string>();
            try
            {
                ViewTable(fieldsName, table_name);
                cmd.CommandText = $"UPDATE {table_name} SET ";
                int i = 0;
                foreach (string str in fieldsName)
                {
                    cmd.CommandText += str + "='" + fieldscontent[i] + "', ";
                    i++;
                };
                cmd.CommandText = cmd.CommandText.Remove(cmd.CommandText.Length - 2);
                cmd.CommandText += $" WHERE {ViewPK(table_name)} = '{primarykey}';";

               
                connect.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Запис оновлено");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            connect.Close();
        }

        public string ViewPK(string TableName)
        {
            string str = "";
            cmd.CommandText = $"EXEC sp_pkeys @table_name = '{TableName}';";
            connect.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                str = reader.GetString(3);
            }
            reader.Close();
            connect.Close();
            return str;
        }
    }
}

