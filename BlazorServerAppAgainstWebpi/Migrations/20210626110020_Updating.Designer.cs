// <auto-generated />
using BlazorServerAppAgainstWebpi;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BlazorServerAppAgainstWebpi.Migrations
{
    [DbContext(typeof(EmployeeDbContext))]
    [Migration("20210626110020_Updating")]
    partial class Updating
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "6.0.0-preview.5.21301.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Employee.EmployeeClass", b =>
                {
                    b.Property<string>("EmployeeId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("EmployeeFirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmployeeLastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pojectName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmployeeId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            EmployeeId = "0a6598eb-96bc-4bda-8eee-3bd04d0d5caa",
                            EmployeeFirstName = "Prakash",
                            EmployeeLastName = "Dubey",
                            pojectName = "Blazor"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
