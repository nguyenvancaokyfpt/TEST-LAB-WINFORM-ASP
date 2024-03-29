USE [master]
GO
/****** Object:  Database [trac_nghiem_online]    Script Date: 3/25/2024 1:21:34 AM ******/
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
/****** Object:  Table [dbo].[admins]    Script Date: 3/25/2024 1:21:34 AM ******/
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
/****** Object:  Table [dbo].[classes]    Script Date: 3/25/2024 1:21:34 AM ******/
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
/****** Object:  Table [dbo].[grades]    Script Date: 3/25/2024 1:21:34 AM ******/
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
/****** Object:  Table [dbo].[permissions]    Script Date: 3/25/2024 1:21:34 AM ******/
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
/****** Object:  Table [dbo].[questions]    Script Date: 3/25/2024 1:21:34 AM ******/
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
/****** Object:  Table [dbo].[quests_of_test]    Script Date: 3/25/2024 1:21:34 AM ******/
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
/****** Object:  Table [dbo].[scores]    Script Date: 3/25/2024 1:21:34 AM ******/
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
/****** Object:  Table [dbo].[specialities]    Script Date: 3/25/2024 1:21:34 AM ******/
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
/****** Object:  Table [dbo].[statuses]    Script Date: 3/25/2024 1:21:34 AM ******/
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
/****** Object:  Table [dbo].[student_test_detail]    Script Date: 3/25/2024 1:21:34 AM ******/
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
/****** Object:  Table [dbo].[students]    Script Date: 3/25/2024 1:21:34 AM ******/
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
/****** Object:  Table [dbo].[subjects]    Script Date: 3/25/2024 1:21:34 AM ******/
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
/****** Object:  Table [dbo].[teachers]    Script Date: 3/25/2024 1:21:34 AM ******/
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
/****** Object:  Table [dbo].[tests]    Script Date: 3/25/2024 1:21:34 AM ******/
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

INSERT [dbo].[admins] ([id_admin], [username], [password], [email], [avatar], [name], [gender], [birthday], [phone], [id_permission], [last_login], [last_seen], [last_seen_url], [timestamps]) VALUES (2, N'admin', N'e10adc3949ba59abbe56e057f20f883e', N'admin@gmail.com', N'avatar-default.jpg', N'ADMIN', N'Nam', CAST(N'2002-02-12' AS Date), N'0919309373', 1, CAST(N'2024-03-25T01:13:17.530' AS DateTime), N'Quản Lý Bài Thi', N'/Admin/TestManager/984652', CAST(N'2024-03-23T03:11:28.850' AS DateTime))
SET IDENTITY_INSERT [dbo].[admins] OFF
GO
SET IDENTITY_INSERT [dbo].[classes] ON 

INSERT [dbo].[classes] ([id_class], [class_name], [id_grade], [id_speciality], [timestamps]) VALUES (2004, N'SE1630-NET', 1, 1, CAST(N'2024-03-24T17:55:32.540' AS DateTime))
INSERT [dbo].[classes] ([id_class], [class_name], [id_grade], [id_speciality], [timestamps]) VALUES (2005, N'SE1625-NET', 1, 1, CAST(N'2024-03-24T17:56:08.187' AS DateTime))
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

INSERT [dbo].[questions] ([id_question], [id_subject], [unit], [img_content], [content], [answer_a], [answer_b], [answer_c], [answer_d], [correct_answer], [timestamps]) VALUES (1053, 1, 1, N'noimage.jpg', N'What is ASP.NET Core Web API?', N'It is a framework for building HTTP services.', N'It is a database management system.', N'It is a front-end development framework.', N'It is a programming language.', N'It is a framework for building HTTP services.', CAST(N'2024-03-24T18:09:20.463' AS DateTime))
INSERT [dbo].[questions] ([id_question], [id_subject], [unit], [img_content], [content], [answer_a], [answer_b], [answer_c], [answer_d], [correct_answer], [timestamps]) VALUES (1054, 1, 2, N'noimage.jpg', N'What is the default HTTP method for retrieving data in ASP.NET Core Web API?', N'GET', N'POST', N'DELETE', N'PUT', N'GET', CAST(N'2024-03-24T18:09:20.463' AS DateTime))
INSERT [dbo].[questions] ([id_question], [id_subject], [unit], [img_content], [content], [answer_a], [answer_b], [answer_c], [answer_d], [correct_answer], [timestamps]) VALUES (1055, 1, 1, N'noimage.jpg', N'Which of the following is NOT a feature of ASP.NET Core Web API?', N'Content negotiation', N'Automatic model binding', N'Server-side rendering', N'Dependency injection', N'Server-side rendering', CAST(N'2024-03-24T18:09:20.463' AS DateTime))
INSERT [dbo].[questions] ([id_question], [id_subject], [unit], [img_content], [content], [answer_a], [answer_b], [answer_c], [answer_d], [correct_answer], [timestamps]) VALUES (1056, 1, 1, N'noimage.jpg', N'What is the default format for request and response in ASP.NET Core Web API?', N'JSON', N'XML', N'YAML', N'HTML', N'JSON', CAST(N'2024-03-24T18:09:20.463' AS DateTime))
INSERT [dbo].[questions] ([id_question], [id_subject], [unit], [img_content], [content], [answer_a], [answer_b], [answer_c], [answer_d], [correct_answer], [timestamps]) VALUES (1057, 1, 1, N'noimage.jpg', N'What is the purpose of routing in ASP.NET Core Web API?', N'To define how HTTP requests are mapped to action methods.', N'To manage database connections.', N'To authenticate users.', N'To execute background tasks.', N'To define how HTTP requests are mapped to action methods.', CAST(N'2024-03-24T18:09:20.463' AS DateTime))
INSERT [dbo].[questions] ([id_question], [id_subject], [unit], [img_content], [content], [answer_a], [answer_b], [answer_c], [answer_d], [correct_answer], [timestamps]) VALUES (1058, 1, 1, N'noimage.jpg', N'What is the purpose of the [ApiController] attribute in ASP.NET Core Web API controllers?', N'To indicate that the controller is an API controller and thus automatically applies binding source parameters from the request body and other sources.', N'To specify the route template for the controller.', N'To define the authentication scheme for the controller.', N'To specify the HTTP method for the controller action.', N'To indicate that the controller is an API controller and thus automatically applies binding source parameters from the request body and other sources.', CAST(N'2024-03-24T18:10:21.963' AS DateTime))
INSERT [dbo].[questions] ([id_question], [id_subject], [unit], [img_content], [content], [answer_a], [answer_b], [answer_c], [answer_d], [correct_answer], [timestamps]) VALUES (1059, 1, 2, N'noimage.jpg', N'Which HTTP status code indicates a successful request in ASP.NET Core Web API?', N'200 OK', N'404 Not Found', N'500 Internal Server Error', N'401 Unauthorized', N'200 OK', CAST(N'2024-03-24T18:10:21.963' AS DateTime))
INSERT [dbo].[questions] ([id_question], [id_subject], [unit], [img_content], [content], [answer_a], [answer_b], [answer_c], [answer_d], [correct_answer], [timestamps]) VALUES (1060, 1, 3, N'noimage.jpg', N'What is CORS in the context of ASP.NET Core Web API?', N'Cross-Origin Resource Sharing, a mechanism that allows resources to be requested from another domain.', N'A security measure to prevent CSRF attacks.', N'A caching mechanism for HTTP responses.', N'A protocol for encrypting data in transit.', N'Cross-Origin Resource Sharing, a mechanism that allows resources to be requested from another domain.', CAST(N'2024-03-24T18:10:21.963' AS DateTime))
INSERT [dbo].[questions] ([id_question], [id_subject], [unit], [img_content], [content], [answer_a], [answer_b], [answer_c], [answer_d], [correct_answer], [timestamps]) VALUES (1061, 1, 3, N'noimage.jpg', N'Which package provides middleware for handling CORS in ASP.NET Core Web API?', N'Microsoft.AspNetCore.Mvc', N'Microsoft.AspNetCore.Http', N'Microsoft.AspNetCore.Cors', N'Microsoft.AspNetCore.Authentication', N'Microsoft.AspNetCore.Cors', CAST(N'2024-03-24T18:10:21.963' AS DateTime))
INSERT [dbo].[questions] ([id_question], [id_subject], [unit], [img_content], [content], [answer_a], [answer_b], [answer_c], [answer_d], [correct_answer], [timestamps]) VALUES (1062, 1, 3, N'noimage.jpg', N'What is the purpose of the [Route] attribute in ASP.NET Core Web API?', N'To specify the route template for the controller or action method.', N'To define the authentication scheme for the controller.', N'To indicate that the controller is an API controller.', N'To specify the HTTP method for the controller action.', N'To specify the route template for the controller or action method.', CAST(N'2024-03-24T18:10:21.963' AS DateTime))
SET IDENTITY_INSERT [dbo].[questions] OFF
GO
SET IDENTITY_INSERT [dbo].[quests_of_test] ON 

INSERT [dbo].[quests_of_test] ([ID], [test_code], [id_question], [timestamps]) VALUES (1021, 274659, 1053, CAST(N'2024-03-24T18:12:13.060' AS DateTime))
INSERT [dbo].[quests_of_test] ([ID], [test_code], [id_question], [timestamps]) VALUES (1023, 274659, 1054, CAST(N'2024-03-24T18:12:24.420' AS DateTime))
INSERT [dbo].[quests_of_test] ([ID], [test_code], [id_question], [timestamps]) VALUES (1024, 274659, 1055, CAST(N'2024-03-24T18:12:31.917' AS DateTime))
INSERT [dbo].[quests_of_test] ([ID], [test_code], [id_question], [timestamps]) VALUES (1025, 274659, 1056, CAST(N'2024-03-24T18:12:36.100' AS DateTime))
INSERT [dbo].[quests_of_test] ([ID], [test_code], [id_question], [timestamps]) VALUES (1026, 274659, 1057, CAST(N'2024-03-24T18:12:40.227' AS DateTime))
INSERT [dbo].[quests_of_test] ([ID], [test_code], [id_question], [timestamps]) VALUES (1027, 274659, 1058, CAST(N'2024-03-24T18:12:47.003' AS DateTime))
INSERT [dbo].[quests_of_test] ([ID], [test_code], [id_question], [timestamps]) VALUES (1028, 274659, 1059, CAST(N'2024-03-24T18:12:51.960' AS DateTime))
INSERT [dbo].[quests_of_test] ([ID], [test_code], [id_question], [timestamps]) VALUES (1029, 274659, 1060, CAST(N'2024-03-24T18:12:56.450' AS DateTime))
INSERT [dbo].[quests_of_test] ([ID], [test_code], [id_question], [timestamps]) VALUES (1030, 274659, 1061, CAST(N'2024-03-24T18:13:04.173' AS DateTime))
INSERT [dbo].[quests_of_test] ([ID], [test_code], [id_question], [timestamps]) VALUES (1031, 274659, 1062, CAST(N'2024-03-24T18:13:08.047' AS DateTime))
INSERT [dbo].[quests_of_test] ([ID], [test_code], [id_question], [timestamps]) VALUES (1032, 984652, 1053, NULL)
INSERT [dbo].[quests_of_test] ([ID], [test_code], [id_question], [timestamps]) VALUES (1033, 984652, 1055, NULL)
INSERT [dbo].[quests_of_test] ([ID], [test_code], [id_question], [timestamps]) VALUES (1034, 984652, 1057, NULL)
INSERT [dbo].[quests_of_test] ([ID], [test_code], [id_question], [timestamps]) VALUES (1035, 984652, 1058, NULL)
INSERT [dbo].[quests_of_test] ([ID], [test_code], [id_question], [timestamps]) VALUES (1036, 984652, 1056, NULL)
INSERT [dbo].[quests_of_test] ([ID], [test_code], [id_question], [timestamps]) VALUES (1037, 984652, 1054, NULL)
INSERT [dbo].[quests_of_test] ([ID], [test_code], [id_question], [timestamps]) VALUES (1038, 984652, 1059, NULL)
INSERT [dbo].[quests_of_test] ([ID], [test_code], [id_question], [timestamps]) VALUES (1039, 984652, 1061, NULL)
INSERT [dbo].[quests_of_test] ([ID], [test_code], [id_question], [timestamps]) VALUES (1040, 984652, 1062, NULL)
INSERT [dbo].[quests_of_test] ([ID], [test_code], [id_question], [timestamps]) VALUES (1041, 984652, 1060, NULL)
SET IDENTITY_INSERT [dbo].[quests_of_test] OFF
GO
SET IDENTITY_INSERT [dbo].[scores] ON 

INSERT [dbo].[scores] ([id_score], [id_student], [test_code], [score_number], [detail], [time_finish]) VALUES (1002, 1003, 274659, 7, N'7/10                                              ', CAST(N'2024-03-24T18:16:16.590' AS DateTime))
INSERT [dbo].[scores] ([id_score], [id_student], [test_code], [score_number], [detail], [time_finish]) VALUES (1003, 1004, 274659, 4, N'4/10                                              ', CAST(N'2024-03-24T18:16:51.770' AS DateTime))
INSERT [dbo].[scores] ([id_score], [id_student], [test_code], [score_number], [detail], [time_finish]) VALUES (1004, 1005, 274659, 3, N'3/10                                              ', CAST(N'2024-03-24T18:17:18.043' AS DateTime))
INSERT [dbo].[scores] ([id_score], [id_student], [test_code], [score_number], [detail], [time_finish]) VALUES (1005, 1006, 274659, 6, N'6/10                                              ', CAST(N'2024-03-24T18:18:08.967' AS DateTime))
INSERT [dbo].[scores] ([id_score], [id_student], [test_code], [score_number], [detail], [time_finish]) VALUES (1006, 1007, 274659, 7, N'7/10                                              ', CAST(N'2024-03-24T18:19:56.577' AS DateTime))
INSERT [dbo].[scores] ([id_score], [id_student], [test_code], [score_number], [detail], [time_finish]) VALUES (1007, 1008, 274659, 10, N'10/10                                             ', CAST(N'2024-03-24T18:22:35.403' AS DateTime))
INSERT [dbo].[scores] ([id_score], [id_student], [test_code], [score_number], [detail], [time_finish]) VALUES (1008, 1009, 274659, 9, N'9/10                                              ', CAST(N'2024-03-24T18:23:03.483' AS DateTime))
INSERT [dbo].[scores] ([id_score], [id_student], [test_code], [score_number], [detail], [time_finish]) VALUES (1009, 1010, 274659, 8, N'8/10                                              ', CAST(N'2024-03-24T18:23:46.520' AS DateTime))
INSERT [dbo].[scores] ([id_score], [id_student], [test_code], [score_number], [detail], [time_finish]) VALUES (1010, 1011, 274659, 8, N'8/10                                              ', CAST(N'2024-03-24T18:24:32.413' AS DateTime))
INSERT [dbo].[scores] ([id_score], [id_student], [test_code], [score_number], [detail], [time_finish]) VALUES (1011, 1012, 274659, 1, N'1/10                                              ', CAST(N'2024-03-24T18:24:57.577' AS DateTime))
SET IDENTITY_INSERT [dbo].[scores] OFF
GO
SET IDENTITY_INSERT [dbo].[specialities] ON 

INSERT [dbo].[specialities] ([id_speciality], [speciality_name], [timestamps]) VALUES (1, N'Software Engineering', NULL)
INSERT [dbo].[specialities] ([id_speciality], [speciality_name], [timestamps]) VALUES (2, N'Graphic Design', NULL)
INSERT [dbo].[specialities] ([id_speciality], [speciality_name], [timestamps]) VALUES (3, N'Bussiness Adminstration', NULL)
SET IDENTITY_INSERT [dbo].[specialities] OFF
GO
SET IDENTITY_INSERT [dbo].[statuses] ON 

INSERT [dbo].[statuses] ([id_status], [status_name], [timestamps]) VALUES (1, N'Mở', CAST(N'2024-03-23T03:49:28.880' AS DateTime))
INSERT [dbo].[statuses] ([id_status], [status_name], [timestamps]) VALUES (2, N'Đóng', CAST(N'2024-03-23T03:49:33.280' AS DateTime))
SET IDENTITY_INSERT [dbo].[statuses] OFF
GO
SET IDENTITY_INSERT [dbo].[student_test_detail] ON 

INSERT [dbo].[student_test_detail] ([ID], [id_student], [test_code], [id_question], [answer_a], [answer_b], [answer_c], [answer_d], [student_answer], [timestamps]) VALUES (1030, 1003, 274659, 1053, N'It is a framework for building HTTP services.', N'It is a front-end development framework.', N'It is a database management system.', N'It is a programming language.', N'It is a framework for building HTTP services.', NULL)
INSERT [dbo].[student_test_detail] ([ID], [id_student], [test_code], [id_question], [answer_a], [answer_b], [answer_c], [answer_d], [student_answer], [timestamps]) VALUES (1028, 1003, 274659, 1054, N'DELETE', N'PUT', N'GET', N'POST', N'DELETE', NULL)
INSERT [dbo].[student_test_detail] ([ID], [id_student], [test_code], [id_question], [answer_a], [answer_b], [answer_c], [answer_d], [student_answer], [timestamps]) VALUES (1021, 1003, 274659, 1055, N'Server-side rendering', N'Dependency injection', N'Automatic model binding', N'Content negotiation', N'Server-side rendering', NULL)
INSERT [dbo].[student_test_detail] ([ID], [id_student], [test_code], [id_question], [answer_a], [answer_b], [answer_c], [answer_d], [student_answer], [timestamps]) VALUES (1027, 1003, 274659, 1056, N'JSON', N'HTML', N'XML', N'YAML', N'JSON', NULL)
INSERT [dbo].[student_test_detail] ([ID], [id_student], [test_code], [id_question], [answer_a], [answer_b], [answer_c], [answer_d], [student_answer], [timestamps]) VALUES (1026, 1003, 274659, 1057, N'To authenticate users.', N'To execute background tasks.', N'To manage database connections.', N'To define how HTTP requests are mapped to action methods.', N'To define how HTTP requests are mapped to action methods.', NULL)
INSERT [dbo].[student_test_detail] ([ID], [id_student], [test_code], [id_question], [answer_a], [answer_b], [answer_c], [answer_d], [student_answer], [timestamps]) VALUES (1024, 1003, 274659, 1058, N'To specify the route template for the controller.', N'To specify the HTTP method for the controller action.', N'To indicate that the controller is an API controller and thus automatically applies binding source parameters from the request body and other sources.', N'To define the authentication scheme for the controller.', N'To specify the route template for the controller.', NULL)
INSERT [dbo].[student_test_detail] ([ID], [id_student], [test_code], [id_question], [answer_a], [answer_b], [answer_c], [answer_d], [student_answer], [timestamps]) VALUES (1029, 1003, 274659, 1059, N'200 OK', N'500 Internal Server Error', N'401 Unauthorized', N'404 Not Found', N'200 OK', NULL)
INSERT [dbo].[student_test_detail] ([ID], [id_student], [test_code], [id_question], [answer_a], [answer_b], [answer_c], [answer_d], [student_answer], [timestamps]) VALUES (1022, 1003, 274659, 1060, N'A caching mechanism for HTTP responses.', N'A security measure to prevent CSRF attacks.', N'Cross-Origin Resource Sharing, a mechanism that allows resources to be requested from another domain.', N'A protocol for encrypting data in transit.', N'A security measure to prevent CSRF attacks.', NULL)
INSERT [dbo].[student_test_detail] ([ID], [id_student], [test_code], [id_question], [answer_a], [answer_b], [answer_c], [answer_d], [student_answer], [timestamps]) VALUES (1023, 1003, 274659, 1061, N'Microsoft.AspNetCore.Mvc', N'Microsoft.AspNetCore.Authentication', N'Microsoft.AspNetCore.Cors', N'Microsoft.AspNetCore.Http', N'Microsoft.AspNetCore.Cors', NULL)
INSERT [dbo].[student_test_detail] ([ID], [id_student], [test_code], [id_question], [answer_a], [answer_b], [answer_c], [answer_d], [student_answer], [timestamps]) VALUES (1025, 1003, 274659, 1062, N'To specify the route template for the controller or action method.', N'To define the authentication scheme for the controller.', N'To indicate that the controller is an API controller.', N'To specify the HTTP method for the controller action.', N'To specify the route template for the controller or action method.', NULL)
INSERT [dbo].[student_test_detail] ([ID], [id_student], [test_code], [id_question], [answer_a], [answer_b], [answer_c], [answer_d], [student_answer], [timestamps]) VALUES (1128, 1003, 984652, 1053, N'It is a programming language.', N'It is a front-end development framework.', N'It is a framework for building HTTP services.', N'It is a database management system.', N'It is a framework for building HTTP services.', NULL)
INSERT [dbo].[student_test_detail] ([ID], [id_student], [test_code], [id_question], [answer_a], [answer_b], [answer_c], [answer_d], [student_answer], [timestamps]) VALUES (1123, 1003, 984652, 1054, N'PUT', N'GET', N'POST', N'DELETE', N'POST', NULL)
INSERT [dbo].[student_test_detail] ([ID], [id_student], [test_code], [id_question], [answer_a], [answer_b], [answer_c], [answer_d], [student_answer], [timestamps]) VALUES (1126, 1003, 984652, 1055, N'Automatic model binding', N'Dependency injection', N'Content negotiation', N'Server-side rendering', N'Automatic model binding', NULL)
INSERT [dbo].[student_test_detail] ([ID], [id_student], [test_code], [id_question], [answer_a], [answer_b], [answer_c], [answer_d], [student_answer], [timestamps]) VALUES (1129, 1003, 984652, 1056, N'JSON', N'XML', N'YAML', N'HTML', N'XML', NULL)
INSERT [dbo].[student_test_detail] ([ID], [id_student], [test_code], [id_question], [answer_a], [answer_b], [answer_c], [answer_d], [student_answer], [timestamps]) VALUES (1125, 1003, 984652, 1057, N'To define how HTTP requests are mapped to action methods.', N'To manage database connections.', N'To authenticate users.', N'To execute background tasks.', N'To manage database connections.', NULL)
INSERT [dbo].[student_test_detail] ([ID], [id_student], [test_code], [id_question], [answer_a], [answer_b], [answer_c], [answer_d], [student_answer], [timestamps]) VALUES (1124, 1003, 984652, 1058, N'To define the authentication scheme for the controller.', N'To specify the HTTP method for the controller action.', N'To indicate that the controller is an API controller and thus automatically applies binding source parameters from the request body and other sources.', N'To specify the route template for the controller.', N'To define the authentication scheme for the controller.', NULL)
INSERT [dbo].[student_test_detail] ([ID], [id_student], [test_code], [id_question], [answer_a], [answer_b], [answer_c], [answer_d], [student_answer], [timestamps]) VALUES (1127, 1003, 984652, 1059, N'500 Internal Server Error', N'404 Not Found', N'401 Unauthorized', N'200 OK', N'500 Internal Server Error', NULL)
INSERT [dbo].[student_test_detail] ([ID], [id_student], [test_code], [id_question], [answer_a], [answer_b], [answer_c], [answer_d], [student_answer], [timestamps]) VALUES (1130, 1003, 984652, 1060, N'A protocol for encrypting data in transit.', N'A caching mechanism for HTTP responses.', N'Cross-Origin Resource Sharing, a mechanism that allows resources to be requested from another domain.', N'A security measure to prevent CSRF attacks.', N'A protocol for encrypting data in transit.', NULL)
INSERT [dbo].[student_test_detail] ([ID], [id_student], [test_code], [id_question], [answer_a], [answer_b], [answer_c], [answer_d], [student_answer], [timestamps]) VALUES (1121, 1003, 984652, 1061, N'Microsoft.AspNetCore.Http', N'Microsoft.AspNetCore.Authentication', N'Microsoft.AspNetCore.Cors', N'Microsoft.AspNetCore.Mvc', N'Microsoft.AspNetCore.Authentication', NULL)
INSERT [dbo].[student_test_detail] ([ID], [id_student], [test_code], [id_question], [answer_a], [answer_b], [answer_c], [answer_d], [student_answer], [timestamps]) VALUES (1122, 1003, 984652, 1062, N'To define the authentication scheme for the controller.', N'To indicate that the controller is an API controller.', N'To specify the route template for the controller or action method.', N'To specify the HTTP method for the controller action.', N'To indicate that the controller is an API controller.', NULL)
INSERT [dbo].[student_test_detail] ([ID], [id_student], [test_code], [id_question], [answer_a], [answer_b], [answer_c], [answer_d], [student_answer], [timestamps]) VALUES (1036, 1004, 274659, 1053, N'It is a database management system.', N'It is a programming language.', N'It is a front-end development framework.', N'It is a framework for building HTTP services.', N'It is a framework for building HTTP services.', NULL)
INSERT [dbo].[student_test_detail] ([ID], [id_student], [test_code], [id_question], [answer_a], [answer_b], [answer_c], [answer_d], [student_answer], [timestamps]) VALUES (1031, 1004, 274659, 1054, N'PUT', N'DELETE', N'GET', N'POST', N'GET', NULL)
INSERT [dbo].[student_test_detail] ([ID], [id_student], [test_code], [id_question], [answer_a], [answer_b], [answer_c], [answer_d], [student_answer], [timestamps]) VALUES (1032, 1004, 274659, 1055, N'Automatic model binding', N'Dependency injection', N'Server-side rendering', N'Content negotiation', N'Automatic model binding', NULL)
INSERT [dbo].[student_test_detail] ([ID], [id_student], [test_code], [id_question], [answer_a], [answer_b], [answer_c], [answer_d], [student_answer], [timestamps]) VALUES (1035, 1004, 274659, 1056, N'YAML', N'JSON', N'HTML', N'XML', N'JSON', NULL)
INSERT [dbo].[student_test_detail] ([ID], [id_student], [test_code], [id_question], [answer_a], [answer_b], [answer_c], [answer_d], [student_answer], [timestamps]) VALUES (1034, 1004, 274659, 1057, N'To authenticate users.', N'To execute background tasks.', N'To manage database connections.', N'To define how HTTP requests are mapped to action methods.', N'To authenticate users.', NULL)
INSERT [dbo].[student_test_detail] ([ID], [id_student], [test_code], [id_question], [answer_a], [answer_b], [answer_c], [answer_d], [student_answer], [timestamps]) VALUES (1033, 1004, 274659, 1058, N'To indicate that the controller is an API controller and thus automatically applies binding source parameters from the request body and other sources.', N'To define the authentication scheme for the controller.', N'To specify the route template for the controller.', N'To specify the HTTP method for the controller action.', N'To define the authentication scheme for the controller.', NULL)
INSERT [dbo].[student_test_detail] ([ID], [id_student], [test_code], [id_question], [answer_a], [answer_b], [answer_c], [answer_d], [student_answer], [timestamps]) VALUES (1039, 1004, 274659, 1059, N'200 OK', N'500 Internal Server Error', N'404 Not Found', N'401 Unauthorized', N'200 OK', NULL)
INSERT [dbo].[student_test_detail] ([ID], [id_student], [test_code], [id_question], [answer_a], [answer_b], [answer_c], [answer_d], [student_answer], [timestamps]) VALUES (1037, 1004, 274659, 1060, N'A caching mechanism for HTTP responses.', N'A security measure to prevent CSRF attacks.', N'Cross-Origin Resource Sharing, a mechanism that allows resources to be requested from another domain.', N'A protocol for encrypting data in transit.', N'A security measure to prevent CSRF attacks.', NULL)
INSERT [dbo].[student_test_detail] ([ID], [id_student], [test_code], [id_question], [answer_a], [answer_b], [answer_c], [answer_d], [student_answer], [timestamps]) VALUES (1038, 1004, 274659, 1061, N'Microsoft.AspNetCore.Mvc', N'Microsoft.AspNetCore.Http', N'Microsoft.AspNetCore.Cors', N'Microsoft.AspNetCore.Authentication', N'Microsoft.AspNetCore.Authentication', NULL)
INSERT [dbo].[student_test_detail] ([ID], [id_student], [test_code], [id_question], [answer_a], [answer_b], [answer_c], [answer_d], [student_answer], [timestamps]) VALUES (1040, 1004, 274659, 1062, N'To define the authentication scheme for the controller.', N'To specify the route template for the controller or action method.', N'To indicate that the controller is an API controller.', N'To specify the HTTP method for the controller action.', N'To define the authentication scheme for the controller.', NULL)
INSERT [dbo].[student_test_detail] ([ID], [id_student], [test_code], [id_question], [answer_a], [answer_b], [answer_c], [answer_d], [student_answer], [timestamps]) VALUES (1046, 1005, 274659, 1053, N'It is a framework for building HTTP services.', N'It is a programming language.', N'It is a front-end development framework.', N'It is a database management system.', N'It is a framework for building HTTP services.', NULL)
INSERT [dbo].[student_test_detail] ([ID], [id_student], [test_code], [id_question], [answer_a], [answer_b], [answer_c], [answer_d], [student_answer], [timestamps]) VALUES (1043, 1005, 274659, 1054, N'DELETE', N'PUT', N'GET', N'POST', N'DELETE', NULL)
INSERT [dbo].[student_test_detail] ([ID], [id_student], [test_code], [id_question], [answer_a], [answer_b], [answer_c], [answer_d], [student_answer], [timestamps]) VALUES (1044, 1005, 274659, 1055, N'Content negotiation', N'Dependency injection', N'Automatic model binding', N'Server-side rendering', N'Content negotiation', NULL)
INSERT [dbo].[student_test_detail] ([ID], [id_student], [test_code], [id_question], [answer_a], [answer_b], [answer_c], [answer_d], [student_answer], [timestamps]) VALUES (1047, 1005, 274659, 1056, N'HTML', N'JSON', N'YAML', N'XML', N'HTML', NULL)
INSERT [dbo].[student_test_detail] ([ID], [id_student], [test_code], [id_question], [answer_a], [answer_b], [answer_c], [answer_d], [student_answer], [timestamps]) VALUES (1049, 1005, 274659, 1057, N'To define how HTTP requests are mapped to action methods.', N'To manage database connections.', N'To authenticate users.', N'To execute background tasks.', N'To define how HTTP requests are mapped to action methods.', NULL)
INSERT [dbo].[student_test_detail] ([ID], [id_student], [test_code], [id_question], [answer_a], [answer_b], [answer_c], [answer_d], [student_answer], [timestamps]) VALUES (1045, 1005, 274659, 1058, N'To specify the route template for the controller.', N'To indicate that the controller is an API controller and thus automatically applies binding source parameters from the request body and other sources.', N'To define the authentication scheme for the controller.', N'To specify the HTTP method for the controller action.', N'To specify the route template for the controller.', NULL)
INSERT [dbo].[student_test_detail] ([ID], [id_student], [test_code], [id_question], [answer_a], [answer_b], [answer_c], [answer_d], [student_answer], [timestamps]) VALUES (1050, 1005, 274659, 1059, N'404 Not Found', N'200 OK', N'401 Unauthorized', N'500 Internal Server Error', N'404 Not Found', NULL)
INSERT [dbo].[student_test_detail] ([ID], [id_student], [test_code], [id_question], [answer_a], [answer_b], [answer_c], [answer_d], [student_answer], [timestamps]) VALUES (1042, 1005, 274659, 1060, N'A security measure to prevent CSRF attacks.', N'Cross-Origin Resource Sharing, a mechanism that allows resources to be requested from another domain.', N'A caching mechanism for HTTP responses.', N'A protocol for encrypting data in transit.', N'A security measure to prevent CSRF attacks.', NULL)
INSERT [dbo].[student_test_detail] ([ID], [id_student], [test_code], [id_question], [answer_a], [answer_b], [answer_c], [answer_d], [student_answer], [timestamps]) VALUES (1048, 1005, 274659, 1061, N'Microsoft.AspNetCore.Authentication', N'Microsoft.AspNetCore.Http', N'Microsoft.AspNetCore.Cors', N'Microsoft.AspNetCore.Mvc', N'Microsoft.AspNetCore.Authentication', NULL)
INSERT [dbo].[student_test_detail] ([ID], [id_student], [test_code], [id_question], [answer_a], [answer_b], [answer_c], [answer_d], [student_answer], [timestamps]) VALUES (1041, 1005, 274659, 1062, N'To specify the route template for the controller or action method.', N'To specify the HTTP method for the controller action.', N'To indicate that the controller is an API controller.', N'To define the authentication scheme for the controller.', N'To specify the route template for the controller or action method.', NULL)
INSERT [dbo].[student_test_detail] ([ID], [id_student], [test_code], [id_question], [answer_a], [answer_b], [answer_c], [answer_d], [student_answer], [timestamps]) VALUES (1059, 1006, 274659, 1053, N'It is a programming language.', N'It is a framework for building HTTP services.', N'It is a front-end development framework.', N'It is a database management system.', N'It is a framework for building HTTP services.', NULL)
INSERT [dbo].[student_test_detail] ([ID], [id_student], [test_code], [id_question], [answer_a], [answer_b], [answer_c], [answer_d], [student_answer], [timestamps]) VALUES (1060, 1006, 274659, 1054, N'PUT', N'POST', N'GET', N'DELETE', N'GET', NULL)
INSERT [dbo].[student_test_detail] ([ID], [id_student], [test_code], [id_question], [answer_a], [answer_b], [answer_c], [answer_d], [student_answer], [timestamps]) VALUES (1056, 1006, 274659, 1055, N'Dependency injection', N'Automatic model binding', N'Content negotiation', N'Server-side rendering', N'Content negotiation', NULL)
INSERT [dbo].[student_test_detail] ([ID], [id_student], [test_code], [id_question], [answer_a], [answer_b], [answer_c], [answer_d], [student_answer], [timestamps]) VALUES (1052, 1006, 274659, 1056, N'XML', N'HTML', N'JSON', N'YAML', N'JSON', NULL)
INSERT [dbo].[student_test_detail] ([ID], [id_student], [test_code], [id_question], [answer_a], [answer_b], [answer_c], [answer_d], [student_answer], [timestamps]) VALUES (1053, 1006, 274659, 1057, N'To manage database connections.', N'To execute background tasks.', N'To authenticate users.', N'To define how HTTP requests are mapped to action methods.', N'To manage database connections.', NULL)
INSERT [dbo].[student_test_detail] ([ID], [id_student], [test_code], [id_question], [answer_a], [answer_b], [answer_c], [answer_d], [student_answer], [timestamps]) VALUES (1054, 1006, 274659, 1058, N'To specify the HTTP method for the controller action.', N'To define the authentication scheme for the controller.', N'To indicate that the controller is an API controller and thus automatically applies binding source parameters from the request body and other sources.', N'To specify the route template for the controller.', N'To indicate that the controller is an API controller and thus automatically applies binding source parameters from the request body and other sources.', NULL)
INSERT [dbo].[student_test_detail] ([ID], [id_student], [test_code], [id_question], [answer_a], [answer_b], [answer_c], [answer_d], [student_answer], [timestamps]) VALUES (1058, 1006, 274659, 1059, N'401 Unauthorized', N'200 OK', N'500 Internal Server Error', N'404 Not Found', N'200 OK', NULL)
INSERT [dbo].[student_test_detail] ([ID], [id_student], [test_code], [id_question], [answer_a], [answer_b], [answer_c], [answer_d], [student_answer], [timestamps]) VALUES (1055, 1006, 274659, 1060, N'Cross-Origin Resource Sharing, a mechanism that allows resources to be requested from another domain.', N'A caching mechanism for HTTP responses.', N'A protocol for encrypting data in transit.', N'A security measure to prevent CSRF attacks.', N'A protocol for encrypting data in transit.', NULL)
INSERT [dbo].[student_test_detail] ([ID], [id_student], [test_code], [id_question], [answer_a], [answer_b], [answer_c], [answer_d], [student_answer], [timestamps]) VALUES (1051, 1006, 274659, 1061, N'Microsoft.AspNetCore.Mvc', N'Microsoft.AspNetCore.Authentication', N'Microsoft.AspNetCore.Cors', N'Microsoft.AspNetCore.Http', N'Microsoft.AspNetCore.Cors', NULL)
INSERT [dbo].[student_test_detail] ([ID], [id_student], [test_code], [id_question], [answer_a], [answer_b], [answer_c], [answer_d], [student_answer], [timestamps]) VALUES (1057, 1006, 274659, 1062, N'To specify the route template for the controller or action method.', N'To indicate that the controller is an API controller.', N'To specify the HTTP method for the controller action.', N'To define the authentication scheme for the controller.', N'To specify the HTTP method for the controller action.', NULL)
INSERT [dbo].[student_test_detail] ([ID], [id_student], [test_code], [id_question], [answer_a], [answer_b], [answer_c], [answer_d], [student_answer], [timestamps]) VALUES (1061, 1007, 274659, 1053, N'It is a front-end development framework.', N'It is a framework for building HTTP services.', N'It is a database management system.', N'It is a programming language.', N'It is a framework for building HTTP services.', NULL)
INSERT [dbo].[student_test_detail] ([ID], [id_student], [test_code], [id_question], [answer_a], [answer_b], [answer_c], [answer_d], [student_answer], [timestamps]) VALUES (1067, 1007, 274659, 1054, N'DELETE', N'PUT', N'GET', N'POST', N'GET', NULL)
INSERT [dbo].[student_test_detail] ([ID], [id_student], [test_code], [id_question], [answer_a], [answer_b], [answer_c], [answer_d], [student_answer], [timestamps]) VALUES (1065, 1007, 274659, 1055, N'Automatic model binding', N'Server-side rendering', N'Content negotiation', N'Dependency injection', N'Automatic model binding', NULL)
INSERT [dbo].[student_test_detail] ([ID], [id_student], [test_code], [id_question], [answer_a], [answer_b], [answer_c], [answer_d], [student_answer], [timestamps]) VALUES (1068, 1007, 274659, 1056, N'HTML', N'JSON', N'XML', N'YAML', N'JSON', NULL)
INSERT [dbo].[student_test_detail] ([ID], [id_student], [test_code], [id_question], [answer_a], [answer_b], [answer_c], [answer_d], [student_answer], [timestamps]) VALUES (1062, 1007, 274659, 1057, N'To authenticate users.', N'To execute background tasks.', N'To manage database connections.', N'To define how HTTP requests are mapped to action methods.', N'To define how HTTP requests are mapped to action methods.', NULL)
INSERT [dbo].[student_test_detail] ([ID], [id_student], [test_code], [id_question], [answer_a], [answer_b], [answer_c], [answer_d], [student_answer], [timestamps]) VALUES (1063, 1007, 274659, 1058, N'To specify the route template for the controller.', N'To indicate that the controller is an API controller and thus automatically applies binding source parameters from the request body and other sources.', N'To specify the HTTP method for the controller action.', N'To define the authentication scheme for the controller.', N'To specify the HTTP method for the controller action.', NULL)
INSERT [dbo].[student_test_detail] ([ID], [id_student], [test_code], [id_question], [answer_a], [answer_b], [answer_c], [answer_d], [student_answer], [timestamps]) VALUES (1064, 1007, 274659, 1059, N'404 Not Found', N'200 OK', N'401 Unauthorized', N'500 Internal Server Error', N'200 OK', NULL)
INSERT [dbo].[student_test_detail] ([ID], [id_student], [test_code], [id_question], [answer_a], [answer_b], [answer_c], [answer_d], [student_answer], [timestamps]) VALUES (1069, 1007, 274659, 1060, N'A caching mechanism for HTTP responses.', N'A protocol for encrypting data in transit.', N'A security measure to prevent CSRF attacks.', N'Cross-Origin Resource Sharing, a mechanism that allows resources to be requested from another domain.', N'Cross-Origin Resource Sharing, a mechanism that allows resources to be requested from another domain.', NULL)
INSERT [dbo].[student_test_detail] ([ID], [id_student], [test_code], [id_question], [answer_a], [answer_b], [answer_c], [answer_d], [student_answer], [timestamps]) VALUES (1066, 1007, 274659, 1061, N'Microsoft.AspNetCore.Cors', N'Microsoft.AspNetCore.Http', N'Microsoft.AspNetCore.Authentication', N'Microsoft.AspNetCore.Mvc', N'Microsoft.AspNetCore.Cors', NULL)
INSERT [dbo].[student_test_detail] ([ID], [id_student], [test_code], [id_question], [answer_a], [answer_b], [answer_c], [answer_d], [student_answer], [timestamps]) VALUES (1070, 1007, 274659, 1062, N'To define the authentication scheme for the controller.', N'To specify the route template for the controller or action method.', N'To specify the HTTP method for the controller action.', N'To indicate that the controller is an API controller.', N'To specify the HTTP method for the controller action.', NULL)
INSERT [dbo].[student_test_detail] ([ID], [id_student], [test_code], [id_question], [answer_a], [answer_b], [answer_c], [answer_d], [student_answer], [timestamps]) VALUES (1072, 1008, 274659, 1053, N'It is a framework for building HTTP services.', N'It is a database management system.', N'It is a front-end development framework.', N'It is a programming language.', N'It is a framework for building HTTP services.', NULL)
INSERT [dbo].[student_test_detail] ([ID], [id_student], [test_code], [id_question], [answer_a], [answer_b], [answer_c], [answer_d], [student_answer], [timestamps]) VALUES (1075, 1008, 274659, 1054, N'DELETE', N'PUT', N'GET', N'POST', N'GET', NULL)
INSERT [dbo].[student_test_detail] ([ID], [id_student], [test_code], [id_question], [answer_a], [answer_b], [answer_c], [answer_d], [student_answer], [timestamps]) VALUES (1073, 1008, 274659, 1055, N'Server-side rendering', N'Dependency injection', N'Automatic model binding', N'Content negotiation', N'Server-side rendering', NULL)
INSERT [dbo].[student_test_detail] ([ID], [id_student], [test_code], [id_question], [answer_a], [answer_b], [answer_c], [answer_d], [student_answer], [timestamps]) VALUES (1080, 1008, 274659, 1056, N'XML', N'HTML', N'JSON', N'YAML', N'JSON', NULL)
INSERT [dbo].[student_test_detail] ([ID], [id_student], [test_code], [id_question], [answer_a], [answer_b], [answer_c], [answer_d], [student_answer], [timestamps]) VALUES (1076, 1008, 274659, 1057, N'To execute background tasks.', N'To manage database connections.', N'To define how HTTP requests are mapped to action methods.', N'To authenticate users.', N'To define how HTTP requests are mapped to action methods.', NULL)
INSERT [dbo].[student_test_detail] ([ID], [id_student], [test_code], [id_question], [answer_a], [answer_b], [answer_c], [answer_d], [student_answer], [timestamps]) VALUES (1078, 1008, 274659, 1058, N'To specify the HTTP method for the controller action.', N'To indicate that the controller is an API controller and thus automatically applies binding source parameters from the request body and other sources.', N'To define the authentication scheme for the controller.', N'To specify the route template for the controller.', N'To indicate that the controller is an API controller and thus automatically applies binding source parameters from the request body and other sources.', NULL)
INSERT [dbo].[student_test_detail] ([ID], [id_student], [test_code], [id_question], [answer_a], [answer_b], [answer_c], [answer_d], [student_answer], [timestamps]) VALUES (1074, 1008, 274659, 1059, N'500 Internal Server Error', N'404 Not Found', N'200 OK', N'401 Unauthorized', N'200 OK', NULL)
INSERT [dbo].[student_test_detail] ([ID], [id_student], [test_code], [id_question], [answer_a], [answer_b], [answer_c], [answer_d], [student_answer], [timestamps]) VALUES (1079, 1008, 274659, 1060, N'A protocol for encrypting data in transit.', N'Cross-Origin Resource Sharing, a mechanism that allows resources to be requested from another domain.', N'A security measure to prevent CSRF attacks.', N'A caching mechanism for HTTP responses.', N'Cross-Origin Resource Sharing, a mechanism that allows resources to be requested from another domain.', NULL)
INSERT [dbo].[student_test_detail] ([ID], [id_student], [test_code], [id_question], [answer_a], [answer_b], [answer_c], [answer_d], [student_answer], [timestamps]) VALUES (1077, 1008, 274659, 1061, N'Microsoft.AspNetCore.Mvc', N'Microsoft.AspNetCore.Http', N'Microsoft.AspNetCore.Authentication', N'Microsoft.AspNetCore.Cors', N'Microsoft.AspNetCore.Cors', NULL)
INSERT [dbo].[student_test_detail] ([ID], [id_student], [test_code], [id_question], [answer_a], [answer_b], [answer_c], [answer_d], [student_answer], [timestamps]) VALUES (1071, 1008, 274659, 1062, N'To indicate that the controller is an API controller.', N'To specify the route template for the controller or action method.', N'To define the authentication scheme for the controller.', N'To specify the HTTP method for the controller action.', N'To specify the route template for the controller or action method.', NULL)
INSERT [dbo].[student_test_detail] ([ID], [id_student], [test_code], [id_question], [answer_a], [answer_b], [answer_c], [answer_d], [student_answer], [timestamps]) VALUES (1088, 1009, 274659, 1053, N'It is a programming language.', N'It is a framework for building HTTP services.', N'It is a database management system.', N'It is a front-end development framework.', N'It is a framework for building HTTP services.', NULL)
INSERT [dbo].[student_test_detail] ([ID], [id_student], [test_code], [id_question], [answer_a], [answer_b], [answer_c], [answer_d], [student_answer], [timestamps]) VALUES (1087, 1009, 274659, 1054, N'DELETE', N'PUT', N'GET', N'POST', N'GET', NULL)
INSERT [dbo].[student_test_detail] ([ID], [id_student], [test_code], [id_question], [answer_a], [answer_b], [answer_c], [answer_d], [student_answer], [timestamps]) VALUES (1082, 1009, 274659, 1055, N'Server-side rendering', N'Automatic model binding', N'Content negotiation', N'Dependency injection', N'Server-side rendering', NULL)
INSERT [dbo].[student_test_detail] ([ID], [id_student], [test_code], [id_question], [answer_a], [answer_b], [answer_c], [answer_d], [student_answer], [timestamps]) VALUES (1086, 1009, 274659, 1056, N'JSON', N'YAML', N'XML', N'HTML', N'JSON', NULL)
INSERT [dbo].[student_test_detail] ([ID], [id_student], [test_code], [id_question], [answer_a], [answer_b], [answer_c], [answer_d], [student_answer], [timestamps]) VALUES (1089, 1009, 274659, 1057, N'To execute background tasks.', N'To define how HTTP requests are mapped to action methods.', N'To manage database connections.', N'To authenticate users.', N'To define how HTTP requests are mapped to action methods.', NULL)
INSERT [dbo].[student_test_detail] ([ID], [id_student], [test_code], [id_question], [answer_a], [answer_b], [answer_c], [answer_d], [student_answer], [timestamps]) VALUES (1083, 1009, 274659, 1058, N'To indicate that the controller is an API controller and thus automatically applies binding source parameters from the request body and other sources.', N'To specify the route template for the controller.', N'To specify the HTTP method for the controller action.', N'To define the authentication scheme for the controller.', N'To indicate that the controller is an API controller and thus automatically applies binding source parameters from the request body and other sources.', NULL)
INSERT [dbo].[student_test_detail] ([ID], [id_student], [test_code], [id_question], [answer_a], [answer_b], [answer_c], [answer_d], [student_answer], [timestamps]) VALUES (1081, 1009, 274659, 1059, N'404 Not Found', N'200 OK', N'500 Internal Server Error', N'401 Unauthorized', N'200 OK', NULL)
INSERT [dbo].[student_test_detail] ([ID], [id_student], [test_code], [id_question], [answer_a], [answer_b], [answer_c], [answer_d], [student_answer], [timestamps]) VALUES (1084, 1009, 274659, 1060, N'A caching mechanism for HTTP responses.', N'A security measure to prevent CSRF attacks.', N'A protocol for encrypting data in transit.', N'Cross-Origin Resource Sharing, a mechanism that allows resources to be requested from another domain.', N'A security measure to prevent CSRF attacks.', NULL)
INSERT [dbo].[student_test_detail] ([ID], [id_student], [test_code], [id_question], [answer_a], [answer_b], [answer_c], [answer_d], [student_answer], [timestamps]) VALUES (1090, 1009, 274659, 1061, N'Microsoft.AspNetCore.Mvc', N'Microsoft.AspNetCore.Cors', N'Microsoft.AspNetCore.Http', N'Microsoft.AspNetCore.Authentication', N'Microsoft.AspNetCore.Cors', NULL)
INSERT [dbo].[student_test_detail] ([ID], [id_student], [test_code], [id_question], [answer_a], [answer_b], [answer_c], [answer_d], [student_answer], [timestamps]) VALUES (1085, 1009, 274659, 1062, N'To define the authentication scheme for the controller.', N'To specify the HTTP method for the controller action.', N'To indicate that the controller is an API controller.', N'To specify the route template for the controller or action method.', N'To specify the route template for the controller or action method.', NULL)
INSERT [dbo].[student_test_detail] ([ID], [id_student], [test_code], [id_question], [answer_a], [answer_b], [answer_c], [answer_d], [student_answer], [timestamps]) VALUES (1099, 1010, 274659, 1053, N'It is a front-end development framework.', N'It is a programming language.', N'It is a framework for building HTTP services.', N'It is a database management system.', N'It is a framework for building HTTP services.', NULL)
INSERT [dbo].[student_test_detail] ([ID], [id_student], [test_code], [id_question], [answer_a], [answer_b], [answer_c], [answer_d], [student_answer], [timestamps]) VALUES (1093, 1010, 274659, 1054, N'POST', N'DELETE', N'PUT', N'GET', N'GET', NULL)
INSERT [dbo].[student_test_detail] ([ID], [id_student], [test_code], [id_question], [answer_a], [answer_b], [answer_c], [answer_d], [student_answer], [timestamps]) VALUES (1091, 1010, 274659, 1055, N'Automatic model binding', N'Server-side rendering', N'Content negotiation', N'Dependency injection', N'Server-side rendering', NULL)
INSERT [dbo].[student_test_detail] ([ID], [id_student], [test_code], [id_question], [answer_a], [answer_b], [answer_c], [answer_d], [student_answer], [timestamps]) VALUES (1095, 1010, 274659, 1056, N'YAML', N'HTML', N'JSON', N'XML', N'JSON', NULL)
INSERT [dbo].[student_test_detail] ([ID], [id_student], [test_code], [id_question], [answer_a], [answer_b], [answer_c], [answer_d], [student_answer], [timestamps]) VALUES (1097, 1010, 274659, 1057, N'To authenticate users.', N'To execute background tasks.', N'To define how HTTP requests are mapped to action methods.', N'To manage database connections.', N'To define how HTTP requests are mapped to action methods.', NULL)
INSERT [dbo].[student_test_detail] ([ID], [id_student], [test_code], [id_question], [answer_a], [answer_b], [answer_c], [answer_d], [student_answer], [timestamps]) VALUES (1098, 1010, 274659, 1058, N'To specify the HTTP method for the controller action.', N'To indicate that the controller is an API controller and thus automatically applies binding source parameters from the request body and other sources.', N'To specify the route template for the controller.', N'To define the authentication scheme for the controller.', N'To specify the HTTP method for the controller action.', NULL)
INSERT [dbo].[student_test_detail] ([ID], [id_student], [test_code], [id_question], [answer_a], [answer_b], [answer_c], [answer_d], [student_answer], [timestamps]) VALUES (1094, 1010, 274659, 1059, N'500 Internal Server Error', N'404 Not Found', N'401 Unauthorized', N'200 OK', N'200 OK', NULL)
INSERT [dbo].[student_test_detail] ([ID], [id_student], [test_code], [id_question], [answer_a], [answer_b], [answer_c], [answer_d], [student_answer], [timestamps]) VALUES (1096, 1010, 274659, 1060, N'A protocol for encrypting data in transit.', N'A security measure to prevent CSRF attacks.', N'Cross-Origin Resource Sharing, a mechanism that allows resources to be requested from another domain.', N'A caching mechanism for HTTP responses.', N'Cross-Origin Resource Sharing, a mechanism that allows resources to be requested from another domain.', NULL)
INSERT [dbo].[student_test_detail] ([ID], [id_student], [test_code], [id_question], [answer_a], [answer_b], [answer_c], [answer_d], [student_answer], [timestamps]) VALUES (1100, 1010, 274659, 1061, N'Microsoft.AspNetCore.Mvc', N'Microsoft.AspNetCore.Authentication', N'Microsoft.AspNetCore.Cors', N'Microsoft.AspNetCore.Http', N'Microsoft.AspNetCore.Cors', NULL)
INSERT [dbo].[student_test_detail] ([ID], [id_student], [test_code], [id_question], [answer_a], [answer_b], [answer_c], [answer_d], [student_answer], [timestamps]) VALUES (1092, 1010, 274659, 1062, N'To specify the route template for the controller or action method.', N'To specify the HTTP method for the controller action.', N'To indicate that the controller is an API controller.', N'To define the authentication scheme for the controller.', N'To specify the HTTP method for the controller action.', NULL)
INSERT [dbo].[student_test_detail] ([ID], [id_student], [test_code], [id_question], [answer_a], [answer_b], [answer_c], [answer_d], [student_answer], [timestamps]) VALUES (1102, 1011, 274659, 1053, N'It is a programming language.', N'It is a front-end development framework.', N'It is a database management system.', N'It is a framework for building HTTP services.', N'It is a framework for building HTTP services.', NULL)
INSERT [dbo].[student_test_detail] ([ID], [id_student], [test_code], [id_question], [answer_a], [answer_b], [answer_c], [answer_d], [student_answer], [timestamps]) VALUES (1110, 1011, 274659, 1054, N'GET', N'POST', N'DELETE', N'PUT', N'GET', NULL)
INSERT [dbo].[student_test_detail] ([ID], [id_student], [test_code], [id_question], [answer_a], [answer_b], [answer_c], [answer_d], [student_answer], [timestamps]) VALUES (1104, 1011, 274659, 1055, N'Automatic model binding', N'Dependency injection', N'Server-side rendering', N'Content negotiation', N'Server-side rendering', NULL)
INSERT [dbo].[student_test_detail] ([ID], [id_student], [test_code], [id_question], [answer_a], [answer_b], [answer_c], [answer_d], [student_answer], [timestamps]) VALUES (1107, 1011, 274659, 1056, N'HTML', N'JSON', N'XML', N'YAML', N'JSON', NULL)
INSERT [dbo].[student_test_detail] ([ID], [id_student], [test_code], [id_question], [answer_a], [answer_b], [answer_c], [answer_d], [student_answer], [timestamps]) VALUES (1108, 1011, 274659, 1057, N'To manage database connections.', N'To authenticate users.', N'To define how HTTP requests are mapped to action methods.', N'To execute background tasks.', N'To define how HTTP requests are mapped to action methods.', NULL)
INSERT [dbo].[student_test_detail] ([ID], [id_student], [test_code], [id_question], [answer_a], [answer_b], [answer_c], [answer_d], [student_answer], [timestamps]) VALUES (1106, 1011, 274659, 1058, N'To indicate that the controller is an API controller and thus automatically applies binding source parameters from the request body and other sources.', N'To define the authentication scheme for the controller.', N'To specify the route template for the controller.', N'To specify the HTTP method for the controller action.', N'To specify the HTTP method for the controller action.', NULL)
INSERT [dbo].[student_test_detail] ([ID], [id_student], [test_code], [id_question], [answer_a], [answer_b], [answer_c], [answer_d], [student_answer], [timestamps]) VALUES (1109, 1011, 274659, 1059, N'200 OK', N'401 Unauthorized', N'404 Not Found', N'500 Internal Server Error', N'200 OK', NULL)
INSERT [dbo].[student_test_detail] ([ID], [id_student], [test_code], [id_question], [answer_a], [answer_b], [answer_c], [answer_d], [student_answer], [timestamps]) VALUES (1103, 1011, 274659, 1060, N'A security measure to prevent CSRF attacks.', N'Cross-Origin Resource Sharing, a mechanism that allows resources to be requested from another domain.', N'A protocol for encrypting data in transit.', N'A caching mechanism for HTTP responses.', N'Cross-Origin Resource Sharing, a mechanism that allows resources to be requested from another domain.', NULL)
INSERT [dbo].[student_test_detail] ([ID], [id_student], [test_code], [id_question], [answer_a], [answer_b], [answer_c], [answer_d], [student_answer], [timestamps]) VALUES (1105, 1011, 274659, 1061, N'Microsoft.AspNetCore.Cors', N'Microsoft.AspNetCore.Http', N'Microsoft.AspNetCore.Mvc', N'Microsoft.AspNetCore.Authentication', N'Microsoft.AspNetCore.Cors', NULL)
GO
INSERT [dbo].[student_test_detail] ([ID], [id_student], [test_code], [id_question], [answer_a], [answer_b], [answer_c], [answer_d], [student_answer], [timestamps]) VALUES (1101, 1011, 274659, 1062, N'To indicate that the controller is an API controller.', N'To specify the HTTP method for the controller action.', N'To specify the route template for the controller or action method.', N'To define the authentication scheme for the controller.', N'To specify the HTTP method for the controller action.', NULL)
INSERT [dbo].[student_test_detail] ([ID], [id_student], [test_code], [id_question], [answer_a], [answer_b], [answer_c], [answer_d], [student_answer], [timestamps]) VALUES (1114, 1012, 274659, 1053, N'It is a front-end development framework.', N'It is a database management system.', N'It is a framework for building HTTP services.', N'It is a programming language.', N'It is a front-end development framework.', NULL)
INSERT [dbo].[student_test_detail] ([ID], [id_student], [test_code], [id_question], [answer_a], [answer_b], [answer_c], [answer_d], [student_answer], [timestamps]) VALUES (1115, 1012, 274659, 1054, N'POST', N'GET', N'DELETE', N'PUT', N'POST', NULL)
INSERT [dbo].[student_test_detail] ([ID], [id_student], [test_code], [id_question], [answer_a], [answer_b], [answer_c], [answer_d], [student_answer], [timestamps]) VALUES (1113, 1012, 274659, 1055, N'Dependency injection', N'Automatic model binding', N'Server-side rendering', N'Content negotiation', N'Dependency injection', NULL)
INSERT [dbo].[student_test_detail] ([ID], [id_student], [test_code], [id_question], [answer_a], [answer_b], [answer_c], [answer_d], [student_answer], [timestamps]) VALUES (1120, 1012, 274659, 1056, N'HTML', N'YAML', N'XML', N'JSON', N'JSON', NULL)
INSERT [dbo].[student_test_detail] ([ID], [id_student], [test_code], [id_question], [answer_a], [answer_b], [answer_c], [answer_d], [student_answer], [timestamps]) VALUES (1117, 1012, 274659, 1057, N'To define how HTTP requests are mapped to action methods.', N'To execute background tasks.', N'To manage database connections.', N'To authenticate users.', N'To authenticate users.', NULL)
INSERT [dbo].[student_test_detail] ([ID], [id_student], [test_code], [id_question], [answer_a], [answer_b], [answer_c], [answer_d], [student_answer], [timestamps]) VALUES (1118, 1012, 274659, 1058, N'To define the authentication scheme for the controller.', N'To specify the route template for the controller.', N'To indicate that the controller is an API controller and thus automatically applies binding source parameters from the request body and other sources.', N'To specify the HTTP method for the controller action.', N'To define the authentication scheme for the controller.', NULL)
INSERT [dbo].[student_test_detail] ([ID], [id_student], [test_code], [id_question], [answer_a], [answer_b], [answer_c], [answer_d], [student_answer], [timestamps]) VALUES (1112, 1012, 274659, 1059, N'404 Not Found', N'500 Internal Server Error', N'401 Unauthorized', N'200 OK', N'401 Unauthorized', NULL)
INSERT [dbo].[student_test_detail] ([ID], [id_student], [test_code], [id_question], [answer_a], [answer_b], [answer_c], [answer_d], [student_answer], [timestamps]) VALUES (1119, 1012, 274659, 1060, N'A security measure to prevent CSRF attacks.', N'A protocol for encrypting data in transit.', N'Cross-Origin Resource Sharing, a mechanism that allows resources to be requested from another domain.', N'A caching mechanism for HTTP responses.', N'A security measure to prevent CSRF attacks.', NULL)
INSERT [dbo].[student_test_detail] ([ID], [id_student], [test_code], [id_question], [answer_a], [answer_b], [answer_c], [answer_d], [student_answer], [timestamps]) VALUES (1116, 1012, 274659, 1061, N'Microsoft.AspNetCore.Http', N'Microsoft.AspNetCore.Authentication', N'Microsoft.AspNetCore.Mvc', N'Microsoft.AspNetCore.Cors', N'Microsoft.AspNetCore.Authentication', NULL)
INSERT [dbo].[student_test_detail] ([ID], [id_student], [test_code], [id_question], [answer_a], [answer_b], [answer_c], [answer_d], [student_answer], [timestamps]) VALUES (1111, 1012, 274659, 1062, N'To specify the HTTP method for the controller action.', N'To specify the route template for the controller or action method.', N'To define the authentication scheme for the controller.', N'To indicate that the controller is an API controller.', N'To specify the HTTP method for the controller action.', NULL)
SET IDENTITY_INSERT [dbo].[student_test_detail] OFF
GO
SET IDENTITY_INSERT [dbo].[students] ON 

INSERT [dbo].[students] ([id_student], [username], [password], [email], [avatar], [name], [gender], [birthday], [phone], [id_permission], [id_class], [id_speciality], [is_testing], [time_start], [time_remaining], [last_login], [last_seen], [last_seen_url], [timestamps]) VALUES (1003, N'namnd1', N'e10adc3949ba59abbe56e057f20f883e', N'namnd1@example.com', N'noimage.jpg', N'Nguyễn Đình Nam', N'Nam', CAST(N'2002-01-01' AS Date), N'0123456789', 3, 2004, 1, 984652, CAST(N'2024-03-25T01:14:24.507' AS DateTime), N'6:54', CAST(N'2024-03-25T01:14:14.033' AS DateTime), N'Trang Chủ', N'/Student', CAST(N'2024-03-24T18:02:53.457' AS DateTime))
INSERT [dbo].[students] ([id_student], [username], [password], [email], [avatar], [name], [gender], [birthday], [phone], [id_permission], [id_class], [id_speciality], [is_testing], [time_start], [time_remaining], [last_login], [last_seen], [last_seen_url], [timestamps]) VALUES (1004, N'chilq1', N'e10adc3949ba59abbe56e057f20f883e', N'chilq1@example.com', N'noimage.jpg', N'Lê Quỳnh Chi', N'Nữ', CAST(N'2002-02-02' AS Date), N'0123456788', 3, 2004, 1, NULL, NULL, NULL, CAST(N'2024-03-24T18:16:34.000' AS DateTime), N'Trang Chủ', N'/Student', CAST(N'2024-03-24T18:02:53.457' AS DateTime))
INSERT [dbo].[students] ([id_student], [username], [password], [email], [avatar], [name], [gender], [birthday], [phone], [id_permission], [id_class], [id_speciality], [is_testing], [time_start], [time_remaining], [last_login], [last_seen], [last_seen_url], [timestamps]) VALUES (1005, N'manhdc1', N'e10adc3949ba59abbe56e057f20f883e', N'manhdc1@example.com', N'noimage.jpg', N'Đinh Công Mạnh', N'Nam', CAST(N'2002-03-03' AS Date), N'0123456787', 3, 2004, 1, NULL, NULL, NULL, CAST(N'2024-03-24T18:16:58.467' AS DateTime), N'Trang Chủ', N'/Student', CAST(N'2024-03-24T18:02:53.457' AS DateTime))
INSERT [dbo].[students] ([id_student], [username], [password], [email], [avatar], [name], [gender], [birthday], [phone], [id_permission], [id_class], [id_speciality], [is_testing], [time_start], [time_remaining], [last_login], [last_seen], [last_seen_url], [timestamps]) VALUES (1006, N'phuongth1', N'e10adc3949ba59abbe56e057f20f883e', N'phuongth1@example.com', N'noimage.jpg', N'Trần Hà Phương', N'Nữ', CAST(N'2002-04-04' AS Date), N'0123456786', 3, 2004, 1, NULL, NULL, NULL, CAST(N'2024-03-24T18:17:28.167' AS DateTime), N'Trang Chủ', N'/Student', CAST(N'2024-03-24T18:02:53.457' AS DateTime))
INSERT [dbo].[students] ([id_student], [username], [password], [email], [avatar], [name], [gender], [birthday], [phone], [id_permission], [id_class], [id_speciality], [is_testing], [time_start], [time_remaining], [last_login], [last_seen], [last_seen_url], [timestamps]) VALUES (1007, N'longlh1', N'e10adc3949ba59abbe56e057f20f883e', N'longlh1@example.com', N'noimage.jpg', N'Lê Hoàng Long', N'Nam', CAST(N'2002-05-05' AS Date), N'0123456785', 3, 2004, 1, NULL, NULL, NULL, CAST(N'2024-03-24T18:18:17.010' AS DateTime), N'Trang Chủ', N'/Student', CAST(N'2024-03-24T18:02:53.457' AS DateTime))
INSERT [dbo].[students] ([id_student], [username], [password], [email], [avatar], [name], [gender], [birthday], [phone], [id_permission], [id_class], [id_speciality], [is_testing], [time_start], [time_remaining], [last_login], [last_seen], [last_seen_url], [timestamps]) VALUES (1008, N'chilq2', N'e10adc3949ba59abbe56e057f20f883e', N'chilq2@example.com', N'noimage.jpg', N'Lương Quỳnh Chi', N'Nữ', CAST(N'2002-06-06' AS Date), N'0123456784', 3, 2004, 1, NULL, NULL, NULL, CAST(N'2024-03-24T18:23:54.593' AS DateTime), N'Trang Chủ', N'/Student', CAST(N'2024-03-24T18:02:53.457' AS DateTime))
INSERT [dbo].[students] ([id_student], [username], [password], [email], [avatar], [name], [gender], [birthday], [phone], [id_permission], [id_class], [id_speciality], [is_testing], [time_start], [time_remaining], [last_login], [last_seen], [last_seen_url], [timestamps]) VALUES (1009, N'hoangpv1', N'e10adc3949ba59abbe56e057f20f883e', N'hoangpv1@example.com', N'noimage.jpg', N'Phạm Văn Hoàng', N'Nam', CAST(N'2002-07-07' AS Date), N'0123456783', 3, 2004, 1, NULL, NULL, NULL, CAST(N'2024-03-24T18:23:11.533' AS DateTime), N'Trang Chủ', N'/Student', CAST(N'2024-03-24T18:02:53.457' AS DateTime))
INSERT [dbo].[students] ([id_student], [username], [password], [email], [avatar], [name], [gender], [birthday], [phone], [id_permission], [id_class], [id_speciality], [is_testing], [time_start], [time_remaining], [last_login], [last_seen], [last_seen_url], [timestamps]) VALUES (1010, N'linhntp1', N'e10adc3949ba59abbe56e057f20f883e', N'linhntp1@example.com', N'noimage.jpg', N'Nguyễn Thị Phương Linh', N'Nữ', CAST(N'2002-08-08' AS Date), N'0123456782', 3, 2004, 1, NULL, NULL, NULL, CAST(N'2024-03-24T18:24:02.917' AS DateTime), N'Trang Chủ', N'/Student', CAST(N'2024-03-24T18:02:53.457' AS DateTime))
INSERT [dbo].[students] ([id_student], [username], [password], [email], [avatar], [name], [gender], [birthday], [phone], [id_permission], [id_class], [id_speciality], [is_testing], [time_start], [time_remaining], [last_login], [last_seen], [last_seen_url], [timestamps]) VALUES (1011, N'hoangpv2', N'e10adc3949ba59abbe56e057f20f883e', N'hoangpv2@example.com', N'noimage.jpg', N'Phùng Viết Hoàng', N'Nam', CAST(N'2002-09-09' AS Date), N'0123456781', 3, 2004, 1, NULL, NULL, NULL, CAST(N'2024-03-24T18:24:09.613' AS DateTime), N'Trang Chủ', N'/Student', CAST(N'2024-03-24T18:02:53.457' AS DateTime))
INSERT [dbo].[students] ([id_student], [username], [password], [email], [avatar], [name], [gender], [birthday], [phone], [id_permission], [id_class], [id_speciality], [is_testing], [time_start], [time_remaining], [last_login], [last_seen], [last_seen_url], [timestamps]) VALUES (1012, N'hoand1', N'e10adc3949ba59abbe56e057f20f883e', N'hoand1@example.com', N'noimage.jpg', N'Nguyễn Đức Hoà', N'Nữ', CAST(N'2002-10-10' AS Date), N'0123456780', 3, 2004, 1, NULL, NULL, NULL, CAST(N'2024-03-24T18:24:39.477' AS DateTime), N'Trang Chủ', N'/Student', CAST(N'2024-03-24T18:02:53.457' AS DateTime))
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
INSERT [dbo].[tests] ([test_name], [test_code], [password], [id_subject], [total_questions], [time_to_do], [note], [id_status], [timestamps]) VALUES (N'FE_PRN231', 274659, N'e10adc3949ba59abbe56e057f20f883e', 1, 10, 10, N'Thi cuoi ky', 1, CAST(N'2024-03-24T18:11:45.973' AS DateTime))
INSERT [dbo].[tests] ([test_name], [test_code], [password], [id_subject], [total_questions], [time_to_do], [note], [id_status], [timestamps]) VALUES (N'FE_PRN231_RE', 984652, N'e10adc3949ba59abbe56e057f20f883e', 1, 10, 10, N'123', 1, NULL)
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__admins__B96D23647734DA5F]    Script Date: 3/25/2024 1:21:34 AM ******/
ALTER TABLE [dbo].[admins] ADD  CONSTRAINT [UQ__admins__B96D23647734DA5F] UNIQUE NONCLUSTERED 
(
	[username] ASC,
	[email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [fk_grade_idx]    Script Date: 3/25/2024 1:21:34 AM ******/
CREATE NONCLUSTERED INDEX [fk_grade_idx] ON [dbo].[classes]
(
	[id_grade] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [fk_speciality_idx]    Script Date: 3/25/2024 1:21:34 AM ******/
CREATE NONCLUSTERED INDEX [fk_speciality_idx] ON [dbo].[classes]
(
	[id_speciality] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__students__B96D2364BADF7213]    Script Date: 3/25/2024 1:21:34 AM ******/
ALTER TABLE [dbo].[students] ADD  CONSTRAINT [UQ__students__B96D2364BADF7213] UNIQUE NONCLUSTERED 
(
	[username] ASC,
	[email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__teachers__B96D2364E4800B05]    Script Date: 3/25/2024 1:21:34 AM ******/
ALTER TABLE [dbo].[teachers] ADD  CONSTRAINT [UQ__teachers__B96D2364E4800B05] UNIQUE NONCLUSTERED 
(
	[username] ASC,
	[email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [UQ__tests__040975AB07882BC3]    Script Date: 3/25/2024 1:21:34 AM ******/
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
