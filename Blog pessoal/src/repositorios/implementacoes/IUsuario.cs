using Blog_pessoal.src.modelos;
using BlogPessoal.src.dtos;

namespace BlogPessoal.src.repositorios
{
    /// <summary>
    /// <para>Resumo: Responsavel por representar ações de CRUD de usuario</para>
    /// <para>Criado por:Gabrila Peres</para>
    /// <para>Versão: 1.0</para>
    /// <para>Data: 29/04/2022</para>
    /// </summary>
    public interface IUsuario
    {
        void NovoUsuario(NovoUsuarioDTO usuario);
        void AtualizarUsuario(AtualizarUsuarioDTO usuario);
        void DeletarUsuario(int Id);
        UsuarioModelo PegarUsuarioPeloId(int Id);
        UsuarioModelo PegarPeloEmail(string email);
        UsuarioModelo PegarPeloNome(string email);
    }
}

