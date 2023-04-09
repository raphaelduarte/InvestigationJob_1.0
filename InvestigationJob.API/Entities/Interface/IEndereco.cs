namespace InvestigationJob.API.Entities.Interface;

public interface IEndereco
{
    public int Id { get; set; }
    public string Rua { get; set; }
    public int Numero { get; set; }
    public string Bairro { get; }
}