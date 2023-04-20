using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace RealEstate.Models
{
    public partial class EDUCATIONPROJECTContext : DbContext
    {
        public EDUCATIONPROJECTContext()
        {
        }

        public EDUCATIONPROJECTContext(DbContextOptions<EDUCATIONPROJECTContext> options)
            : base(options)
        {
        }

        public virtual DbSet<MatrialVideo> MatrialVideos { get; set; }
        public virtual DbSet<StudentMatrial> StudentMatrials { get; set; }
        public virtual DbSet<TbAssignment> TbAssignments { get; set; }
        public virtual DbSet<TbCode> TbCodes { get; set; }
        public virtual DbSet<TbMatrial> TbMatrials { get; set; }
        public virtual DbSet<TbMatrialTeacher> TbMatrialTeachers { get; set; }
        public virtual DbSet<TbStudent> TbStudents { get; set; }
        public virtual DbSet<TbTeacher> TbTeachers { get; set; }
        public virtual DbSet<TbVideo> TbVideos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-GG0P0Q7\\SQLEXPRESS;Database=EDUCATIONPROJECT;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MatrialVideo>(entity =>
            {
                entity.HasKey(e => new { e.MatrialId, e.VideoId });

                entity.ToTable("MatrialVideo");

                entity.Property(e => e.MatrialId).HasColumnName("MatrialID");

                entity.Property(e => e.VideoId).HasColumnName("VideoID");

                entity.HasOne(d => d.Matrial)
                    .WithMany(p => p.MatrialVideos)
                    .HasForeignKey(d => d.MatrialId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MatrialVideo_TbMatrial");

                entity.HasOne(d => d.Video)
                    .WithMany(p => p.MatrialVideos)
                    .HasForeignKey(d => d.VideoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MatrialVideo_TbVideos");
            });

            modelBuilder.Entity<StudentMatrial>(entity =>
            {
                entity.HasKey(e => new { e.StudentId, e.MatrialId });

                entity.ToTable("StudentMatrial");

                entity.Property(e => e.StudentId).HasColumnName("StudentID");

                entity.Property(e => e.MatrialId).HasColumnName("MatrialID");

                entity.HasOne(d => d.Matrial)
                    .WithMany(p => p.StudentMatrials)
                    .HasForeignKey(d => d.MatrialId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StudentMatrial_TbMatrial");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.StudentMatrials)
                    .HasForeignKey(d => d.StudentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StudentMatrial_TbStudent");
            });

            modelBuilder.Entity<TbAssignment>(entity =>
            {
                entity.HasKey(e => new { e.StudentId, e.MatrialId });

                entity.ToTable("TbAssignment");

                entity.Property(e => e.StudentId).HasColumnName("StudentID");

                entity.Property(e => e.MatrialId).HasColumnName("MatrialID");

                entity.HasOne(d => d.Matrial)
                    .WithMany(p => p.TbAssignments)
                    .HasForeignKey(d => d.MatrialId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TbAssignment_TbMatrial");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.TbAssignments)
                    .HasForeignKey(d => d.StudentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TbAssignment_TbStudent");
            });

            modelBuilder.Entity<TbCode>(entity =>
            {
                entity.HasKey(e => e.CodeId);

                entity.Property(e => e.CodeId).HasColumnName("CodeID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.StudentId).HasColumnName("StudentID");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.TbCodes)
                    .HasForeignKey(d => d.StudentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TbCodes_TbStudent");
            });

            modelBuilder.Entity<TbMatrial>(entity =>
            {
                entity.HasKey(e => e.MatrialId);

                entity.ToTable("TbMatrial");

                entity.Property(e => e.MatrialId).HasColumnName("MatrialID");

                entity.Property(e => e.MatrialName)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<TbMatrialTeacher>(entity =>
            {
                entity.HasKey(e => new { e.MatrialId, e.TeacherId });

                entity.ToTable("TbMatrialTeacher");

                entity.Property(e => e.MatrialId).HasColumnName("MatrialID");

                entity.Property(e => e.TeacherId).HasColumnName("TeacherID");

                entity.HasOne(d => d.Matrial)
                    .WithMany(p => p.TbMatrialTeachers)
                    .HasForeignKey(d => d.MatrialId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TbMatrialTeacher_TbMatrial");

                entity.HasOne(d => d.Teacher)
                    .WithMany(p => p.TbMatrialTeachers)
                    .HasForeignKey(d => d.TeacherId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TbMatrialTeacher_TbTeacher");
            });

            modelBuilder.Entity<TbStudent>(entity =>
            {
                entity.HasKey(e => e.StudentId);

                entity.ToTable("TbStudent");

                entity.Property(e => e.StudentId).HasColumnName("StudentID");

                entity.Property(e => e.StudentFullName)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<TbTeacher>(entity =>
            {
                entity.HasKey(e => e.TeacherId);

                entity.ToTable("TbTeacher");

                entity.Property(e => e.TeacherId).HasColumnName("TeacherID");

                entity.Property(e => e.TeacherName)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<TbVideo>(entity =>
            {
                entity.HasKey(e => e.VideoId);

                entity.Property(e => e.VideoId).HasColumnName("VideoID");

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("URL");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
