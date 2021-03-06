// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Ticketing_RepoLayer;

namespace Ticketing_RepoLayer.Migrations
{
    [DbContext(typeof(Class1.Depotcontext))]
    partial class DepotcontextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Customer_Entities.Customer_Details", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Emailid");

                    b.Property<string>("Flight_Number");

                    b.Property<string>("PNR_number");

                    b.Property<string>("RName");

                    b.Property<string>("SeatNumbers");

                    b.Property<int>("age");

                    b.Property<string>("meal");

                    b.HasKey("Id");

                    b.HasIndex("Emailid");

                    b.ToTable("customer_Details");
                });

            modelBuilder.Entity("Customer_Entities.Customer_Header", b =>
                {
                    b.Property<string>("Emailid");

                    b.Property<string>("Name");

                    b.Property<int>("Nos");

                    b.HasKey("Emailid");

                    b.ToTable("Customer_Header");
                });

            modelBuilder.Entity("Customer_Entities.Discount", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("discount");

                    b.HasKey("id");

                    b.ToTable("Discounts");
                });

            modelBuilder.Entity("Customer_Entities.Customer_Details", b =>
                {
                    b.HasOne("Customer_Entities.Customer_Header", "Email_id")
                        .WithMany()
                        .HasForeignKey("Emailid");
                });
#pragma warning restore 612, 618
        }
    }
}
