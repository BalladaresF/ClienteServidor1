USE [master]
GO

CREATE DATABASE [RENTAUNED]
 GO
 
USE [RENTAUNED]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Sucursal](
	[IdSucursal] [int] NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Direccion] [varchar](255) NOT NULL,
	[Estado] [bit] NOT NULL,
	[Telefono] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Sucursal] PRIMARY KEY CLUSTERED 
(
	[IdSucursal] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Cliente](
	[IdCliente] [varchar](10) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[PrimerApellido] [varchar](255) NOT NULL,
	[SegundoApellido] [varchar](255) NOT NULL,
	[FechaNacimiento] [datetime] NOT NULL,
	[Genero] [varchar](1) NOT NULL,
 CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED 
(
	[IdCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoVehiculo](
	[IdTipo] [int] NOT NULL,
	[Descripcion] [varchar](50) NOT NULL,
	[Estado] [bit] NOT NULL,
 CONSTRAINT [PK_TipoVehiculo] PRIMARY KEY CLUSTERED 
(
	[IdTipo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Vehiculo](
	[IdPlaca] [varchar](10) NOT NULL,
	[Marca] [varchar](50) NOT NULL,
	[Modelo] [varchar](50) NOT NULL,
	[IdTipoVehiculo] [int] NOT NULL,
	[CostoAlquilerDia] [int] NOT NULL,
	[Kilometraje] [int] NOT NULL,
 CONSTRAINT [PK_Vehiculo] PRIMARY KEY CLUSTERED 
(
	[IdPlaca] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Vehiculo]  WITH CHECK ADD  CONSTRAINT [FK_Vehiculo_TipoVehiculo] FOREIGN KEY([IdTipoVehiculo])
REFERENCES [dbo].[TipoVehiculo] ([IdTipo])
GO

ALTER TABLE [dbo].[Vehiculo] CHECK CONSTRAINT [FK_Vehiculo_TipoVehiculo]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[VehiculoSucursal](
	[IdAsignacion] [int] NOT NULL,
	[IdSucursal] [int] NOT NULL,
	[IdPlaca] [varchar](10) NOT NULL,
	[FechaAsignacion] [datetime] NOT NULL,
 CONSTRAINT [PK_VehiculoSucursal] PRIMARY KEY CLUSTERED 
(
	[IdAsignacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[VehiculoSucursal]  WITH CHECK ADD  CONSTRAINT [FK_VehiculoSucursal_Sucursal] FOREIGN KEY([IdSucursal])
REFERENCES [dbo].[Sucursal] ([IdSucursal])
GO

ALTER TABLE [dbo].[VehiculoSucursal] CHECK CONSTRAINT [FK_VehiculoSucursal_Sucursal]
GO

ALTER TABLE [dbo].[VehiculoSucursal]  WITH CHECK ADD  CONSTRAINT [FK_VehiculoSucursal_Vehiculo] FOREIGN KEY([IdPlaca])
REFERENCES [dbo].[Vehiculo] ([IdPlaca])
GO

ALTER TABLE [dbo].[VehiculoSucursal] CHECK CONSTRAINT [FK_VehiculoSucursal_Vehiculo]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[CoberturaSeguro](
	[IdCobertura] [int] NOT NULL,
	[Descripcion] [varchar](50) NOT NULL,
	[IdTipoVehiculo] [int] NOT NULL,
	[Estado] [bit] NOT NULL,
	[Monto] [int] NOT NULL,
 CONSTRAINT [PK_CoberturaSeguro] PRIMARY KEY CLUSTERED 
(
	[IdCobertura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[CoberturaSeguro]  WITH CHECK ADD  CONSTRAINT [FK_CoberturaSeguro_TipoVehiculo] FOREIGN KEY([IdTipoVehiculo])
REFERENCES [dbo].[TipoVehiculo] ([IdTipo])
GO

ALTER TABLE [dbo].[CoberturaSeguro] CHECK CONSTRAINT [FK_CoberturaSeguro_TipoVehiculo]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Reserva](
	[IdReserva] [int] NOT NULL,
	[IdCliente] [varchar](10) NULL,
	[IdPlaca] [varchar](10) NULL,
	[FechaReserva] [datetime] NULL,
	[FechaInicio] [datetime] NULL,
	[FechaFin] [datetime] NULL,
	[MontoReserva] [int] NULL,
 CONSTRAINT [PK_Reserva] PRIMARY KEY CLUSTERED 
(
	[IdReserva] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Reserva]  WITH CHECK ADD  CONSTRAINT [FK_Reserva_Cliente] FOREIGN KEY([IdCliente])
REFERENCES [dbo].[Cliente] ([IdCliente])
GO

ALTER TABLE [dbo].[Reserva] CHECK CONSTRAINT [FK_Reserva_Cliente]
GO

ALTER TABLE [dbo].[Reserva]  WITH CHECK ADD  CONSTRAINT [FK_Reserva_Vehiculo] FOREIGN KEY([IdPlaca])
REFERENCES [dbo].[Vehiculo] ([IdPlaca])
GO

ALTER TABLE [dbo].[Reserva] CHECK CONSTRAINT [FK_Reserva_Vehiculo]
GO

