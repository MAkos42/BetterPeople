﻿// <auto-generated />
using BetterPeople.Resources.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BetterPeople.Migrations
{
    [DbContext(typeof(SqLiteDBContext))]
    partial class SqLiteDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity("BetterPeople.Resources.Database.Target", b =>
                {
                    b.Property<ulong>("ServerId")
                        .ValueGeneratedOnAdd();

                    b.Property<ulong>("ClientId");

                    b.Property<ulong>("TargetId");

                    b.Property<string>("Username");

                    b.HasKey("ServerId");

                    b.ToTable("Targets");
                });
#pragma warning restore 612, 618
        }
    }
}
