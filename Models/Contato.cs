class Contato
{
    public int Codigo { get; }
    public string Nome { get; }
    public string Telefone { get; }
    public ETipoRelacionamentoContato Tipo { get; }

    public Contato(
        int codigo, 
        string nome, 
        string telefone, 
        ETipoRelacionamentoContato tipo
    )
    {
        Codigo = codigo;
        Nome = nome;
        Telefone = telefone;
        Tipo = tipo;
    }
}