using System.ComponentModel.DataAnnotations;

namespace AppClassLibraryClient.model
{
    public class UsuarioLoginRequest
    {
        /// <summary>
        /// Nome de usuário para acessar a conta
        /// </summary>
        /// <example>user0@email.com</example>
        [Required]
        public string Email { get; set; }

        /// <summary>
        /// Senha do usuário
        /// </summary>
        /// <example>q1w2e3r4</example>
        [Required]
        public string Senha { get; set; }
    }
}
