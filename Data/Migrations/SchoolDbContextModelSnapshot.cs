// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ServerBlazorEF.data.Migrations
{
    [DbContext(typeof(SchoolDbContext))]
    partial class SchoolDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("ServerBlazorEF.Models.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("School")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StudentId");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            StudentId = 1,
                            FirstName = "Jane",
                            LastName = "Smith",
                            School = "Medicine"
                        },
                        new
                        {
                            StudentId = 2,
                            FirstName = "John",
                            LastName = "Fisher",
                            School = "Engineering"
                        },
                        new
                        {
                            StudentId = 3,
                            FirstName = "Pamela",
                            LastName = "Baker",
                            School = "Food Science"
                        },
                        new
                        {
                            StudentId = 4,
                            FirstName = "Peter",
                            LastName = "Taylor",
                            School = "Mining"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
