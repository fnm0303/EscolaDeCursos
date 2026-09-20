using EscolaDeCursos.WebApp.Modulos.ModuloAluno.Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EscolaDeCursos.WebApp.Modulos.ModuloAluno.Infraestrutura;

public sealed class AlunoConfiguration : IEntityTypeConfiguration<Aluno>
{
    public void Configure(EntityTypeBuilder<Aluno> builder)
    {
        builder.ToTable("TBAlunos");

        builder.HasKey(i => i.Id);
        builder.Property(i => i.Id).ValueGeneratedNever();

        builder.Property(i => i.Nome).HasMaxLength(100).IsRequired();
        builder.Property(i => i.Email).IsRequired();
        builder.Property(i => i.NumeroMatricula).IsRequired();

        builder.HasIndex(i => i.Email).IsUnique();
        builder.HasIndex(i => i.NumeroMatricula).IsUnique();
    }
}
