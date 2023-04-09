namespace InvestigationJob.API.Entities.Interface.Endereco;

public interface IBairro : IBairroCidade
{
    public int Id { get; set; }
    public int IdBairroCidade { get; set; } 
    public string Bairro { get; set; }
    
}