namespace InvestigationJob.API.Entities.Interface;

public interface INomeCompleto
{
    public Guid IdNomeCompleto { get; set; }
    public string Nome { get; set; }
    public string Sobrenome { get; set; }
}