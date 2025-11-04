using System;
using Microsoft.EntityFrameworkCore;

namespace Projeto1
{
    public class Repository : DbContext
    {
        private static readonly String _connectionParams = @"server=127.0.0.1;port=3307;uid=root;pwd=;database=projeto1";

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Credencial> Credenciais { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Compra> Compras { get; set; }
        public DbSet<Item> Itens { get; set; }
        public DbSet<Pagamento> Pagamentos { get; set; }
        public DbSet <Vendedor> Vendendores { get; set; }

        public Repository()
        {
            Repository db = this;
            if (this.Database.EnsureCreated())
            {
                Credencial cPadrao = new Credencial();
                cPadrao.NomeUsuario = "ana.zaira";
                cPadrao.Senha = "12345678";
                cPadrao.Gerente = true;
                cPadrao.UltimoAcesso = DateTime.Now;
                
                Usuario padrao = new Usuario();
                padrao.Nome = "Ana Zaira da Silva";
                padrao.Telefone = "(00)00000-0000";
                padrao.Email = "anazaira@email.com";
                padrao.CredencialId = cPadrao.Id;

                padrao.Credencial = cPadrao;
                cPadrao.Usuario = padrao;

                CredencialRepository.SaveOrUpdate(cPadrao);
                UsuarioRepository.SaveOrUpdate(padrao);
            }
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseMySQL(_connectionParams);
        }
    }
}
