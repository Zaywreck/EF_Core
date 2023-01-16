using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OOP.EFCore.ConsoleApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.EFCore.ConsoleApp.DAL_data_access_layer.Mapping
{
    public class BookMap : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasKey(b => b.BookId);
            builder.Property(b => b.Title)
                .IsRequired()
                .HasMaxLength(250);
            builder.Property(b => b.CreatedDate)
                .HasDefaultValue(DateTime.Now);
            builder.Property(b => b.Price)
                .HasDefaultValue(0)
                .IsRequired();
            builder.HasData(
                new Book(1, "Sherlock Holmes",40) { CategoryId=3},
                new Book(2, "İyiki Ölsem",50) { CategoryId=1},
                new Book(3, "Suç ve Ceza",60) { CategoryId=1},
                new Book(4, "Satranç",20) { CategoryId = 1 }
            );
            builder.HasOne(b=> b.Category)
                .WithMany(c=>c.Books)
                .HasForeignKey(b=>b.CategoryId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}