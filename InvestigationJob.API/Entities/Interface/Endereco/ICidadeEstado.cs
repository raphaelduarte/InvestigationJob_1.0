namespace InvestigationJob.API.Entities.Interface.Endereco;

public interface ICidadeEstado : ICidade, IEstado
{
    public Guid IdCidadeEstado { get; set; }
    IList<ICidade> Cidades { get; set; }
    IList<IEstado> Estados { get; set; }
}