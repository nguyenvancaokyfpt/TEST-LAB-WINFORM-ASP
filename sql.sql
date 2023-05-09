USE [master]
GO
/****** Object:  Database [TestLab]    Script Date: 3/25/2023 11:43:47 PM ******/
CREATE DATABASE [TestLab]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TestLab', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.LUCIFER24\MSSQL\DATA\TestLab.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'TestLab_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.LUCIFER24\MSSQL\DATA\TestLab_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [TestLab] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TestLab].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TestLab] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TestLab] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TestLab] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TestLab] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TestLab] SET ARITHABORT OFF 
GO
ALTER DATABASE [TestLab] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [TestLab] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TestLab] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TestLab] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TestLab] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TestLab] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TestLab] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TestLab] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TestLab] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TestLab] SET  DISABLE_BROKER 
GO
ALTER DATABASE [TestLab] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TestLab] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TestLab] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TestLab] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TestLab] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TestLab] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TestLab] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TestLab] SET RECOVERY FULL 
GO
ALTER DATABASE [TestLab] SET  MULTI_USER 
GO
ALTER DATABASE [TestLab] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TestLab] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TestLab] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TestLab] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [TestLab] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [TestLab] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'TestLab', N'ON'
GO
ALTER DATABASE [TestLab] SET QUERY_STORE = ON
GO
ALTER DATABASE [TestLab] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [TestLab]
GO
/****** Object:  Table [dbo].[TL_admin]    Script Date: 3/25/2023 11:43:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TL_admin](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[username] [nvarchar](50) NOT NULL,
	[password] [nvarchar](50) NOT NULL,
	[fullname] [nvarchar](50) NOT NULL,
	[create_at] [timestamp] NOT NULL,
	[detele_at] [datetime] NULL,
	[update_at] [datetime] NULL,
 CONSTRAINT [PK_TL_admin] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TL_answer]    Script Date: 3/25/2023 11:43:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TL_answer](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[answer_text] [varchar](2000) NOT NULL,
	[question_id] [int] NOT NULL,
	[is_correct] [bit] NOT NULL,
	[create_at] [timestamp] NOT NULL,
	[detele_at] [datetime] NULL,
	[update_at] [datetime] NULL,
	[create_by] [int] NOT NULL,
 CONSTRAINT [PK_TL_answer] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TL_chapter]    Script Date: 3/25/2023 11:43:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TL_chapter](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[chapter_name] [nvarchar](100) NOT NULL,
	[course_id] [int] NOT NULL,
	[create_at] [timestamp] NOT NULL,
	[detele_at] [datetime] NULL,
	[update_at] [datetime] NULL,
	[create_by] [int] NOT NULL,
 CONSTRAINT [PK_TL_chapter] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TL_course]    Script Date: 3/25/2023 11:43:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TL_course](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[course_name] [nvarchar](50) NOT NULL,
	[create_at] [timestamp] NOT NULL,
	[detele_at] [datetime] NULL,
	[update_at] [datetime] NULL,
	[create_by] [int] NOT NULL,
 CONSTRAINT [PK_TL_course] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TL_paper]    Script Date: 3/25/2023 11:43:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TL_paper](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[paper_name] [nvarchar](50) NOT NULL,
	[paper_code] [nvarchar](50) NOT NULL,
	[question_num] [int] NOT NULL,
	[duration] [int] NOT NULL,
	[start_time] [datetime] NULL,
	[end_time] [datetime] NULL,
	[is_open] [bit] NOT NULL,
	[create_at] [timestamp] NOT NULL,
	[detele_at] [datetime] NULL,
	[update_at] [datetime] NULL,
	[create_by] [int] NOT NULL,
	[course_id] [int] NULL,
 CONSTRAINT [PK_TL_paper] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TL_question]    Script Date: 3/25/2023 11:43:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TL_question](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[question_text] [nvarchar](max) NOT NULL,
	[question_image] [varbinary](max) NULL,
	[course_id] [int] NOT NULL,
	[chapter_id] [int] NOT NULL,
	[create_at] [timestamp] NOT NULL,
	[detele_at] [datetime] NULL,
	[update_at] [datetime] NULL,
	[create_by] [int] NULL,
 CONSTRAINT [PK_TL_question] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TL_question_paper]    Script Date: 3/25/2023 11:43:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TL_question_paper](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[question_id] [int] NOT NULL,
	[paper_id] [int] NOT NULL,
	[mark] [int] NOT NULL,
 CONSTRAINT [PK_TL_question_paper] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TL_student]    Script Date: 3/25/2023 11:43:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TL_student](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[username] [nvarchar](50) NOT NULL,
	[password] [nvarchar](50) NOT NULL,
	[fullname] [nvarchar](50) NOT NULL,
	[detele_at] [datetime] NULL,
	[update_at] [datetime] NULL,
	[create_at] [timestamp] NOT NULL,
 CONSTRAINT [PK_TL_student] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TL_submitpaper]    Script Date: 3/25/2023 11:43:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TL_submitpaper](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[student_id] [int] NOT NULL,
	[paper_id] [int] NOT NULL,
	[create_at] [timestamp] NOT NULL,
	[start_time] [datetime] NULL,
	[update_at] [datetime] NULL,
	[detele_at] [datetime] NULL,
	[mark] [float] NULL,
 CONSTRAINT [PK_TL_submitpaper] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TL_submitpaper_detail]    Script Date: 3/25/2023 11:43:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TL_submitpaper_detail](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[submitpaper_id] [int] NOT NULL,
	[question_id] [int] NOT NULL,
	[answer_id] [int] NOT NULL,
 CONSTRAINT [PK_TL_submitpaper_detail] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[TL_question_paper] ADD  CONSTRAINT [DF_TL_question_paper_mark]  DEFAULT ((1)) FOR [mark]
GO
ALTER TABLE [dbo].[TL_submitpaper] ADD  CONSTRAINT [DF_TL_submitpaper_mark]  DEFAULT ((-1)) FOR [mark]
GO
ALTER TABLE [dbo].[TL_answer]  WITH CHECK ADD  CONSTRAINT [FK_TL_answer_TL_admin] FOREIGN KEY([create_by])
REFERENCES [dbo].[TL_admin] ([id])
GO
ALTER TABLE [dbo].[TL_answer] CHECK CONSTRAINT [FK_TL_answer_TL_admin]
GO
ALTER TABLE [dbo].[TL_answer]  WITH CHECK ADD  CONSTRAINT [FK_TL_answer_TL_question] FOREIGN KEY([question_id])
REFERENCES [dbo].[TL_question] ([id])
GO
ALTER TABLE [dbo].[TL_answer] CHECK CONSTRAINT [FK_TL_answer_TL_question]
GO
ALTER TABLE [dbo].[TL_chapter]  WITH CHECK ADD  CONSTRAINT [FK_TL_chapter_TL_admin] FOREIGN KEY([create_by])
REFERENCES [dbo].[TL_admin] ([id])
GO
ALTER TABLE [dbo].[TL_chapter] CHECK CONSTRAINT [FK_TL_chapter_TL_admin]
GO
ALTER TABLE [dbo].[TL_chapter]  WITH CHECK ADD  CONSTRAINT [FK_TL_chapter_TL_course] FOREIGN KEY([course_id])
REFERENCES [dbo].[TL_course] ([id])
GO
ALTER TABLE [dbo].[TL_chapter] CHECK CONSTRAINT [FK_TL_chapter_TL_course]
GO
ALTER TABLE [dbo].[TL_course]  WITH CHECK ADD  CONSTRAINT [FK_TL_course_TL_admin] FOREIGN KEY([create_by])
REFERENCES [dbo].[TL_admin] ([id])
GO
ALTER TABLE [dbo].[TL_course] CHECK CONSTRAINT [FK_TL_course_TL_admin]
GO
ALTER TABLE [dbo].[TL_paper]  WITH CHECK ADD  CONSTRAINT [FK_TL_paper_TL_admin] FOREIGN KEY([create_by])
REFERENCES [dbo].[TL_admin] ([id])
GO
ALTER TABLE [dbo].[TL_paper] CHECK CONSTRAINT [FK_TL_paper_TL_admin]
GO
ALTER TABLE [dbo].[TL_paper]  WITH CHECK ADD  CONSTRAINT [FK_TL_paper_TL_admin1] FOREIGN KEY([create_by])
REFERENCES [dbo].[TL_admin] ([id])
GO
ALTER TABLE [dbo].[TL_paper] CHECK CONSTRAINT [FK_TL_paper_TL_admin1]
GO
ALTER TABLE [dbo].[TL_paper]  WITH CHECK ADD  CONSTRAINT [FK_TL_paper_TL_course] FOREIGN KEY([course_id])
REFERENCES [dbo].[TL_course] ([id])
GO
ALTER TABLE [dbo].[TL_paper] CHECK CONSTRAINT [FK_TL_paper_TL_course]
GO
ALTER TABLE [dbo].[TL_question]  WITH CHECK ADD  CONSTRAINT [FK_TL_question_TL_admin] FOREIGN KEY([create_by])
REFERENCES [dbo].[TL_admin] ([id])
GO
ALTER TABLE [dbo].[TL_question] CHECK CONSTRAINT [FK_TL_question_TL_admin]
GO
ALTER TABLE [dbo].[TL_question]  WITH CHECK ADD  CONSTRAINT [FK_TL_question_TL_chapter] FOREIGN KEY([chapter_id])
REFERENCES [dbo].[TL_chapter] ([id])
GO
ALTER TABLE [dbo].[TL_question] CHECK CONSTRAINT [FK_TL_question_TL_chapter]
GO
ALTER TABLE [dbo].[TL_question]  WITH CHECK ADD  CONSTRAINT [FK_TL_question_TL_course] FOREIGN KEY([course_id])
REFERENCES [dbo].[TL_course] ([id])
GO
ALTER TABLE [dbo].[TL_question] CHECK CONSTRAINT [FK_TL_question_TL_course]
GO
ALTER TABLE [dbo].[TL_question_paper]  WITH CHECK ADD  CONSTRAINT [FK_TL_question_paper_TL_paper] FOREIGN KEY([paper_id])
REFERENCES [dbo].[TL_paper] ([id])
GO
ALTER TABLE [dbo].[TL_question_paper] CHECK CONSTRAINT [FK_TL_question_paper_TL_paper]
GO
ALTER TABLE [dbo].[TL_question_paper]  WITH CHECK ADD  CONSTRAINT [FK_TL_question_paper_TL_question] FOREIGN KEY([question_id])
REFERENCES [dbo].[TL_question] ([id])
GO
ALTER TABLE [dbo].[TL_question_paper] CHECK CONSTRAINT [FK_TL_question_paper_TL_question]
GO
ALTER TABLE [dbo].[TL_submitpaper]  WITH CHECK ADD  CONSTRAINT [FK_TL_submitpaper_TL_paper] FOREIGN KEY([paper_id])
REFERENCES [dbo].[TL_paper] ([id])
GO
ALTER TABLE [dbo].[TL_submitpaper] CHECK CONSTRAINT [FK_TL_submitpaper_TL_paper]
GO
ALTER TABLE [dbo].[TL_submitpaper]  WITH CHECK ADD  CONSTRAINT [FK_TL_submitpaper_TL_student] FOREIGN KEY([student_id])
REFERENCES [dbo].[TL_student] ([id])
GO
ALTER TABLE [dbo].[TL_submitpaper] CHECK CONSTRAINT [FK_TL_submitpaper_TL_student]
GO
ALTER TABLE [dbo].[TL_submitpaper_detail]  WITH CHECK ADD  CONSTRAINT [FK_TL_submitpaper_detail_TL_answer] FOREIGN KEY([answer_id])
REFERENCES [dbo].[TL_answer] ([id])
GO
ALTER TABLE [dbo].[TL_submitpaper_detail] CHECK CONSTRAINT [FK_TL_submitpaper_detail_TL_answer]
GO
ALTER TABLE [dbo].[TL_submitpaper_detail]  WITH CHECK ADD  CONSTRAINT [FK_TL_submitpaper_detail_TL_question] FOREIGN KEY([question_id])
REFERENCES [dbo].[TL_question] ([id])
GO
ALTER TABLE [dbo].[TL_submitpaper_detail] CHECK CONSTRAINT [FK_TL_submitpaper_detail_TL_question]
GO
ALTER TABLE [dbo].[TL_submitpaper_detail]  WITH CHECK ADD  CONSTRAINT [FK_TL_submitpaper_detail_TL_submitpaper] FOREIGN KEY([submitpaper_id])
REFERENCES [dbo].[TL_submitpaper] ([id])
GO
ALTER TABLE [dbo].[TL_submitpaper_detail] CHECK CONSTRAINT [FK_TL_submitpaper_detail_TL_submitpaper]
GO
USE [master]
GO
ALTER DATABASE [TestLab] SET  READ_WRITE 
GO
