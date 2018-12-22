
/****** Object:  Database [ProyectoPR5]    Script Date: 21/12/2018 10:52:02 ******/
CREATE DATABASE [ProyectoPR5]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ProyectoPR5', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\ProyectoPR5.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ProyectoPR5_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\ProyectoPR5_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
USE [ProyectoPR5]
GO
ALTER DATABASE [ProyectoPR5] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ProyectoPR5].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ProyectoPR5] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ProyectoPR5] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ProyectoPR5] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ProyectoPR5] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ProyectoPR5] SET ARITHABORT OFF 
GO
ALTER DATABASE [ProyectoPR5] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ProyectoPR5] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ProyectoPR5] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ProyectoPR5] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ProyectoPR5] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ProyectoPR5] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ProyectoPR5] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ProyectoPR5] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ProyectoPR5] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ProyectoPR5] SET  ENABLE_BROKER 
GO
ALTER DATABASE [ProyectoPR5] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ProyectoPR5] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ProyectoPR5] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ProyectoPR5] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ProyectoPR5] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ProyectoPR5] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ProyectoPR5] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ProyectoPR5] SET RECOVERY FULL 
GO
ALTER DATABASE [ProyectoPR5] SET  MULTI_USER 
GO
ALTER DATABASE [ProyectoPR5] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ProyectoPR5] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ProyectoPR5] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ProyectoPR5] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ProyectoPR5] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'ProyectoPR5', N'ON'
GO
ALTER DATABASE [ProyectoPR5] SET QUERY_STORE = OFF
GO
USE [ProyectoPR5]
GO
ALTER DATABASE SCOPED CONFIGURATION SET IDENTITY_CACHE = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [ProyectoPR5]
GO
/****** Object:  Table [dbo].[artCustodia]    Script Date: 21/12/2018 10:52:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[artCustodia](
	[idArticuloCus] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](20) NULL,
	[idCategoria] [int] NULL,
	[FechaIngreso] [datetime] NULL,
	[descripcion] [varchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[idArticuloCus] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[artEntregados]    Script Date: 21/12/2018 10:52:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[artEntregados](
	[idArticuloEnt] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](20) NULL,
	[idCategoria] [int] NULL,
	[FechaIngreso] [datetime] NULL,
	[descripcion] [varchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[idArticuloEnt] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[artEstraviados]    Script Date: 21/12/2018 10:52:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE TABLE [dbo].[artEstraviados](
	[idArticuloExt] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](20) NULL,
	[idCategoria] [int] NULL,
	[FechaIngreso] [datetime] NULL,
	[descripcion] [varchar](200) NULL,
	[IngresadoPor] [varchar](200) NULL,
	[Telefono Contacto] [int] NULL
PRIMARY KEY CLUSTERED 
(
	[idArticuloExt] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categoria]    Script Date: 21/12/2018 10:52:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categoria](
	[idCategoria] [int] IDENTITY(1,1) NOT NULL,
	[nombreCategoria] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[idCategoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 21/12/2018 10:52:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[idUsuario] [int] IDENTITY(1,1) NOT NULL,
	[cedula] [varchar](20) NULL,
	[pass] [varchar](20) NULL,
	[idRol] [int] NULL,
	[nombre] [varchar](100) NULL,
	[telefono] [int] NULL,
	[correo] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[idUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[artCustodia]  WITH CHECK ADD FOREIGN KEY([idCategoria])
REFERENCES [dbo].[Categoria] ([idCategoria])
GO
ALTER TABLE [dbo].[artEntregados]  WITH CHECK ADD FOREIGN KEY([idCategoria])
REFERENCES [dbo].[Categoria] ([idCategoria])
GO
ALTER TABLE [dbo].[artEstraviados]  WITH CHECK ADD FOREIGN KEY([idCategoria])
REFERENCES [dbo].[Categoria] ([idCategoria])
GO
ALTER DATABASE [ProyectoPR5] SET  READ_WRITE 
GO


------------------------Trigger---------------------------------------------------
CREATE TRIGGER tr1 ON artCustodia
AFTER delete
AS
	declare @PidCate int;
	declare @PNombre varchar(500);
	declare @des varchar(500);

	

	select @PidCate=i.idCategoria from deleted i;	
	select @PNombre=i.nombre from Deleted i;
	select @des=i.descripcion from Deleted i;
	
	
insert into artEntregados(nombre,idCategoria,FechaIngreso,descripcion) values(@PNombre,@PidCate,getdate(),@des);

	


GO
USE [ProyectoPR5]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO
--------------------------Trigger 2--------------------------------------------------------
CREATE TRIGGER tr2 ON artCustodia
AFTER insert
AS

		declare @idInsertado int;
		select @idInsertado=i.idArticuloCus from inserted i;
	
update artCustodia set FechaIngreso=getdate() where idArticuloCus=@idInsertado;

	


GO
USE [ProyectoPR5]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

---------------------------------Trigger 3---------------------------------------------------------------------------------

CREATE TRIGGER tr3 ON artEstraviados
AFTER insert
AS

		declare @idInsertado int;
		select @idInsertado=i.idArticuloExt from inserted i;
	
update artEstraviados set FechaIngreso=getdate() where idArticuloExt=@idInsertado;

	


GO
USE [ProyectoPR5]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO



-----------------------------------------------Trigger 4-------------------------------------------------------------------
CREATE TRIGGER tr4 ON artEstraviados
AFTER delete
AS
	declare @PidCate int;
	declare @PNombre varchar(500);
	declare @des varchar(500);

	

	select @PidCate=i.idCategoria from deleted i;	
	select @PNombre=i.nombre from Deleted i;
	select @des=i.descripcion from Deleted i;
	
	
insert into artCustodia(nombre,idCategoria,FechaIngreso,descripcion) values(@PNombre,@PidCate,getdate(),@des);

	


GO
USE [ProyectoPR5]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO





------------------------------------------------------------------------------------------------------------------

-----------Inserts Iniciales
insert into Usuarios(cedula,correo,idRol,nombre,pass,telefono) values(5525,'Fake@fake.com',0,'Administrador','5525',00000000);
insert into Categoria values('Otros');





