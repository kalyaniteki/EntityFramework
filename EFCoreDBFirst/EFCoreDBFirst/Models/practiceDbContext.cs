using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EFCoreDBFirst.Models
{
    public partial class practiceDbContext : DbContext
    {
        public practiceDbContext()
        {
        }

        public practiceDbContext(DbContextOptions<practiceDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<Department1> Department1 { get; set; }
        public virtual DbSet<Departments> Departments { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<Item> Item { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<Project> Project { get; set; }
        public virtual DbSet<School> School { get; set; }
        public virtual DbSet<Student> Student { get; set; }
        public virtual DbSet<WorksOn> WorksOn { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-80R3HO1\\SQLEXPRESS;Initial Catalog=practiceDb;User ID=sa;Password=pass@word1");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Address)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.ContactName)
                    .HasColumnName("contactName")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Customerid)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Fax)
                    .HasMaxLength(24)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Phone)
                    .HasMaxLength(24)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Town)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.DeptId)
                    .HasColumnName("dept_id")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DeptName)
                    .HasColumnName("dept_name")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Location)
                    .HasColumnName("location")
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Department1>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.DeptName)
                    .HasColumnName("dept_name")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DeptNo).HasColumnName("dept_no");

                entity.Property(e => e.Location)
                    .HasColumnName("location")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Departments>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.DeptName)
                    .HasColumnName("dept_name")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DeptNo)
                    .HasColumnName("dept_no")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Location)
                    .HasColumnName("location")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("employee");

                entity.Property(e => e.DeptNo)
                    .HasColumnName("dept_no")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EmpFname)
                    .HasColumnName("emp_fname")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EmpLname)
                    .HasColumnName("emp_lname")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EmpNo).HasColumnName("emp_no");
            });

            modelBuilder.Entity<Item>(entity =>
            {
                entity.Property(e => e.ItemId).HasColumnName("itemId");

                entity.Property(e => e.ItemName)
                    .IsRequired()
                    .HasColumnName("itemName");

                entity.Property(e => e.Price).HasColumnName("price");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.HasIndex(e => e.ItemId);

                entity.Property(e => e.OrderId).HasColumnName("orderId");

                entity.Property(e => e.Deliverydate)
                    .HasColumnName("deliverydate")
                    .HasColumnType("date");

                entity.Property(e => e.ItemId).HasColumnName("itemId");

                entity.Property(e => e.Orderdate)
                    .HasColumnName("orderdate")
                    .HasColumnType("date");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.Order)
                    .HasForeignKey(d => d.ItemId);
            });

            modelBuilder.Entity<Orders>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CustomerId)
                    .IsRequired()
                    .HasColumnName("customerId")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Freight).HasColumnType("money");

                entity.Property(e => e.Orderdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Shipaddres)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Shipname)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Shippeddate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("product");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.Stock).HasColumnName("stock");
            });

            modelBuilder.Entity<Project>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("project");

                entity.Property(e => e.Budget).HasColumnName("budget");

                entity.Property(e => e.ProName)
                    .IsRequired()
                    .HasColumnName("pro_name")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProNo)
                    .HasColumnName("pro_no")
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<School>(entity =>
            {
                entity.HasKey(e => e.Shid)
                    .HasName("PK__school__2FC4CAD84BFC42BE");

                entity.ToTable("school");

                entity.Property(e => e.Shid)
                    .HasColumnName("shid")
                    .ValueGeneratedNever();

                entity.Property(e => e.Sname)
                    .HasColumnName("sname")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Strength).HasColumnName("strength");
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.Property(e => e.Age).HasColumnName("age");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.Std).HasColumnName("std");
            });

            modelBuilder.Entity<WorksOn>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("works_on");

                entity.Property(e => e.EDate)
                    .HasColumnName("e_date")
                    .HasColumnType("date");

                entity.Property(e => e.Eid).HasColumnName("eid");

                entity.Property(e => e.Job)
                    .HasColumnName("job")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Pno)
                    .IsRequired()
                    .HasColumnName("pno")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
