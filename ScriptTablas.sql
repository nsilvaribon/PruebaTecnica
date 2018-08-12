USE [Administracion]
GO

/****** Object:  Table [dbo].[Usuarios]    Script Date: 08/12/2018 18:28:29 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Usuarios](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[NombreCompleto] [varchar](100) NOT NULL,
	[Direccion] [varchar](100) NOT NULL,
	[FechaNacimiento] [datetime] NOT NULL,
	[TipoDocumento] [int] NOT NULL,
	[NumeroDocumento] [varchar](20) NOT NULL,
	[Pais] [varchar](100) NOT NULL,
	[Departamento] [varchar](100) NOT NULL,
	[Ciudad] [varchar](100) NOT NULL,
 CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


USE [Administracion]
GO

/****** Object:  Table [dbo].[TiposDocumento]    Script Date: 08/12/2018 18:28:39 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[TiposDocumento](
	[Id] [int] NOT NULL,
	[TipoDocumento] [varchar](100) NOT NULL,
 CONSTRAINT [PK_TiposDocumento] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

