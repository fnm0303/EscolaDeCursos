using EscolaDeCursos.WebApp.Compartilhado.Infraestrutura.Arquivos;
using EscolaDeCursos.WebApp.Modulos.ModuloCurso.Dominio;

namespace EscolaDeCursos.WebApp.Modulos.ModuloCurso.Infraestrutura;

public sealed class RepositorioCursoEmArquivo(ContextoJson contexto)
    : RepositorioBaseEmArquivo<Curso>(contexto), IRepositorioCurso
{
    public bool ExisteComNome(string nome, Guid? idIgnorado = null)
    {
        return registros.Any(c =>
            c.Id != idIgnorado &&
            string.Equals(c.Nome.Trim(), nome.Trim(), StringComparison.OrdinalIgnoreCase)
        );
    }

    public override List<Curso> SelecionarTodos()
    {
        return registros.OrderBy(c => c.Nome).ToList();
    }

    public override bool Excluir(Guid idSelecionado)
    {
        bool possuiVinculos = contexto.Aulas.Any(a => a.Curso.Id == idSelecionado);

        return !possuiVinculos && base.Excluir(idSelecionado);
    }

    protected override List<Curso> ObterRegistros(ContextoJson contexto)
    {
        return contexto.Cursos;
    }
}