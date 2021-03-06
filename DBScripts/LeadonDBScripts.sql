USE [master]
GO
/****** Object:  Database [LeadonTimberframe]    Script Date: 13/11/2017 08:12:13 ******/
CREATE DATABASE [LeadonTimberframe]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'LeadonTimberframeDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER2014\MSSQL\DATA\LeadonTimberframeDB.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'LeadonTimberframeDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER2014\MSSQL\DATA\LeadonTimberframeDB_log.ldf' , SIZE = 4224KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [LeadonTimberframe] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [LeadonTimberframe].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [LeadonTimberframe] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [LeadonTimberframe] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [LeadonTimberframe] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [LeadonTimberframe] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [LeadonTimberframe] SET ARITHABORT OFF 
GO
ALTER DATABASE [LeadonTimberframe] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [LeadonTimberframe] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [LeadonTimberframe] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [LeadonTimberframe] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [LeadonTimberframe] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [LeadonTimberframe] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [LeadonTimberframe] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [LeadonTimberframe] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [LeadonTimberframe] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [LeadonTimberframe] SET  DISABLE_BROKER 
GO
ALTER DATABASE [LeadonTimberframe] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [LeadonTimberframe] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [LeadonTimberframe] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [LeadonTimberframe] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [LeadonTimberframe] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [LeadonTimberframe] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [LeadonTimberframe] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [LeadonTimberframe] SET RECOVERY FULL 
GO
ALTER DATABASE [LeadonTimberframe] SET  MULTI_USER 
GO
ALTER DATABASE [LeadonTimberframe] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [LeadonTimberframe] SET DB_CHAINING OFF 
GO
ALTER DATABASE [LeadonTimberframe] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [LeadonTimberframe] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [LeadonTimberframe] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'LeadonTimberframe', N'ON'
GO
USE [LeadonTimberframe]
GO
/****** Object:  Table [dbo].[Contractors]    Script Date: 13/11/2017 08:12:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Contractors](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Contractor] [varchar](255) NULL,
 CONSTRAINT [PK_Contractors] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CraneHire]    Script Date: 13/11/2017 08:12:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CraneHire](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[CraneHire] [varchar](255) NULL,
 CONSTRAINT [PK_CraneHire] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Erectors]    Script Date: 13/11/2017 08:12:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Erectors](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ErectorName] [varchar](255) NULL,
 CONSTRAINT [PK_Erectors] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HouseTypes]    Script Date: 13/11/2017 08:12:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HouseTypes](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[HouseTypeName] [varchar](255) NULL,
 CONSTRAINT [PK_HouseTypes] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[JobDeadTime]    Script Date: 13/11/2017 08:12:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[JobDeadTime](
	[JobId] [int] NOT NULL,
	[DeadTime] [int] NOT NULL,
	[Notes] [nvarchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[JobPlots]    Script Date: 13/11/2017 08:12:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[JobPlots](
	[JobPlotID] [int] IDENTITY(1,1) NOT NULL,
	[PlotId] [int] NOT NULL,
	[JobId] [int] NULL,
	[HouseTypeID] [int] NULL,
	[ErectorID] [int] NULL,
	[CraneID] [int] NULL,
 CONSTRAINT [PK_JobPlots_1] PRIMARY KEY CLUSTERED 
(
	[JobPlotID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[JobRecurringConfig]    Script Date: 13/11/2017 08:12:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[JobRecurringConfig](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[JobId] [int] NOT NULL,
	[ScheduleStartDate] [datetime] NULL,
	[Daily] [bit] NOT NULL,
	[Weekly] [bit] NOT NULL,
	[Fortnightly] [bit] NOT NULL,
	[Monthly] [bit] NOT NULL,
	[Custom] [bit] NOT NULL,
	[CustomDays] [int] NULL,
	[CancelledDate] [datetime] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Jobs]    Script Date: 13/11/2017 08:12:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Jobs](
	[JobID] [int] IDENTITY(1,1) NOT NULL,
	[Line] [varchar](255) NULL,
	[JobName] [varchar](500) NULL,
	[JobContractorID] [int] NULL,
	[SiteName] [varchar](255) NULL,
	[SiteContact] [varchar](255) NULL,
	[SiteComplete] [bit] NULL,
	[ProductionDate] [datetime] NULL CONSTRAINT [DF_Jobs_ProductionDate]  DEFAULT (CONVERT([date],getdate(),(0))),
	[OnsiteDate] [datetime] NULL CONSTRAINT [DF_Jobs_OnsiteDate]  DEFAULT (CONVERT([date],getdate(),(0))),
	[CompletionDate] [datetime] NULL CONSTRAINT [DF_Jobs_CompletionDate]  DEFAULT (CONVERT([date],getdate(),(0))),
	[ProductionCompleteDate] [datetime] NULL,
 CONSTRAINT [PK_Jobs] PRIMARY KEY CLUSTERED 
(
	[JobID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Plots]    Script Date: 13/11/2017 08:12:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Plots](
	[PlotId] [int] IDENTITY(1,1) NOT NULL,
	[PlotName] [varchar](500) NULL,
	[HouseTypeID] [int] NOT NULL,
	[Line_Ext] [float] NULL,
	[Line_IN & IL] [float] NULL,
	[Line_PY] [float] NULL,
	[Floor_F/C] [float] NULL,
	[Floor_Barges] [float] NULL,
	[Floor_Materials] [float] NULL,
	[Floor_Loading] [float] NULL,
	[Bench_Apex] [float] NULL,
	[Bench_PY Apex] [float] NULL,
	[Line_Total] [float] NULL,
	[Floor_Total] [float] NULL,
	[Bench_Total] [float] NULL,
 CONSTRAINT [PK_PlotProductionQuantities] PRIMARY KEY CLUSTERED 
(
	[PlotId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[JobRecurringConfig] ADD  CONSTRAINT [DF_JobRecurringConfig_Daily]  DEFAULT ((0)) FOR [Daily]
GO
ALTER TABLE [dbo].[JobRecurringConfig] ADD  CONSTRAINT [DF_JobRecurringConfig_Weekly]  DEFAULT ((0)) FOR [Weekly]
GO
ALTER TABLE [dbo].[JobRecurringConfig] ADD  CONSTRAINT [DF_JobRecurringConfig_Fortnightly]  DEFAULT ((0)) FOR [Fortnightly]
GO
ALTER TABLE [dbo].[JobRecurringConfig] ADD  CONSTRAINT [DF_JobRecurringConfig_Monthly]  DEFAULT ((0)) FOR [Monthly]
GO
ALTER TABLE [dbo].[JobRecurringConfig] ADD  CONSTRAINT [DF_JobRecurringConfig_Custom]  DEFAULT ((0)) FOR [Custom]
GO
/****** Object:  StoredProcedure [dbo].[DeleteContractor]    Script Date: 13/11/2017 08:12:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[DeleteContractor]
	@ID int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	DELETE FROM [dbo].[Contractors]
      WHERE ID = @ID
END

GO
/****** Object:  StoredProcedure [dbo].[DeleteCraneHire]    Script Date: 13/11/2017 08:12:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[DeleteCraneHire]
	@ID int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	DELETE FROM [dbo].[CraneHire]
      WHERE ID = @ID
END

GO
/****** Object:  StoredProcedure [dbo].[DeleteErector]    Script Date: 13/11/2017 08:12:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[DeleteErector]
	@ID int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	DELETE FROM [dbo].[Erectors]
      WHERE ID = @ID
END

GO
/****** Object:  StoredProcedure [dbo].[DeleteHouseType]    Script Date: 13/11/2017 08:12:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[DeleteHouseType]
	@ID int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	DELETE FROM [dbo].[HouseTypes]
      WHERE ID = @ID
END

GO
/****** Object:  StoredProcedure [dbo].[DeleteJobPlot]    Script Date: 13/11/2017 08:12:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[DeleteJobPlot]
	-- Add the parameters for the stored procedure here
	@JobPlotID int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	Delete from JobPlots
	where JobPlotID = @JobPlotID
END

GO
/****** Object:  StoredProcedure [dbo].[DeletePlot]    Script Date: 13/11/2017 08:12:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[DeletePlot]
	@PlotID int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	DELETE FROM [dbo].[Plots]
      WHERE PlotID = @PlotID
END

GO
/****** Object:  StoredProcedure [dbo].[GetContractors]    Script Date: 13/11/2017 08:12:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetContractors]
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	select * from Contractors
	order by Contractor
END

GO
/****** Object:  StoredProcedure [dbo].[GetCraneHire]    Script Date: 13/11/2017 08:12:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
Create PROCEDURE [dbo].[GetCraneHire]
	-- Add the parameters for the stored procedure here
	@id int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	select * from CraneHire where id = @id
END

GO
/****** Object:  StoredProcedure [dbo].[GetCraneHires]    Script Date: 13/11/2017 08:12:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetCraneHires]
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	select * from CraneHire
END

GO
/****** Object:  StoredProcedure [dbo].[GetErector]    Script Date: 13/11/2017 08:12:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetErector]
	-- Add the parameters for the stored procedure here
	@id int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	select * from Erectors where id = @id
END

GO
/****** Object:  StoredProcedure [dbo].[GetErectors]    Script Date: 13/11/2017 08:12:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
Create PROCEDURE [dbo].[GetErectors]
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	select * from Erectors
END

GO
/****** Object:  StoredProcedure [dbo].[GetHouseType]    Script Date: 13/11/2017 08:12:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetHouseType]
	-- Add the parameters for the stored procedure here
	@id int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	select * from HouseTypes where id = @id
END

GO
/****** Object:  StoredProcedure [dbo].[GetHouseTypes]    Script Date: 13/11/2017 08:12:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetHouseTypes]
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	select * from HouseTypes
END

GO
/****** Object:  StoredProcedure [dbo].[GetJob]    Script Date: 13/11/2017 08:12:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetJob]
	@JobID int
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	select * from Jobs
	where JobID = @JobID
	
END

--[GetJob] 1
GO
/****** Object:  StoredProcedure [dbo].[GetJobDeadTime]    Script Date: 13/11/2017 08:12:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetJobDeadTime]
	@JobID int
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	select * from JobDeadTime
	where JobId = @JobID
	
END

--[GetJobDeadTime] 1
GO
/****** Object:  StoredProcedure [dbo].[GetJobPlots]    Script Date: 13/11/2017 08:12:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetJobPlots]
	@JobPlotID int
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	  select jp.*--, p.PlotName, h.HouseTypeName, p.Line_Total, p.Bench_Total, p.Floor_Total
  from JobPlots jp--, Plots p, HouseTypes h
  where
  --p.PlotId = jp.PlotId
  --and h.ID = p.HouseTypeID
  --and 
  jp.JobPlotID = @JobPlotID

	
END
--[GetJobPlots] 1


GO
/****** Object:  StoredProcedure [dbo].[GetJobPlotsByJob]    Script Date: 13/11/2017 08:12:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetJobPlotsByJob]
	@JobID int
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	  select jp.*--, p.PlotName, h.HouseTypeName, p.Line_Total, p.Bench_Total, p.Floor_Total
  from JobPlots jp--, Plots p, HouseTypes h
  where
  --p.PlotId = jp.PlotId
  --and h.ID = p.HouseTypeID
  --and 
  jp.JobId = @JobID

	
END
--[GetJobPlotsByJob] 1


GO
/****** Object:  StoredProcedure [dbo].[GetJobPlotsReport]    Script Date: 13/11/2017 08:12:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetJobPlotsReport]

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	select p.PlotId, p.PlotName, h.HouseTypeName, p.Line_total, p.Floor_Total, p.Bench_Total, jp.*, e.ErectorName, c.CraneHire, j.JobID, j.JobName, j.Line, j.SiteContact
	from Plots p LEFT outer JOIN HouseTypes h ON p.HouseTypeID = h.ID
	LEFT OUTER JOIN jobPlots jp ON p.PlotId = jp.PlotId
	LEFT OUTER JOIN Erectors e ON e.ID = jp.ErectorID
	LEFT OUTER JOIN CraneHire c ON c.ID = jp.CraneID
	LEFT OUTER JOIN Jobs j on j.JobID = jp.JobId
	Order By j.JobID
	--where p.HouseTypeID = h.ID
	--and jp.PlotId = p.PlotId
	--and e.ID = jp.ErectorID
	--and c.ID = jp.CraneID
END

--[GetJobPlotsReport] 


Update JobPlots
set CraneID = 2 where CraneID = 1
GO
/****** Object:  StoredProcedure [dbo].[GetJobPlotsReportForDates]    Script Date: 13/11/2017 08:12:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetJobPlotsReportForDates]
	@fromDate datetime,
	@toDate datetime
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	select p.PlotId, p.PlotName, h.HouseTypeName, p.Line_total, p.Floor_Total, p.Bench_Total, jp.*, e.ErectorName, c.CraneHire, j.JobID, j.JobName, j.Line, j.SiteContact, j.ProductionDate, j.OnsiteDate, j.CompletionDate
	from Plots p LEFT outer JOIN HouseTypes h ON p.HouseTypeID = h.ID
	LEFT OUTER JOIN jobPlots jp ON p.PlotId = jp.PlotId
	LEFT OUTER JOIN Erectors e ON e.ID = jp.ErectorID
	LEFT OUTER JOIN CraneHire c ON c.ID = jp.CraneID
	LEFT OUTER JOIN Jobs j on j.JobID = jp.JobId
	WHERE 
		j.ProductionDate between @fromDate and @toDate
	Order By j.JobID
	--where p.HouseTypeID = h.ID
	--and jp.PlotId = p.PlotId
	--and e.ID = jp.ErectorID
	--and c.ID = jp.CraneID
END

--[GetJobPlotsReportForDates] '2017-07-28 00:00:00', '2027-07-29 00:00:00'



GO
/****** Object:  StoredProcedure [dbo].[GetJobPlotsReportForDatesOrdered]    Script Date: 13/11/2017 08:12:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetJobPlotsReportForDatesOrdered]
	@fromDate datetime,
	@toDate datetime
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	select j.Line, p.PlotName, j.ProductionDate, j.OnsiteDate, e.ErectorName, j.CompletionDate,  c.CraneHire --, jp.*,j.JobID, j.JobName,  j.SiteContact,  p.PlotId
	from 
		Plots p LEFT outer JOIN HouseTypes h ON p.HouseTypeID = h.ID
		LEFT OUTER JOIN jobPlots jp ON p.PlotId = jp.PlotId
		LEFT OUTER JOIN Erectors e ON e.ID = jp.ErectorID
		LEFT OUTER JOIN CraneHire c ON c.ID = jp.CraneID
		LEFT OUTER JOIN Jobs j on j.JobID = jp.JobId
	WHERE 
		j.ProductionDate between @fromDate and @toDate
	Order By j.JobID

END

--[GetJobPlotsReportForDatesOrdered] '2007-07-28 00:00:00', '2027-07-29 00:00:00'



GO
/****** Object:  StoredProcedure [dbo].[GetJobRecurringConfig]    Script Date: 13/11/2017 08:12:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetJobRecurringConfig]
	@JobID int
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	select * from [dbo].[JobRecurringConfig]
	where JobID = @JobID
	
END

--[GetJobRecurringConfig] 1
GO
/****** Object:  StoredProcedure [dbo].[GetJobs]    Script Date: 13/11/2017 08:12:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetJobs]
	
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	select * from Jobs
	order by ProductionDate 
	
	
END

GO
/****** Object:  StoredProcedure [dbo].[GetPlot]    Script Date: 13/11/2017 08:12:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetPlot]
	@PlotID int
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	select PlotID, PlotName, HouseTypeID, Line_Total, Floor_Total, Bench_Total  from Plots
	where PlotID = @PlotID
	
END

GO
/****** Object:  StoredProcedure [dbo].[GetPlots]    Script Date: 13/11/2017 08:12:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetPlots]
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	select * from Plots

	
END

GO
/****** Object:  StoredProcedure [dbo].[GetUnScheduledPlots]    Script Date: 13/11/2017 08:12:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetUnScheduledPlots]

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	select p.PlotId, p.PlotName, h.HouseTypeName, p.Line_total, p.Floor_Total, p.Bench_Total from Plots p, HouseTypes h
	where p.PlotID not in (Select distinct plotId from JobPlots)
	and p.HouseTypeID = h.ID
END

--[GetUnScheduledPlots] 

GO
/****** Object:  StoredProcedure [dbo].[GetWeeklyScheduleForPrinting]    Script Date: 13/11/2017 08:12:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetWeeklyScheduleForPrinting]
	
	@fromDate datetime,
	@toDate datetime
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

select 
--j.JobID,
j.Line as Line, 
j.JobName as Name, 
'' as Duration, 
j.ProductionDate as Production, 
j.OnsiteDate as [On-site / Delivery],
e.ErectorName as Erector,
j.CompletionDate as [Erecting Complete],
c.CraneHire as [Crane Hire]
from
Jobs j,
jobplots jp
left outer join erectors e on jp.erectorid = e.ID
left outer join CraneHire c on jp.CraneID = e.ID
WHERE
j.JobID = jp.JobId

and j.ProductionDate between @fromDate and @toDate

order by j.ProductionDate asc

END

---[GetWeeklyScheduleForPrinting] '17/07/2017 09:00:00', '24/07/2017 08:59:59'
--[GetWeeklyScheduleForPrinting] convert(datetime, '10/07/2017 09:00:00', 101), convert(datetime, '17/07/2017 08:59:59', 101)


GO
/****** Object:  StoredProcedure [dbo].[RecalculateSchedule]    Script Date: 13/11/2017 08:12:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[RecalculateSchedule]
	@workingHours int,
	@weekStarting smalldatetime
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	SET DATEFIRST 1

	declare @StartDate datetime
	declare @hrsPerDay int

	declare @StartTime time --Start of working day
	declare @EndTime time --End of working day

	set @StartTime = '06:00:00'
	set @EndTime = '17:00:00'

	set @hrsPerDay = @workingHours / 5

	--select @hrsPerDay as HoursPerDay
		
	

	set @StartDate =  CAST(DATEADD(day, 1-DATEPART(weekday, @weekStarting), @weekStarting) AS datetime) 
	set @StartDate = @StartDate + @StartTime

	declare @jobID int
	declare @prodStart datetime
	declare @prodEnd datetime
	declare @totProdHours float
	declare @rollingStartDate datetime

	set @rollingStartDate = @StartDate
	--DebugLine1
	--select @rollingStartDate as RollingStartDate

	--DebugLine2
	--select j.JobID, j.ProductionDate, DATENAME(weekday, j.ProductionDate) as StartDay, j.ProductionCompleteDate, DATENAME(weekday, j.ProductionCompleteDate) as CompleteDay, SUM(p.Line_Total) + SUM(p.Bench_Total) as TotalProdHours
	--	from Jobs j inner join JobPlots jp on j.JobID = jp.JobId
	--	left outer join Plots p on jp.PlotId = p.PlotId
	--	where j.ProductionDate >= @StartDate
	--	group by j.JobID, j.ProductionDate, j.ProductionCompleteDate
	--	order by j.ProductionDate

	/*
	Cursor to run through all jobs and their plots ordered by Production Date
	*/
	declare myCur scroll cursor for		
		select j.JobID, j.ProductionDate, j.ProductionCompleteDate, SUM(p.Line_Total) + SUM(p.Bench_Total) as TotalProdHours
		from Jobs j inner join JobPlots jp on j.JobID = jp.JobId
		left outer join Plots p on jp.PlotId = p.PlotId
		where j.ProductionDate >= @StartDate
		group by j.JobID, j.ProductionDate, j.ProductionCompleteDate
		order by j.ProductionDate

		open myCur

		fetch first from myCur into @jobID, @prodStart, @prodEnd, @totProdHours
		while @@FETCH_STATUS = 0
		begin
			
			declare @endDate datetime

			/*
			If the number of production hours for job is more than can be done in one day and less than 24 hours add 24hrs
			@rollingstartdate will be the new start date for each job
			*/ 
			if @totProdHours > @hrsPerDay AND @totProdHours < 24
			BEGIN
				--select 1 as LessThan24
				set @totProdHours = @totProdHours + 24				
				set @endDate = DATEADD(minute, ceiling(@totProdHours * 60), @rollingStartDate)
			END
			ELSE --Production is > 24 hours so need to work out how many days to add on
			BEGIN
				--select 2 GreaterThan24
				--select @totProdHours as totProdHours
				declare @totDays int
				declare @remainingMins int				
				set @totDays = CONVERT(int, @totProdHours / @hrsPerDay)				
				set @remainingMins = Convert(int, ceiling(60 * (CAST(@totProdHours AS decimal(38,19)) % @hrsPerDay)))
				

				--select @totDays as TotDays, @remainingMins as RemainingMins
				
				set @endDate = DATEADD(day, @totDays, @rollingStartDate)				
				set @endDate = DATEADD(minute, @remainingMins, @endDate)
				--select @prodStart as Prodstart, @totDays as totDays, @remainingMins as remainingmins, @endDate as enddate
			END					

			/*Handle the end date being after hours on a friday or a Sat/Sund*/
			declare @endDay varchar(20)
			set @endDay = DATENAME(weekday, @endDate)
			--select @endDay as endDay

			declare @jobEndTime time
			set @jobEndTime = CONVERT(TIME, @endDate)
			--select @jobEndTime as EndTime

			declare @daysToAddToCoverWeekend int
			
			SET @daysToAddToCoverWeekend = CASE @endDay
				WHEN 'Friday' THEN 3
				WHEN 'Saturday' THEN 2
				WHEN 'Sunday' THEN 1
				ELSE 0
			END

			if @daysToAddToCoverWeekend = 3 --If friday
			begin
				declare @timeDiff int
				declare @datePart date
				declare @newEndDate date
				declare @newEndDateTime datetime
				

				declare @tempEndOfDayEndDate datetime

				if @jobEndTime > @EndTime --If it is a friday and the end time is after close of business we need to finish job on Monday
				BEGIN
					set @datePart = CONVERT(date, @endDate);
					set @tempEndOfDayEndDate = CONVERT(datetime, @datePart) + @EndTime
					set @timeDiff = DATEDIFF(hour, @endDate, @tempEndOfDayEndDate)

					set @newEndDate = DATEADD(dd, @daysToAddToCoverWeekend,CONVERT(Date, @endDate))
					set @newEndDateTime = CONVERT(datetime, @newEndDate) + @StartTime
					set @newEndDateTime = DATEADD(hh, @timeDiff, @newEndDateTime)

					--select @newEndDate as NewEndDate

					set @endDate = @newEndDate
				END
			end

			if @daysToAddToCoverWeekend = 2 or @daysToAddToCoverWeekend = 1
			BEGIN				
					set @newEndDate = DATEADD(dd, @daysToAddToCoverWeekend,CONVERT(Date, @endDate))					
					set @endDate = @newEndDate
			END

			/*
			Update the production start and production end dates for the current job
			*/
			update Jobs
			set ProductionDate = @rollingStartDate, ProductionCompleteDate = @endDate
			where JobID = @jobID

			/*
			Set the start date of the next job to the end date of this job
			*/
			set @rollingStartDate = @endDate

		fetch next from myCur into @jobID, @prodStart, @prodEnd, @totProdHours
		end
		close myCur
		deallocate myCur

		--DebugLine3
		--select j.JobID, j.ProductionDate, DATENAME(weekday, j.ProductionDate) as StartDay, j.ProductionCompleteDate, DATENAME(weekday, j.ProductionCompleteDate) as CompleteDay, SUM(p.Line_Total) + SUM(p.Bench_Total) as TotalProdHours
		--from Jobs j inner join JobPlots jp on j.JobID = jp.JobId
		--left outer join Plots p on jp.PlotId = p.PlotId
		--where j.ProductionDate >= @StartDate
		--group by j.JobID, j.ProductionDate, j.ProductionCompleteDate
		--order by j.ProductionDate



END


--[RecalculateSchedule] 25, '2017-09-11'


GO
/****** Object:  StoredProcedure [dbo].[SaveContractor]    Script Date: 13/11/2017 08:12:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SaveContractor]
	-- Add the parameters for the stored procedure here
	@ContID int = 0,
	@ContName varchar(255)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	if @ContID = 0 
	BEGIN
		INSERT INTO [dbo].[Contractors]
			   ([Contractor])
		 VALUES
			   (@ContName)
	END
	ELSE
	BEGIN
		UPDATE [dbo].[Contractors]
	   SET [Contractor] = @ContName
	 WHERE ID = @ContID
	END
END

GO
/****** Object:  StoredProcedure [dbo].[SaveCraneHire]    Script Date: 13/11/2017 08:12:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SaveCraneHire]
	-- Add the parameters for the stored procedure here
	@CraneID int = 0,
	@CraneHire varchar(255)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	if @CraneID = 0 
	BEGIN
		INSERT INTO [dbo].[CraneHire]
			   ([CraneHire])
		 VALUES
			   (@CraneHire)
	END
	ELSE
	BEGIN
		UPDATE [dbo].[CraneHire]
	   SET [CraneHire] = @CraneHire
	 WHERE ID = @CraneID
	END
END

GO
/****** Object:  StoredProcedure [dbo].[SaveErector]    Script Date: 13/11/2017 08:12:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SaveErector]
	-- Add the parameters for the stored procedure here
	@ErectorID int = 0,
	@Name varchar(255)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	if @ErectorID = 0 
	BEGIN
		INSERT INTO [dbo].[Erectors]
			   ([ErectorName])
		 VALUES
			   (@Name)
	END
	ELSE
	BEGIN
		UPDATE [dbo].[Erectors]
	   SET [ErectorName] = @Name
	 WHERE ID = @ErectorID
	END
END

GO
/****** Object:  StoredProcedure [dbo].[SaveHouseType]    Script Date: 13/11/2017 08:12:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SaveHouseType]
	-- Add the parameters for the stored procedure here
	@HouseID int = 0,
	@Name varchar(255)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	if @HouseID = 0 
	BEGIN
		INSERT INTO [dbo].[HouseTypes]
			   ([HouseTypeName])
		 VALUES
			   (@Name)
	END
	ELSE
	BEGIN
		UPDATE [dbo].[HouseTypes]
	   SET [HouseTypeName] = @Name
	 WHERE ID = @HouseID
	END
END

GO
/****** Object:  StoredProcedure [dbo].[SaveJob]    Script Date: 13/11/2017 08:12:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SaveJob]
	-- Add the parameters for the stored procedure here
	@JobID int = 0,
	@Line varchar(255),
	@JobName varchar(500),
	@JobContractorID int,	
	@SiteName varchar(255),
	@SiteContact varchar(255),
	@ProdDate Datetime = null,
	@OnsiteDate Datetime = null,
	@CompletionDate Datetime = null,
	@SiteComplete bit
	--, 
	--@newID int OUTPUT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	if @JobID = 0 
	BEGIN

		INSERT INTO [dbo].[Jobs]
           ([Line]
		   ,[JobName]
           ,[JobContractorID]
           ,[SiteName]
           ,[SiteContact]
		   ,[ProductionDate]
		   ,[OnsiteDate]
		   ,[CompletionDate]
           ,[SiteComplete])
     VALUES
           (@Line
		   ,@JobName
           ,@JobContractorID
           ,@SiteName
           ,@SiteContact
		   ,@ProdDate
		   ,@OnsiteDate
		   ,@CompletionDate
           ,@SiteComplete)

	  SELECT SCOPE_IDENTITY()
	  --select @newID as ID
	END
	ELSE
	BEGIN
		UPDATE [dbo].[Jobs]
			SET [Line] = @Line
			,[JobName] = @JobName
			  ,[JobContractorID] = @JobContractorID
			  ,[SiteName] = @SiteName
			  ,[SiteContact] = @SiteContact
			  ,[ProductionDate] = @ProdDate
			  ,[OnsiteDate] = @OnsiteDate
			  ,[CompletionDate] = @CompletionDate
			  ,[SiteComplete] = @SiteComplete
		 WHERE JobID = @JobID

		 SELECT @JobID
		 
	END
END

GO
/****** Object:  StoredProcedure [dbo].[SaveJobDeadTime]    Script Date: 13/11/2017 08:12:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SaveJobDeadTime]
	@JobID int,
	@DeadTime int,
	@Notes nvarchar(max)
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	if exists(select 1 from JobDeadTime where JobId = @JobID)
	begin
		UPDATE [dbo].[JobDeadTime]
	   SET [DeadTime] = @DeadTime
		  ,[Notes] = @Notes
	 WHERE [JobId] = @JobId
	end
	else
	begin
	INSERT INTO [dbo].[JobDeadTime]
           ([JobId]
           ,[DeadTime]
           ,[Notes])
     VALUES
           (@JobID,
		   @DeadTime,
		   @Notes)
	end
	
END

--[SaveJobDeadTime] 1
GO
/****** Object:  StoredProcedure [dbo].[SaveJobPlot]    Script Date: 13/11/2017 08:12:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SaveJobPlot]
	-- Add the parameters for the stored procedure here
	@JobPlotID int = 0,
	@PlotID int,
	@JobID int,
	@HouseType int = 0,
	@ErectorID int = 0,
	@CraneID int = 0
	--@ProdDate date = null,
	--@OnsiteDate date = null,
	--@CompDate date = null
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	if @JobPlotID = 0 
	BEGIN
		INSERT INTO [dbo].[JobPlots]
           ([PlotId]
		   ,[JobId]
           ,[HouseTypeID]
           ,[ErectorID]
           ,[CraneID])
     VALUES
           (@PlotId
		   ,@JobID
           ,@HouseType
           ,@ErectorID
           ,@CraneID)

	 SELECT @@IDENTITY
	END
	ELSE
	BEGIN
		UPDATE [dbo].[JobPlots]
		   SET [PlotId] = @PlotID
			  ,[JobId] = @JobID
			  ,[HouseTypeID] = @HouseType
			  ,[ErectorID] = @ErectorID
			  ,[CraneID] = @CraneID
		 WHERE JobPlotID = @JobPlotID
	END
END

GO
/****** Object:  StoredProcedure [dbo].[SaveJobRecurringConfig]    Script Date: 13/11/2017 08:12:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SaveJobRecurringConfig]
	@JobID int,
	@ScheduleStartDate datetime,
	@Daily bit,
	@Weekly bit,
	@Fortnightly bit,
	@Monthly bit,
	@Custom bit,
	@CustomDays int,
	@CancelledDate datetime null
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	if exists(select 1 from [JobRecurringConfig] where JobId = @JobID)
	begin
		UPDATE [dbo].[JobRecurringConfig]
	   SET [ScheduleStartDate] = @ScheduleStartDate
      ,[Daily] = @Daily
      ,[Weekly] = @Weekly
      ,[Fortnightly] = @Fortnightly
      ,[Monthly] = @Monthly
      ,[Custom] = @Custom
      ,[CustomDays] = @CustomDays
      ,[CancelledDate] = @CancelledDate
 WHERE [JobId] = @JobID
	end
	else
	begin
	INSERT INTO [dbo].[JobRecurringConfig]
           ([JobId]
           ,[ScheduleStartDate]
           ,[Daily]
           ,[Weekly]
           ,[Fortnightly]
           ,[Monthly]
           ,[Custom]
           ,[CustomDays]
           ,[CancelledDate])
     VALUES
           (@JobID
		   ,@ScheduleStartDate
		   ,@Daily
		  ,@Weekly
		  ,@Fortnightly
		  ,@Monthly
		  ,@Custom
		  ,@CustomDays
		  ,@CancelledDate)
	end
END

--[GetJobRecurringConfig] 1
GO
/****** Object:  StoredProcedure [dbo].[SavePlot]    Script Date: 13/11/2017 08:12:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SavePlot]
	-- Add the parameters for the stored procedure here
	@PlotId int = 0,
	@PlotName varchar(500) = null,
	@HouseTypeId int,
	@LineExt float = 0.0,
	@LineINIL float = 0.0,
	@LinePY float = 0.0,
	@FloorFC float = 0.0,
	@FloorBarges float = 0.0,
	@FloorMaterials float = 0.0,
	@FloorLoading float = 0.0,
	@BenchApex float = 0.0,
	@BenchPYApex float = 0.0,
	@LineTot float,
	@FloorTot float,
	@BenchTot float
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	if @PlotId = 0 
	BEGIN
		INSERT INTO [dbo].[Plots]
           ([PlotName]
		   ,[HouseTypeID]
           ,[Line_Ext]
           ,[Line_IN & IL]
           ,[Line_PY]
           ,[Floor_F/C]
           ,[Floor_Barges]
           ,[Floor_Materials]
           ,[Floor_Loading]
           ,[Bench_Apex]
           ,[Bench_PY Apex]
           ,[Line_Total]
           ,[Floor_Total]
           ,[Bench_Total])
     VALUES
           (@PlotName,
		    @HouseTypeId,			
			@LineExt,
			@LineINIL,
			@LinePY,
			@FloorFC,
			@FloorBarges,
			@FloorMaterials,
			@FloorLoading,
			@BenchApex,
			@BenchPYApex,
			@LineTot,
			@FloorTot,
			@BenchTot)

			SELECT SCOPE_IDENTITY()
	END
	ELSE
	BEGIN
		UPDATE [dbo].[Plots]
	   SET [PlotName] = @PlotName
	      ,[HouseTypeID] = @HouseTypeId
		  ,[Line_Ext] = @LineExt
		  ,[Line_IN & IL] = @LineINIL
		  ,[Line_PY] = @LinePY
		  ,[Floor_F/C] = @FloorFC
		  ,[Floor_Barges] = @FloorBarges
		  ,[Floor_Materials] = @FloorMaterials
		  ,[Floor_Loading] = @FloorLoading
		  ,[Bench_Apex] = @BenchApex
		  ,[Bench_PY Apex] = @BenchPYApex
		  ,[Line_Total] = @LineTot
		  ,[Floor_Total] = @FloorTot
		  ,[Bench_Total] = @BenchTot
	 WHERE PlotId = @PlotId

	 SELECT @PlotId
	END
	
	
END

GO
USE [master]
GO
ALTER DATABASE [LeadonTimberframe] SET  READ_WRITE 
GO
