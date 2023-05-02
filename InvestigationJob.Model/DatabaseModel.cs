using Microsoft.Data.SqlClient;
namespace InvestigationJob.DatabaseModel;

public class DatabaseModel
{
    const string connectionString = "Server=SQLEXPRESS;Database=Investigation Job;Integrated Security=SSPI";

    var connection = new SqlConnection();

    connection.Open();
}