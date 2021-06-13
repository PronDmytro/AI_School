using System;
using System.Windows.Forms;
using System.Data.SQLite;

namespace AI_School
{
    public partial class FormAuth : Form
    {
        public string connectionString = " Data Source =  db.sqlite3; Version = 3 ";

        public SQLiteConnection con;

        public string programName = "Автоматизована інформаційно-пошукова система обліку \"Школи\"";

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


        public FormAuth()
        {
            InitializeComponent();
        }


        public int IsLoginAndPasswordCorrect(string login, string password)
        {
            int user_id = 0;

            using (SQLiteCommand fmd = con.CreateCommand())
            {
                try
                {
                    fmd.CommandText = @"SELECT id FROM users WHERE login=@l AND password=@p";
                    fmd.Parameters.Add("@l", System.Data.DbType.String, -1);
                    fmd.Parameters["@l"].Value = login;

                    fmd.Parameters.Add("@p", System.Data.DbType.String, -1);
                    fmd.Parameters["@p"].Value = password;

                    SQLiteDataReader r = fmd.ExecuteReader();
                    while (r.Read())
                    {
                        user_id = Convert.ToInt32(r["id"]);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, "SQLITE SELECT ERROR : " + ex.Message,
                                  "SQLite select error", MessageBoxButtons.OK,
                                  MessageBoxIcon.Error,
                                  MessageBoxDefaultButton.Button1, 0);
                }
            }
            return user_id;
        }


        public int GetRightByUserId(int user_id)
        {
            int rights = -1;

            using (SQLiteCommand fmd = con.CreateCommand())
            {
                try
                {
                    fmd.CommandText = @"SELECT rights FROM users WHERE id = @i";
                    fmd.Parameters.Add("@i", System.Data.DbType.Decimal, -1);
                    fmd.Parameters["@i"].Value = user_id;
                    

                    SQLiteDataReader r = fmd.ExecuteReader();
                    while (r.Read())
                    {
                        rights = Convert.ToInt32(r["rights"]);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, "SQLITE SELECT ERROR : " + ex.Message,
                                  "SQLite select error", MessageBoxButtons.OK,
                                  MessageBoxIcon.Error,
                                  MessageBoxDefaultButton.Button1, 0);
                }
            }
            return rights;
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            if (ConnectToSQLiteDB()==1)
            {

                int user_id = IsLoginAndPasswordCorrect(textBox_login.Text.Trim(), textBox_password.Text);

                if (user_id < 1)
                {
                    MessageBox.Show(this, "AUTH ERROR", "LOGIN OR PASSWORD INCORRECT OR USER NOT FOUND!",
                                  MessageBoxButtons.OK,
                                 MessageBoxIcon.Error,
                                 MessageBoxDefaultButton.Button1, 0);
                }
                else
                {
                    int user_rights = GetRightByUserId(user_id);

                    MainMenu modalForm = new MainMenu();

                    modalForm.connectionString = connectionString;
                    modalForm.user_id = user_id;
                    modalForm.user_rights = user_rights;

                    modalForm.Text = programName + " UID#" + user_id.ToString() + " RIGHTS:" + user_rights.ToString();

                    modalForm.programName = programName;

                    modalForm.ShowDialog();

                    // вікно закрили, стираємо логін і пароль і виставляєм фокус
                    textBox_login.Text = "";
                    textBox_password.Text = "";
                    textBox_login.Focus();
                }

                con.Close();
            }
        }
        private void textBox_login_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void textBox_password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
