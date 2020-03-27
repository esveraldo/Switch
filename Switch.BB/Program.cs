using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Logging;
using Switch.BB.Reports;
using Switch.Domain.Entities;
using Switch.Domain.Enums;
using Switch.Infra.CrossCutting;
using Switch.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Switch.BB
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario User1;
            Usuario User2;
            Usuario User3;
            Usuario User4;
            Usuario User5;
            Usuario User6;

            Usuario CriarUsuario(string nome)
            {
                return new Usuario()
                {
                    Nome = nome,
                    Sobrenome = "Martins",
                    Email = "esveraldo@hotmail.com",
                    Senha = "123",
                    DataDeNascimento = new DateTime(1968, 01, 10),
                    Foto = "C:\\Temp",
                    Sexo = SexoEnum.Masculino
                };
            }
            /*var usuario = new Usuario()
            {
                Nome = "Esveraldo",
                Sobrenome = "Martins",
                Email = "esveraldo@hotmail.com",
                Senha = "123",
                DataDeNascimento = new DateTime(1968, 01, 10),
                Foto = "C:\\Temp",
                Sexo = SexoEnum.Masculino
            };*/

            User1 = CriarUsuario("Anna Luiza");
            User2 = CriarUsuario("Maria Eduarda");
            User3 = CriarUsuario("Adriana");
            User4 = CriarUsuario("José");
            User5 = CriarUsuario("Maria");
            User6 = CriarUsuario("Rodolfo");

            List<Usuario> usuarios = new List<Usuario>()
            {
                User1, User2, User3, User4, User5, User6,
            };


            var optionBuilder = new DbContextOptionsBuilder<SwitchContext>();
            optionBuilder.UseLazyLoadingProxies();
            optionBuilder.UseMySql("Server=localhost;userid=root;password=root;database=SwitchDB", m => m.MigrationsAssembly("Switch.Infra.Data").MinBatchSize(1000));//Máximo 1000
            //ESTA LINHA ABAIXO, MOSTRA O VALOR DO PARAMETRO QUE FOI ALTERADO NO LOG, SOMENTE ISSO
            //optionBuilder.EnableSensitiveDataLogging();

            try
            {
                using (var dbcontext = new SwitchContext(optionBuilder.Options))
                {
                    dbcontext.GetService<ILoggerFactory>().AddProvider(new Logger());
                    //dbcontext.Usuarios.AddRange(usuarios);
                    //dbcontext.SaveChanges();

                    //-----------------------------------//

                    /*var Esveraldo = dbcontext.Usuarios.FirstOrDefault(u => u.Nome == "Esveraldo");
                    Esveraldo.Senha = "abc123";
                    dbcontext.Update<Usuario>(Esveraldo);
                    dbcontext.SaveChanges();*/

                    //CHANGE TRACKER(QUANDO VOCE CRIA dbcontext.ChangeTracker, tem que criar funcao, como la no final ExibirChangeTracke )
                    /*var usuario0 = CriarUsuario("usuario0");
                    Console.WriteLine("Criando usuario0..");
                    Console.WriteLine("Verificando o ChangeTracker de usuario0");
                    dbcontext.Usuarios.Add(usuario0);
                    ExibirChangeTracker(dbcontext.ChangeTracker);

                    // #region Operations

                    ////Obtendo
                    var usuario1 = dbcontext.Usuarios.FirstOrDefault(u => u.Nome == "usuarioNovo1");
                    Console.WriteLine("Obtendo usuario1");
                    Console.WriteLine("Verificando o ChangeTracker de usuario1");
                    ExibirChangeTracker(dbcontext.ChangeTracker);

                    ////Editando
                    Console.WriteLine("Editando usuario1");
                    usuario1.Nome = "NovoNomeUsuario";
                    Console.WriteLine("Verificando o ChangeTracker de usuario1");
                    ExibirChangeTracker(dbcontext.ChangeTracker);

                    ////Adicionando Novo
                    var usuarioNovo2 = CriarUsuario("usuarioNovo2");
                    Console.WriteLine("Adicionando usuarioNovo2");
                    dbcontext.Usuarios.Add(usuarioNovo2);
                    Console.WriteLine("Verificando o ChangeTracker de usuarioNovo2");
                    ExibirChangeTracker(dbcontext.ChangeTracker);

                    ////Deletando
                    Console.WriteLine("Deletando usuario1");
                    Console.WriteLine("Verificando o ChangeTracker de usuario1");
                    dbcontext.Usuarios.Remove(usuario1);
                    ExibirChangeTracker(dbcontext.ChangeTracker);

                    ////Detached/desanexado
                    var usuario3 = CriarUsuario("Usuario3");
                    Console.WriteLine("Status do Usuario3");
                    Console.WriteLine(dbcontext.Entry(usuario3).State);
                    //#endregion*/

                    //-----------------------------------------------------//

                    /*var usuario123 = CriarUsuario("usuario123");
                    var usuario124 = CriarUsuario("usuario123");

                    var TotalUsuarios = dbcontext.Usuarios.Count(u => u.Nome == "usuario123");
                    var usuario = dbcontext.Usuarios.FirstOrDefault(u => u.Nome == "usuario123");

                    //chamada do dbcontext
                    dbcontext.Remove<Usuario>(usuario);
                    //chamada do dbset
                    //dbcontext.Usuarios.Remove(usuario);
                    dbcontext.SaveChanges();

                    TotalUsuarios = dbcontext.Usuarios.Count(u => u.Nome == "usuario123");*/

                    //--------------------------------------------//

                    /*var Esveraldo = CriarUsuario("Esveraldo");
                    Console.WriteLine("Id do Esveraldo: " + Esveraldo.Id);
                    Console.ReadKey();

                    dbcontext.Usuarios.Add(Esveraldo);
                    Console.WriteLine("Id do Esveraldo: " + Esveraldo.Id);
                    Console.ReadKey();

                    dbcontext.SaveChanges();
                    Console.WriteLine("Id do Esveraldo: " + Esveraldo.Id);
                    Console.ReadKey();*/

                    //----------------------------------------//

                    //EAGER LOADING - faz o carregamento de todas as informações(imediato) - ver no log

                    //var instituicao = dbcontext.InstituicoesEnsino.include(i => i.Usuario).FirstOrDefault();
                    //var usuario = instituicao.Usuario;

                    //--------------------------------------//

                    //LAZY LOADING - carregamento sob demanda ver no log

                    //var usuario = dbcontext.Usuarios.FirstOrDefault();
                    //var instituicoes = usuario.InstituicaoDeEnsino;

                    //--------------------------------//

                    //var Esveraldo = dbcontext.Usuarios.FirstOrDefault(u => u.Nome == "Esveraldo");
                    //Esveraldo.Senha = "123456";

                    //dbcontext.Update<Usuario>(Esveraldo);
                    //dbcontext.SaveChanges();

                    //--------------------------------//

                    //ADICIONAR INSTANCIA RELACIONADA

                    /*var jose = CriarUsuario("José");

                    jose.InstituicoesDeEnsino.Add(new InstituicaoDeEnsino() { Nome = "Faculdade Unicarioca" });
                    jose.Identificacao = new Identificacao() { Numero = "123456789" });

                    dbcontext.Usuarios.Add(jose);
                    dbcontext.SaveChanges();*/

                    //ATUALIZAR INSTANCIA RELACIONADA

                    /*var jose = dbcontext.Usuarios.FirstOrDefault(u => u.Nome == "José");
                    var instituicaoDeEnsino = jose.InstituicoesDeEnsino.FirstOrDefault(i => i.Nome.Contains("Faculdade Unicarioca"));

                    instituicaoDeEnsino.Nome = "Faculdade Unicarioca - Tecnologia";
                    dbcontext.SaveChanges();*/

                    //REMOVER ITEM DE UMA INSTANCIA

                    /*var jose = dbcontext.Usuarios.FirstOrDefault(u => u.Nome == "José");
                    var instituicaoDeEnsino = jose.InstituicoesDeEnsino.FirstOrDefault(i => i.Nome == "Faculdade Unicarioca - Tecnologia");

                    jose.InstituicoesDeEnsino.Remove(instituicaoDeEnsino);

                    dbcontext.SaveChanges();*/

                    //------------------------------//

                    //PROJEÇÃO COM EF CORE

                    /*var sql = "select Nome, SobreNome from usuarios";

                    var connection = dbcontext.Database.GetDbConnection();
                    var ListaUsuarios = new List<UsuarioDTO>();

                    using (var command = connection.CreateCommand())
                    {
                        connection.Open();
                        command.CommandText = sql;

                        using (var dataReader = command.ExecuteReader())
                        {
                            if (dataReader.HasRows)
                            {
                                while (dataReader.Read())
                                {
                                    var usuarioDTO = new UsuarioDTO();
                                    usuarioDTO.Nome = dataReader["nome"].ToString();
                                    usuarioDTO.SobreNome = dataReader["sobrenome"].ToString();
                                    ListaUsuarios.Add(usuarioDTO);
                                }

                            }
                        }
                    }*/

                    //LIMPAR O PARAMETRO CONTRA SQL INJECTION

                    var FiltroPesquisa = "Esveraldo";

                    var sql = "select Nome, SobreNome from usuarios where nome = '@nomeUsuario'";

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

        public static void ExibirChangeTracker(ChangeTracker changeTracker)
        {
            foreach (var entry in changeTracker.Entries())
            {
                Console.WriteLine("Nome da Instancia: " + entry.Entity.GetType().FullName);
                Console.WriteLine("Status da Entidade: " + entry.State);
                Console.WriteLine("-------------");
            }

            Console.WriteLine("");
            Console.WriteLine("");
        }
    }
}
