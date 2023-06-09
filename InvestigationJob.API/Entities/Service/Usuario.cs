﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using InvestigationJob.API.Entities.Interface;

namespace InvestigationJob.API.Entities.Service;

[Table("Usuario")]
public class Usuario : IUsuario
{
    [Key]
    public Guid IdUsuario { get; }
    private Guid _idNomeCompleto;
    private Guid _idCpf;
    private Guid _idTelefone;
    private Guid _idEndereco;
    private Guid _idImage;
    private int _idNomeCompleto1;
    private int _idCpf1;
    private int _idTelefone1;
    private int _idEndereco1;
    private int _idImage1;
    

    int IUsuario.IdNomeCompleto
    {
        get => _idNomeCompleto1;
        set => _idNomeCompleto1 = value;
    }

    int IUsuario.IdCpf
    {
        get => _idCpf1;
        set => _idCpf1 = value;
    }

    int IUsuario.IdTelefone
    {
        get => _idTelefone1;
        set => _idTelefone1 = value;
    }

    int IUsuario.IdEndereco
    {
        get => _idEndereco1;
        set => _idEndereco1 = value;
    }

    int IUsuario.IdImage
    {
        get => _idImage1;
        set => _idImage1 = value;
    }

    Guid INomeCompleto.IdNomeCompleto
    {
        get => _idNomeCompleto;
        set => _idNomeCompleto = value;
    }

    public string Nome { get; set; }
    public string Sobrenome { get; set; }

    Guid ICpf.IdCpf
    {
        get => _idCpf;
        set => _idCpf = value;
    }

    public int Cpf { get; set; }

    Guid ITelefone.IdTelefone
    {
        get => _idTelefone;
        set => _idTelefone = value;
    }

    public int Ddd { get; set; }
    public int NumeroTelefone { get; set; }

    Guid IEndereco.IdEndereco
    {
        get => _idEndereco;
        set => _idEndereco = value;
    }

    public string Rua { get; set; }
    public int Numero { get; set; }
    public string Bairro { get; }

    Guid IImage.IdImage
    {
        get => _idImage;
        set => _idImage = value;
    }

    public string Image { get; set; }
}