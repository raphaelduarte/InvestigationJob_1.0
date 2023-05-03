using Dapper;
using InvestigationJob.API.Data;
using InvestigationJob.API.Entities.Interface;
using InvestigationJob.API.Entities.Service;
using Microsoft.Data.SqlClient;

namespace InvestigationJob.API;

class InvestigationJob
{
    static void Main(string[] args)
    {
        
        using (var context = new DataContext())
        {
            var Usuario = new Usuario { Nome = "Raphael", Sobrenome = "Duarte Silva Silveira"};
            context.Add(Usuario);
            context.SaveChanges();
            Console.WriteLine("Foi para o banco");
        }
    }
}