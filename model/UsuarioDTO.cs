using AppClassLibraryDomain.model;
using System;

namespace AppClassLibraryClient.model
{
    public class UsuarioDTO
    {
        public virtual long Id { get; set; }
        public virtual string Nome { get; set; }
        public virtual string Email { get; set; }
        public virtual bool? Ativo { get; set; }
        public virtual DateTimeOffset? DataOperacao { get; set; }
        public virtual DateTimeOffset? DataUltimoAcesso { get; set; }
        public virtual UsuarioFotoPerfil UsuarioFotoPerfil { get; set; }
    }
}
