USE [master]

DROP DATABASE [ASU_DATA]
GO

/****** Object:  Database [ASU_DATA]    Script Date: 22.05.2020 19:22:17 ******/
CREATE DATABASE [ASU_DATA]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ASU_DATA', FILENAME = N'C:\Users\asker\ASU_DATA.mdf' , SIZE = 73728KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ASU_DATA_log', FILENAME = N'C:\Users\asker\ASU_DATA.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ASU_DATA].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [ASU_DATA] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [ASU_DATA] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [ASU_DATA] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [ASU_DATA] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [ASU_DATA] SET ARITHABORT OFF 
GO

ALTER DATABASE [ASU_DATA] SET AUTO_CLOSE ON 
GO

ALTER DATABASE [ASU_DATA] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [ASU_DATA] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [ASU_DATA] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [ASU_DATA] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [ASU_DATA] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [ASU_DATA] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [ASU_DATA] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [ASU_DATA] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [ASU_DATA] SET  DISABLE_BROKER 
GO

ALTER DATABASE [ASU_DATA] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [ASU_DATA] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [ASU_DATA] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [ASU_DATA] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [ASU_DATA] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [ASU_DATA] SET READ_COMMITTED_SNAPSHOT ON 
GO

ALTER DATABASE [ASU_DATA] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [ASU_DATA] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [ASU_DATA] SET  MULTI_USER 
GO

ALTER DATABASE [ASU_DATA] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [ASU_DATA] SET DB_CHAINING OFF 
GO

ALTER DATABASE [ASU_DATA] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [ASU_DATA] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [ASU_DATA] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [ASU_DATA] SET QUERY_STORE = OFF
GO

USE [ASU_DATA]
GO


ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO

ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO

ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO

ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO

ALTER DATABASE [ASU_DATA] SET  READ_WRITE 
GO

/****** Object:  Table [dbo].[Lot]    Script Date: 22.05.2020 19:28:57 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Lot](
	[LotId] [bigint] IDENTITY(1,1) NOT NULL,
	[LotTypeId] [nvarchar](5) NULL,
	[ParentId] [bigint] NULL,
	[MarkSymbolId] [int] NULL,
	[QTY] [int] NULL,
	[Description] [nvarchar](250) NULL,
	[CreateDate] [datetime] NOT NULL,
	[ManufacturingDate] [nvarchar](60) NULL,
	[PrefixNumber] [nvarchar](15) NULL,
	[Number] [bigint] NULL,
	[SuffixNumber] [nvarchar](20) NULL,
	[PartNumber] [nvarchar](150) NULL,
	[Summary] [nvarchar](max) NULL,
	[ProductNumbers] [nvarchar](1024) NULL,
	[WareId] [bigint] NULL,
 CONSTRAINT [PK_LOT] PRIMARY KEY CLUSTERED 
(
	[LotId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO


GO
SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON


CREATE TABLE [dbo].[Wares](
	[WareId] [bigint] IDENTITY(1,1) NOT NULL,
	[ContractId] [bigint] NOT NULL,
	[UserId] [uniqueidentifier] NOT NULL,
	[ClassId] [bigint] NOT NULL,
	[ManufactoryId] [bigint] NOT NULL,
	[TypeNominal] [nvarchar](128) NOT NULL,
	[Decoding] [nvarchar](128) NULL,
	[StatementDate] [datetime] NULL,
	[TU1] [nvarchar](30) NULL,
	[TU2] [nvarchar](30) NULL,
	[QTY] [int] NOT NULL,
	[TypeRepresentative] [bit] NOT NULL,
	
 CONSTRAINT [PK_WARES] PRIMARY KEY CLUSTERED 
(
	[WareId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] 

GO


ALTER TABLE [dbo].[Lot]  WITH CHECK ADD  CONSTRAINT [FK_Lot_Wares] FOREIGN KEY([WareId])
REFERENCES [dbo].[Wares] ([WareId])
GO

ALTER TABLE [dbo].[Lot] CHECK CONSTRAINT [FK_Lot_Wares]
GO
begin 
-- SET IDENTITY_INSERT to ON.  

SET IDENTITY_INSERT dbo.[Wares] ON;  
INSERT INTO [dbo].[Wares]
           ([WareId],
		   [ContractId]
           ,[UserId]
           ,[ClassId]
           ,[ManufactoryId]
           ,[TypeNominal]
           ,[Decoding]
           ,[StatementDate]
           ,[TU1]
           ,[TU2]
           ,[QTY]
           ,[TypeRepresentative]
           )
SELECT [WareId]
      ,[ContractId]
      ,[UserId]
      ,[ClassId]
      ,[ManufactoryId]
      ,[TypeNominal]
      ,[Decoding]
      ,[StatementDate]
      ,[TU1]
      ,[TU2]
      ,[QTY]
      ,[TypeRepresentative]
  FROM [Asulive].[dbo].[Wares]

  

SET IDENTITY_INSERT dbo.[Wares] off;

SET IDENTITY_INSERT dbo.lot ON;  


INSERT INTO [dbo].[Lot]
           ([LotID],[LotTypeId]
           ,[ParentId]
           ,[MarkSymbolId]
           ,[QTY]
           ,[Description]
           ,[CreateDate]
           ,[ManufacturingDate]
           ,[PrefixNumber]
           ,[Number]
           ,[SuffixNumber]
           ,[PartNumber]
           ,[Summary]
           ,[ProductNumbers]
        
           ,[WareId]
         )
SELECT
[LotID]
	,[LotTypeId]
      ,[ParentId]
      ,[MarkSymbolId]
      ,[QTY]
      ,[Description]
      ,[CreateDate]
      ,[ManufacturingDate]
      ,[PrefixNumber]
      ,[Number]
      ,[SuffixNumber]
      ,[PartNumber]
      ,[Summary]
      ,[ProductNumbers]
      ,[WareId]
  FROM [Asulive].[dbo].[Lot]


SET IDENTITY_INSERT dbo.lot off

 SET ANSI_PADDING ON
CREATE NONCLUSTERED INDEX [NonClusteredIndex-20200522-200001] ON [dbo].[Wares]
(
	[TypeNominal] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)

end 

--браки

CREATE TABLE [dbo].[Defect](
	[DefectId] [bigint] IDENTITY(1,1) NOT NULL,
	[DefectTypeId] [bigint] NULL,
	[Description] [nvarchar](500) NULL,
	[TU] [bit] NOT NULL,
	[Unrecommend] [bit] NOT NULL,
	[RFA] [bit] NOT NULL,
	[RouteOperationId] [bigint] NULL,
	[ProductNumbers] [nvarchar](1024) NULL,
	[DefectCount] [bigint] NULL,
 CONSTRAINT [PK_DEFECT] PRIMARY KEY CLUSTERED 
(
	[DefectId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

/****** Object:  Table [dbo].[RouteOperation]    Script Date: 09.08.2020 21:47:09 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[RouteOperation](
	[RouteOperationId] [bigint] IDENTITY(1,1) NOT NULL,
	[LotId] [bigint] NOT NULL,
	
 CONSTRAINT [PK_ROUTEOPERATION] PRIMARY KEY CLUSTERED 
(
	[RouteOperationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] 
GO


--Заполняем браки 


INSERT INTO [dbo].[Defect]
           ([DefectTypeId]
           ,[Description]
           ,[TU]
           ,[Unrecommend]
           ,[RFA]
           ,[RouteOperationId]
           ,[ProductNumbers]
           ,[DefectCount])
Select [DefectTypeId]
           ,[Description]
           ,[TU]
           ,[Unrecommend]
           ,[RFA]
           ,[RouteOperationId]
           ,[ProductNumbers]
           ,[DefectCount]
		   from Asulive.dbo.Defect


go
SET IDENTITY_INSERT dbo.[RouteOperation] on

Insert into [RouteOperation]([RouteOperationId],[LotId])
select distinct r.[RouteOperationId],[LotId] from Asulive.dbo.RouteOperation r, Asulive.dbo.Defect d
where d.RouteOperationId= r.RouteOperationId 
 
SET IDENTITY_INSERT dbo.[RouteOperation] Off
go 

ALTER TABLE [dbo].[RouteOperation]  WITH CHECK ADD  CONSTRAINT [FK_ROUTEOPE_ROUTE_ROU_LOT] FOREIGN KEY([LotId])
REFERENCES [dbo].[Lot] ([LotId])
ON DELETE CASCADE
GO



ALTER TABLE [dbo].[Defect]  WITH CHECK ADD  CONSTRAINT [FK_Defect_RouteOperation] FOREIGN KEY([RouteOperationId])
REFERENCES [dbo].[RouteOperation] ([RouteOperationId])
ON DELETE CASCADE
GO


ALTER TABLE [dbo].[Defect] CHECK CONSTRAINT [FK_Defect_RouteOperation]
GO
