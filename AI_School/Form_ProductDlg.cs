using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Globalization;

namespace NAUM_APTEKA_2021
{
    public partial class Form_ProductDlg : Form
    {
        public int user_id { get; set; }
        public int user_rights { get; set; }

        public int record_id { get; set; }
        
        public string connectionString { get; set; }

        public SQLiteConnection con;


        public Form_ProductDlg()
        {
            InitializeComponent();
        }


        public int ConnectToSQLiteDB()
        {
            con = new SQLiteConnection(connectionString);

            try
            {
                //Console.WriteLine("TRY TO CONNECT : " + connectionString);
                con.Open();
                if (con.State == System.Data.ConnectionState.Open)
                {
                    ///Console.WriteLine("SQLITE CONNECTED SUCCESSFULLY!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "SQLITE CONNECT ERROR : " + ex.Message,
                                   "SQLite connection error", MessageBoxButtons.OK,
                                   MessageBoxIcon.Error,
                                   MessageBoxDefaultButton.Button1, 0);
                return 0;
            }
            return 1;
        }




        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form_ProductDlg_Load(object sender, EventArgs e)
        {
            if (record_id == -1)
            {
                textBox_id.Text = "Новий запис";
                Text = "Додання нового запису"; 
            }
            else
            {
                textBox_id.Text = record_id.ToString();
                Text = "Редагування запису #" + record_id.ToString();
            }
        }

        public void LoadDataInFiledsByRecordId(int rec_id)
        {
            if (ConnectToSQLiteDB() == 1)
            {

                using (SQLiteCommand fmd = con.CreateCommand())
                {
                    try
                    {
                        fmd.CommandText = @"SELECT name,itemscount,cost,comment FROM products WHERE id=@l";
                        fmd.Parameters.Add("@l", System.Data.DbType.Int32, -1);
                        fmd.Parameters["@l"].Value = rec_id;


                        SQLiteDataReader r = fmd.ExecuteReader();
                        while (r.Read())
                        {
                            //Console.WriteLine("->"+ (int)r["id"]);
                            textBox_id.Text = rec_id.ToString();
                            textBox_productName.Text = (r["name"]).ToString();
                            textBox_comment.Text = (r["comment"]).ToString();

                            textBox_itemsCount.Text = (r["itemscount"]).ToString();
                            textBox_cost.Text = (r["cost"]).ToString();

                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("SQLITE SELECT ERROR : " + ex.Message);
                    }
                }
                con.Close();
            }
            //sql load records
            // and put it into textboxs
        }

        private void button_action_Click(object sender, EventArgs e)
        {
            textBox_itemsCount.Text = textBox_itemsCount.Text.Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
            textBox_itemsCount.Text = textBox_itemsCount.Text.Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);

            
            
            bool need_to_close_this_window = false;
            if (ConnectToSQLiteDB() == 1)
            {
                string name = "";
                double itemscount = 0;
                double cost = 0;
                string comment = "";

                name = textBox_productName.Text.Trim();
                comment = textBox_comment.Text.Trim();
                try
                {
                    itemscount = Convert.ToDouble(textBox_itemsCount.Text.Trim());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, "Помилка",
                                  "Помилка перетворення в дійсне число (Кількість): " + ex.Message, MessageBoxButtons.OK,
                                  MessageBoxIcon.Error,
                                  MessageBoxDefaultButton.Button1, 0);

                    con.Close();
                    return;

                }

                try
                {
                    cost = Convert.ToDouble(textBox_cost.Text.Trim());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, "Помилка",
                                  "Помилка перетворення в дійсне число (Ціна): " + ex.Message, MessageBoxButtons.OK,
                                  MessageBoxIcon.Error,
                                  MessageBoxDefaultButton.Button1, 0);

                    con.Close();
                    return;

                }


                if (record_id == -1)
                {// новий запис
                
                    // перевіряємо поля, що б не були пусті і через трай кет парсимо інтові значення і зап в змінні

                    using (SQLiteCommand fmd = con.CreateCommand())
                    {
                        try
                        {
                            // fmd.CommandText = @"SELECT id FROM users WHERE login=@l AND password=@p";
                            fmd.CommandText = @"INSERT INTO products (name,itemscount,cost,comment) VALUES (@n,@y,@c,@s)";
                            fmd.Parameters.Add("@n", System.Data.DbType.String, -1);
                            fmd.Parameters["@n"].Value = name;

                            fmd.Parameters.Add("@y", System.Data.DbType.Double, -1);
                            fmd.Parameters["@y"].Value = itemscount;

                            fmd.Parameters.Add("@c", System.Data.DbType.Double, -1);
                            fmd.Parameters["@c"].Value = cost;

                            fmd.Parameters.Add("@s", System.Data.DbType.String, -1);

                            fmd.Parameters["@s"].Value = comment;

                            DialogResult r8 = MessageBox.Show("Додати новий запис?",
                                       "Підтвердження виконання операції", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


                            if (r8 == DialogResult.Yes)
                            {
                                fmd.ExecuteNonQuery();
                                need_to_close_this_window = true;
                            }
                            else
                            {
                                need_to_close_this_window = true;
                            }

                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("SQLITE SELECT ERROR : " + ex.Message);
                        }

                    }
                    con.Close();
                }
                else
                {// редактування
                    using (SQLiteCommand fmd = con.CreateCommand())
                    {
                        try
                        {
                            // fmd.CommandText = @"SELECT id FROM users WHERE login=@l AND password=@p";
                            fmd.CommandText = @"UPDATE products SET name=@n,itemscount=@y,cost=@c,comment=@s WHERE id=@a";
                            fmd.Parameters.Add("@n", System.Data.DbType.String, -1);
                            fmd.Parameters["@n"].Value = name;

                            fmd.Parameters.Add("@y", System.Data.DbType.Double, -1);
                            fmd.Parameters["@y"].Value = itemscount;

                            fmd.Parameters.Add("@c", System.Data.DbType.Double, -1);
                            fmd.Parameters["@c"].Value = cost;

                            fmd.Parameters.Add("@s", System.Data.DbType.String, -1);
                            fmd.Parameters["@s"].Value = comment;

                            fmd.Parameters.Add("@a", System.Data.DbType.Int32, -1);
                            fmd.Parameters["@a"].Value = record_id;

                            DialogResult r8 = MessageBox.Show("Редагувати запис?",
                                       "Підтвердження виконання операції", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


                            if (r8 == DialogResult.Yes)
                            {
                                fmd.ExecuteNonQuery();
                                need_to_close_this_window = true;
                            }
                            else
                            {
                                need_to_close_this_window = true;
                            }

                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("SQLITE SELECT ERROR : " + ex.Message);
                        }

                    }
                    con.Close();
                }
            }
            else
            {
                // не можу зєднатися з БД
            }

            if (need_to_close_this_window)
            {
                Close();
            }
            
        }

        private void textBox_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
