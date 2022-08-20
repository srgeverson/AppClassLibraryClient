using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace AppClassLibraryClient.model
{
    public class UsuarioRequest
    {
        /// <summary>
        /// Nome de usuário para acessar a conta
        /// </summary>
        /// <example>Geverson</example>
        [Required]
        public string Nome { get; set; }

        /// <summary>
        /// Nome de usuário para acessar a conta
        /// </summary>
        /// <example>srgeverson@email.com</example>
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
