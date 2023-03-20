public class Caminhao : Veiculo
{
    public Caminhao() : base(ETipoVeiculo.CAMINHAO)
    { }

    public Caminhao(int codigo, string descricao, string placa, string chassi, int pesoEmToneladas) 
        : base(codigo, descricao, placa, ETipoVeiculo.CAMINHAO) 
    {
        Chassi = chassi;
        PesoEmToneladas = pesoEmToneladas;
    }

    public string Chassi { get; set; }
    public int PesoEmToneladas { get; set; }
}