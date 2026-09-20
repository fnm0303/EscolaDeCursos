using EscolaDeCursos.WebApp.Modulos.ModuloInstrutor.Dominio;
using Microsoft.EntityFrameworkCore;

namespace EscolaDeCursos.WebApp.Modulos.ModuloInstrutor.Infraestrutura;

public sealed class InstrutorConfiguration : IEntityTypeConfiguration<Instrutor>
{
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Instrutor> builder)
    {
        builder.ToTable("TBInstrutores");

        //colunas da tabela
        builder.HasKey(i => i.Id); //chave primária
        builder.Property(i => i.Id).ValueGeneratedNever();

        builder.Property(i => i.Nome).HasMaxLength(100).IsRequired();
        builder.Property(i => i.Telefone).HasMaxLength(20).IsRequired();
        builder.Property(i => i.Cpf).HasMaxLength(15).IsRequired();

        builder.HasIndex(i => i.Telefone).IsUnique();
        builder.HasIndex(i => i.Cpf).IsUnique();
    }
}
