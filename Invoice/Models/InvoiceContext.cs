using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Invoice.models
{
    public partial class InvoiceContext : DbContext
    {
        public InvoiceContext()
        {
        }

        public InvoiceContext(DbContextOptions<InvoiceContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Car> Car { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Invoice> Invoice { get; set; }
        public virtual DbSet<Item> Item { get; set; }
        public virtual DbSet<Product> Product { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=LAPTOP-AQ2F2FCE\\SQLEXPRESS;Database=Invoice;User Id=kevin;Password=kevin;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>(entity =>
            {
                entity.ToTable("car");

                entity.Property(e => e.CarId).HasColumnName("car_id");

                entity.Property(e => e.CarDate)
                    .HasColumnName("car_date")
                    .HasColumnType("date");

                entity.Property(e => e.CarVin).HasColumnName("car_vin");

                entity.Property(e => e.CarYearmakemodel)
                    .HasColumnName("car_yearmakemodel")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasKey(e => e.CustId);

                entity.ToTable("customer");

                entity.Property(e => e.CustId).HasColumnName("cust_id");

                entity.Property(e => e.CustAddiAddr)
                    .HasColumnName("cust_addi_addr")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CustAddress)
                    .HasColumnName("cust_address")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CustEmail)
                    .HasColumnName("cust_email")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CustName)
                    .HasColumnName("cust_name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CustPhone)
                    .HasColumnName("cust_phone")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Invoice>(entity =>
            {
                entity.ToTable("invoice");

                entity.Property(e => e.InvoiceId).HasColumnName("invoice_id");

                entity.Property(e => e.CarId).HasColumnName("car_id");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.InvoiceDate)
                    .HasColumnName("invoice_date")
                    .HasColumnType("date");

                entity.HasOne(d => d.Car)
                    .WithMany(p => p.Invoice)
                    .HasForeignKey(d => d.CarId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_invoice_car");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Invoice)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_invoice_customer");
            });

            modelBuilder.Entity<Item>(entity =>
            {
                entity.ToTable("item");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.InvoiceId).HasColumnName("invoice_id");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.HasOne(d => d.Invoice)
                    .WithMany(p => p.Item)
                    .HasForeignKey(d => d.InvoiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_item_invoice");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.Item)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_item_product");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("product");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasColumnName("product_name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ProductPrice)
                    .HasColumnName("product_price")
                    .HasColumnType("smallmoney");
            });
        }
    }
}
