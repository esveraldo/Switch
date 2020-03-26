using Microsoft.EntityFrameworkCore;
using Switch.Domain.Entities;
using Switch.Domain.Enums;
using Switch.Infra.Data.Context;
using System;

namespace SwitchApp
{
    class Program
    {
        static void Main(string[] args)
        {
        var usuario = new Usuario() { Nome = "Esveraldo", Sobrenome = "Martins",
            Email = "esveraldo@hotmail.com", Senha = "123", DataDeNascimento = new DateTime(1968, 01, 10),
            Foto = "C:\\Temp", Sexo = SexoEnum.Masculino };

            var optionBuilder = new DbContextOptionsBuilder<SwitchContext>();
            optionBuilder.UseLazyLoadingProxies();
            optionBuilder.UseMySql("Server=localhost;userid=root;password=root;database=SwitchDB", m => m.MigrationsAssembly("Switch.Infra.Data"));

            try
            {
                using (var dbcontext = new SwitchContext(optionBuilder.Options))
                {
                    dbcontext.Usuarios.Add(usuario);
                    dbcontext.SaveChanges();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }
            Console.WriteLine("Teste passou!");
            Console.ReadKey();
        }
    }
}
