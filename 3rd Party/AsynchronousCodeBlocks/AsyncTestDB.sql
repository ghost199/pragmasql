USE [master]
GO

CREATE DATABASE [AsyncTestDB]
GO

USE [AsyncTestDB]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Address](
	[Name] [nvarchar](50) NULL,
	[Age] [int] NULL,
	[Location] [nvarchar](1000) NULL
) ON [PRIMARY]

GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Grade](
	[Mathematics] [nchar](1) NULL,
	[ComputerScience] [nchar](1) NULL,
	[Physics] [nchar](1) NULL
) ON [PRIMARY]
