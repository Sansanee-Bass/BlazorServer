// <auto-generated />
using System;
using BlazorServer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BlazorServer.Migrations
{
    [DbContext(typeof(BlogContext))]
    partial class BlogContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.4");

            modelBuilder.Entity("BlazorServer.Models.BlogEntry", b =>
                {
                    b.Property<uint>("BlogEntryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Content")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Time")
                        .HasColumnType("datetime");

                    b.Property<string>("Title")
                        .HasColumnType("varchar(120)");

                    b.HasKey("BlogEntryId");

                    b.ToTable("Entries");
                });
#pragma warning restore 612, 618
        }
    }
}
