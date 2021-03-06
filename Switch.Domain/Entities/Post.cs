﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Switch.Domain.Entities
{
    public class Post
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public DateTime DataDoPost { get; set; }
        public string Postagem { get; set; }

        public int UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }

        public int GrupoId { get; set; }
        public virtual Grupo Grupo { get; set; }
    }
}
