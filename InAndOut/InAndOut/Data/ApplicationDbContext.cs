//using InAndOut.Models;
//using Microsoft.EntityFrameworkCore;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace InAndOut.Data
//{
//    public partial class ApplicationDbContext : DbContext
//    {
//        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
//        {

//        }

//        public DbSet<Item> Items { get; set; }
//        public DbSet<Expense> Expenses { get; set; }
//        public DbSet<ExpenseType> ExpenseTypes { get; set; }
//        public DbSet<FileUpload> Savemedia { get; set; }
//        public DbSet<Student> Students { get; set; }
//        public DbSet<Employee> Employees { get; set; }
//        public DbSet<ExamResult> ExamResults { get; set; }
//        public DbSet<Finance> Finances { get; set; }
//        public DbSet<Attendance> Attendances { get; set; }

//        //public virtual DbSet<Invoice> Invoices { get; set; }

//        //protected override void OnModelCreating(ModelBuilder modelBuilder)
//        //{
//        //    modelBuilder.Entity<Invoice>(entity =>
//        //    {
//        //        entity.Property(x => x.Date).HasColumnType("datetime");
//        //        entity.Property(x => x.Value).HasColumnType("decimal(18,2)");
//        //    });
//        //    OnModelCreatingPartial(modelBuilder);
//        //}

//        //partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

//    }
//}