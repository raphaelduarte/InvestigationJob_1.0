namespace InvestigationJob.API.Entities.Interface.Endereco;

public interface IBairroCidade : IBairro, ICidade
{
    public Guid IdBairroCidade { get; set; }
    IList<IBairro> Bairros { get; set; }
    IList<ICidade> Cidades { get; set; }
}