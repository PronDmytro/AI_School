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
    public partial class Form_Products : Form
    {
        public int user_id { get; set; }
        public int user_rights { get; set; }
        public string connectionString { get; set; }


        public SQLiteConnection con;

        public Form_Products()
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

        private void button_add_Click(object sender, EventArgs e)
        {
            Form_ProductDlg frm = new Form_ProductDlg();
            frm.connectionString = connectionString;
            frm.user_id = user_id;
            frm.user_rights = user_rights;
            frm.record_id = -1;
            frm.button_action.Text = "Додати запис";

            frm.ShowDialog();

            button_refresh.PerformClick();
        }

        private void Form_Products_Load(object sender, EventArgs e)
        {
            //dataGridView1.AutoResizeRow(2, DataGridViewAutoSizeRowMode.AllCellsExceptHeader);
            button_refresh.PerformClick(); // натискаємо на кнопку, чим підгружаємо дані з БД
            if (user_rights == 0)
            {// user ringhts
                button_delete.Enabled = false;
            }
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            int id_for_edit = -1;
            try
            {
               // id_for_edit = Convert.ToInt32(textBox_id_for_edit.Text.Trim());
                id_for_edit = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["#"].Value.ToString());
            }
            catch ( Exception ex)
            {
                MessageBox.Show(this, "Помилка",
                                      "Помилка перетворення в дійсне число (Ціна): " + ex.Message, MessageBoxButtons.OK,
                                      MessageBoxIcon.Error,
                                      MessageBoxDefaultButton.Button1, 0);
                return;
            }
            Form_ProductDlg frm = new Form_ProductDlg();
            frm.connectionString = connectionString;
            frm.user_id = user_id;
            frm.user_rights = user_rights;
            frm.record_id = id_for_edit;

            frm.LoadDataInFiledsByRecordId(id_for_edit);

            frm.button_action.Text = "Редагувати запис";

            frm.ShowDialog();
            button_refresh.PerformClick();
            //id_for_edit
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            
            

            int id_for_edit = -1;
            try
            {
                id_for_edit = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["#"].Value.ToString());
                // id_for_edit = Convert.ToInt32(textBox_id_for_edit.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Помилка перетворення в дійсне число (номер запису): " + ex.Message,  "Помилка", 
                                     
                                      
                                      MessageBoxButtons.OK,
                                      MessageBoxIcon.Error,
                                      MessageBoxDefaultButton.Button1, 0);
                return;
            }

            DialogResult r8 = MessageBox.Show( "Видалити запис#" + id_for_edit + "?",
                                       "Підтвердження виконання операції", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            if (r8 == DialogResult.Yes)
            {
                if (ConnectToSQLiteDB() == 1)
                {
                    using (SQLiteCommand fmd = con.CreateCommand())
                    {
                        try
                        {
                            //fmd.CommandText = @"SELECT id FROM users WHERE login=@l AND password=@p";
                            fmd.CommandText = @"DELETE FROM products WHERE id = @l";
                            fmd.Parameters.Add("@l", System.Data.DbType.Int32, -1);
                            fmd.Parameters["@l"].Value = id_for_edit;

                            int x = 0;

                            x = fmd.ExecuteNonQuery();
                            if (x != 0)
                            {
                                MessageBox.Show(this, "Успіх!",
                                   "Запис з ID#"+id_for_edit+ " видалений успішно!", MessageBoxButtons.OK,
                                   MessageBoxIcon.Information,
                                   MessageBoxDefaultButton.Button1, 0);
                            }
                            else
                            {
                                MessageBox.Show(this, "Помилка видалення запису!",
                                   "Запис з ID#" + id_for_edit + " НЕ БУВ ВИДАЛЕНИЙ!", MessageBoxButtons.OK,
                                   MessageBoxIcon.Error,
                                   MessageBoxDefaultButton.Button1, 0);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(this, "Помилка SQL-запиту!",
                                  "Запис з ID#" + id_for_edit + " НЕ БУВ ВИДАЛЕНИЙ!" + ex.Message, MessageBoxButtons.OK,
                                  MessageBoxIcon.Error,
                                  MessageBoxDefaultButton.Button1, 0);

                            
                        }
                    }
                }

                button_refresh.PerformClick();
                // fmd.ExecuteNonQuery();
                // need_to_close_this_window = true;
            }
            else
            {
                // need_to_close_this_window = true;
            }


            //id_for_edit
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            Close();
        }
        

        private void button_refresh_Click(object sender, EventArgs e)
        {
            if (ConnectToSQLiteDB() == 1)
            {
                DataTable dt = new DataTable();
                try
                {
                    string sql = @"SELECT id as '#',name as 'Найменування',itemscount as 'Кількість',cost as 'Вартість',comment as 'Примітка' FROM products"; // можливо треба поставити LIMIT ?
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql,con);
                    DataSet ds = new System.Data.DataSet();
                    adapter.Fill(ds, "products");
                    dataGridView1.DataSource = ds.Tables[0];
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this,
                                      "Помилка оновлення даних таблиці: " + ex.Message,
                                       "Помилка", 
                                       MessageBoxButtons.OK,
                                      MessageBoxIcon.Error,
                                      MessageBoxDefaultButton.Button1, 0);
                    con.Close();
                    return;
                }
                con.Close();
            }
                
        }
    }
}
