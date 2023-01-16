using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OOP.EFCore.ConsoleApp.Entities;
using OOP.EFCore.ConsoleApp.Migrations;

namespace OOP.EFCore.ConsoleApp.DAL_data_access_layer.Mapping
{
    public class AuthorMap : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.HasKey(a => a.AuthorID);
            builder.Ignore(a => a.FullName);
            builder.Property(a => a.CreatedDate).HasDefaultValue(DateTime.Now);
            builder.HasData(
                new Author { AuthorID=1, FirstName="Mert", LastName="Gülle"},
                new Author { AuthorID=2, FirstName="Sena Nur", LastName="Gülle"},
                new Author { AuthorID=3, FirstName="Bora Han", LastName="Gülle" }
            );
        }
    }
}
