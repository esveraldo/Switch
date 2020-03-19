using Switch.Domain.Enums;
using System;

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
    }
}
