using EscolaDeCursos.WebApp.Compartilhado.Infraestrutura.ORM;
using EscolaDeCursos.WebApp.Modulos.ModuloCurso.Dominio;
using Microsoft.EntityFrameworkCore;

namespace EscolaDeCursos.WebApp.Modulos.ModuloCurso.Infraestrutura;

public sealed class RepositorioCursoEmOrm : IRepositorioCurso
{
    public void Cadastrar(Curso entidade)
    {
        throw new NotImplementedException();
    }

    public bool Editar(Guid idSelecionado, Curso entidadeAtualizada)
    {
        throw new NotImplementedException();
    }

    public bool Excluir(Guid idSelecionado)
    {
        throw new NotImplementedException();
    }

    public bool ExisteComNome(string nome, Guid? idIgnorado = null)
    {
        throw new NotImplementedException();
    }

    public Curso? SelecionarPorId(Guid idSelecionado)
    {
        throw new NotImplementedException();
    }

    public List<Curso> SelecionarTodos()
    {
        throw new NotImplementedException();
    }
}