﻿// <auto-generated />
using Algorithm_Solver.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Algorithm_Solver.Migrations
{
    [DbContext(typeof(Algorithm_SolverContext))]
    partial class Algorithm_SolverContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Algorithm_Solver.Models.AlgorithmTask", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Input");

                    b.Property<string>("Name");

                    b.Property<string>("Output");

                    b.HasKey("Id");

                    b.ToTable("AlgorithmTask");
                });

            modelBuilder.Entity("Algorithm_Solver.Models.Score", b =>
                {
                    b.Property<string>("NickName")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Losses");

                    b.Property<int>("Wins");

                    b.HasKey("NickName");

                    b.ToTable("Score");
                });
#pragma warning restore 612, 618
        }
    }
}
