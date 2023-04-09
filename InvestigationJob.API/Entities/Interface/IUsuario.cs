using System.Collections.ObjectModel;

namespace InvestigationJob.API.Entities.Interface;

public interface IUsuario : INomeCompleto, ICpf, ITelefone, IEndereco
{
    public int Id { get;}
    public int IdNomeCompleto { get; set; }
    public int IdCpf { get; set; }
    public int IdTelefone { get; set; }
    public int IdEndereco { get; set; }
    
    
}