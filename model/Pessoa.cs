public class Pessoa
{
    public string Nome { get; set; }
    public string SobreNome { get; set; }

    public Pessoa()
    {
        Nome = string.Empty;
        SobreNome = string.Empty;
    }

    public override string ToString()
    {
        return string.Format("{0} {1}", Nome, SobreNome);
    }
}