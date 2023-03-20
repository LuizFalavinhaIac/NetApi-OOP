public abstract class ServicoDeVeiculo<T> where T : Veiculo
{
    protected List<T> veiculos = new List<T>();

    public void InsiraVeiculo(T veiculo)
    {
        veiculos.Add(veiculo);
    }

    public T ObtenhaVeiculo(int codigo)
    {
        return veiculos.FirstOrDefault(v => v.Codigo == codigo);
    }

    public List<T> ObtenhaListaDeVeiculos()
    {
        return veiculos;
    }
}