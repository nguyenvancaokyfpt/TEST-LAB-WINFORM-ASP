USE [master]
GO
/****** Object:  Database [trac_nghiem_online]    Script Date: 3/23/2024 4:11:01 PM ******/
CREATE DATABASE [trac_nghiem_online]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'trac_nghiem_online', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.KY\MSSQL\DATA\trac_nghiem_online.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'trac_nghiem_online_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.KY\MSSQL\DATA\trac_nghiem_online_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [trac_nghiem_online] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [trac_nghiem_online].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [trac_nghiem_online] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [trac_nghiem_online] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [trac_nghiem_online] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [trac_nghiem_online] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [trac_nghiem_online] SET ARITHABORT OFF 
GO
ALTER DATABASE [trac_nghiem_online] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [trac_nghiem_online] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [trac_nghiem_online] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [trac_nghiem_online] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [trac_nghiem_online] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [trac_nghiem_online] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [trac_nghiem_online] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [trac_nghiem_online] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [trac_nghiem_online] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [trac_nghiem_online] SET  DISABLE_BROKER 
GO
ALTER DATABASE [trac_nghiem_online] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [trac_nghiem_online] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [trac_nghiem_online] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [trac_nghiem_online] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [trac_nghiem_online] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [trac_nghiem_online] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [trac_nghiem_online] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [trac_nghiem_online] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [trac_nghiem_online] SET  MULTI_USER 
GO
ALTER DATABASE [trac_nghiem_online] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [trac_nghiem_online] SET DB_CHAINING OFF 
GO
ALTER DATABASE [trac_nghiem_online] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [trac_nghiem_online] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [trac_nghiem_online] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [trac_nghiem_online] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'trac_nghiem_online', N'ON'
GO
ALTER DATABASE [trac_nghiem_online] SET QUERY_STORE = OFF
GO
USE [trac_nghiem_online]
GO
/****** Object:  Table [dbo].[admins]    Script Date: 3/23/2024 4:11:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[admins](
	[id_admin] [int] IDENTITY(1,1) NOT NULL,
	[username] [varchar](20) NOT NULL,
	[password] [varchar](32) NOT NULL,
	[email] [varchar](100) NOT NULL,
	[avatar] [varchar](255) NULL,
	[name] [nvarchar](100) NOT NULL,
	[gender] [nvarchar](50) NOT NULL,
	[birthday] [date] NOT NULL,
	[phone] [varchar](45) NULL,
	[id_permission] [int] NOT NULL,
	[last_login] [datetime] NULL,
	[last_seen] [nvarchar](100) NULL,
	[last_seen_url] [varchar](100) NULL,
	[timestamps] [datetime] NULL,
 CONSTRAINT [PK__admins__89472E9530A157A8] PRIMARY KEY CLUSTERED 
(
	[id_admin] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[classes]    Script Date: 3/23/2024 4:11:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[classes](
	[id_class] [int] IDENTITY(1,1) NOT NULL,
	[class_name] [nvarchar](50) NOT NULL,
	[id_grade] [int] NOT NULL,
	[id_speciality] [int] NOT NULL,
	[timestamps] [datetime] NULL,
 CONSTRAINT [PK__classes__2352EEA93059EA0D] PRIMARY KEY CLUSTERED 
(
	[id_class] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[grades]    Script Date: 3/23/2024 4:11:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[grades](
	[id_grade] [int] IDENTITY(1,1) NOT NULL,
	[grade_name] [nvarchar](50) NOT NULL,
	[timestamps] [datetime] NULL,
 CONSTRAINT [PK__grades__6DB797E43E3A39E1] PRIMARY KEY CLUSTERED 
(
	[id_grade] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[permissions]    Script Date: 3/23/2024 4:11:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[permissions](
	[id_permission] [int] IDENTITY(1,1) NOT NULL,
	[permission_name] [nvarchar](50) NOT NULL,
	[timestamps] [datetime] NULL,
 CONSTRAINT [PK__permissi__5180B3BFE43D88CB] PRIMARY KEY CLUSTERED 
(
	[id_permission] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[questions]    Script Date: 3/23/2024 4:11:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[questions](
	[id_question] [int] IDENTITY(1,1) NOT NULL,
	[id_subject] [int] NOT NULL,
	[unit] [int] NOT NULL,
	[img_content] [varchar](255) NULL,
	[content] [ntext] NOT NULL,
	[answer_a] [ntext] NOT NULL,
	[answer_b] [ntext] NOT NULL,
	[answer_c] [ntext] NOT NULL,
	[answer_d] [ntext] NOT NULL,
	[correct_answer] [ntext] NOT NULL,
	[timestamps] [datetime] NULL,
 CONSTRAINT [PK__question__2BD924771B7173C5] PRIMARY KEY CLUSTERED 
(
	[id_question] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[quests_of_test]    Script Date: 3/23/2024 4:11:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[quests_of_test](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[test_code] [int] NOT NULL,
	[id_question] [int] NOT NULL,
	[timestamps] [datetime] NULL,
 CONSTRAINT [PK__quests_o__3214EC27B8C23CE0] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[scores]    Script Date: 3/23/2024 4:11:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[scores](
	[id_score] [int] IDENTITY(1,1) NOT NULL,
	[id_student] [int] NOT NULL,
	[test_code] [int] NOT NULL,
	[score_number] [float] NOT NULL,
	[detail] [nchar](50) NOT NULL,
	[time_finish] [datetime] NULL,
 CONSTRAINT [PK_scores] PRIMARY KEY CLUSTERED 
(
	[id_student] ASC,
	[test_code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[specialities]    Script Date: 3/23/2024 4:11:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[specialities](
	[id_speciality] [int] IDENTITY(1,1) NOT NULL,
	[speciality_name] [nvarchar](255) NOT NULL,
	[timestamps] [datetime] NULL,
 CONSTRAINT [PK__speciali__CF97EB984CF2A323] PRIMARY KEY CLUSTERED 
(
	[id_speciality] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[statuses]    Script Date: 3/23/2024 4:11:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[statuses](
	[id_status] [int] IDENTITY(1,1) NOT NULL,
	[status_name] [nvarchar](50) NOT NULL,
	[timestamps] [datetime] NULL,
 CONSTRAINT [PK__statuses__5D2DC6E865E1C90F] PRIMARY KEY CLUSTERED 
(
	[id_status] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[student_test_detail]    Script Date: 3/23/2024 4:11:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[student_test_detail](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[id_student] [int] NOT NULL,
	[test_code] [int] NOT NULL,
	[id_question] [int] NOT NULL,
	[answer_a] [ntext] NOT NULL,
	[answer_b] [ntext] NOT NULL,
	[answer_c] [ntext] NOT NULL,
	[answer_d] [ntext] NOT NULL,
	[student_answer] [ntext] NULL,
	[timestamps] [datetime] NULL,
 CONSTRAINT [PK_student_test_detail] PRIMARY KEY CLUSTERED 
(
	[id_student] ASC,
	[test_code] ASC,
	[id_question] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[students]    Script Date: 3/23/2024 4:11:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[students](
	[id_student] [int] IDENTITY(1,1) NOT NULL,
	[username] [varchar](20) NOT NULL,
	[password] [varchar](32) NOT NULL,
	[email] [varchar](100) NOT NULL,
	[avatar] [varchar](255) NULL,
	[name] [nvarchar](100) NOT NULL,
	[gender] [nvarchar](50) NOT NULL,
	[birthday] [date] NOT NULL,
	[phone] [varchar](45) NULL,
	[id_permission] [int] NOT NULL,
	[id_class] [int] NOT NULL,
	[id_speciality] [int] NOT NULL,
	[is_testing] [int] NULL,
	[time_start] [datetime] NULL,
	[time_remaining] [varchar](10) NULL,
	[last_login] [datetime] NULL,
	[last_seen] [nvarchar](100) NULL,
	[last_seen_url] [varchar](100) NULL,
	[timestamps] [datetime] NULL,
 CONSTRAINT [PK__students__2BE2EBB681A432C4] PRIMARY KEY CLUSTERED 
(
	[id_student] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[subjects]    Script Date: 3/23/2024 4:11:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[subjects](
	[id_subject] [int] IDENTITY(1,1) NOT NULL,
	[subject_name] [nvarchar](255) NOT NULL,
	[timestamps] [datetime] NULL,
 CONSTRAINT [PK__subjects__8F848F6098C0F347] PRIMARY KEY CLUSTERED 
(
	[id_subject] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[teachers]    Script Date: 3/23/2024 4:11:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[teachers](
	[id_teacher] [int] IDENTITY(1,1) NOT NULL,
	[username] [varchar](20) NOT NULL,
	[password] [varchar](32) NOT NULL,
	[email] [varchar](100) NOT NULL,
	[avatar] [varchar](255) NULL,
	[name] [nvarchar](100) NOT NULL,
	[gender] [nvarchar](50) NOT NULL,
	[birthday] [date] NOT NULL,
	[phone] [varchar](45) NULL,
	[id_permission] [int] NOT NULL,
	[id_speciality] [int] NOT NULL,
	[last_login] [datetime] NULL,
	[last_seen] [nvarchar](100) NULL,
	[last_seen_url] [varchar](100) NULL,
	[timestamps] [datetime] NULL,
 CONSTRAINT [PK__teachers__3BAEF8F9A484A318] PRIMARY KEY CLUSTERED 
(
	[id_teacher] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tests]    Script Date: 3/23/2024 4:11:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tests](
	[test_name] [nvarchar](255) NOT NULL,
	[test_code] [int] NOT NULL,
	[password] [varchar](32) NOT NULL,
	[id_subject] [int] NOT NULL,
	[total_questions] [int] NOT NULL,
	[time_to_do] [int] NOT NULL,
	[note] [ntext] NULL,
	[id_status] [int] NOT NULL,
	[timestamps] [datetime] NULL,
 CONSTRAINT [PK_tests] PRIMARY KEY CLUSTERED 
(
	[test_code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[admins] ON 

INSERT [dbo].[admins] ([id_admin], [username], [password], [email], [avatar], [name], [gender], [birthday], [phone], [id_permission], [last_login], [last_seen], [last_seen_url], [timestamps]) VALUES (2, N'admin', N'e10adc3949ba59abbe56e057f20f883e', N'admin@gmail.com', N'avatar-default.jpg', N'ADMIN', N'1', CAST(N'2002-02-12' AS Date), N'0919309373', 1, CAST(N'2024-03-23T16:01:33.450' AS DateTime), N'Trang Chủ', N'/Admin', CAST(N'2024-03-23T03:11:28.850' AS DateTime))
SET IDENTITY_INSERT [dbo].[admins] OFF
GO
SET IDENTITY_INSERT [dbo].[classes] ON 

INSERT [dbo].[classes] ([id_class], [class_name], [id_grade], [id_speciality], [timestamps]) VALUES (1, N'SE1630NET', 1, 1, NULL)
INSERT [dbo].[classes] ([id_class], [class_name], [id_grade], [id_speciality], [timestamps]) VALUES (2, N'SE1731NET', 2, 1, NULL)
INSERT [dbo].[classes] ([id_class], [class_name], [id_grade], [id_speciality], [timestamps]) VALUES (3, N'SE1722NODE', 2, 3, NULL)
SET IDENTITY_INSERT [dbo].[classes] OFF
GO
SET IDENTITY_INSERT [dbo].[grades] ON 

INSERT [dbo].[grades] ([id_grade], [grade_name], [timestamps]) VALUES (1, N'K16', NULL)
INSERT [dbo].[grades] ([id_grade], [grade_name], [timestamps]) VALUES (2, N'K17', NULL)
SET IDENTITY_INSERT [dbo].[grades] OFF
GO
SET IDENTITY_INSERT [dbo].[permissions] ON 

INSERT [dbo].[permissions] ([id_permission], [permission_name], [timestamps]) VALUES (1, N'Admin', CAST(N'2024-03-23T03:10:18.220' AS DateTime))
INSERT [dbo].[permissions] ([id_permission], [permission_name], [timestamps]) VALUES (2, N'Teacher', CAST(N'2024-03-23T03:10:22.430' AS DateTime))
INSERT [dbo].[permissions] ([id_permission], [permission_name], [timestamps]) VALUES (3, N'Student', CAST(N'2023-02-12T00:00:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[permissions] OFF
GO
SET IDENTITY_INSERT [dbo].[questions] ON 

INSERT [dbo].[questions] ([id_question], [id_subject], [unit], [img_content], [content], [answer_a], [answer_b], [answer_c], [answer_d], [correct_answer], [timestamps]) VALUES (1, 1, 1, N'noimage.png', N'Thay Chung Dep Trai Khong', N'Sure', N'Co', N'Chac Chan', N'oke', N'Chac Chan', NULL)
INSERT [dbo].[questions] ([id_question], [id_subject], [unit], [img_content], [content], [answer_a], [answer_b], [answer_c], [answer_d], [correct_answer], [timestamps]) VALUES (2, 1, 7, N'noimage.png', N'PRN dễ không', N'không', N'hay ', N'dễ', N'đơn giản', N'đơn giản', NULL)
INSERT [dbo].[questions] ([id_question], [id_subject], [unit], [img_content], [content], [answer_a], [answer_b], [answer_c], [answer_d], [correct_answer], [timestamps]) VALUES (3, 1, 1, N'noimage.png', N'What is the capital city of France?', N'Paris', N'London', N'Berlin', N'Madrid', N'A', CAST(N'2024-03-23T03:38:19.180' AS DateTime))
INSERT [dbo].[questions] ([id_question], [id_subject], [unit], [img_content], [content], [answer_a], [answer_b], [answer_c], [answer_d], [correct_answer], [timestamps]) VALUES (4, 1, 2, N'noimage.png', N'Which planet is known as the Red Planet?', N'Mercury', N'Venus', N'Mars', N'Jupiter', N'C', CAST(N'2024-03-23T03:38:19.180' AS DateTime))
INSERT [dbo].[questions] ([id_question], [id_subject], [unit], [img_content], [content], [answer_a], [answer_b], [answer_c], [answer_d], [correct_answer], [timestamps]) VALUES (5, 1, 3, N'noimage.png', N'What is the powerhouse of the cell?', N'Nucleus', N'Mitochondria', N'Endoplasmic reticulum', N'Cell membrane', N'B', CAST(N'2024-03-23T03:38:19.180' AS DateTime))
INSERT [dbo].[questions] ([id_question], [id_subject], [unit], [img_content], [content], [answer_a], [answer_b], [answer_c], [answer_d], [correct_answer], [timestamps]) VALUES (6, 1, 4, N'noimage.png', N'What is the chemical symbol for water?', N'Wa', N'Wo', N'Wt', N'H2O', N'D', CAST(N'2024-03-23T03:38:19.180' AS DateTime))
INSERT [dbo].[questions] ([id_question], [id_subject], [unit], [img_content], [content], [answer_a], [answer_b], [answer_c], [answer_d], [correct_answer], [timestamps]) VALUES (7, 1, 5, N'noimage.png', N'Which of the following is a primary color?', N'Red', N'Green', N'Purple', N'Orange', N'A', CAST(N'2024-03-23T03:38:19.180' AS DateTime))
INSERT [dbo].[questions] ([id_question], [id_subject], [unit], [img_content], [content], [answer_a], [answer_b], [answer_c], [answer_d], [correct_answer], [timestamps]) VALUES (8, 1, 6, N'noimage.png', N'What is the largest mammal?', N'Dolphin', N'Elephant', N'Blue whale', N'Tiger', N'C', CAST(N'2024-03-23T03:38:19.180' AS DateTime))
INSERT [dbo].[questions] ([id_question], [id_subject], [unit], [img_content], [content], [answer_a], [answer_b], [answer_c], [answer_d], [correct_answer], [timestamps]) VALUES (9, 1, 7, N'noimage.png', N'Which gas do plants use to carry out photosynthesis?', N'Oxygen', N'Carbon dioxide', N'Nitrogen', N'Hydrogen', N'B', CAST(N'2024-03-23T03:38:19.180' AS DateTime))
INSERT [dbo].[questions] ([id_question], [id_subject], [unit], [img_content], [content], [answer_a], [answer_b], [answer_c], [answer_d], [correct_answer], [timestamps]) VALUES (10, 1, 8, N'noimage.png', N'What year did the Titanic sink?', N'1912', N'1920', N'1905', N'1915', N'A', CAST(N'2024-03-23T03:38:19.180' AS DateTime))
INSERT [dbo].[questions] ([id_question], [id_subject], [unit], [img_content], [content], [answer_a], [answer_b], [answer_c], [answer_d], [correct_answer], [timestamps]) VALUES (11, 1, 9, N'noimage.png', N'Which country is famous for its tulips?', N'Netherlands', N'France', N'Italy', N'Australia', N'A', CAST(N'2024-03-23T03:38:19.180' AS DateTime))
INSERT [dbo].[questions] ([id_question], [id_subject], [unit], [img_content], [content], [answer_a], [answer_b], [answer_c], [answer_d], [correct_answer], [timestamps]) VALUES (12, 1, 10, N'noimage.png', N'What is the tallest mountain in the world?', N'Mount Everest', N'Mount Kilimanjaro', N'Mount Fuji', N'Mount McKinley', N'A', CAST(N'2024-03-23T03:38:19.180' AS DateTime))
INSERT [dbo].[questions] ([id_question], [id_subject], [unit], [img_content], [content], [answer_a], [answer_b], [answer_c], [answer_d], [correct_answer], [timestamps]) VALUES (13, 1, 11, N'noimage.png', N'Who wrote "Romeo and Juliet"?', N'William Shakespeare', N'Jane Austen', N'Charles Dickens', N'Leo Tolstoy', N'A', CAST(N'2024-03-23T03:38:19.180' AS DateTime))
INSERT [dbo].[questions] ([id_question], [id_subject], [unit], [img_content], [content], [answer_a], [answer_b], [answer_c], [answer_d], [correct_answer], [timestamps]) VALUES (14, 1, 12, N'noimage.png', N'What is the chemical symbol for gold?', N'Ag', N'Au', N'Pt', N'Pb', N'B', CAST(N'2024-03-23T03:38:19.180' AS DateTime))
INSERT [dbo].[questions] ([id_question], [id_subject], [unit], [img_content], [content], [answer_a], [answer_b], [answer_c], [answer_d], [correct_answer], [timestamps]) VALUES (15, 1, 13, N'noimage.png', N'What is the largest organ in the human body?', N'Liver', N'Heart', N'Lungs', N'Skin', N'D', CAST(N'2024-03-23T03:38:19.180' AS DateTime))
INSERT [dbo].[questions] ([id_question], [id_subject], [unit], [img_content], [content], [answer_a], [answer_b], [answer_c], [answer_d], [correct_answer], [timestamps]) VALUES (16, 1, 14, N'noimage.png', N'What is the currency of Japan?', N'Yuan', N'Peso', N'Yen', N'Ruble', N'C', CAST(N'2024-03-23T03:38:19.180' AS DateTime))
INSERT [dbo].[questions] ([id_question], [id_subject], [unit], [img_content], [content], [answer_a], [answer_b], [answer_c], [answer_d], [correct_answer], [timestamps]) VALUES (17, 1, 15, N'noimage.png', N'Who painted the Mona Lisa?', N'Vincent van Gogh', N'Pablo Picasso', N'Leonardo da Vinci', N'Claude Monet', N'C', CAST(N'2024-03-23T03:38:19.180' AS DateTime))
INSERT [dbo].[questions] ([id_question], [id_subject], [unit], [img_content], [content], [answer_a], [answer_b], [answer_c], [answer_d], [correct_answer], [timestamps]) VALUES (18, 1, 16, N'noimage.png', N'What is the chemical formula for table salt?', N'NaCl', N'H2O', N'CO2', N'O2', N'A', CAST(N'2024-03-23T03:38:19.180' AS DateTime))
INSERT [dbo].[questions] ([id_question], [id_subject], [unit], [img_content], [content], [answer_a], [answer_b], [answer_c], [answer_d], [correct_answer], [timestamps]) VALUES (19, 1, 17, N'noimage.png', N'Which is the smallest planet in our solar system?', N'Earth', N'Mercury', N'Pluto', N'Mars', N'B', CAST(N'2024-03-23T03:38:19.180' AS DateTime))
INSERT [dbo].[questions] ([id_question], [id_subject], [unit], [img_content], [content], [answer_a], [answer_b], [answer_c], [answer_d], [correct_answer], [timestamps]) VALUES (20, 1, 18, N'noimage.png', N'What is the hardest natural substance on Earth?', N'Iron', N'Diamond', N'Gold', N'Silver', N'B', CAST(N'2024-03-23T03:38:19.180' AS DateTime))
INSERT [dbo].[questions] ([id_question], [id_subject], [unit], [img_content], [content], [answer_a], [answer_b], [answer_c], [answer_d], [correct_answer], [timestamps]) VALUES (21, 1, 19, N'noimage.png', N'What is the chemical symbol for oxygen?', N'O', N'O2', N'CO2', N'H2O', N'A', CAST(N'2024-03-23T03:38:19.180' AS DateTime))
INSERT [dbo].[questions] ([id_question], [id_subject], [unit], [img_content], [content], [answer_a], [answer_b], [answer_c], [answer_d], [correct_answer], [timestamps]) VALUES (22, 1, 20, N'noimage.png', N'What is the largest ocean on Earth?', N'Atlantic Ocean', N'Indian Ocean', N'Arctic Ocean', N'Pacific Ocean', N'D', CAST(N'2024-03-23T03:38:19.180' AS DateTime))
INSERT [dbo].[questions] ([id_question], [id_subject], [unit], [img_content], [content], [answer_a], [answer_b], [answer_c], [answer_d], [correct_answer], [timestamps]) VALUES (24, 2, 1, N'noimage.png', N'What is the capital city of Germany?', N'Paris', N'London', N'Berlin', N'Madrid', N'C', CAST(N'2024-03-23T03:41:23.697' AS DateTime))
INSERT [dbo].[questions] ([id_question], [id_subject], [unit], [img_content], [content], [answer_a], [answer_b], [answer_c], [answer_d], [correct_answer], [timestamps]) VALUES (25, 2, 1, N'noimage.png', N'Which planet is known as the Blue Planet?', N'Mercury', N'Venus', N'Earth', N'Mars', N'C', CAST(N'2024-03-23T03:41:23.697' AS DateTime))
INSERT [dbo].[questions] ([id_question], [id_subject], [unit], [img_content], [content], [answer_a], [answer_b], [answer_c], [answer_d], [correct_answer], [timestamps]) VALUES (26, 2, 1, N'noimage.png', N'What is the largest internal organ in the human body?', N'Liver', N'Heart', N'Lungs', N'Kidneys', N'A', CAST(N'2024-03-23T03:41:23.697' AS DateTime))
INSERT [dbo].[questions] ([id_question], [id_subject], [unit], [img_content], [content], [answer_a], [answer_b], [answer_c], [answer_d], [correct_answer], [timestamps]) VALUES (27, 2, 1, N'noimage.png', N'What is the chemical symbol for sodium?', N'S', N'Na', N'So', N'Si', N'B', CAST(N'2024-03-23T03:41:23.697' AS DateTime))
INSERT [dbo].[questions] ([id_question], [id_subject], [unit], [img_content], [content], [answer_a], [answer_b], [answer_c], [answer_d], [correct_answer], [timestamps]) VALUES (28, 2, 1, N'noimage.png', N'Which of the following is a noble gas?', N'Argon', N'Oxygen', N'Nitrogen', N'Carbon dioxide', N'A', CAST(N'2024-03-23T03:41:23.697' AS DateTime))
INSERT [dbo].[questions] ([id_question], [id_subject], [unit], [img_content], [content], [answer_a], [answer_b], [answer_c], [answer_d], [correct_answer], [timestamps]) VALUES (29, 2, 1, N'noimage.png', N'What is the smallest bone in the human body?', N'Femur', N'Tibia', N'Stapes', N'Radius', N'C', CAST(N'2024-03-23T03:41:23.697' AS DateTime))
INSERT [dbo].[questions] ([id_question], [id_subject], [unit], [img_content], [content], [answer_a], [answer_b], [answer_c], [answer_d], [correct_answer], [timestamps]) VALUES (30, 2, 1, N'noimage.png', N'What is the chemical symbol for water?', N'Wa', N'Wo', N'Wt', N'H2O', N'D', CAST(N'2024-03-23T03:41:23.697' AS DateTime))
INSERT [dbo].[questions] ([id_question], [id_subject], [unit], [img_content], [content], [answer_a], [answer_b], [answer_c], [answer_d], [correct_answer], [timestamps]) VALUES (31, 2, 1, N'noimage.png', N'What is the largest ocean on Earth?', N'Atlantic Ocean', N'Indian Ocean', N'Arctic Ocean', N'Pacific Ocean', N'D', CAST(N'2024-03-23T03:41:23.697' AS DateTime))
INSERT [dbo].[questions] ([id_question], [id_subject], [unit], [img_content], [content], [answer_a], [answer_b], [answer_c], [answer_d], [correct_answer], [timestamps]) VALUES (32, 2, 1, N'noimage.png', N'What is the SI unit for measuring temperature?', N'Celsius', N'Fahrenheit', N'Kelvin', N'Rankine', N'C', CAST(N'2024-03-23T03:41:23.697' AS DateTime))
INSERT [dbo].[questions] ([id_question], [id_subject], [unit], [img_content], [content], [answer_a], [answer_b], [answer_c], [answer_d], [correct_answer], [timestamps]) VALUES (33, 2, 1, N'noimage.png', N'Who developed the theory of relativity?', N'Albert Einstein', N'Isaac Newton', N'Galileo Galilei', N'Nikola Tesla', N'A', CAST(N'2024-03-23T03:41:23.697' AS DateTime))
INSERT [dbo].[questions] ([id_question], [id_subject], [unit], [img_content], [content], [answer_a], [answer_b], [answer_c], [answer_d], [correct_answer], [timestamps]) VALUES (34, 2, 1, N'noimage.png', N'What is the chemical symbol for silver?', N'Au', N'Ag', N'Pt', N'Pb', N'B', CAST(N'2024-03-23T03:41:23.697' AS DateTime))
INSERT [dbo].[questions] ([id_question], [id_subject], [unit], [img_content], [content], [answer_a], [answer_b], [answer_c], [answer_d], [correct_answer], [timestamps]) VALUES (35, 2, 1, N'noimage.png', N'Who wrote "To Kill a Mockingbird"?', N'Harper Lee', N'J.K. Rowling', N'Tolkien', N'Charles Dickens', N'A', CAST(N'2024-03-23T03:41:23.697' AS DateTime))
INSERT [dbo].[questions] ([id_question], [id_subject], [unit], [img_content], [content], [answer_a], [answer_b], [answer_c], [answer_d], [correct_answer], [timestamps]) VALUES (36, 2, 1, N'noimage.png', N'Which gas do plants use to carry out photosynthesis?', N'Oxygen', N'Carbon dioxide', N'Nitrogen', N'Hydrogen', N'B', CAST(N'2024-03-23T03:41:23.697' AS DateTime))
INSERT [dbo].[questions] ([id_question], [id_subject], [unit], [img_content], [content], [answer_a], [answer_b], [answer_c], [answer_d], [correct_answer], [timestamps]) VALUES (37, 2, 1, N'noimage.png', N'What is the longest river in the world?', N'Nile River', N'Amazon River', N'Yangtze River', N'Mississippi River', N'A', CAST(N'2024-03-23T03:41:23.697' AS DateTime))
INSERT [dbo].[questions] ([id_question], [id_subject], [unit], [img_content], [content], [answer_a], [answer_b], [answer_c], [answer_d], [correct_answer], [timestamps]) VALUES (38, 2, 1, N'noimage.png', N'What is the largest organ in the human body?', N'Liver', N'Heart', N'Brain', N'Skin', N'D', CAST(N'2024-03-23T03:41:23.697' AS DateTime))
INSERT [dbo].[questions] ([id_question], [id_subject], [unit], [img_content], [content], [answer_a], [answer_b], [answer_c], [answer_d], [correct_answer], [timestamps]) VALUES (39, 2, 1, N'noimage.png', N'What is the chemical formula for table salt?', N'NaCl', N'H2O', N'CO2', N'O2', N'A', CAST(N'2024-03-23T03:41:23.697' AS DateTime))
INSERT [dbo].[questions] ([id_question], [id_subject], [unit], [img_content], [content], [answer_a], [answer_b], [answer_c], [answer_d], [correct_answer], [timestamps]) VALUES (40, 2, 1, N'noimage.png', N'Who painted the Sistine Chapel ceiling?', N'Leonardo da Vinci', N'Michelangelo', N'Raphael', N'Donatello', N'B', CAST(N'2024-03-23T03:41:23.697' AS DateTime))
INSERT [dbo].[questions] ([id_question], [id_subject], [unit], [img_content], [content], [answer_a], [answer_b], [answer_c], [answer_d], [correct_answer], [timestamps]) VALUES (41, 2, 1, N'noimage.png', N'What is the chemical symbol for oxygen?', N'O', N'O2', N'CO2', N'H2O', N'B', CAST(N'2024-03-23T03:41:23.697' AS DateTime))
INSERT [dbo].[questions] ([id_question], [id_subject], [unit], [img_content], [content], [answer_a], [answer_b], [answer_c], [answer_d], [correct_answer], [timestamps]) VALUES (42, 2, 1, N'noimage.png', N'What is the most abundant gas in Earth’s atmosphere?', N'Oxygen', N'Carbon dioxide', N'Nitrogen', N'Hydrogen', N'C', CAST(N'2024-03-23T03:41:23.697' AS DateTime))
INSERT [dbo].[questions] ([id_question], [id_subject], [unit], [img_content], [content], [answer_a], [answer_b], [answer_c], [answer_d], [correct_answer], [timestamps]) VALUES (43, 2, 1, N'noimage.png', N'Who was the first woman to win a Nobel Prize?', N'Marie Curie', N'Rosalind Franklin', N'Dorothy Hodgkin', N'Rita Levi-Montalcini', N'A', CAST(N'2024-03-23T03:41:23.697' AS DateTime))
INSERT [dbo].[questions] ([id_question], [id_subject], [unit], [img_content], [content], [answer_a], [answer_b], [answer_c], [answer_d], [correct_answer], [timestamps]) VALUES (44, 2, 1, N'noimage.png', N'What is the capital city of Australia?', N'Sydney', N'Melbourne', N'Canberra', N'Brisbane', N'C', CAST(N'2024-03-23T03:41:23.697' AS DateTime))
INSERT [dbo].[questions] ([id_question], [id_subject], [unit], [img_content], [content], [answer_a], [answer_b], [answer_c], [answer_d], [correct_answer], [timestamps]) VALUES (45, 2, 1, N'noimage.png', N'What is the chemical symbol for gold?', N'Ag', N'Au', N'Pt', N'Pb', N'B', CAST(N'2024-03-23T03:41:23.697' AS DateTime))
INSERT [dbo].[questions] ([id_question], [id_subject], [unit], [img_content], [content], [answer_a], [answer_b], [answer_c], [answer_d], [correct_answer], [timestamps]) VALUES (46, 2, 1, N'noimage.png', N'Who wrote "Hamlet"?', N'William Shakespeare', N'Jane Austen', N'Charles Dickens', N'Leo Tolstoy', N'A', CAST(N'2024-03-23T03:41:23.697' AS DateTime))
INSERT [dbo].[questions] ([id_question], [id_subject], [unit], [img_content], [content], [answer_a], [answer_b], [answer_c], [answer_d], [correct_answer], [timestamps]) VALUES (47, 2, 1, N'noimage.png', N'What is the hardest natural substance on Earth?', N'Iron', N'Diamond', N'Gold', N'Silver', N'B', CAST(N'2024-03-23T03:41:23.697' AS DateTime))
INSERT [dbo].[questions] ([id_question], [id_subject], [unit], [img_content], [content], [answer_a], [answer_b], [answer_c], [answer_d], [correct_answer], [timestamps]) VALUES (48, 2, 1, N'noimage.png', N'What is the chemical symbol for carbon?', N'C', N'Ca', N'Co', N'Cr', N'A', CAST(N'2024-03-23T03:41:23.697' AS DateTime))
INSERT [dbo].[questions] ([id_question], [id_subject], [unit], [img_content], [content], [answer_a], [answer_b], [answer_c], [answer_d], [correct_answer], [timestamps]) VALUES (49, 2, 1, N'noimage.png', N'Who discovered penicillin?', N'Alexander Fleming', N'Louis Pasteur', N'Robert Koch', N'Joseph Lister', N'A', CAST(N'2024-03-23T03:41:23.697' AS DateTime))
INSERT [dbo].[questions] ([id_question], [id_subject], [unit], [img_content], [content], [answer_a], [answer_b], [answer_c], [answer_d], [correct_answer], [timestamps]) VALUES (50, 2, 1, N'noimage.png', N'What is the tallest mammal on Earth?', N'Elephant', N'Giraffe', N'Horse', N'Kangaroo', N'B', CAST(N'2024-03-23T03:41:23.697' AS DateTime))
INSERT [dbo].[questions] ([id_question], [id_subject], [unit], [img_content], [content], [answer_a], [answer_b], [answer_c], [answer_d], [correct_answer], [timestamps]) VALUES (51, 2, 1, N'noimage.png', N'What is the chemical symbol for calcium?', N'Ca', N'C', N'Co', N'Cr', N'A', CAST(N'2024-03-23T03:41:23.697' AS DateTime))
INSERT [dbo].[questions] ([id_question], [id_subject], [unit], [img_content], [content], [answer_a], [answer_b], [answer_c], [answer_d], [correct_answer], [timestamps]) VALUES (52, 2, 1, N'noimage.png', N'What is the national flower of Japan?', N'Rose', N'Lily', N'Cherry blossom', N'Daisy', N'C', CAST(N'2024-03-23T03:41:23.697' AS DateTime))
SET IDENTITY_INSERT [dbo].[questions] OFF
GO
SET IDENTITY_INSERT [dbo].[quests_of_test] ON 

INSERT [dbo].[quests_of_test] ([ID], [test_code], [id_question], [timestamps]) VALUES (1, 395251, 24, NULL)
INSERT [dbo].[quests_of_test] ([ID], [test_code], [id_question], [timestamps]) VALUES (2, 395251, 44, NULL)
INSERT [dbo].[quests_of_test] ([ID], [test_code], [id_question], [timestamps]) VALUES (3, 395251, 45, NULL)
INSERT [dbo].[quests_of_test] ([ID], [test_code], [id_question], [timestamps]) VALUES (4, 395251, 34, NULL)
INSERT [dbo].[quests_of_test] ([ID], [test_code], [id_question], [timestamps]) VALUES (5, 395251, 27, NULL)
INSERT [dbo].[quests_of_test] ([ID], [test_code], [id_question], [timestamps]) VALUES (6, 395251, 40, NULL)
INSERT [dbo].[quests_of_test] ([ID], [test_code], [id_question], [timestamps]) VALUES (7, 395251, 36, NULL)
INSERT [dbo].[quests_of_test] ([ID], [test_code], [id_question], [timestamps]) VALUES (8, 395251, 38, NULL)
INSERT [dbo].[quests_of_test] ([ID], [test_code], [id_question], [timestamps]) VALUES (9, 395251, 52, NULL)
INSERT [dbo].[quests_of_test] ([ID], [test_code], [id_question], [timestamps]) VALUES (10, 395251, 30, NULL)
INSERT [dbo].[quests_of_test] ([ID], [test_code], [id_question], [timestamps]) VALUES (11, 395251, 33, NULL)
INSERT [dbo].[quests_of_test] ([ID], [test_code], [id_question], [timestamps]) VALUES (12, 395251, 37, NULL)
INSERT [dbo].[quests_of_test] ([ID], [test_code], [id_question], [timestamps]) VALUES (13, 395251, 41, NULL)
INSERT [dbo].[quests_of_test] ([ID], [test_code], [id_question], [timestamps]) VALUES (14, 395251, 25, NULL)
INSERT [dbo].[quests_of_test] ([ID], [test_code], [id_question], [timestamps]) VALUES (15, 395251, 48, NULL)
INSERT [dbo].[quests_of_test] ([ID], [test_code], [id_question], [timestamps]) VALUES (16, 395251, 28, NULL)
INSERT [dbo].[quests_of_test] ([ID], [test_code], [id_question], [timestamps]) VALUES (17, 395251, 42, NULL)
INSERT [dbo].[quests_of_test] ([ID], [test_code], [id_question], [timestamps]) VALUES (18, 395251, 31, NULL)
INSERT [dbo].[quests_of_test] ([ID], [test_code], [id_question], [timestamps]) VALUES (19, 395251, 35, NULL)
INSERT [dbo].[quests_of_test] ([ID], [test_code], [id_question], [timestamps]) VALUES (20, 395251, 29, NULL)
SET IDENTITY_INSERT [dbo].[quests_of_test] OFF
GO
SET IDENTITY_INSERT [dbo].[scores] ON 

INSERT [dbo].[scores] ([id_score], [id_student], [test_code], [score_number], [detail], [time_finish]) VALUES (1, 1, 395251, 0, N'0/20                                              ', CAST(N'2024-03-23T03:53:46.933' AS DateTime))
SET IDENTITY_INSERT [dbo].[scores] OFF
GO
SET IDENTITY_INSERT [dbo].[specialities] ON 

INSERT [dbo].[specialities] ([id_speciality], [speciality_name], [timestamps]) VALUES (1, N'Công Nghe AI', NULL)
INSERT [dbo].[specialities] ([id_speciality], [speciality_name], [timestamps]) VALUES (2, N'IOT', NULL)
INSERT [dbo].[specialities] ([id_speciality], [speciality_name], [timestamps]) VALUES (3, N'NODE JS', NULL)
SET IDENTITY_INSERT [dbo].[specialities] OFF
GO
SET IDENTITY_INSERT [dbo].[statuses] ON 

INSERT [dbo].[statuses] ([id_status], [status_name], [timestamps]) VALUES (1, N'Open', CAST(N'2024-03-23T03:49:28.880' AS DateTime))
INSERT [dbo].[statuses] ([id_status], [status_name], [timestamps]) VALUES (2, N'Đóng', CAST(N'2024-03-23T03:49:33.280' AS DateTime))
SET IDENTITY_INSERT [dbo].[statuses] OFF
GO
SET IDENTITY_INSERT [dbo].[student_test_detail] ON 

INSERT [dbo].[student_test_detail] ([ID], [id_student], [test_code], [id_question], [answer_a], [answer_b], [answer_c], [answer_d], [student_answer], [timestamps]) VALUES (14, 1, 395251, 24, N'Paris', N'Madrid', N'London', N'Berlin', N'Paris', NULL)
INSERT [dbo].[student_test_detail] ([ID], [id_student], [test_code], [id_question], [answer_a], [answer_b], [answer_c], [answer_d], [student_answer], [timestamps]) VALUES (8, 1, 395251, 25, N'Earth', N'Venus', N'Mercury', N'Mars', N'Earth', NULL)
INSERT [dbo].[student_test_detail] ([ID], [id_student], [test_code], [id_question], [answer_a], [answer_b], [answer_c], [answer_d], [student_answer], [timestamps]) VALUES (17, 1, 395251, 27, N'Si', N'S', N'So', N'Na', N'Na', NULL)
INSERT [dbo].[student_test_detail] ([ID], [id_student], [test_code], [id_question], [answer_a], [answer_b], [answer_c], [answer_d], [student_answer], [timestamps]) VALUES (2, 1, 395251, 28, N'Nitrogen', N'Argon', N'Oxygen', N'Carbon dioxide', N'Oxygen', NULL)
INSERT [dbo].[student_test_detail] ([ID], [id_student], [test_code], [id_question], [answer_a], [answer_b], [answer_c], [answer_d], [student_answer], [timestamps]) VALUES (5, 1, 395251, 29, N'Femur', N'Radius', N'Stapes', N'Tibia', N'Stapes', NULL)
INSERT [dbo].[student_test_detail] ([ID], [id_student], [test_code], [id_question], [answer_a], [answer_b], [answer_c], [answer_d], [student_answer], [timestamps]) VALUES (15, 1, 395251, 30, N'Wt', N'Wo', N'Wa', N'H2O', N'Wt', NULL)
INSERT [dbo].[student_test_detail] ([ID], [id_student], [test_code], [id_question], [answer_a], [answer_b], [answer_c], [answer_d], [student_answer], [timestamps]) VALUES (16, 1, 395251, 31, N'Atlantic Ocean', N'Indian Ocean', N'Pacific Ocean', N'Arctic Ocean', N'Indian Ocean', NULL)
INSERT [dbo].[student_test_detail] ([ID], [id_student], [test_code], [id_question], [answer_a], [answer_b], [answer_c], [answer_d], [student_answer], [timestamps]) VALUES (10, 1, 395251, 33, N'Nikola Tesla', N'Galileo Galilei', N'Albert Einstein', N'Isaac Newton', N'Nikola Tesla', NULL)
INSERT [dbo].[student_test_detail] ([ID], [id_student], [test_code], [id_question], [answer_a], [answer_b], [answer_c], [answer_d], [student_answer], [timestamps]) VALUES (18, 1, 395251, 34, N'Pt', N'Ag', N'Pb', N'Au', N'Pt', NULL)
INSERT [dbo].[student_test_detail] ([ID], [id_student], [test_code], [id_question], [answer_a], [answer_b], [answer_c], [answer_d], [student_answer], [timestamps]) VALUES (4, 1, 395251, 35, N'Harper Lee', N'Tolkien', N'J.K. Rowling', N'Charles Dickens', N'Charles Dickens', NULL)
INSERT [dbo].[student_test_detail] ([ID], [id_student], [test_code], [id_question], [answer_a], [answer_b], [answer_c], [answer_d], [student_answer], [timestamps]) VALUES (13, 1, 395251, 36, N'Hydrogen', N'Oxygen', N'Nitrogen', N'Carbon dioxide', N'Carbon dioxide', NULL)
INSERT [dbo].[student_test_detail] ([ID], [id_student], [test_code], [id_question], [answer_a], [answer_b], [answer_c], [answer_d], [student_answer], [timestamps]) VALUES (19, 1, 395251, 37, N'Nile River', N'Yangtze River', N'Amazon River', N'Mississippi River', N'Yangtze River', NULL)
INSERT [dbo].[student_test_detail] ([ID], [id_student], [test_code], [id_question], [answer_a], [answer_b], [answer_c], [answer_d], [student_answer], [timestamps]) VALUES (20, 1, 395251, 38, N'Brain', N'Liver', N'Skin', N'Heart', N'Brain', NULL)
INSERT [dbo].[student_test_detail] ([ID], [id_student], [test_code], [id_question], [answer_a], [answer_b], [answer_c], [answer_d], [student_answer], [timestamps]) VALUES (3, 1, 395251, 40, N'Leonardo da Vinci', N'Donatello', N'Raphael', N'Michelangelo', N'Leonardo da Vinci', NULL)
INSERT [dbo].[student_test_detail] ([ID], [id_student], [test_code], [id_question], [answer_a], [answer_b], [answer_c], [answer_d], [student_answer], [timestamps]) VALUES (1, 1, 395251, 41, N'O', N'O2', N'CO2', N'H2O', N'O2', NULL)
INSERT [dbo].[student_test_detail] ([ID], [id_student], [test_code], [id_question], [answer_a], [answer_b], [answer_c], [answer_d], [student_answer], [timestamps]) VALUES (11, 1, 395251, 42, N'Oxygen', N'Hydrogen', N'Carbon dioxide', N'Nitrogen', N'Hydrogen', NULL)
INSERT [dbo].[student_test_detail] ([ID], [id_student], [test_code], [id_question], [answer_a], [answer_b], [answer_c], [answer_d], [student_answer], [timestamps]) VALUES (9, 1, 395251, 44, N'Melbourne', N'Brisbane', N'Sydney', N'Canberra', N'Melbourne', NULL)
INSERT [dbo].[student_test_detail] ([ID], [id_student], [test_code], [id_question], [answer_a], [answer_b], [answer_c], [answer_d], [student_answer], [timestamps]) VALUES (6, 1, 395251, 45, N'Ag', N'Pt', N'Pb', N'Au', N'Pt', NULL)
INSERT [dbo].[student_test_detail] ([ID], [id_student], [test_code], [id_question], [answer_a], [answer_b], [answer_c], [answer_d], [student_answer], [timestamps]) VALUES (7, 1, 395251, 48, N'Cr', N'Co', N'Ca', N'C', N'C', NULL)
INSERT [dbo].[student_test_detail] ([ID], [id_student], [test_code], [id_question], [answer_a], [answer_b], [answer_c], [answer_d], [student_answer], [timestamps]) VALUES (12, 1, 395251, 52, N'Cherry blossom', N'Rose', N'Lily', N'Daisy', N'Cherry blossom', NULL)
SET IDENTITY_INSERT [dbo].[student_test_detail] OFF
GO
SET IDENTITY_INSERT [dbo].[students] ON 

INSERT [dbo].[students] ([id_student], [username], [password], [email], [avatar], [name], [gender], [birthday], [phone], [id_permission], [id_class], [id_speciality], [is_testing], [time_start], [time_remaining], [last_login], [last_seen], [last_seen_url], [timestamps]) VALUES (1, N'hocsinh', N'e10adc3949ba59abbe56e057f20f883e', N'hocsinh@gmail.com', N'avatar-default.jpg', N'Hoc Sinh', N'Nam', CAST(N'1997-01-01' AS Date), NULL, 3, 1, 1, NULL, NULL, NULL, CAST(N'2024-03-23T16:09:26.453' AS DateTime), N'Trang Chủ', N'/Student', NULL)
INSERT [dbo].[students] ([id_student], [username], [password], [email], [avatar], [name], [gender], [birthday], [phone], [id_permission], [id_class], [id_speciality], [is_testing], [time_start], [time_remaining], [last_login], [last_seen], [last_seen_url], [timestamps]) VALUES (2, N'hocsinh2', N'e10adc3949ba59abbe56e057f20f883e', N'hocsinh2@gmail.com', N'avatar-default.jpg', N'hocsinh2', N'Nam', CAST(N'1997-01-01' AS Date), NULL, 3, 2, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[students] OFF
GO
SET IDENTITY_INSERT [dbo].[subjects] ON 

INSERT [dbo].[subjects] ([id_subject], [subject_name], [timestamps]) VALUES (1, N'PRN231', NULL)
INSERT [dbo].[subjects] ([id_subject], [subject_name], [timestamps]) VALUES (2, N'PRN221', NULL)
INSERT [dbo].[subjects] ([id_subject], [subject_name], [timestamps]) VALUES (3, N'PRN211', NULL)
SET IDENTITY_INSERT [dbo].[subjects] OFF
GO
SET IDENTITY_INSERT [dbo].[teachers] ON 

INSERT [dbo].[teachers] ([id_teacher], [username], [password], [email], [avatar], [name], [gender], [birthday], [phone], [id_permission], [id_speciality], [last_login], [last_seen], [last_seen_url], [timestamps]) VALUES (1, N'giaovien', N'e10adc3949ba59abbe56e057f20f883e', N'giaovien@gmail.com', N'avatar-default.jpg', N'chunglv', N'Nam', CAST(N'1997-01-01' AS Date), NULL, 2, 1, CAST(N'2024-03-23T03:54:16.970' AS DateTime), N'Trang Chủ', N'/Teacher', NULL)
INSERT [dbo].[teachers] ([id_teacher], [username], [password], [email], [avatar], [name], [gender], [birthday], [phone], [id_permission], [id_speciality], [last_login], [last_seen], [last_seen_url], [timestamps]) VALUES (2, N'giaovien2', N'e10adc3949ba59abbe56e057f20f883e', N'giaovien2@gmail.com', N'avatar-default.jpg', N'giaovien2', N'Nam', CAST(N'1997-01-03' AS Date), NULL, 2, 1, NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[teachers] OFF
GO
INSERT [dbo].[tests] ([test_name], [test_code], [password], [id_subject], [total_questions], [time_to_do], [note], [id_status], [timestamps]) VALUES (N'FE_PRN221', 395251, N'e10adc3949ba59abbe56e057f20f883e', 2, 20, 20, N'note', 1, NULL)
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__admins__B96D23647734DA5F]    Script Date: 3/23/2024 4:11:01 PM ******/
ALTER TABLE [dbo].[admins] ADD  CONSTRAINT [UQ__admins__B96D23647734DA5F] UNIQUE NONCLUSTERED 
(
	[username] ASC,
	[email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [fk_grade_idx]    Script Date: 3/23/2024 4:11:01 PM ******/
CREATE NONCLUSTERED INDEX [fk_grade_idx] ON [dbo].[classes]
(
	[id_grade] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [fk_speciality_idx]    Script Date: 3/23/2024 4:11:01 PM ******/
CREATE NONCLUSTERED INDEX [fk_speciality_idx] ON [dbo].[classes]
(
	[id_speciality] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__students__B96D2364BADF7213]    Script Date: 3/23/2024 4:11:01 PM ******/
ALTER TABLE [dbo].[students] ADD  CONSTRAINT [UQ__students__B96D2364BADF7213] UNIQUE NONCLUSTERED 
(
	[username] ASC,
	[email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__teachers__B96D2364E4800B05]    Script Date: 3/23/2024 4:11:01 PM ******/
ALTER TABLE [dbo].[teachers] ADD  CONSTRAINT [UQ__teachers__B96D2364E4800B05] UNIQUE NONCLUSTERED 
(
	[username] ASC,
	[email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [UQ__tests__040975AB07882BC3]    Script Date: 3/23/2024 4:11:01 PM ******/
ALTER TABLE [dbo].[tests] ADD UNIQUE NONCLUSTERED 
(
	[test_code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[admins] ADD  CONSTRAINT [DF__admins__avatar__45F365D3]  DEFAULT ('avatar-default.jpg') FOR [avatar]
GO
ALTER TABLE [dbo].[admins] ADD  CONSTRAINT [DF_admins_timestamps]  DEFAULT (getdate()) FOR [timestamps]
GO
ALTER TABLE [dbo].[classes] ADD  CONSTRAINT [DF_classes_timestamps]  DEFAULT (getdate()) FOR [timestamps]
GO
ALTER TABLE [dbo].[grades] ADD  CONSTRAINT [DF_grades_timestamps]  DEFAULT (getdate()) FOR [timestamps]
GO
ALTER TABLE [dbo].[permissions] ADD  CONSTRAINT [DF_permissions_timestamps]  DEFAULT (getdate()) FOR [timestamps]
GO
ALTER TABLE [dbo].[questions] ADD  CONSTRAINT [DF_questions_timestamps]  DEFAULT (getdate()) FOR [timestamps]
GO
ALTER TABLE [dbo].[quests_of_test] ADD  CONSTRAINT [DF_quests_of_test_timestamps]  DEFAULT (getdate()) FOR [timestamps]
GO
ALTER TABLE [dbo].[scores] ADD  CONSTRAINT [DF_scores_time_finish]  DEFAULT (getdate()) FOR [time_finish]
GO
ALTER TABLE [dbo].[specialities] ADD  CONSTRAINT [DF_specialities_timestamps]  DEFAULT (getdate()) FOR [timestamps]
GO
ALTER TABLE [dbo].[statuses] ADD  CONSTRAINT [DF_statuses_timestamps]  DEFAULT (getdate()) FOR [timestamps]
GO
ALTER TABLE [dbo].[student_test_detail] ADD  CONSTRAINT [DF_student_test_detail_timestamps]  DEFAULT (getdate()) FOR [timestamps]
GO
ALTER TABLE [dbo].[students] ADD  CONSTRAINT [DF__students__avatar__4E88ABD4]  DEFAULT ('avatar-default.jpg') FOR [avatar]
GO
ALTER TABLE [dbo].[students] ADD  CONSTRAINT [DF__students__is_tes__52593CB8]  DEFAULT (NULL) FOR [is_testing]
GO
ALTER TABLE [dbo].[students] ADD  CONSTRAINT [DF__students__time_r__534D60F1]  DEFAULT (NULL) FOR [time_remaining]
GO
ALTER TABLE [dbo].[students] ADD  CONSTRAINT [DF_students_timestamps]  DEFAULT (getdate()) FOR [timestamps]
GO
ALTER TABLE [dbo].[subjects] ADD  CONSTRAINT [DF_subjects_timestamps]  DEFAULT (getdate()) FOR [timestamps]
GO
ALTER TABLE [dbo].[teachers] ADD  CONSTRAINT [DF__teachers__avatar__49C3F6B7]  DEFAULT ('avatar-default.jpg') FOR [avatar]
GO
ALTER TABLE [dbo].[teachers] ADD  CONSTRAINT [DF_teachers_timestamps]  DEFAULT (getdate()) FOR [timestamps]
GO
ALTER TABLE [dbo].[tests] ADD  CONSTRAINT [DF_tests_timestamps]  DEFAULT (getdate()) FOR [timestamps]
GO
ALTER TABLE [dbo].[admins]  WITH CHECK ADD  CONSTRAINT [FK__admins__id_permi__46E78A0C] FOREIGN KEY([id_permission])
REFERENCES [dbo].[permissions] ([id_permission])
GO
ALTER TABLE [dbo].[admins] CHECK CONSTRAINT [FK__admins__id_permi__46E78A0C]
GO
ALTER TABLE [dbo].[classes]  WITH CHECK ADD  CONSTRAINT [fk_grade] FOREIGN KEY([id_grade])
REFERENCES [dbo].[grades] ([id_grade])
GO
ALTER TABLE [dbo].[classes] CHECK CONSTRAINT [fk_grade]
GO
ALTER TABLE [dbo].[classes]  WITH CHECK ADD  CONSTRAINT [fk_speciality] FOREIGN KEY([id_speciality])
REFERENCES [dbo].[specialities] ([id_speciality])
GO
ALTER TABLE [dbo].[classes] CHECK CONSTRAINT [fk_speciality]
GO
ALTER TABLE [dbo].[questions]  WITH CHECK ADD  CONSTRAINT [FK__questions__id_su__5629CD9C] FOREIGN KEY([id_subject])
REFERENCES [dbo].[subjects] ([id_subject])
GO
ALTER TABLE [dbo].[questions] CHECK CONSTRAINT [FK__questions__id_su__5629CD9C]
GO
ALTER TABLE [dbo].[quests_of_test]  WITH CHECK ADD  CONSTRAINT [FK_quests_of_test_questions] FOREIGN KEY([id_question])
REFERENCES [dbo].[questions] ([id_question])
GO
ALTER TABLE [dbo].[quests_of_test] CHECK CONSTRAINT [FK_quests_of_test_questions]
GO
ALTER TABLE [dbo].[quests_of_test]  WITH CHECK ADD  CONSTRAINT [FK_quests_of_test_tests] FOREIGN KEY([test_code])
REFERENCES [dbo].[tests] ([test_code])
GO
ALTER TABLE [dbo].[quests_of_test] CHECK CONSTRAINT [FK_quests_of_test_tests]
GO
ALTER TABLE [dbo].[scores]  WITH CHECK ADD  CONSTRAINT [FK__scores__id_stude__60A75C0F] FOREIGN KEY([id_student])
REFERENCES [dbo].[students] ([id_student])
GO
ALTER TABLE [dbo].[scores] CHECK CONSTRAINT [FK__scores__id_stude__60A75C0F]
GO
ALTER TABLE [dbo].[scores]  WITH CHECK ADD  CONSTRAINT [FK_scores_tests] FOREIGN KEY([test_code])
REFERENCES [dbo].[tests] ([test_code])
GO
ALTER TABLE [dbo].[scores] CHECK CONSTRAINT [FK_scores_tests]
GO
ALTER TABLE [dbo].[students]  WITH CHECK ADD  CONSTRAINT [FK__students__id_cla__5070F446] FOREIGN KEY([id_class])
REFERENCES [dbo].[classes] ([id_class])
GO
ALTER TABLE [dbo].[students] CHECK CONSTRAINT [FK__students__id_cla__5070F446]
GO
ALTER TABLE [dbo].[students]  WITH CHECK ADD  CONSTRAINT [FK__students__id_per__4F7CD00D] FOREIGN KEY([id_permission])
REFERENCES [dbo].[permissions] ([id_permission])
GO
ALTER TABLE [dbo].[students] CHECK CONSTRAINT [FK__students__id_per__4F7CD00D]
GO
ALTER TABLE [dbo].[students]  WITH CHECK ADD  CONSTRAINT [FK__students__id_spe__5165187F] FOREIGN KEY([id_speciality])
REFERENCES [dbo].[specialities] ([id_speciality])
GO
ALTER TABLE [dbo].[students] CHECK CONSTRAINT [FK__students__id_spe__5165187F]
GO
ALTER TABLE [dbo].[teachers]  WITH CHECK ADD  CONSTRAINT [FK__teachers__id_per__4AB81AF0] FOREIGN KEY([id_permission])
REFERENCES [dbo].[permissions] ([id_permission])
GO
ALTER TABLE [dbo].[teachers] CHECK CONSTRAINT [FK__teachers__id_per__4AB81AF0]
GO
ALTER TABLE [dbo].[teachers]  WITH CHECK ADD  CONSTRAINT [FK__teachers__id_spe__4BAC3F29] FOREIGN KEY([id_speciality])
REFERENCES [dbo].[specialities] ([id_speciality])
GO
ALTER TABLE [dbo].[teachers] CHECK CONSTRAINT [FK__teachers__id_spe__4BAC3F29]
GO
ALTER TABLE [dbo].[tests]  WITH CHECK ADD  CONSTRAINT [FK__tests__id_status__59FA5E80] FOREIGN KEY([id_status])
REFERENCES [dbo].[statuses] ([id_status])
GO
ALTER TABLE [dbo].[tests] CHECK CONSTRAINT [FK__tests__id_status__59FA5E80]
GO
ALTER TABLE [dbo].[tests]  WITH CHECK ADD  CONSTRAINT [FK__tests__id_subjec__59063A47] FOREIGN KEY([id_subject])
REFERENCES [dbo].[subjects] ([id_subject])
GO
ALTER TABLE [dbo].[tests] CHECK CONSTRAINT [FK__tests__id_subjec__59063A47]
GO
USE [master]
GO
ALTER DATABASE [trac_nghiem_online] SET  READ_WRITE 
GO
