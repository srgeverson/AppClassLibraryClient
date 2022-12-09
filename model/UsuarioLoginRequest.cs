using Newtonsoft.Json;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace AppClassLibraryClient.model
{
    public class UsuarioLoginRequest
    {
        /// <summary>
        /// Nome de usuário para acessar a conta
        /// </summary>
        /// <example>user0@email.com</example>
        [Required]
        [DataMember(Name = "email")]
        [JsonProperty(PropertyName = "email")]
        [StringLength(2, ErrorMessage = "A quantidade máxima de caracteres é 255. ")]
        [DefaultValue("")]
        public string Email { get; set; }

        /// <summary>
        /// Senha do usuário
        /// </summary>
        /// <example>q1w2e3r4</example>
        [Required]
        [DataMember(Name = "senha")]
        [JsonProperty(PropertyName = "senha")]
        [StringLength(255, ErrorMessage = "A quantidade máxima de caracteres é 255. ")]
        [DefaultValue("")]
        public string Senha { get; set; }
    }
}
