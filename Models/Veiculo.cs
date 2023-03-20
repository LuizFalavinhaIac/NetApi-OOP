public abstract class Veiculo
{
    public Veiculo(ETipoVeiculo tipo) 
    {
        Tipo = tipo;
    }

    public Veiculo(int codigo, string descricao, string placa, ETipoVeiculo tipo) : this(tipo)
    {
        Codigo = codigo;
        Descricao = descricao;
        Placa = placa;
    }

    public int Codigo { get; set; }
    public string Descricao { get;set; }
    public string Placa { get; set; }
    public ETipoVeiculo Tipo { get; set; }
}