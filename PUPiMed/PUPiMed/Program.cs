using MetroFramework.Controls;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PUPiMed
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginNew());
            //try
            //{
            //    LoginNew.setConnection("root;", "root;");
            //    LoginNew.conn.Open();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //finally
            //{
            //    LoginNew.conn.Close();
            //}
            //Application.Run(new MainForm());


            /*
            while (Console.ReadKey().KeyChar != 'x')
            {
                Console.Write("Enter code: ");
                string x= Console.ReadLine();
                Console.WriteLine(getNextCode(x)==null?"Invalid Code.":getNextCode(x));
            }  
            Console.ReadLine();
            */
        }

        public static bool fillComboBox(MetroComboBox comboBox, string strQuery, out List<String> alistCode)
        {
            comboBox.Items.Clear();
            alistCode = new List<String>();
            bool retval = true;
            using (LoginNew.conn)
            {
                if (LoginNew.conn != null && (LoginNew.conn.State == ConnectionState.Closed))
                    LoginNew.conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(strQuery, LoginNew.conn))
                {
                    using (MySqlDataReader dataReader = cmd.ExecuteReader())
                    {
                        if (dataReader.Read())
                        {
                            alistCode.Add(dataReader.GetString(0));
                            comboBox.Items.Add(dataReader.GetString(1));
                            while (dataReader.Read())
                            {
                                alistCode.Add(dataReader.GetString(0));
                                comboBox.Items.Add(dataReader.GetString(1));
                            }
                        }
                        else
                        {
                            comboBox.Items.Add("");
                            alistCode.Add("");
                            retval = false;
                        }
                        dataReader.Close();
                        comboBox.SelectedIndex = 0;
                    }
                }
            }
            return retval;
        }

        //returns true if a duplicate is found
        public static bool duplicateEntry(DataGridView grid, string value, int column)
        {
            foreach (DataGridViewRow row in grid.Rows)
            {
                if (row.Cells[column].Value.ToString().Equals(value))
                {
                    return true;
                }
            }
            return false;
        }

        public static bool ExecuteQuery(string query)
        {
            bool result = false;
            try
            {
                if (LoginNew.conn != null && (LoginNew.conn.State == ConnectionState.Closed))
                    LoginNew.conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, LoginNew.conn);
                if (cmd.ExecuteNonQuery() == 1)
                {
                    result = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("\t"+ex.Message.ToString());
            }
            finally
            {
                LoginNew.conn.Close();
            }

            return result;
        }

        public static string getPrevCode (string query)
        {
            string prev = null;
            try {
                if (LoginNew.conn != null && (LoginNew.conn.State == ConnectionState.Closed))
                    LoginNew.conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, LoginNew.conn))
                {
                    using (MySqlDataReader dataReader = cmd.ExecuteReader())
                    {
                        if (dataReader.Read())
                        {
                            prev = dataReader.GetString(0);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                LoginNew.conn.Close();
            }

            return prev;
        }

        public static string getNextCode(string prev)
        {
            if (Regex.IsMatch(prev, "^[a-zA-Z0-9-_]+$"))
            {
                string original = prev;
                string num = string.Empty;
                //reverse the string bc we only need to increment the rightmost collection of numbers in the string 
                prev = reverse(prev);

                //Get Numeric Values to be incremented
                char p = '\0', c;
                //p will contain the previous character
                //c will contain the current character
                for (int i = 0; i < prev.Length; i++)
                {
                    c = prev[i];
                    if (Char.IsDigit(c))
                    {
                        num += c;
                    }
                    else
                    {
                        //if current characteris not a digit, 
                        //check if the previous one is, then break
                        //that means we already found our num string
                        if (Char.IsDigit(p))
                            break;
                    }
                    p = c;
                }
                if (String.IsNullOrEmpty(num))
                {
                    num = "0";
                    original += num;
                }
                //reverse the num string to get the original value
                num = reverse(num);

                //increment
                ulong nextInt = ulong.Parse(num);  //ulong so u could store numbers upto 18446744073709551615 
                ++nextInt;  

                //For zeros ex: (0001) 
                string newInt = nextInt.ToString();
                //reverese so u could just add zeroes at the end of the real nos
                newInt = reverse(newInt);
                if (newInt.Length < num.Length)
                {
                    int i = 0;
                    int diff = num.Length - newInt.Length;
                    while (i < diff)
                    {
                        newInt += "0";
                        ++i;
                    }
                }
                newInt = reverse(newInt);

                //place on original string
                string nextCode = String.Empty;

                //replace only the last occurence
                //bc ex: prev: aaa000sss000, might result to aaa001sss001
                int loc = original.LastIndexOf(num);
                nextCode = original.Remove(loc, num.Length).Insert(loc, newInt);
                return nextCode;
            }

            return null;
        }

        public static string reverse(string str)
        {
            char[] rev = str.ToCharArray();
            Array.Reverse(rev);
            return new String(rev); ;
        }

    }
}
