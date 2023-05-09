using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace TestLabEntity.AutoDB;

public partial class TestLabContext : DbContext
{
    public TestLabContext()
    {
    }

    public TestLabContext(DbContextOptions<TestLabContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TlAdmin> TlAdmins { get; set; }

    public virtual DbSet<TlAnswer> TlAnswers { get; set; }

    public virtual DbSet<TlChapter> TlChapters { get; set; }

    public virtual DbSet<TlCourse> TlCourses { get; set; }

    public virtual DbSet<TlPaper> TlPapers { get; set; }

    public virtual DbSet<TlQuestion> TlQuestions { get; set; }

    public virtual DbSet<TlQuestionPaper> TlQuestionPapers { get; set; }

    public virtual DbSet<TlStudent> TlStudents { get; set; }

    public virtual DbSet<TlSubmitpaper> TlSubmitpapers { get; set; }

    public virtual DbSet<TlSubmitpaperDetail> TlSubmitpaperDetails { get; set; }

    private string? GetConnectionString()
    {
        string? connectionString;
        IConfiguration config = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", true, true)
            .Build();
        connectionString = config["ConnectionStrings:DefaultConnection"];
        return connectionString;
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer(GetConnectionString());
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TlAdmin>(entity =>
        {
            entity.ToTable("TL_admin");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreateAt)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("create_at");
            entity.Property(e => e.DeteleAt)
                .HasColumnType("datetime")
                .HasColumnName("detele_at");
            entity.Property(e => e.Fullname)
                .HasMaxLength(50)
                .HasColumnName("fullname");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .HasColumnName("password");
            entity.Property(e => e.UpdateAt)
                .HasColumnType("datetime")
                .HasColumnName("update_at");
            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .HasColumnName("username");
        });

        modelBuilder.Entity<TlAnswer>(entity =>
        {
            entity.ToTable("TL_answer");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AnswerText)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("answer_text");
            entity.Property(e => e.CreateAt)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("create_at");
            entity.Property(e => e.CreateBy).HasColumnName("create_by");
            entity.Property(e => e.DeteleAt)
                .HasColumnType("datetime")
                .HasColumnName("detele_at");
            entity.Property(e => e.IsCorrect).HasColumnName("is_correct");
            entity.Property(e => e.QuestionId).HasColumnName("question_id");
            entity.Property(e => e.UpdateAt)
                .HasColumnType("datetime")
                .HasColumnName("update_at");

            entity.HasOne(d => d.CreateByNavigation).WithMany(p => p.TlAnswers)
                .HasForeignKey(d => d.CreateBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TL_answer_TL_admin");

            entity.HasOne(d => d.Question).WithMany(p => p.TlAnswers)
                .HasForeignKey(d => d.QuestionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TL_answer_TL_question");
        });

        modelBuilder.Entity<TlChapter>(entity =>
        {
            entity.ToTable("TL_chapter");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ChapterName)
                .HasMaxLength(100)
                .HasColumnName("chapter_name");
            entity.Property(e => e.CourseId).HasColumnName("course_id");
            entity.Property(e => e.CreateAt)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("create_at");
            entity.Property(e => e.CreateBy).HasColumnName("create_by");
            entity.Property(e => e.DeteleAt)
                .HasColumnType("datetime")
                .HasColumnName("detele_at");
            entity.Property(e => e.UpdateAt)
                .HasColumnType("datetime")
                .HasColumnName("update_at");

            entity.HasOne(d => d.Course).WithMany(p => p.TlChapters)
                .HasForeignKey(d => d.CourseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TL_chapter_TL_course");

            entity.HasOne(d => d.CreateByNavigation).WithMany(p => p.TlChapters)
                .HasForeignKey(d => d.CreateBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TL_chapter_TL_admin");
        });

        modelBuilder.Entity<TlCourse>(entity =>
        {
            entity.ToTable("TL_course");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CourseName)
                .HasMaxLength(50)
                .HasColumnName("course_name");
            entity.Property(e => e.CreateAt)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("create_at");
            entity.Property(e => e.CreateBy).HasColumnName("create_by");
            entity.Property(e => e.DeteleAt)
                .HasColumnType("datetime")
                .HasColumnName("detele_at");
            entity.Property(e => e.UpdateAt)
                .HasColumnType("datetime")
                .HasColumnName("update_at");

            entity.HasOne(d => d.CreateByNavigation).WithMany(p => p.TlCourses)
                .HasForeignKey(d => d.CreateBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TL_course_TL_admin");
        });

        modelBuilder.Entity<TlPaper>(entity =>
        {
            entity.ToTable("TL_paper");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CourseId).HasColumnName("course_id");
            entity.Property(e => e.CreateAt)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("create_at");
            entity.Property(e => e.CreateBy).HasColumnName("create_by");
            entity.Property(e => e.DeteleAt)
                .HasColumnType("datetime")
                .HasColumnName("detele_at");
            entity.Property(e => e.Duration).HasColumnName("duration");
            entity.Property(e => e.EndTime)
                .HasColumnType("datetime")
                .HasColumnName("end_time");
            entity.Property(e => e.IsOpen).HasColumnName("is_open");
            entity.Property(e => e.PaperCode)
                .HasMaxLength(50)
                .HasColumnName("paper_code");
            entity.Property(e => e.PaperName)
                .HasMaxLength(50)
                .HasColumnName("paper_name");
            entity.Property(e => e.QuestionNum).HasColumnName("question_num");
            entity.Property(e => e.StartTime)
                .HasColumnType("datetime")
                .HasColumnName("start_time");
            entity.Property(e => e.UpdateAt)
                .HasColumnType("datetime")
                .HasColumnName("update_at");

            entity.HasOne(d => d.Course).WithMany(p => p.TlPapers)
                .HasForeignKey(d => d.CourseId)
                .HasConstraintName("FK_TL_paper_TL_course");

            entity.HasOne(d => d.CreateByNavigation).WithMany(p => p.TlPapers)
                .HasForeignKey(d => d.CreateBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TL_paper_TL_admin");
        });

        modelBuilder.Entity<TlQuestion>(entity =>
        {
            entity.ToTable("TL_question");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ChapterId).HasColumnName("chapter_id");
            entity.Property(e => e.CourseId).HasColumnName("course_id");
            entity.Property(e => e.CreateAt)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("create_at");
            entity.Property(e => e.CreateBy).HasColumnName("create_by");
            entity.Property(e => e.DeteleAt)
                .HasColumnType("datetime")
                .HasColumnName("detele_at");
            entity.Property(e => e.QuestionImage).HasColumnName("question_image");
            entity.Property(e => e.QuestionText).HasColumnName("question_text");
            entity.Property(e => e.UpdateAt)
                .HasColumnType("datetime")
                .HasColumnName("update_at");

            entity.HasOne(d => d.Chapter).WithMany(p => p.TlQuestions)
                .HasForeignKey(d => d.ChapterId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TL_question_TL_chapter");

            entity.HasOne(d => d.Course).WithMany(p => p.TlQuestions)
                .HasForeignKey(d => d.CourseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TL_question_TL_course");

            entity.HasOne(d => d.CreateByNavigation).WithMany(p => p.TlQuestions)
                .HasForeignKey(d => d.CreateBy)
                .HasConstraintName("FK_TL_question_TL_admin");
        });

        modelBuilder.Entity<TlQuestionPaper>(entity =>
        {
            entity.ToTable("TL_question_paper");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Mark)
                .HasDefaultValueSql("((1))")
                .HasColumnName("mark");
            entity.Property(e => e.PaperId).HasColumnName("paper_id");
            entity.Property(e => e.QuestionId).HasColumnName("question_id");

            entity.HasOne(d => d.Paper).WithMany(p => p.TlQuestionPapers)
                .HasForeignKey(d => d.PaperId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TL_question_paper_TL_paper");

            entity.HasOne(d => d.Question).WithMany(p => p.TlQuestionPapers)
                .HasForeignKey(d => d.QuestionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TL_question_paper_TL_question");
        });

        modelBuilder.Entity<TlStudent>(entity =>
        {
            entity.ToTable("TL_student");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreateAt)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("create_at");
            entity.Property(e => e.DeteleAt)
                .HasColumnType("datetime")
                .HasColumnName("detele_at");
            entity.Property(e => e.Fullname)
                .HasMaxLength(50)
                .HasColumnName("fullname");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .HasColumnName("password");
            entity.Property(e => e.UpdateAt)
                .HasColumnType("datetime")
                .HasColumnName("update_at");
            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .HasColumnName("username");
        });

        modelBuilder.Entity<TlSubmitpaper>(entity =>
        {
            entity.ToTable("TL_submitpaper");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreateAt)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("create_at");
            entity.Property(e => e.DeteleAt)
                .HasColumnType("datetime")
                .HasColumnName("detele_at");
            entity.Property(e => e.Mark)
                .HasDefaultValueSql("((-1))")
                .HasColumnName("mark");
            entity.Property(e => e.PaperId).HasColumnName("paper_id");
            entity.Property(e => e.StartTime)
                .HasColumnType("datetime")
                .HasColumnName("start_time");
            entity.Property(e => e.StudentId).HasColumnName("student_id");
            entity.Property(e => e.UpdateAt)
                .HasColumnType("datetime")
                .HasColumnName("update_at");

            entity.HasOne(d => d.Paper).WithMany(p => p.TlSubmitpapers)
                .HasForeignKey(d => d.PaperId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TL_submitpaper_TL_paper");

            entity.HasOne(d => d.Student).WithMany(p => p.TlSubmitpapers)
                .HasForeignKey(d => d.StudentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TL_submitpaper_TL_student");
        });

        modelBuilder.Entity<TlSubmitpaperDetail>(entity =>
        {
            entity.ToTable("TL_submitpaper_detail");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AnswerId).HasColumnName("answer_id");
            entity.Property(e => e.QuestionId).HasColumnName("question_id");
            entity.Property(e => e.SubmitpaperId).HasColumnName("submitpaper_id");

            entity.HasOne(d => d.Answer).WithMany(p => p.TlSubmitpaperDetails)
                .HasForeignKey(d => d.AnswerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TL_submitpaper_detail_TL_answer");

            entity.HasOne(d => d.Question).WithMany(p => p.TlSubmitpaperDetails)
                .HasForeignKey(d => d.QuestionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TL_submitpaper_detail_TL_question");

            entity.HasOne(d => d.Submitpaper).WithMany(p => p.TlSubmitpaperDetails)
                .HasForeignKey(d => d.SubmitpaperId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TL_submitpaper_detail_TL_submitpaper");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
