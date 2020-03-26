using Switch.Domain.Enums;
using System;
using System.Collections.Generic;

namespace Switch.Domain.Entities
{
    public class Usuario
    {
        public int Id { get; private set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public DateTime DataDeNascimento { get; set; }
        public string Foto { get; set; }
        public SexoEnum Sexo { get; set; }
        public virtual Identificacao Identificacao { get; set; }
        public virtual StatusRelacionamento StatusRelacionamento { get; set; }
        public virtual ProcurandoPor ProcurandoPor { get; set; }


        public virtual ICollection<Post> Posts { get; set; }
        public virtual ICollection<UsuarioGrupo> UsuarioGrupos { get; set; }
        public virtual ICollection<LocalDeTrabalho> LocaisDeTrabalho { get; set; }
        public virtual ICollection<InstituicaoDeEnsino> InstituicoesDeEnsino { get; set; }
        public virtual ICollection<Amigo> Amigos { get; set; }
        public virtual ICollection<Comentario> Comentarios { get; set; }
        public string SexoEnum { get; set; }

        public Usuario()
        {
            Posts = new List<Post>();
            UsuarioGrupos = new List<UsuarioGrupo>();
            LocaisDeTrabalho = new List<LocalDeTrabalho>();
            InstituicoesDeEnsino = new List<InstituicaoDeEnsino>();
            Amigos = new List<Amigo>();
        }
    }
}
