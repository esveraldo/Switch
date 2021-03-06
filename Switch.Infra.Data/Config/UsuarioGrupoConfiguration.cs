﻿using Microsoft.EntityFrameworkCore;
using Switch.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Switch.Infra.Data.Config
{
    public class UsuarioGrupoConfiguration : IEntityTypeConfiguration<UsuarioGrupo>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<UsuarioGrupo> builder)
        {
            builder.HasKey(u => new { u.UsuarioId, u.GrupoId });

            builder.Property(u => u.DataCriacao).IsRequired();
            builder.Property(u => u.Administrador);

        }
    }

}