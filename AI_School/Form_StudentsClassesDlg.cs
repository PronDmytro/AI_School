using System;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Globalization;

namespace AI_School
{
    public partial class Form_StudentsClassesDlg : Form
    {
        public int user_id { get; set; }
        public int user_rights { get; set; }

        public int record_id { get; set; }
        
        public string connectionString { get; set; }

        public SQLiteConnection con;


        public Form_StudentsClassesDlg()
        {
            InitializeComponent();
        }

        public int ConnectToSQLiteDB()
        {
            con = new SQLiteConnection(connectionString);

            try
            {
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
                        fmd.CommandText = @"SELECT className,studentsCount,classTeacher,comment FROM studentsClasses WHERE id=@l";
                        fmd.Parameters.Add("@l", System.Data.DbType.Int32, -1);
                        fmd.Parameters["@l"].Value = rec_id;


                        SQLiteDataReader r = fmd.ExecuteReader();
                        while (r.Read())
                        {
                            //Console.WriteLine("->"+ (int)r["id"]);
                            textBox_id.Text = rec_id.ToString();
                            textBox_className.Text = (r["className"]).ToString();
                            textBox_comment.Text = (r["comment"]).ToString();

                            textBox_studentsCount.Text = (r["studentsCount"]).ToString();
                            textBox_classTeacher.Text = (r["classTeacher"]).ToString();

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
            textBox_studentsCount.Text = textBox_studentsCount.Text.Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
            textBox_studentsCount.Text = textBox_studentsCount.Text.Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);

            bool need_to_close_this_window = false;
            if (ConnectToSQLiteDB() == 1)
            {
                string className = "";
                int studentsCount = 0;
                string classTeacher = "";
                string comment = "";

                classTeacher = textBox_classTeacher.Text.Trim();
                className = textBox_className.Text.Trim();
                comment = textBox_comment.Text.Trim();
                try
                {
                    studentsCount = Convert.ToInt32(textBox_studentsCount.Text.Trim());
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

                if (record_id == -1)
                {// новий запис
                
                    // перевіряємо поля, що б не були пусті і через трай кет парсимо інтові значення і зап в змінні

                    using (SQLiteCommand fmd = con.CreateCommand())
                    {
                        try
                        {
                            // fmd.CommandText = @"SELECT id FROM users WHERE login=@l AND password=@p";
                            fmd.CommandText = @"INSERT INTO studentsClasses (className,studentsCount,classTeacher,comment) VALUES (@n,@y,@c,@s)";
                            fmd.Parameters.Add("@n", System.Data.DbType.String, -1);
                            fmd.Parameters["@n"].Value = className;

                            fmd.Parameters.Add("@y", System.Data.DbType.Int32, -1);
                            fmd.Parameters["@y"].Value = studentsCount;

                            fmd.Parameters.Add("@c", System.Data.DbType.String, -1);
                            fmd.Parameters["@c"].Value = classTeacher;

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
                                MessageBox.Show("SQLITE SELECT ERROR : ");
                                need_to_close_this_window = true;
                            }

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("SQLITE SELECT ERROR : " + ex.Message);
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
                            fmd.CommandText = @"UPDATE studentsClasses SET className=@n,studentsCount=@y,classTeacher=@c,comment=@s WHERE id=@a";
                            fmd.Parameters.Add("@n", System.Data.DbType.String, -1);
                            fmd.Parameters["@n"].Value = className;

                            fmd.Parameters.Add("@y", System.Data.DbType.Int32, -1);
                            fmd.Parameters["@y"].Value = studentsCount;

                            fmd.Parameters.Add("@c", System.Data.DbType.String, -1);
                            fmd.Parameters["@c"].Value = classTeacher;

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
                            MessageBox.Show("SQLITE SELECT ERROR : " + ex.Message);
                        }

                    }
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("не можу зєднатися з БД");
                // не можу зєднатися з БД
            }

            if (need_to_close_this_window)
            {
                Close();
            }
            
        }
        private void button_close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
