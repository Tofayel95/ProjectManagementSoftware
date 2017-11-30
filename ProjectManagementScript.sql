USE [master]
GO

/****** Object:  Database [ProjectManagementTool]    Script Date: 11/30/2017 6:00:54 PM ******/
CREATE DATABASE [ProjectManagementTool]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ProjectManagementTool', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\ProjectManagementTool.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'ProjectManagementTool_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\ProjectManagementTool_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO

ALTER DATABASE [ProjectManagementTool] SET COMPATIBILITY_LEVEL = 120
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ProjectManagementTool].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [ProjectManagementTool] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [ProjectManagementTool] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [ProjectManagementTool] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [ProjectManagementTool] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [ProjectManagementTool] SET ARITHABORT OFF 
GO

ALTER DATABASE [ProjectManagementTool] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [ProjectManagementTool] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [ProjectManagementTool] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [ProjectManagementTool] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [ProjectManagementTool] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [ProjectManagementTool] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [ProjectManagementTool] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [ProjectManagementTool] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [ProjectManagementTool] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [ProjectManagementTool] SET  DISABLE_BROKER 
GO

ALTER DATABASE [ProjectManagementTool] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [ProjectManagementTool] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [ProjectManagementTool] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [ProjectManagementTool] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [ProjectManagementTool] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [ProjectManagementTool] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [ProjectManagementTool] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [ProjectManagementTool] SET RECOVERY FULL 
GO

ALTER DATABASE [ProjectManagementTool] SET  MULTI_USER 
GO

ALTER DATABASE [ProjectManagementTool] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [ProjectManagementTool] SET DB_CHAINING OFF 
GO

ALTER DATABASE [ProjectManagementTool] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [ProjectManagementTool] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO

ALTER DATABASE [ProjectManagementTool] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [ProjectManagementTool] SET  READ_WRITE 
GO
