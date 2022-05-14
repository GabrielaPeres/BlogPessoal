using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using BlogPessoal.src.modelos;
using BlogPessoal.src.data;

namespace BlogPessoalTeste.Testes.data
{
    [TestClass]
    public class BlogPessoalContextoTeste
    {
        private BlogPessoalContexto _contexto;

        [TestInitialize]
        public void inicio()
        {
            var opt = new DbContextOptionsBuilder<BlogPessoalContexto>()
                .UseInMemoryDatabase(databaseName: "db_blogpessoal")
                .Options;

            _contexto = new BlogPessoalContexto(opt);
        }

        [TestMethod]
        public void InserirNovoUsuarioNoBancoRetornarUsuario()
        {
            UsuarioModelo usuario = new UsuarioModelo();

            usuario.Nome = "Gabriela Peres";
            usuario.Email = "gabriela@email.com";
            usuario.Senha = "134652";
            usuario.Foto = "AKITAOLINKDAFOTO";

            _contexto.Usuarios.Add(usuario); // Adcionando usuario

            _contexto.SaveChanges(); // Commita criação

            Assert.IsNotNull(_contexto.Usuarios.FirstOrDefault(u => u.Email == "gabriela@email.com"));
        }
    }
}
