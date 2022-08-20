namespace AppClassLibraryClient.model
{
    /// <summary>
    /// Classe que representa o payload do token JWT.
    /// </summary>
    public class PayloadToken
    {
        /// <summary>
        /// (subject) = Entidade à quem o token pertence, normalmente o ID do usuário.
        /// </summary>
        public long? sub { get; set; }
        /// <summary>
        /// (issuer) = Emissor do token.
        /// </summary>
        public string iss { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int[] roles { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// (issued at) = Timestamp de quando o token foi criado.
        /// </summary>
        public long iat { get; set; }
        /// <summary>
        /// (expiration) = Timestamp de quando o token irá expirar;
        /// </summary>
        public long exp { get; set; }
        /// <summary>
        /// (audience) = Destinatário do token, representa a aplicação que irá usá-lo.
        /// </summary>
        public string aud { get; set; }
    }
}
