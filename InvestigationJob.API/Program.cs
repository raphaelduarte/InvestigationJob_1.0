using System;
using Dapper;
using InvestigationJob.API.Entities.Interface;
using Microsoft.Data.SqlClient;
namespace InvestigationJob.DatabaseModel;

class InvestigationJob
{
    static void Main(string[] args)
    {
        const string connectionString = "Server=SQLEXPRESS;Database=Investigation Job;Integrated Security=SSPI";

        using (var connection = new SqlConnection(connectionString))
        {
            var usuario = connection.Query<IUsuario>("SELECT [IdUsuario] FROM [IUsuario]");
        }
    }
}