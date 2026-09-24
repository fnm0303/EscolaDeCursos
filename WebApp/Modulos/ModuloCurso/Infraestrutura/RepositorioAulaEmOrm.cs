using EscolaDeCursos.WebApp.Modulos.ModuloCurso.Dominio;

namespace EscolaDeCursos.WebApp.Modulos.ModuloCurso.Infraestrutura;

public sealed class RepositorioAulaEmOrm : IRepositorioAula
{
    public void Cadastrar(Aula entidade)
    {
        throw new NotImplementedException();
    }

    public bool Editar(Guid idSelecionado, Aula entidadeAtualizada)
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

    public bool ExisteComOrdem(Guid cursoId, int ordem, Guid? idIgnorado = null)
    {
        throw new NotImplementedException();
    }

    public bool ExistePorCursoId(Guid cursoId)
    {
        throw new NotImplementedException();
    }

    public List<Aula> SelecionarPorCursoId(Guid cursoId)
    {
        throw new NotImplementedException();
    }

    public Aula? SelecionarPorId(Guid idSelecionado)
    {
        throw new NotImplementedException();
    }

    public List<Aula> SelecionarTodos()
    {
        throw new NotImplementedException();
    }
}
