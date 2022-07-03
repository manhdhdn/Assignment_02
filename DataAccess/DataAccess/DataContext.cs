using BusinessObject;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace DataAccess
{
    public partial class DataContext : DbContext
    {
        public DataContext()
        {
        }

        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Member> Members { get; set; } = null!;
        public virtual DbSet<Order> Orders { get; set; } = null!;
        public virtual DbSet<OrderDetail> OrderDetails { get; set; } = null!;
        public virtual DbSet<Product> Products { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(GetConnetionString());
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BusinessObject.Member", b =>
            {
                b.Property<int>("MemberId")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MemberId"), 1L, 1);

                b.Property<string>("City")
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnType("nvarchar(15)");

                b.Property<string>("CompanyName")
                    .IsRequired()
                    .HasMaxLength(40)
                    .HasColumnType("nvarchar(40)");

                b.Property<string>("Country")
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnType("nvarchar(15)");

                b.Property<string>("Email")
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnType("nvarchar(100)");

                b.Property<string>("Password")
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnType("nvarchar(30)");

                b.HasKey("MemberId");

                b.ToTable("Members");
            });

            modelBuilder.Entity("BusinessObject.Order", b =>
            {
                b.Property<int>("OrderId")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderId"), 1L, 1);

                b.Property<decimal?>("Freight")
                    .HasColumnType("decimal(18,2)");

                b.Property<int>("MemberId")
                    .HasColumnType("int");

                b.Property<DateTime>("OrderDate")
                    .HasColumnType("datetime2");

                b.Property<DateTime?>("RequiredDate")
                    .HasColumnType("datetime2");

                b.Property<DateTime?>("ShippedDate")
                    .HasColumnType("datetime2");

                b.HasKey("OrderId");

                b.HasIndex("MemberId");

                b.ToTable("Orders");
            });

            modelBuilder.Entity("BusinessObject.OrderDetail", b =>
            {
                b.Property<int>("OrderId")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderId"), 1L, 1);

                b.Property<double>("Discount")
                    .HasColumnType("float");

                b.Property<int>("ProductId")
                    .HasColumnType("int");

                b.Property<int>("Quantity")
                    .HasColumnType("int");

                b.Property<decimal>("UnitPrice")
                    .HasColumnType("decimal(18,2)");

                b.HasKey("OrderId");

                b.HasIndex("OrderId");

                b.HasIndex("ProductId");

                b.ToTable("OrderDetails");
            });

            modelBuilder.Entity("BusinessObject.Product", b =>
            {
                b.Property<int>("ProductId")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"), 1L, 1);

                b.Property<int>("CategoryId")
                    .HasColumnType("int");

                b.Property<string>("ProductName")
                    .IsRequired()
                    .HasMaxLength(40)
                    .HasColumnType("nvarchar(40)");

                b.Property<int>("UnitInStock")
                    .HasColumnType("int");

                b.Property<decimal>("UnitPrice")
                    .HasColumnType("decimal(18,2)");

                b.Property<string>("Weight")
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnType("nvarchar(20)");

                b.HasKey("ProductId");

                b.ToTable("Products");
            });

            modelBuilder.Entity("BusinessObject.Order", b =>
            {
                b.HasOne("BusinessObject.Member", null)
                    .WithMany("Orders")
                    .HasForeignKey("MemberId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();
            });

            modelBuilder.Entity("BusinessObject.OrderDetail", b =>
            {
                b.HasOne("BusinessObject.Order", null)
                    .WithMany("OrderDetails")
                    .HasForeignKey("OrderId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.HasOne("BusinessObject.Product", null)
                    .WithMany("OrderDetails")
                    .HasForeignKey("ProductId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();
            });

            modelBuilder.Entity("BusinessObject.Member", b =>
            {
                b.Navigation("Orders");
            });

            modelBuilder.Entity("BusinessObject.Order", b =>
            {
                b.Navigation("OrderDetails");
            });

            modelBuilder.Entity("BusinessObject.Product", b =>
            {
                b.Navigation("OrderDetails");
            });
        }

        private static string GetConnetionString()
        {
            IConfiguration configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            return configuration["ConnectionStrings:SqlServer"];
        }
    }
}
