public class ServicoDeCaminhao : ServicoDeVeiculo<Caminhao>
{ 
    public ServicoDeCaminhao() {}

    public int ObtenhaQuantidadeDeVeiculos()
    {
        return veiculos.Count;
    }
}