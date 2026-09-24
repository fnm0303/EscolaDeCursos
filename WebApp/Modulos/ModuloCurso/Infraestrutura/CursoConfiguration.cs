using EscolaDeCursos.WebApp.Modulos.ModuloCurso.Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EscolaDeCursos.WebApp.Modulos.ModuloCurso.Infraestrutura;

public sealed class CursoConfiguration : IEntityTypeConfiguration<Curso>
{
    public void Configure(EntityTypeBuilder<Curso> builder)
    {
        builder.ToTable("TBCursos");

        builder.HasKey(c => c.Id);
        builder.Property(c => c.Id).ValueGeneratedNever();

        builder.Property(c => c.Nome).HasMaxLength(100).IsRequired();

        builder.Property(c => c.Nivel).HasConversion<string>().IsRequired();

        builder.Property(c => c.CargaHoraria).IsRequired();

        builder.HasMany(c => c.Aulas) // Curso:1 N:Aulas
        .WithOne(a => a.Curso)
        .HasForeignKey(a => a.CursoId)
        .HasConstraintName("FK_TBAulas_TBCursos")
        .OnDelete(DeleteBehavior.Restrict);
    }
}
