USE [WnFormsCliente]
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 30/09/2022 12:58:08 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clientes](
	[idCliente] [int] IDENTITY(1,1) NOT NULL,
	[Nombres] [varchar](50) NOT NULL,
	[Apellidos] [varchar](50) NOT NULL,
	[Direccion] [nvarchar](50) NULL,
 CONSTRAINT [PK_Clientes] PRIMARY KEY CLUSTERED 
(
	[idCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Clientes] ON 

INSERT [dbo].[Clientes] ([idCliente], [Nombres], [Apellidos], [Direccion]) VALUES (1, N'Angel Camilo', N'Arias Correcha', N'Mz 3 casa 23 Praderas')
INSERT [dbo].[Clientes] ([idCliente], [Nombres], [Apellidos], [Direccion]) VALUES (2, N'Paola Andreaa', N'Sabogal Rojas', N'Casa 15 piso 2 llanos grandes')
INSERT [dbo].[Clientes] ([idCliente], [Nombres], [Apellidos], [Direccion]) VALUES (7, N'Jaime Andres', N'Rojas Mejia', N'cll4 #456 Centro')
INSERT [dbo].[Clientes] ([idCliente], [Nombres], [Apellidos], [Direccion]) VALUES (8, N'Karol sofia', N'Parra Alvarez', N'Carr 5 #897 B/ Alcala')
INSERT [dbo].[Clientes] ([idCliente], [Nombres], [Apellidos], [Direccion]) VALUES (9, N'Carlos Andres', N'Perez Aragon', N'Autopista 23 #4553')
SET IDENTITY_INSERT [dbo].[Clientes] OFF
GO
