using Dapper;
using MySql.Data.MySqlClient;
namespace Dapper1.Models
{
    public class Dbconnection
    {
        string connectionString = "server=localhost;database=employee007;user=root;password=root123";
        public List<employee> Getemployee()
        {
            
            string sqlemployee = "select * from employee";
           List<employee> employees= new List<employee>();
            using (var connection = new MySqlConnection(connectionString)) 
            {
                employees=connection.Query<employee>(sqlemployee).ToList();
            };
            return employees;
        }
    }
}
