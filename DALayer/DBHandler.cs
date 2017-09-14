using System;
using System.Data.SqlClient;

namespace DALayer
{
    public class DBHandler : IDataAccess
    {
        /// <summary>
        /// Call to create new connection to db
        /// </summary>
        /// <returns>SqlConnection</returns>
        private SqlConnection ConnectDb()
        {
            //"Server=localhost\\SQLEXPRESS;Initial Catalog=LotWManager;IntegratedSecurity=True"
            const string connectionString = "Server=localhost\\SQLEXPRESS;Database=LotWManager;Trusted_Connection=True";

            var conn = new SqlConnection(connectionString);
            return conn;
        }

        /// <summary>
        /// Sends username and password to database, returns number of entries with matching data
        /// </summary>
        /// <param name="user"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public int checkPasswordWithUsername(string user, string password)
        {
            using (var conn = ConnectDb())
            {
                conn.Open();
                
                var query=new SqlCommand("SELECT COUNT(*) FROM UserAccounts WHERE username=@username AND password=@password", conn);
                query.Parameters.AddWithValue("@username", user);
                query.Parameters.AddWithValue("@password", password);
                return Convert.ToInt32(query.ExecuteScalar());

            }
        }

        public void checkUserExists(string user)
        {
            throw new System.NotImplementedException();
        }
    }
}