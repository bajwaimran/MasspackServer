using System;
using System.IO;
using System.Collections;
using System.Data.SqlClient;

using DevExpress.XtraEditors;

namespace BestellErfassung.FileHelpers
{
    class ConnectionStringHelpers
    {
        internal const string connectionStringFile = "C:\\ConnectionString.txt";

        //internal static string StartConnectionStringWizzard()
        //{
        //    using (ConnectionStringForm conStringDialog = new ConnectionStringForm())
        //    {
        //        string retVal;
        //        if (conStringDialog.ShowDialog() == DialogResult.OK)
        //            retVal = GetActiveConnectionStringFromFile();
        //        else
        //            retVal = String.Empty;
        //        return retVal;
        //    }
        //}

        internal static SqlException CheckConnectionToServer(string connectionString)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    conn.Close();
                }
                return null;
            }
            catch (SqlException sqlEx)
            {
                return sqlEx;
            }
            catch (Exception ex)
            {
                // Invalid connection string
                //FileHelpers.Delete(ConnectionStringHelpers.connectionStringFile);
                //XtraMessageBox.Show(ex.Message);
                return null;
            }
        }

        internal static ArrayList GetAllConnectionStringsFromFile()
        {
            ArrayList connStrArray = new ArrayList();
            if (FileHelpers.Exists(connectionStringFile))
            {
                using (StreamReader sr = new StreamReader(connectionStringFile))
                {
                    try
                    {
                        while (sr.Peek() != -1)
                            connStrArray.Add(CryptionHelpers.Decrypt(sr.ReadLine()));
                    }
                    catch (Exception e)
                    {
                        //XtraMessageBox.Show(e.Message);
                        //throw new UserFriendlyException(e.Message);
                    }
                    finally
                    {
                        sr.Close();
                    }
                }
            }
            connStrArray.Sort();
            return connStrArray;
        }

        internal static string[] SplitString(string str)
        {
            char[] delimiterChars = { '=', ';' };
            string[] words = str.Split(delimiterChars);
            return words;
        }        

        internal static string GetActiveConnectionStringFromFile()
        {
            string connStr = String.Empty;
            try
            {
                using (StreamReader sr = new StreamReader(connectionStringFile))
                {
                    string[] splitString;
                    while (sr.Peek() != -1)
                    {
                        connStr = CryptionHelpers.Decrypt(sr.ReadLine());
                        splitString = SplitString(connStr);
                        if (String.Compare(splitString[3].ToString(), "True", false) != 0)
                            continue;
                        connStr = StripConnectionString(connStr);
                        break;
                    }
                }
            }
            catch (Exception e)
            {
                //XtraMessageBox.Show(e.Message);
                //throw new UserFriendlyException(e.Message);
            }
            return connStr;
        }

        internal static string StripConnectionString(string str)
        {
            return str.Substring(str.IndexOf("Data Source="));
        }
    }
}
