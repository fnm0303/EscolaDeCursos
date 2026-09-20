using EscolaDeCursos.WebApp.Compartilhado.Dominio;
using EscolaDeCursos.WebApp.Compartilhado.Infraestrutura.ORM;
using EscolaDeCursos.WebApp.Modulos.ModuloAluno.Dominio;

namespace EscolaDeCursos.WebApp.Modulos.ModuloAluno.Infraestrutura;

public sealed class RepositorioAlunoEmOrm : IRepositorio<Aluno>
{
    private readonly EscolaDeCursosDbContext dbContext;

    public RepositorioAlunoEmOrm(EscolaDeCursosDbContext dbContext)
    {
        this.dbContext = dbContext;
    }
    public void Cadastrar(Aluno entidade)
    {
        dbContext.Alunos.Add(entidade);

        dbContext.SaveChanges();
    }

    public bool Editar(Guid idSelecionado, Aluno entidadeAtualizada)
    {
        Aluno? aluno = SelecionarPorId(idSelecionado);

        if (aluno == null)
            return false;

        aluno.Atualizar(entidadeAtualizada);

        dbContext.SaveChanges();

        return true;
    }

    public bool Excluir(Guid idSelecionado)
    {
        Aluno? aluno = SelecionarPorId(idSelecionado);

        if (aluno == null)
            return false;

        dbContext.Alunos.Remove(aluno);

        dbContext.SaveChanges();

        return true;
    }

    public Aluno? SelecionarPorId(Guid idSelecionado)
    {
        return dbContext.Alunos.SingleOrDefault(i => i.Id == idSelecionado);
    }

    public List<Aluno> SelecionarTodos()
    {
        return dbContext.Alunos.ToList();
    }
}
