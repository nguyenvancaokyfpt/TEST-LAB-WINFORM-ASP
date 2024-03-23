using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Models;

public partial class TracNghiemOnlineContext : DbContext
{
    public TracNghiemOnlineContext()
    {
    }

    public TracNghiemOnlineContext(DbContextOptions<TracNghiemOnlineContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Admin> Admins { get; set; }

    public virtual DbSet<Class> Classes { get; set; }

    public virtual DbSet<Grade> Grades { get; set; }

    public virtual DbSet<Permission> Permissions { get; set; }

    public virtual DbSet<Question> Questions { get; set; }

    public virtual DbSet<QuestsOfTest> QuestsOfTests { get; set; }

    public virtual DbSet<Score> Scores { get; set; }

    public virtual DbSet<Speciality> Specialities { get; set; }

    public virtual DbSet<Status> Statuses { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    public virtual DbSet<StudentTestDetail> StudentTestDetails { get; set; }

    public virtual DbSet<Subject> Subjects { get; set; }

    public virtual DbSet<Teacher> Teachers { get; set; }

    public virtual DbSet<Test> Tests { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("server=DESKTOP-BR7P12E\\KY; database=trac_nghiem_online;user=sa;password=1234567;Integrated Security=true;TrustServerCertificate=Yes");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Admin>(entity =>
        {
            entity.HasKey(e => e.IdAdmin).HasName("PK__admins__89472E9530A157A8");

            entity.ToTable("admins");

            entity.HasIndex(e => new { e.Username, e.Email }, "UQ__admins__B96D23647734DA5F").IsUnique();

            entity.Property(e => e.IdAdmin).HasColumnName("id_admin");
            entity.Property(e => e.Avatar)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("avatar-default.jpg")
                .HasColumnName("avatar");
            entity.Property(e => e.Birthday).HasColumnName("birthday");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Gender)
                .HasMaxLength(50)
                .HasColumnName("gender");
            entity.Property(e => e.IdPermission).HasColumnName("id_permission");
            entity.Property(e => e.LastLogin)
                .HasColumnType("datetime")
                .HasColumnName("last_login");
            entity.Property(e => e.LastSeen)
                .HasMaxLength(100)
                .HasColumnName("last_seen");
            entity.Property(e => e.LastSeenUrl)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("last_seen_url");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasColumnName("name");
            entity.Property(e => e.Password)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("password");
            entity.Property(e => e.Phone)
                .HasMaxLength(45)
                .IsUnicode(false)
                .HasColumnName("phone");
            entity.Property(e => e.Timestamps)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("timestamps");
            entity.Property(e => e.Username)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("username");

            entity.HasOne(d => d.IdPermissionNavigation).WithMany(p => p.Admins)
                .HasForeignKey(d => d.IdPermission)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__admins__id_permi__46E78A0C");
        });

        modelBuilder.Entity<Class>(entity =>
        {
            entity.HasKey(e => e.IdClass).HasName("PK__classes__2352EEA93059EA0D");

            entity.ToTable("classes");

            entity.HasIndex(e => e.IdGrade, "fk_grade_idx");

            entity.HasIndex(e => e.IdSpeciality, "fk_speciality_idx");

            entity.Property(e => e.IdClass).HasColumnName("id_class");
            entity.Property(e => e.ClassName)
                .HasMaxLength(50)
                .HasColumnName("class_name");
            entity.Property(e => e.IdGrade).HasColumnName("id_grade");
            entity.Property(e => e.IdSpeciality).HasColumnName("id_speciality");
            entity.Property(e => e.Timestamps)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("timestamps");

            entity.HasOne(d => d.IdGradeNavigation).WithMany(p => p.Classes)
                .HasForeignKey(d => d.IdGrade)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_grade");

            entity.HasOne(d => d.IdSpecialityNavigation).WithMany(p => p.Classes)
                .HasForeignKey(d => d.IdSpeciality)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_speciality");
        });

        modelBuilder.Entity<Grade>(entity =>
        {
            entity.HasKey(e => e.IdGrade).HasName("PK__grades__6DB797E43E3A39E1");

            entity.ToTable("grades");

            entity.Property(e => e.IdGrade).HasColumnName("id_grade");
            entity.Property(e => e.GradeName)
                .HasMaxLength(50)
                .HasColumnName("grade_name");
            entity.Property(e => e.Timestamps)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("timestamps");
        });

        modelBuilder.Entity<Permission>(entity =>
        {
            entity.HasKey(e => e.IdPermission).HasName("PK__permissi__5180B3BFE43D88CB");

            entity.ToTable("permissions");

            entity.Property(e => e.IdPermission).HasColumnName("id_permission");
            entity.Property(e => e.PermissionName)
                .HasMaxLength(50)
                .HasColumnName("permission_name");
            entity.Property(e => e.Timestamps)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("timestamps");
        });

        modelBuilder.Entity<Question>(entity =>
        {
            entity.HasKey(e => e.IdQuestion).HasName("PK__question__2BD924771B7173C5");

            entity.ToTable("questions");

            entity.Property(e => e.IdQuestion).HasColumnName("id_question");
            entity.Property(e => e.AnswerA)
                .HasColumnType("ntext")
                .HasColumnName("answer_a");
            entity.Property(e => e.AnswerB)
                .HasColumnType("ntext")
                .HasColumnName("answer_b");
            entity.Property(e => e.AnswerC)
                .HasColumnType("ntext")
                .HasColumnName("answer_c");
            entity.Property(e => e.AnswerD)
                .HasColumnType("ntext")
                .HasColumnName("answer_d");
            entity.Property(e => e.Content)
                .HasColumnType("ntext")
                .HasColumnName("content");
            entity.Property(e => e.CorrectAnswer)
                .HasColumnType("ntext")
                .HasColumnName("correct_answer");
            entity.Property(e => e.IdSubject).HasColumnName("id_subject");
            entity.Property(e => e.ImgContent)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("img_content");
            entity.Property(e => e.Timestamps)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("timestamps");
            entity.Property(e => e.Unit).HasColumnName("unit");

            entity.HasOne(d => d.IdSubjectNavigation).WithMany(p => p.Questions)
                .HasForeignKey(d => d.IdSubject)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__questions__id_su__5629CD9C");
        });

        modelBuilder.Entity<QuestsOfTest>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__quests_o__3214EC27B8C23CE0");

            entity.ToTable("quests_of_test");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IdQuestion).HasColumnName("id_question");
            entity.Property(e => e.TestCode).HasColumnName("test_code");
            entity.Property(e => e.Timestamps)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("timestamps");

            entity.HasOne(d => d.IdQuestionNavigation).WithMany(p => p.QuestsOfTests)
                .HasForeignKey(d => d.IdQuestion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_quests_of_test_questions");

            entity.HasOne(d => d.TestCodeNavigation).WithMany(p => p.QuestsOfTests)
                .HasForeignKey(d => d.TestCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_quests_of_test_tests");
        });

        modelBuilder.Entity<Score>(entity =>
        {
            entity.HasKey(e => new { e.IdStudent, e.TestCode });

            entity.ToTable("scores");

            entity.Property(e => e.IdStudent).HasColumnName("id_student");
            entity.Property(e => e.TestCode).HasColumnName("test_code");
            entity.Property(e => e.Detail)
                .HasMaxLength(50)
                .IsFixedLength()
                .HasColumnName("detail");
            entity.Property(e => e.IdScore)
                .ValueGeneratedOnAdd()
                .HasColumnName("id_score");
            entity.Property(e => e.ScoreNumber).HasColumnName("score_number");
            entity.Property(e => e.TimeFinish)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("time_finish");

            entity.HasOne(d => d.IdStudentNavigation).WithMany(p => p.Scores)
                .HasForeignKey(d => d.IdStudent)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__scores__id_stude__60A75C0F");

            entity.HasOne(d => d.TestCodeNavigation).WithMany(p => p.Scores)
                .HasForeignKey(d => d.TestCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_scores_tests");
        });

        modelBuilder.Entity<Speciality>(entity =>
        {
            entity.HasKey(e => e.IdSpeciality).HasName("PK__speciali__CF97EB984CF2A323");

            entity.ToTable("specialities");

            entity.Property(e => e.IdSpeciality).HasColumnName("id_speciality");
            entity.Property(e => e.SpecialityName)
                .HasMaxLength(255)
                .HasColumnName("speciality_name");
            entity.Property(e => e.Timestamps)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("timestamps");
        });

        modelBuilder.Entity<Status>(entity =>
        {
            entity.HasKey(e => e.IdStatus).HasName("PK__statuses__5D2DC6E865E1C90F");

            entity.ToTable("statuses");

            entity.Property(e => e.IdStatus).HasColumnName("id_status");
            entity.Property(e => e.StatusName)
                .HasMaxLength(50)
                .HasColumnName("status_name");
            entity.Property(e => e.Timestamps)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("timestamps");
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity.HasKey(e => e.IdStudent).HasName("PK__students__2BE2EBB681A432C4");

            entity.ToTable("students");

            entity.HasIndex(e => new { e.Username, e.Email }, "UQ__students__B96D2364BADF7213").IsUnique();

            entity.Property(e => e.IdStudent).HasColumnName("id_student");
            entity.Property(e => e.Avatar)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("avatar-default.jpg")
                .HasColumnName("avatar");
            entity.Property(e => e.Birthday).HasColumnName("birthday");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Gender)
                .HasMaxLength(50)
                .HasColumnName("gender");
            entity.Property(e => e.IdClass).HasColumnName("id_class");
            entity.Property(e => e.IdPermission).HasColumnName("id_permission");
            entity.Property(e => e.IdSpeciality).HasColumnName("id_speciality");
            entity.Property(e => e.IsTesting)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("is_testing");
            entity.Property(e => e.LastLogin)
                .HasColumnType("datetime")
                .HasColumnName("last_login");
            entity.Property(e => e.LastSeen)
                .HasMaxLength(100)
                .HasColumnName("last_seen");
            entity.Property(e => e.LastSeenUrl)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("last_seen_url");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasColumnName("name");
            entity.Property(e => e.Password)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("password");
            entity.Property(e => e.Phone)
                .HasMaxLength(45)
                .IsUnicode(false)
                .HasColumnName("phone");
            entity.Property(e => e.TimeRemaining)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("time_remaining");
            entity.Property(e => e.TimeStart)
                .HasColumnType("datetime")
                .HasColumnName("time_start");
            entity.Property(e => e.Timestamps)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("timestamps");
            entity.Property(e => e.Username)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("username");

            entity.HasOne(d => d.IdClassNavigation).WithMany(p => p.Students)
                .HasForeignKey(d => d.IdClass)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__students__id_cla__5070F446");

            entity.HasOne(d => d.IdPermissionNavigation).WithMany(p => p.Students)
                .HasForeignKey(d => d.IdPermission)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__students__id_per__4F7CD00D");

            entity.HasOne(d => d.IdSpecialityNavigation).WithMany(p => p.Students)
                .HasForeignKey(d => d.IdSpeciality)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__students__id_spe__5165187F");
        });

        modelBuilder.Entity<StudentTestDetail>(entity =>
        {
            entity.HasKey(e => new { e.IdStudent, e.TestCode, e.IdQuestion });

            entity.ToTable("student_test_detail");

            entity.Property(e => e.IdStudent).HasColumnName("id_student");
            entity.Property(e => e.TestCode).HasColumnName("test_code");
            entity.Property(e => e.IdQuestion).HasColumnName("id_question");
            entity.Property(e => e.AnswerA)
                .HasColumnType("ntext")
                .HasColumnName("answer_a");
            entity.Property(e => e.AnswerB)
                .HasColumnType("ntext")
                .HasColumnName("answer_b");
            entity.Property(e => e.AnswerC)
                .HasColumnType("ntext")
                .HasColumnName("answer_c");
            entity.Property(e => e.AnswerD)
                .HasColumnType("ntext")
                .HasColumnName("answer_d");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.StudentAnswer)
                .HasColumnType("ntext")
                .HasColumnName("student_answer");
            entity.Property(e => e.Timestamps)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("timestamps");
        });

        modelBuilder.Entity<Subject>(entity =>
        {
            entity.HasKey(e => e.IdSubject).HasName("PK__subjects__8F848F6098C0F347");

            entity.ToTable("subjects");

            entity.Property(e => e.IdSubject).HasColumnName("id_subject");
            entity.Property(e => e.SubjectName)
                .HasMaxLength(255)
                .HasColumnName("subject_name");
            entity.Property(e => e.Timestamps)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("timestamps");
        });

        modelBuilder.Entity<Teacher>(entity =>
        {
            entity.HasKey(e => e.IdTeacher).HasName("PK__teachers__3BAEF8F9A484A318");

            entity.ToTable("teachers");

            entity.HasIndex(e => new { e.Username, e.Email }, "UQ__teachers__B96D2364E4800B05").IsUnique();

            entity.Property(e => e.IdTeacher).HasColumnName("id_teacher");
            entity.Property(e => e.Avatar)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("avatar-default.jpg")
                .HasColumnName("avatar");
            entity.Property(e => e.Birthday).HasColumnName("birthday");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Gender)
                .HasMaxLength(50)
                .HasColumnName("gender");
            entity.Property(e => e.IdPermission).HasColumnName("id_permission");
            entity.Property(e => e.IdSpeciality).HasColumnName("id_speciality");
            entity.Property(e => e.LastLogin)
                .HasColumnType("datetime")
                .HasColumnName("last_login");
            entity.Property(e => e.LastSeen)
                .HasMaxLength(100)
                .HasColumnName("last_seen");
            entity.Property(e => e.LastSeenUrl)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("last_seen_url");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasColumnName("name");
            entity.Property(e => e.Password)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("password");
            entity.Property(e => e.Phone)
                .HasMaxLength(45)
                .IsUnicode(false)
                .HasColumnName("phone");
            entity.Property(e => e.Timestamps)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("timestamps");
            entity.Property(e => e.Username)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("username");

            entity.HasOne(d => d.IdPermissionNavigation).WithMany(p => p.Teachers)
                .HasForeignKey(d => d.IdPermission)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__teachers__id_per__4AB81AF0");

            entity.HasOne(d => d.IdSpecialityNavigation).WithMany(p => p.Teachers)
                .HasForeignKey(d => d.IdSpeciality)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__teachers__id_spe__4BAC3F29");
        });

        modelBuilder.Entity<Test>(entity =>
        {
            entity.HasKey(e => e.TestCode);

            entity.ToTable("tests");

            entity.HasIndex(e => e.TestCode, "UQ__tests__040975AB07882BC3").IsUnique();

            entity.Property(e => e.TestCode)
                .ValueGeneratedNever()
                .HasColumnName("test_code");
            entity.Property(e => e.IdStatus).HasColumnName("id_status");
            entity.Property(e => e.IdSubject).HasColumnName("id_subject");
            entity.Property(e => e.Note)
                .HasColumnType("ntext")
                .HasColumnName("note");
            entity.Property(e => e.Password)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("password");
            entity.Property(e => e.TestName)
                .HasMaxLength(255)
                .HasColumnName("test_name");
            entity.Property(e => e.TimeToDo).HasColumnName("time_to_do");
            entity.Property(e => e.Timestamps)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("timestamps");
            entity.Property(e => e.TotalQuestions).HasColumnName("total_questions");

            entity.HasOne(d => d.IdStatusNavigation).WithMany(p => p.Tests)
                .HasForeignKey(d => d.IdStatus)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__tests__id_status__59FA5E80");

            entity.HasOne(d => d.IdSubjectNavigation).WithMany(p => p.Tests)
                .HasForeignKey(d => d.IdSubject)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__tests__id_subjec__59063A47");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
