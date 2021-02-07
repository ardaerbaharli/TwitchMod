using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace twitchMod
{
    class Database
    {

        private static SqlCommand sqlCommand;
        private static SqlConnection connection;
        private static SqlDataReader reader;
        public static string connectionString = "Data Source=DESKTOP-MT1SCOE;Initial Catalog=TwitchMod;Integrated Security=True";

        public static List<string> GetBlacklistWords()
        {
            try
            {
                connection = new SqlConnection
                {
                    ConnectionString = connectionString
                };
                connection.Open();
                sqlCommand = new SqlCommand
                {
                    Connection = connection,
                    CommandText = "SELECT * FROM BlacklistWords"
                };
                reader = sqlCommand.ExecuteReader();

                var filter = new List<string>();

                while (reader.Read())
                {
                    filter.Add(reader[0].ToString().TrimEnd());
                }
                connection.Close();
                return filter;
            }
            catch (Exception ex)
            {
                connection.Close();
                LogHandler.ReportCrash(ex);
                return new List<string>();
            }

        }
        public static bool AddBlacklistWord(string blacklistWord)
        {
            if (!DoesBlacklistWordExist(blacklistWord))
            {
                int isSuccessful;
                try
                {
                    connection = new SqlConnection
                    {
                        ConnectionString = connectionString
                    };
                    sqlCommand = new SqlCommand
                    {
                        Connection = connection,
                        CommandText = "INSERT INTO BlacklistWords (blacklistWord) VALUES ('" + blacklistWord + "')"
                    };
                    connection.Open();
                    isSuccessful = sqlCommand.ExecuteNonQuery();
                    connection.Close();
                    if (isSuccessful == 0)
                        return false;
                    else
                        return true;
                }
                catch (Exception ex)
                {
                    connection.Close();
                    LogHandler.ReportCrash(ex);
                    return false;
                }
            }
            else
                return false;
        }
        public static bool DoesBlacklistWordExist(string blacklistWord)
        {
            try
            {
                connection.Open();
                SqlCommand checkIfExists = new SqlCommand("SELECT COUNT(*) FROM BlacklistWords WHERE (blacklistWord = @blacklistWord)", connection);
                checkIfExists.Parameters.AddWithValue("@blacklistWord", blacklistWord);
                int doesExist = (int)checkIfExists.ExecuteScalar();

                connection.Close();
                if (doesExist > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                connection.Close();
                LogHandler.ReportCrash(ex);
                return false;
            }
        }

        public static bool RemoveBlacklistWord(string word)
        {
            if (DoesBlacklistWordExist(word))
            {
                int isSuccessful;
                try
                {
                    connection = new SqlConnection
                    {
                        ConnectionString = connectionString
                    };
                    sqlCommand = new SqlCommand
                    {
                        Connection = connection,
                        CommandText = "DELETE FROM BlacklistWords WHERE blacklistWord='" + word + "'"
                    };
                    connection.Open();
                    isSuccessful = sqlCommand.ExecuteNonQuery();
                    connection.Close();
                    if (isSuccessful == 0)
                        return false;
                    else
                        return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
            else
                return false;
        }
    }
}
