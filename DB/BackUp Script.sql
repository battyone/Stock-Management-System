USE [StockManagementSystemDB]
GO
/****** Object:  Table [dbo].[Categorys]    Script Date: 06-Jul-19 11:12:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Categorys](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
 CONSTRAINT [PK_Categorys] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Companys]    Script Date: 06-Jul-19 11:12:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Companys](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
 CONSTRAINT [PK_Companys] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Items]    Script Date: 06-Jul-19 11:12:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Items](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ItemName] [varchar](50) NULL,
	[CategoryID] [int] NULL,
	[CompanyID] [int] NULL,
	[ReorderLevel] [int] NULL,
	[AvailableQuantity] [int] NULL,
 CONSTRAINT [PK_Items] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Stocks]    Script Date: 06-Jul-19 11:12:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Stocks](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ItemID] [int] NULL,
	[Quantity] [int] NULL,
	[Date] [date] NULL,
	[Status] [varchar](50) NULL,
 CONSTRAINT [PK_Stocks] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[User]    Script Date: 06-Jul-19 11:12:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[User](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Username] [varchar](50) NULL,
	[Password] [varchar](50) NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Categorys] ON 

INSERT [dbo].[Categorys] ([ID], [Name]) VALUES (1, N'Stationary')
INSERT [dbo].[Categorys] ([ID], [Name]) VALUES (2, N'Cosmetics')
INSERT [dbo].[Categorys] ([ID], [Name]) VALUES (3, N'Electronics')
SET IDENTITY_INSERT [dbo].[Categorys] OFF
SET IDENTITY_INSERT [dbo].[Companys] ON 

INSERT [dbo].[Companys] ([ID], [Name]) VALUES (1, N'Unilever')
INSERT [dbo].[Companys] ([ID], [Name]) VALUES (2, N'RFL')
INSERT [dbo].[Companys] ([ID], [Name]) VALUES (3, N'Walton')
SET IDENTITY_INSERT [dbo].[Companys] OFF
SET IDENTITY_INSERT [dbo].[Items] ON 

INSERT [dbo].[Items] ([ID], [ItemName], [CategoryID], [CompanyID], [ReorderLevel], [AvailableQuantity]) VALUES (1, N'Shampo', 2, 1, 10, 30)
INSERT [dbo].[Items] ([ID], [ItemName], [CategoryID], [CompanyID], [ReorderLevel], [AvailableQuantity]) VALUES (2, N'Mobile', 3, 3, 50, 200)
INSERT [dbo].[Items] ([ID], [ItemName], [CategoryID], [CompanyID], [ReorderLevel], [AvailableQuantity]) VALUES (3, N'Oil', 2, 1, 15, 33)
SET IDENTITY_INSERT [dbo].[Items] OFF
SET IDENTITY_INSERT [dbo].[Stocks] ON 

INSERT [dbo].[Stocks] ([ID], [ItemID], [Quantity], [Date], [Status]) VALUES (1, 2, 51, CAST(0xCD3F0B00 AS Date), N'Stock In')
INSERT [dbo].[Stocks] ([ID], [ItemID], [Quantity], [Date], [Status]) VALUES (3, 1, 12, CAST(0xCD3F0B00 AS Date), N'Stock In')
INSERT [dbo].[Stocks] ([ID], [ItemID], [Quantity], [Date], [Status]) VALUES (4, 3, 20, CAST(0xCD3F0B00 AS Date), N'Stock In')
INSERT [dbo].[Stocks] ([ID], [ItemID], [Quantity], [Date], [Status]) VALUES (5, 2, 49, CAST(0xCD3F0B00 AS Date), N'Stock In')
INSERT [dbo].[Stocks] ([ID], [ItemID], [Quantity], [Date], [Status]) VALUES (6, 1, 18, CAST(0xCE3F0B00 AS Date), N'Stock In')
INSERT [dbo].[Stocks] ([ID], [ItemID], [Quantity], [Date], [Status]) VALUES (7, 2, 50, CAST(0xCE3F0B00 AS Date), N'Stock In')
INSERT [dbo].[Stocks] ([ID], [ItemID], [Quantity], [Date], [Status]) VALUES (1007, 3, 13, CAST(0xD33F0B00 AS Date), N'Stock In')
INSERT [dbo].[Stocks] ([ID], [ItemID], [Quantity], [Date], [Status]) VALUES (1008, 2, 50, CAST(0xDD3F0B00 AS Date), N'Stock In')
SET IDENTITY_INSERT [dbo].[Stocks] OFF
SET IDENTITY_INSERT [dbo].[User] ON 

INSERT [dbo].[User] ([ID], [Username], [Password]) VALUES (1, N'bitm', N'1234')
SET IDENTITY_INSERT [dbo].[User] OFF
ALTER TABLE [dbo].[Items]  WITH CHECK ADD  CONSTRAINT [FK_Items_Categorys] FOREIGN KEY([CategoryID])
REFERENCES [dbo].[Categorys] ([ID])
GO
ALTER TABLE [dbo].[Items] CHECK CONSTRAINT [FK_Items_Categorys]
GO
ALTER TABLE [dbo].[Items]  WITH CHECK ADD  CONSTRAINT [FK_Items_Companys] FOREIGN KEY([CompanyID])
REFERENCES [dbo].[Companys] ([ID])
GO
ALTER TABLE [dbo].[Items] CHECK CONSTRAINT [FK_Items_Companys]
GO
ALTER TABLE [dbo].[Stocks]  WITH CHECK ADD  CONSTRAINT [FK_Stocks_Items] FOREIGN KEY([ItemID])
REFERENCES [dbo].[Items] ([ID])
GO
ALTER TABLE [dbo].[Stocks] CHECK CONSTRAINT [FK_Stocks_Items]
GO
