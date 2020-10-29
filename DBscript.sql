USE [VietIS]
GO
/****** Object:  Table [dbo].[User]    Script Date: 10/29/2020 5:49:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[Birthday] [date] NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[PhoneNumber] [nvarchar](20) NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserTB]    Script Date: 10/29/2020 5:49:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserTB](
	[ID] [int] NOT NULL,
	[Username] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
	[IsAdmin] [bit] NOT NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[User] ON 

INSERT [dbo].[User] ([ID], [FirstName], [LastName], [Birthday], [Email], [PhoneNumber]) VALUES (1, N'Zyta', N'Ngo The Anh', CAST(N'2000-12-30' AS Date), N'zyta.ngo@gmail.com', N'0909090909')
INSERT [dbo].[User] ([ID], [FirstName], [LastName], [Birthday], [Email], [PhoneNumber]) VALUES (2, N'Anh', N'Ngo', CAST(N'2000-08-01' AS Date), N'anhnt@gmail.com', N'0357467491')
INSERT [dbo].[User] ([ID], [FirstName], [LastName], [Birthday], [Email], [PhoneNumber]) VALUES (3, N'Viet', N'Tran', CAST(N'1999-09-09' AS Date), N'vietqt12123@fpt.edu.vn', N'66771508')
INSERT [dbo].[User] ([ID], [FirstName], [LastName], [Birthday], [Email], [PhoneNumber]) VALUES (4, N'Huy', N'Quoc', CAST(N'2000-02-02' AS Date), N'huyqt140254@fpt.edu.vn', N'013049295')
INSERT [dbo].[User] ([ID], [FirstName], [LastName], [Birthday], [Email], [PhoneNumber]) VALUES (5, N'Tung', N'Nguyen', CAST(N'1998-09-09' AS Date), N'tungntSe14255@fpt.edu.vn', N'0702957294')
SET IDENTITY_INSERT [dbo].[User] OFF
GO
