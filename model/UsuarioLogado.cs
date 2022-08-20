/// <summary>
/// Classe que representa usuário que irá se autenticar
/// </summary>
public class UsuarioLogado
{
    public string access_token { get; set; }
    public string token_type { get; set; }
    public long expires_in { get; set; }
    public string scope { get; set; }
    public string Mensagem { get; set; }
}