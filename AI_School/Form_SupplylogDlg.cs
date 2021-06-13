using System;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Globalization;


namespace AI_School
{
    public partial class Form_SupplylogDlg : Form
    {

        public int user_id { get; set; }
        public int user_rights { get; set; }
        public string connectionString { get; set; }


        public int record_id { get; set; }


        public SQLiteConnection con;




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



        public void LoadDataInFiledsByRecordId(int rec_id)
        {
            if (ConnectToSQLiteDB() == 1)
            {

                using (SQLiteCommand fmd = con.CreateCommand())
                {
                    try
                    {
                        fmd.CommandText = @"SELECT teacherId,studentsClassId,lessonNumber,subject,lesson_dt FROM schedule WHERE id=@l";
                        fmd.Parameters.Add("@l", System.Data.DbType.Int32, -1);
                        fmd.Parameters["@l"].Value = rec_id;


                        SQLiteDataReader r = fmd.ExecuteReader();
                        while (r.Read())
                        {
                            LoadDataInComboboxByTblAndFieldName(ref comboBox_teacherId, "teachers", "name", true, Convert.ToInt32((r["teacherId"]).ToString()));
                            LoadDataInComboboxByTblAndFieldName(ref comboBox_studetsclassesId, "studentsClasses", "className", true, Convert.ToInt32((r["studentsClassId"]).ToString()));

                            
                            textBox_count.Text = (r["lessonNumber"]).ToString();
                            
                            dateTimePicker_dtsupply.Text = (r["lesson_dt"]).ToString();
                            textBox_subject.Text = (r["subject"]).ToString();
                        }
                    }
                    catch (Exception ex)
                    {
                        con.Close();
                        MessageBox.Show("SQLITE SELECT ERROR : " + ex.Message);
                    }
                }
                con.Close();
            }
            //sql load records
            // and put it into textboxs
        }

        public void LoadDataInComboboxByTblAndFieldName(ref  ComboBox comboboxtarger, string tblname, string fieldname, bool needID = false, int setid = -1)
        {
            if (ConnectToSQLiteDB() == 1)
            {

                using (SQLiteCommand fmd = con.CreateCommand())
                {
                    try
                    {
                        fmd.CommandText = @"SELECT id," + fieldname + " FROM " + tblname;
                        //fmd.Parameters.Add("@l", System.Data.DbType.Int32, -1);
                        //fmd.Parameters["@l"].Value = rec_id;
                        comboboxtarger.Items.Clear();
                        int curIndex = 0;
                        SQLiteDataReader r = fmd.ExecuteReader();
                        int rememberId = 0;
                        while (r.Read())
                        {
                            comboboxtarger.Items.Add((needID ? r["id"] + " : " : "") + r[fieldname]);
                            string tmpxx = r["id"].ToString();
                            if (r["id"].ToString() == setid.ToString())
                            {
                                rememberId = curIndex;
                            }

                            //Console.WriteLine("->"+ (int)r["id"]);
                            /*
                            textBox_productName.Text = (r["name"]).ToString();
                            textBox_comment.Text = (r["comment"]).ToString();

                            textBox_itemsCount.Text = (r["itemscount"]).ToString();
                            textBox_cost.Text = (r["cost"]).ToString();
                             */
                            curIndex++;

                        }
                        if (setid != -1)
                        {
                            comboboxtarger.SelectedIndex = rememberId;
                        }
                    }
                    catch (Exception ex)
                    {
                        con.Close();
                        MessageBox.Show(ex.Message);
                        //Console.WriteLine("SQLITE SELECT ERROR : " + ex.Message);
                    }
                }
                con.Close();
            }
            //sql load records
            // and put it into textboxs
        }


        public Form_SupplylogDlg()
        {
            InitializeComponent();
        }

        private void Form_SupplylogDlg_Load(object sender, EventArgs e)
        {
            LoadDataInComboboxByTblAndFieldName(ref comboBox_teacherId, "teachers", "name", true);
            LoadDataInComboboxByTblAndFieldName(ref comboBox_studetsclassesId, "studentsClasses", "className", true);

            if (record_id == -1)
            {
                textBox_id.Text = "Новий запис";
                Text = "Додання нового запису";

                string tmp = DateTime.Now.ToString("dd.MM.yyyy");
                tmp = (DateTime.Now.AddMinutes(15)).ToString("dd.MM.yyyy");
                dateTimePicker_dtsupply.Text = tmp;
            }
            else
            {
                textBox_id.Text = record_id.ToString();
                Text = "Редагування запису #" + record_id.ToString();
            }
           
        }


        private int GetIdInTextStringBySeparator(string inStr)
        {
            string[] array = inStr.Split(new char[] { ':' });

            if (array.Length > 0)
            {
                try
                {
                    return Convert.ToInt32(array[0].Trim());
                }
                catch
                {
                    return -1;
                }
            }

            return -1;

        }


        private void button_action_Click(object sender, EventArgs e)
        {

            textBox_count.Text = textBox_count.Text.Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
            textBox_count.Text = textBox_count.Text.Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);



            bool need_to_close_this_window = false;
            if (ConnectToSQLiteDB() == 1)
            {
                int teacherId = 0;
                int studentsClassId = 0;
                int lessonNumber = 0;
                string lesson_dt = "";
                string subject = "";

                subject = textBox_subject.Text.Trim();
                lesson_dt = dateTimePicker_dtsupply.Text.Trim();
                //-------------------------------------------------------------------------
                teacherId = GetIdInTextStringBySeparator(comboBox_teacherId.Text.Trim());
                if (teacherId == -1)
                {
                    MessageBox.Show(this, "Вчитель",
                                  "id не знайдено (Вчитель): ", MessageBoxButtons.OK,
                                  MessageBoxIcon.Error,
                                  MessageBoxDefaultButton.Button1, 0);
                    return;
                }

                //-------------------------------------------------------------------------
                studentsClassId = GetIdInTextStringBySeparator(comboBox_studetsclassesId.Text.Trim());
                if (studentsClassId == -1)
                {
                    MessageBox.Show(this, "Клас",
                                  "id не знайдено (Клас): ", MessageBoxButtons.OK,
                                  MessageBoxIcon.Error,
                                  MessageBoxDefaultButton.Button1, 0);
                    con.Close();
                    return;
                }

                try
                {
                    lessonNumber = Convert.ToInt32(textBox_count.Text.Trim());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, "Помилка",
                                  "Помилка перетворення в  число (Номер): " + ex.Message, MessageBoxButtons.OK,
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
                        
                        //==============================================================================================
                        // [1] Виконуємо вставку в таблицю жуналів
                        //==============================================================================================
                        try
                        {
                            // fmd.CommandText = @"SELECT id FROM users WHERE login=@l AND password=@p";
                            fmd.CommandText = @"INSERT INTO schedule (teacherId,studentsClassId,lessonNumber,subject,lesson_dt) VALUES (@teacherId,@studentsClassId,@lessonNumber,@subject,@lesson_dt)";
                            
                            
                            fmd.Parameters.Add("@teacherId", System.Data.DbType.Int32, -1);
                            fmd.Parameters["@teacherId"].Value = teacherId;

                            fmd.Parameters.Add("@studentsClassId", System.Data.DbType.Int32, -1);
                            fmd.Parameters["@studentsClassId"].Value = studentsClassId;


                            fmd.Parameters.Add("@lessonNumber", System.Data.DbType.Int32, -1);
                            fmd.Parameters["@lessonNumber"].Value = lessonNumber;

                            fmd.Parameters.Add("@subject", System.Data.DbType.String, -1);
                            fmd.Parameters["@subject"].Value = subject;

                            fmd.Parameters.Add("@lesson_dt", System.Data.DbType.String, -1);
                            fmd.Parameters["@lesson_dt"].Value = lesson_dt;
                            DialogResult r8 = MessageBox.Show("Додати новий запис?",
                                       "Підтвердження виконання операції", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


                            if (r8 == DialogResult.Yes)
                            {
                                fmd.ExecuteNonQuery();
                                need_to_close_this_window = true;
                            }
                            else
                            {
                                need_to_close_this_window = false;
                            }

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("SQLITE SELECT ERROR : " + ex.Message);
                        }
                        
                    }
                    con.Close();

                    //=============================================================================================
                }
                else
                {// редактування
                    using (SQLiteCommand fmd = con.CreateCommand())
                    {
                        try
                        {
                            // fmd.CommandText = @"SELECT id FROM users WHERE login=@l AND password=@p";
                            fmd.CommandText = @"UPDATE schedule SET teacherId=@teacherId,studentsClassId=@studentsClassId,lessonNumber=@lessonNumber,subject=@subject WHERE id=@a";


                            fmd.Parameters.Add("@teacherId", System.Data.DbType.Int32, -1);
                            fmd.Parameters["@teacherId"].Value = teacherId;

                            fmd.Parameters.Add("@studentsClassId", System.Data.DbType.Int32, -1);
                            fmd.Parameters["@studentsClassId"].Value = studentsClassId;

                            fmd.Parameters.Add("@lessonNumber", System.Data.DbType.Int32, -1);
                            fmd.Parameters["@lessonNumber"].Value = lessonNumber;

                            fmd.Parameters.Add("@subject", System.Data.DbType.String, -1);
                            fmd.Parameters["@subject"].Value = subject;

                            fmd.Parameters.Add("@lesson_dt", System.Data.DbType.String, -1);
                            fmd.Parameters["@lesson_dt"].Value = lesson_dt;

                            fmd.Parameters.Add("@a", System.Data.DbType.String, -1);
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
