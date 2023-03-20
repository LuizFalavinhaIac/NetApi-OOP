public class Carro : Veiculo
{
    public Carro() : base(ETipoVeiculo.CARRO)
    { }

    public Carro(int codigo, string descricao, string placa, int ocupacaoMaxima)
        : base(codigo, descricao, placa, ETipoVeiculo.CARRO)
    {
        OcupacaoMaxima = ocupacaoMaxima;
    }

    public int OcupacaoMaxima { get; set; }
}