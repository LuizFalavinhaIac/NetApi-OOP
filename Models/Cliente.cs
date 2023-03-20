class Cliente
{
    private readonly List<Contato> _contatos = new List<Contato>();

    public string Nome { get; }
    public string Email { get; }
    public string Telefone { get; }
    public string Endereco { get; }

    public IReadOnlyList<Contato> Contatos => _contatos;

    public Cliente(string nome, string email, string telefone, string endereco)
    {
        Nome = nome;
        Email = email;
        Telefone = telefone;
        Endereco = endereco;
    }

    public void AdicionarContato(
        int codigo, 
        string nome, 
        string telefone, 
        ETipoRelacionamentoContato tipo
    )
    {
        var novoContato = new Contato(codigo, nome, telefone, tipo);

        if (!CadastroContatoExiste(novoContato))
        {
            _contatos.Add(novoContato);
            OrdenarContatos();
        }
    }

    private bool CadastroContatoExiste(Contato novoContato)
    {
        return _contatos.Any(contato => 
            contato.Telefone == novoContato.Telefone &&
            contato.Tipo == novoContato.Tipo
        );
    }

    private void OrdenarContatos()
    {
        _contatos.Sort((c1, c2) => c1.Codigo.CompareTo(c2.Codigo));
    }
}