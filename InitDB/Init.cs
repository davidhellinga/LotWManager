using System.Data.SqlClient;

namespace InitDB
{
    public class Init
    {
        private SqlConnection ConnectDB()
        {
            //"Server=localhost\\SQLEXPRESS;Initial Catalog=LotWManager;IntegratedSecurity=True"
            const string connectionString = "Server=localhost\\SQLEXPRESS;Database=LotWManager;Trusted_Connection=True";
            
            var conn=new SqlConnection(connectionString);
            return conn;
        }

        public void startInit()
        {
            using (var conn = ConnectDB())
            {
                conn.Open();
            
                var query= new SqlCommand("DELETE FROM UserAccounts", conn);
                query.ExecuteNonQuery();

                query = new SqlCommand("INSERT INTO UserAccounts(username, password, email) VALUES(@username, @password, @email)", conn);
                query.Parameters.AddWithValue("@username", "admin");
                query.Parameters.AddWithValue("@password", "admin");
                query.Parameters.AddWithValue("@email", "admin@admin.nl");
                query.ExecuteNonQuery();
            }
        }
    }
}