using System;
using System.Data;
using System.Data.SQLite;

namespace StudentManagementSystem1
{
    public static class DatabaseHelper
    {
        private static string connectionString = $"Data Source={System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "SMSDatabase.db")};Version=3;";

        public static SQLiteConnection GetConnection()
        {
            return new SQLiteConnection(connectionString);
        }

        // 2. දත්ත කියවීමේ ක්‍රියාවලිය (Select Queries) - Login එක සඳහා
        public static int ExecuteNonQuery(string query, SQLiteParameter[] parameters = null)
        {
            // using එකක් ඇතුළේ දැම්මම වැඩේ ඉවර වුණු ගමන්ම Connection එක සදහටම ක්ලෝස් වෙනවා!
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        public static DataTable ExecuteQuery(string query, SQLiteParameter[] parameters = null)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }
                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        return dt;
                    }
                }
            }
        }
    }
}