
/****** Object:  Table [dbo].[PEDIDO_DETALLE]    Script Date: 19/02/2024 5:25:40 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PEDIDO_DETALLE](
	[CLIENTE_ID] [decimal](18, 0) NULL,
	[PRODUCT_ID] [int] NULL,
	[CANTIDAD] [int] NULL,
	[PRECIO_INDIVIDUAL] [money] NULL,
	[PRECIO]  AS ([CANTIDAD]*[PRECIO_INDIVIDUAL])
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PEDIDOS]    Script Date: 19/02/2024 5:25:40 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PEDIDOS](
	[PEDIDOSID] [int] IDENTITY(1,1) NOT NULL,
	[CLIENTE_ID] [decimal](18, 0) NULL,
	[TOTAL] [money] NULL,
	[ENTREGA] [varchar](200) NULL,
	[ES_ENTREGADO] [bit] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PRODUCT]    Script Date: 19/02/2024 5:25:40 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PRODUCT](
	[PRODUCTNAME] [varchar](200) NULL,
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[STOCK] [int] NULL,
	[PRECIO] [money] NULL,
	[CATEGORIA] [varchar](200) NULL,
	[IMAGEN] [varchar](200) NULL,
	[MARCA] [varchar](200) NULL,
	[GENERO] [varchar](200) NULL,
 CONSTRAINT [PK_PRODUCT] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UMUSER]    Script Date: 19/02/2024 5:25:40 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UMUSER](
	[USERNAME] [varchar](200) NULL,
	[EMAIL] [varchar](200) NULL,
	[PASSWORD] [varchar](200) NULL,
	[ID] [decimal](18, 0) NOT NULL,
 CONSTRAINT [PK_UMUSER] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[PRODUCT] ON 
GO
INSERT [dbo].[PRODUCT] ([PRODUCTNAME], [ID], [STOCK], [PRECIO], [CATEGORIA], [IMAGEN], [MARCA], [GENERO]) VALUES (N'Forum CL Corte Bajo', 4, 20, 55.5600, N'Oferta', N'~/imagenes/Principal/collecion/Hombres/zapato_0016s_0001_FORUM-CL-CORTE-BAJO.png', N'Adidas', N'Masculino')
GO
INSERT [dbo].[PRODUCT] ([PRODUCTNAME], [ID], [STOCK], [PRECIO], [CATEGORIA], [IMAGEN], [MARCA], [GENERO]) VALUES (N'Men''s Blazer', 5, 5, 67.9800, N'Nuevo', N'~/imagenes/Principal/collecion/Hombres/zapato_0012s_0000_Capa-2.png', N'Nike', N'Hombre')
GO
INSERT [dbo].[PRODUCT] ([PRODUCTNAME], [ID], [STOCK], [PRECIO], [CATEGORIA], [IMAGEN], [MARCA], [GENERO]) VALUES (N'Air Jordan 6 Retro', 6, 2, 34.2000, N'Oferta', N'~/imagenes/Principal/collecion/mujeres/zapato_0006s_0000_Air-jordan-6-retro.png', N'NIKE', N'Mujer')
GO
INSERT [dbo].[PRODUCT] ([PRODUCTNAME], [ID], [STOCK], [PRECIO], [CATEGORIA], [IMAGEN], [MARCA], [GENERO]) VALUES (N'One Star Pro Suede', 7, 4, 56.8000, N'Más vendido', N'~/imagenes/Principal/collecion/Hombres/zapato_0014s_0000_One-star-pro-suede.png', N'Adidas', N'Hombre')
GO
INSERT [dbo].[PRODUCT] ([PRODUCTNAME], [ID], [STOCK], [PRECIO], [CATEGORIA], [IMAGEN], [MARCA], [GENERO]) VALUES (N'Old Skool V Dream', 8, 3, 12.4000, N'Oferta', N'~/imagenes/Principal/collecion/ninos/zapato_0001s_0000_old-skool-v-dream.png', N'Vans', N'Niño')
GO
INSERT [dbo].[PRODUCT] ([PRODUCTNAME], [ID], [STOCK], [PRECIO], [CATEGORIA], [IMAGEN], [MARCA], [GENERO]) VALUES (N'Duramo SL 2.0', 9, 10, 90.5000, N'Oferta', N'~/imagenes/Principal/collecion/mujeres/zapato_0011s_0002_Duramo-sl-2.0.png', N'Adidas', N'Mujer')
GO
INSERT [dbo].[PRODUCT] ([PRODUCTNAME], [ID], [STOCK], [PRECIO], [CATEGORIA], [IMAGEN], [MARCA], [GENERO]) VALUES (N'Superstar', 10, 5, 45.6700, N'Nuevo', N'~/imagenes/Principal/collecion/Hombres/zapato_0016s_0000_SUPERSTAR.png', N'Adidas', N'Hombre')
GO
INSERT [dbo].[PRODUCT] ([PRODUCTNAME], [ID], [STOCK], [PRECIO], [CATEGORIA], [IMAGEN], [MARCA], [GENERO]) VALUES (N'574 V2', 11, 12, 68.3400, N'Más vendido', N'~/imagenes/Principal/collecion/mujeres/zapato_0009s_0000_574.png', N'New Balance', N'Mujer')
GO
INSERT [dbo].[PRODUCT] ([PRODUCTNAME], [ID], [STOCK], [PRECIO], [CATEGORIA], [IMAGEN], [MARCA], [GENERO]) VALUES (N'Air Force 1 LV8', 12, 9, 420.4500, N'Oferta', N'~/imagenes/Principal/collecion/mujeres/zapato_0006s_0004_Air-force-1-LV8.png', N'Nike', N'Hombre')
GO
INSERT [dbo].[PRODUCT] ([PRODUCTNAME], [ID], [STOCK], [PRECIO], [CATEGORIA], [IMAGEN], [MARCA], [GENERO]) VALUES (N'Pro Blaze Strap', 13, 4, 69.4200, N'Nuevo', N'~/imagenes/Principal/collecion/ninos/zapato_0000s_0001_Pro-Blaze-Strap.png', N'Converse', N'Niño')
GO
INSERT [dbo].[PRODUCT] ([PRODUCTNAME], [ID], [STOCK], [PRECIO], [CATEGORIA], [IMAGEN], [MARCA], [GENERO]) VALUES (N'Forum CL Corte Bajo', 14, 20, 78.5600, N'Oferta', N'~/imagenes/Principal/collecion/Hombres/zapato_0016s_0001_FORUM-CL-CORTE-BAJO.png', N'Adidas', N'Hombre')
GO
INSERT [dbo].[PRODUCT] ([PRODUCTNAME], [ID], [STOCK], [PRECIO], [CATEGORIA], [IMAGEN], [MARCA], [GENERO]) VALUES (N'Nucleus', 15, 20, 70.0000, N'Nuevo', N'~/imagenes/Principal/collecion/Hombres/zapato_0012s_0001_Nucleus.png', N'Puma', N'Hombre')
GO
INSERT [dbo].[PRODUCT] ([PRODUCTNAME], [ID], [STOCK], [PRECIO], [CATEGORIA], [IMAGEN], [MARCA], [GENERO]) VALUES (N'DISRUPTOR II PREMIUM', 16, 21, 59.9500, N'Oferta', N'~/imagenes/Principal/collecion/Hombres/zapato_0013s_0000_DISRUPTOR-II-PREMIUM.png', N'Fila', N'Hombre')
GO
INSERT [dbo].[PRODUCT] ([PRODUCTNAME], [ID], [STOCK], [PRECIO], [CATEGORIA], [IMAGEN], [MARCA], [GENERO]) VALUES (N'GRANT HILL 2 25TH ANNIVERSARY', 17, 22, 75.0000, N'Oferta', N'~/imagenes/Principal/collecion/Hombres/zapato_0013s_0001_GRANT-HILL-2-25TH-ANNIVERSARY.png', N'Fila', N'Hombre')
GO
INSERT [dbo].[PRODUCT] ([PRODUCTNAME], [ID], [STOCK], [PRECIO], [CATEGORIA], [IMAGEN], [MARCA], [GENERO]) VALUES (N'Chuck Taylor all star classic', 18, 7, 75.0000, N'Más vendido', N'~/imagenes/Principal/collecion/Hombres/zapato_0014s_0001_Chuck-Taylor-all-star-classic.png', N'Converse', N'Hombre')
GO
INSERT [dbo].[PRODUCT] ([PRODUCTNAME], [ID], [STOCK], [PRECIO], [CATEGORIA], [IMAGEN], [MARCA], [GENERO]) VALUES (N'Clasicos negros slip on checkerboard ns', 19, 8, 40.0000, N'Más vendido', N'~/imagenes/Principal/collecion/Hombres/zapato_0015s_0000_Clasicos-negros-slip-on-checkerboard-ns-.png', N'Vans', N'Hombre')
GO
INSERT [dbo].[PRODUCT] ([PRODUCTNAME], [ID], [STOCK], [PRECIO], [CATEGORIA], [IMAGEN], [MARCA], [GENERO]) VALUES (N'Rufalcon', 20, 9, 36.5000, N'Más vendido', N'~/imagenes/Principal/collecion/Hombres/zapato_0016s_0002_Rufalcon.png', N'Adidas', N'Hombre')
GO
INSERT [dbo].[PRODUCT] ([PRODUCTNAME], [ID], [STOCK], [PRECIO], [CATEGORIA], [IMAGEN], [MARCA], [GENERO]) VALUES (N'Basketball kawhi 2', 21, 10, 159.9900, N'Nuevo', N'~/imagenes/Principal/collecion/Hombres/zapato_0017s_0000_Basketball-kawhi-2.png', N'NewBalance', N'Hombre')
GO
INSERT [dbo].[PRODUCT] ([PRODUCTNAME], [ID], [STOCK], [PRECIO], [CATEGORIA], [IMAGEN], [MARCA], [GENERO]) VALUES (N'515', 22, 11, 100.9800, N'Nuevo', N'~/imagenes/Principal/collecion/Hombres/zapato_0017s_0001_515.png', N'NewBalance', N'Hombre')
GO
INSERT [dbo].[PRODUCT] ([PRODUCTNAME], [ID], [STOCK], [PRECIO], [CATEGORIA], [IMAGEN], [MARCA], [GENERO]) VALUES (N'574', 23, 11, 89.9900, N'Nuevo', N'~/imagenes/Principal/collecion/Hombres/zapato_0017s_0002_574.png', N'NewBalance', N'Hombre')
GO
INSERT [dbo].[PRODUCT] ([PRODUCTNAME], [ID], [STOCK], [PRECIO], [CATEGORIA], [IMAGEN], [MARCA], [GENERO]) VALUES (N'9060', 24, 11, 149.9900, N'Nuevo', N'~/imagenes/Principal/collecion/Hombres/zapato_0017s_0003_9060.png', N'NewBalance', N'Hombre')
GO
INSERT [dbo].[PRODUCT] ([PRODUCTNAME], [ID], [STOCK], [PRECIO], [CATEGORIA], [IMAGEN], [MARCA], [GENERO]) VALUES (N'Fresh foam roav v2', 25, 11, 71.5000, N'Oferta', N'~/imagenes/Principal/collecion/Hombres/zapato_0017s_0004_Fresh-foam-roav-v2.png', N'NewBalance', N'Hombre')
GO
INSERT [dbo].[PRODUCT] ([PRODUCTNAME], [ID], [STOCK], [PRECIO], [CATEGORIA], [IMAGEN], [MARCA], [GENERO]) VALUES (N'Zoomx Streakfly', 26, 12, 105.8000, N'Oferta', N'~/imagenes/Principal/collecion/Hombres/zapato_0018s_0000_Zoomx-Streakfly.png', N'Nike', N'Hombre')
GO
INSERT [dbo].[PRODUCT] ([PRODUCTNAME], [ID], [STOCK], [PRECIO], [CATEGORIA], [IMAGEN], [MARCA], [GENERO]) VALUES (N'Nike Zapatillas Air Zoom Pegasus 38', 27, 13, 105.9000, N'Oferta', N'~/imagenes/Principal/collecion/Hombres/zapato_0018s_0001_Capa-1.png', N'Nike', N'Hombre')
GO
INSERT [dbo].[PRODUCT] ([PRODUCTNAME], [ID], [STOCK], [PRECIO], [CATEGORIA], [IMAGEN], [MARCA], [GENERO]) VALUES (N'Blazer Low''77 jumbo', 28, 14, 33.2500, N'Oferta', N'~/imagenes/Principal/collecion/Hombres/zapato_0018s_0002_Blazer-Low''77-jumbo.png', N'Nike', N'Hombre')
GO
INSERT [dbo].[PRODUCT] ([PRODUCTNAME], [ID], [STOCK], [PRECIO], [CATEGORIA], [IMAGEN], [MARCA], [GENERO]) VALUES (N'Nike Blazer Mid ''77 Vintage', 29, 15, 100.2500, N'Nuevo', N'~/imagenes/Principal/collecion/Hombres/zapato_0018s_0003_Nike-Blazer-Mid-''77-Vintage-100usd.png', N'Nike', N'Hombre')
GO
INSERT [dbo].[PRODUCT] ([PRODUCTNAME], [ID], [STOCK], [PRECIO], [CATEGORIA], [IMAGEN], [MARCA], [GENERO]) VALUES (N'Run Star Hike Platform Embroidered Crystals', 30, 15, 110.5000, N'Nuevo', N'~/imagenes/Principal/collecion/mujeres/zapato_0005s_0000_Run-Star-Hike-Platform-Embroidered-Crystals.png', N'Converse', N'Mujer')
GO
INSERT [dbo].[PRODUCT] ([PRODUCTNAME], [ID], [STOCK], [PRECIO], [CATEGORIA], [IMAGEN], [MARCA], [GENERO]) VALUES (N'Chuck Taylor All Star Desert Floral ', 31, 16, 80.0000, N'Nuevo', N'~/imagenes/Principal/collecion/mujeres/zapato_0005s_0001_Chuck-Taylor-All-Star-Desert-Floral.png', N'Converse', N'Mujer')
GO
INSERT [dbo].[PRODUCT] ([PRODUCTNAME], [ID], [STOCK], [PRECIO], [CATEGORIA], [IMAGEN], [MARCA], [GENERO]) VALUES (N'Air max 90 toggle se', 32, 17, 63.5000, N'Nuevo', N'~/imagenes/Principal/collecion/mujeres/zapato_0006s_0001_Air-max-90-toggle-se.png', N'Nike', N'Mujer')
GO
INSERT [dbo].[PRODUCT] ([PRODUCTNAME], [ID], [STOCK], [PRECIO], [CATEGORIA], [IMAGEN], [MARCA], [GENERO]) VALUES (N'Air max 270', 33, 18, 63.6000, N'Nuevo', N'~/imagenes/Principal/collecion/mujeres/zapato_0006s_0002_Air-max-270-.png', N'Nike', N'Mujer')
GO
INSERT [dbo].[PRODUCT] ([PRODUCTNAME], [ID], [STOCK], [PRECIO], [CATEGORIA], [IMAGEN], [MARCA], [GENERO]) VALUES (N'Nike flex runner 2 lil', 34, 19, 45.8000, N'Oferta', N'~/imagenes/Principal/collecion/mujeres/zapato_0006s_0003_Nike-flex-runner-2-lil.png', N'Nike', N'Mujer')
GO
INSERT [dbo].[PRODUCT] ([PRODUCTNAME], [ID], [STOCK], [PRECIO], [CATEGORIA], [IMAGEN], [MARCA], [GENERO]) VALUES (N'Air force 1 LV8', 35, 20, 45.9000, N'Oferta', N'~/imagenes/Principal/collecion/mujeres/zapato_0006s_0004_Air-force-1-LV8.png', N'Nike', N'Mujer')
GO
INSERT [dbo].[PRODUCT] ([PRODUCTNAME], [ID], [STOCK], [PRECIO], [CATEGORIA], [IMAGEN], [MARCA], [GENERO]) VALUES (N'Clasicos negros authentic x otw', 36, 21, 45.1000, N'Más vendido', N'~/imagenes/Principal/collecion/mujeres/zapato_0007s_0000_clasicos-negros-authentic-x-otw-gallery-.png', N'Vans', N'Mujer')
GO
INSERT [dbo].[PRODUCT] ([PRODUCTNAME], [ID], [STOCK], [PRECIO], [CATEGORIA], [IMAGEN], [MARCA], [GENERO]) VALUES (N'Clasicos blancos old skool', 37, 22, 45.1100, N'Más vendido', N'~/imagenes/Principal/collecion/mujeres/zapato_0007s_0001_Clasicos-blancos-old-skool-.png', N'Vans', N'Mujer')
GO
INSERT [dbo].[PRODUCT] ([PRODUCTNAME], [ID], [STOCK], [PRECIO], [CATEGORIA], [IMAGEN], [MARCA], [GENERO]) VALUES (N'Trinomic mira inland', 38, 23, 70.5000, N'Más vendido', N'~/imagenes/Principal/collecion/mujeres/zapato_0008s_0000_Trinomic-mira-inland.png', N'Puma', N'Mujer')
GO
INSERT [dbo].[PRODUCT] ([PRODUCTNAME], [ID], [STOCK], [PRECIO], [CATEGORIA], [IMAGEN], [MARCA], [GENERO]) VALUES (N'Rider fv sneakers', 39, 24, 50.5000, N'Más vendido', N'~/imagenes/Principal/collecion/mujeres/zapato_0008s_0001_Rider-fv-sneakers-.png', N'Puma', N'Mujer')
GO
INSERT [dbo].[PRODUCT] ([PRODUCTNAME], [ID], [STOCK], [PRECIO], [CATEGORIA], [IMAGEN], [MARCA], [GENERO]) VALUES (N'515', 40, 25, 50.6000, N'Más vendido', N'~/imagenes/Principal/collecion/mujeres/zapato_0009s_0001_515.png', N'NewBalance', N'Mujer')
GO
INSERT [dbo].[PRODUCT] ([PRODUCTNAME], [ID], [STOCK], [PRECIO], [CATEGORIA], [IMAGEN], [MARCA], [GENERO]) VALUES (N'Fresh foam 880 v12', 41, 25, 95.9700, N'Más vendido', N'~/imagenes/Principal/collecion/mujeres/zapato_0009s_0002_fresh-foam-880-v12.png', N'NewBalance', N'Mujer')
GO
INSERT [dbo].[PRODUCT] ([PRODUCTNAME], [ID], [STOCK], [PRECIO], [CATEGORIA], [IMAGEN], [MARCA], [GENERO]) VALUES (N'Fresh foam 880 v12 Pink', 42, 26, 65.9800, N'Oferta', N'~/imagenes/Principal/collecion/mujeres/zapato_0009s_0003_Fresh-foam-880-v12.png', N'NewBalance', N'Mujer')
GO
INSERT [dbo].[PRODUCT] ([PRODUCTNAME], [ID], [STOCK], [PRECIO], [CATEGORIA], [IMAGEN], [MARCA], [GENERO]) VALUES (N'327', 43, 27, 95.9900, N'Más vendido', N'~/imagenes/Principal/collecion/mujeres/zapato_0009s_0004_327.png', N'NewBalance', N'Mujer')
GO
INSERT [dbo].[PRODUCT] ([PRODUCTNAME], [ID], [STOCK], [PRECIO], [CATEGORIA], [IMAGEN], [MARCA], [GENERO]) VALUES (N'Air force 1 low plataform', 44, 27, 100.5600, N'Más vendido', N'~/imagenes/Principal/collecion/mujeres/zapato_0010s_0000_Air-force-1-low-plataform-_.png', N'Nike', N'Mujer')
GO
INSERT [dbo].[PRODUCT] ([PRODUCTNAME], [ID], [STOCK], [PRECIO], [CATEGORIA], [IMAGEN], [MARCA], [GENERO]) VALUES (N'Free metcon 4', 45, 28, 78.0200, N'Más vendido', N'~/imagenes/Principal/collecion/mujeres/zapato_0010s_0001_Free-metcon-4.png', N'Nike', N'Mujer')
GO
INSERT [dbo].[PRODUCT] ([PRODUCTNAME], [ID], [STOCK], [PRECIO], [CATEGORIA], [IMAGEN], [MARCA], [GENERO]) VALUES (N'Air force 1 ''07', 46, 29, 200.0000, N'Nuevo', N'~/imagenes/Principal/collecion/mujeres/zapato_0010s_0002_Air-force-1-''07.png', N'Nike', N'Mujer')
GO
INSERT [dbo].[PRODUCT] ([PRODUCTNAME], [ID], [STOCK], [PRECIO], [CATEGORIA], [IMAGEN], [MARCA], [GENERO]) VALUES (N'Air max 90 futura', 47, 29, 157.8000, N'Nuevo', N'~/imagenes/Principal/collecion/mujeres/zapato_0010s_0003_Air-max-90-futura.png', N'Nike', N'Mujer')
GO
INSERT [dbo].[PRODUCT] ([PRODUCTNAME], [ID], [STOCK], [PRECIO], [CATEGORIA], [IMAGEN], [MARCA], [GENERO]) VALUES (N'Air max plus', 48, 30, 157.9000, N'Nuevo', N'~/imagenes/Principal/collecion/mujeres/zapato_0010s_0004_Air-max-plus.png', N'Nike', N'Mujer')
GO
INSERT [dbo].[PRODUCT] ([PRODUCTNAME], [ID], [STOCK], [PRECIO], [CATEGORIA], [IMAGEN], [MARCA], [GENERO]) VALUES (N'Galaxar run', 49, 31, 157.1000, N'Nuevo', N'~/imagenes/Principal/collecion/mujeres/zapato_0011s_0000_Galaxar-run-.png', N'Adidas', N'Mujer')
GO
INSERT [dbo].[PRODUCT] ([PRODUCTNAME], [ID], [STOCK], [PRECIO], [CATEGORIA], [IMAGEN], [MARCA], [GENERO]) VALUES (N'Duramo sl', 50, 32, 157.1100, N'Nuevo', N'~/imagenes/Principal/collecion/mujeres/zapato_0011s_0001_Duramo-sl-.png', N'Adidas', N'Mujer')
GO
INSERT [dbo].[PRODUCT] ([PRODUCTNAME], [ID], [STOCK], [PRECIO], [CATEGORIA], [IMAGEN], [MARCA], [GENERO]) VALUES (N'Breaknet', 51, 33, 56.7000, N'Más vendido', N'~/imagenes/Principal/collecion/mujeres/zapato_0011s_0003_breaknet.png', N'Adidas', N'Mujer')
GO
INSERT [dbo].[PRODUCT] ([PRODUCTNAME], [ID], [STOCK], [PRECIO], [CATEGORIA], [IMAGEN], [MARCA], [GENERO]) VALUES (N'UPERTURF SEAN WOTHERSPOON X HOT WHEELS', 52, 34, 178.4000, N'Más vendido', N'~/imagenes/Principal/collecion/mujeres/zapato_0011s_0004_UPERTURF-SEAN-WOTHERSPOON-X-HOT-WHEELS.png', N'Adidas', N'Mujer')
GO
INSERT [dbo].[PRODUCT] ([PRODUCTNAME], [ID], [STOCK], [PRECIO], [CATEGORIA], [IMAGEN], [MARCA], [GENERO]) VALUES (N'Chuck Taylor All Star Easy On Unicorns', 53, 35, 178.5000, N'Más vendido', N'~/imagenes/Principal/collecion/ninos/zapato_0000s_0000_Chuck-Taylor-All-Star-Easy-On-Unicorns.png', N'Converse', N'Niño')
GO
INSERT [dbo].[PRODUCT] ([PRODUCTNAME], [ID], [STOCK], [PRECIO], [CATEGORIA], [IMAGEN], [MARCA], [GENERO]) VALUES (N'Sk8 mid reissue v', 54, 24, 56.7500, N'Más vendido', N'~/imagenes/Principal/collecion/ninos/zapato_0001s_0001_sk8-mid-reissue-v.png', N'Vans', N'Niño')
GO
INSERT [dbo].[PRODUCT] ([PRODUCTNAME], [ID], [STOCK], [PRECIO], [CATEGORIA], [IMAGEN], [MARCA], [GENERO]) VALUES (N'Rider fv future vintage', 55, 25, 56.7600, N'Más vendido', N'~/imagenes/Principal/collecion/ninos/zapato_0002s_0000_Rider-fv-future-vintage.png', N'Puma', N'Niño')
GO
INSERT [dbo].[PRODUCT] ([PRODUCTNAME], [ID], [STOCK], [PRECIO], [CATEGORIA], [IMAGEN], [MARCA], [GENERO]) VALUES (N'574', 56, 26, 56.7700, N'Más vendido', N'~/imagenes/Principal/collecion/ninos/zapato_0003s_0000_574.png', N'NewBalance', N'Niño')
GO
INSERT [dbo].[PRODUCT] ([PRODUCTNAME], [ID], [STOCK], [PRECIO], [CATEGORIA], [IMAGEN], [MARCA], [GENERO]) VALUES (N'237', 57, 26, 76.5000, N'Oferta', N'~/imagenes/Principal/collecion/ninos/zapato_0003s_0001_237.png', N'NewBalance', N'Niño')
GO
INSERT [dbo].[PRODUCT] ([PRODUCTNAME], [ID], [STOCK], [PRECIO], [CATEGORIA], [IMAGEN], [MARCA], [GENERO]) VALUES (N'Fresh foam roav v2', 58, 26, 76.6000, N'Oferta', N'~/imagenes/Principal/collecion/ninos/zapato_0003s_0002_fresh-foam-roav-v2.png', N'NewBalance', N'Niño')
GO
INSERT [dbo].[PRODUCT] ([PRODUCTNAME], [ID], [STOCK], [PRECIO], [CATEGORIA], [IMAGEN], [MARCA], [GENERO]) VALUES (N'574 GREEN', 59, 27, 76.7000, N'Oferta', N'~/imagenes/Principal/collecion/ninos/zapato_0003s_0003_574.png', N'NewBalance', N'Niño')
GO
INSERT [dbo].[PRODUCT] ([PRODUCTNAME], [ID], [STOCK], [PRECIO], [CATEGORIA], [IMAGEN], [MARCA], [GENERO]) VALUES (N'VS Switch', 60, 28, 25.5000, N'Nuevo', N'~/imagenes/Principal/collecion/ninos/zapato_0004s_0000_VS-Switch.png', N'Adidas', N'Niño')
GO
INSERT [dbo].[PRODUCT] ([PRODUCTNAME], [ID], [STOCK], [PRECIO], [CATEGORIA], [IMAGEN], [MARCA], [GENERO]) VALUES (N'Tenasaur run', 61, 29, 25.5000, N'Nuevo', N'~/imagenes/Principal/collecion/ninos/zapato_0004s_0001_Tenasaur-run.png', N'Adidas', N'Niño')
GO
INSERT [dbo].[PRODUCT] ([PRODUCTNAME], [ID], [STOCK], [PRECIO], [CATEGORIA], [IMAGEN], [MARCA], [GENERO]) VALUES (N'FORTARUN LACE RUNNING', 62, 30, 25.6000, N'Nuevo', N'~/imagenes/Principal/collecion/ninos/zapato_0004s_0002_-FORTARUN-LACE-RUNNING.png', N'Adidas', N'Niño')
GO
INSERT [dbo].[PRODUCT] ([PRODUCTNAME], [ID], [STOCK], [PRECIO], [CATEGORIA], [IMAGEN], [MARCA], [GENERO]) VALUES (N'ADIDAS X MARVEL DURAMO 10 MILES MORALES', 63, 31, 25.7000, N'Nuevo', N'~/imagenes/Principal/collecion/ninos/zapato_0004s_0003_CORDONES-ADIDAS-X-MARVEL-DURAMO-10-MILES-MORALES.png', N'Adidas', N'Niño')
GO
INSERT [dbo].[PRODUCT] ([PRODUCTNAME], [ID], [STOCK], [PRECIO], [CATEGORIA], [IMAGEN], [MARCA], [GENERO]) VALUES (N'Reebok Classic Leather Legacy AZ', 64, 15, 100.2500, N'Nuevo', N'~/imagenes/Principal/collecion/Hombres/191383-800-Tenis Reebok Classic Leather Legacy AZ.jpg', N'Reebok', N'Hombre')
GO
INSERT [dbo].[PRODUCT] ([PRODUCTNAME], [ID], [STOCK], [PRECIO], [CATEGORIA], [IMAGEN], [MARCA], [GENERO]) VALUES (N'Tenis Reebok Classic Leather', 65, 16, 100.2600, N'Nuevo', N'~/imagenes/Principal/collecion/Hombres/192532-800-Tenis Reebok Classic Leather.jpg', N'Reebok', N'Hombre')
GO
INSERT [dbo].[PRODUCT] ([PRODUCTNAME], [ID], [STOCK], [PRECIO], [CATEGORIA], [IMAGEN], [MARCA], [GENERO]) VALUES (N'Tenis Reebok Classic Leather Blue', 66, 17, 100.2700, N'Nuevo', N'~/imagenes/Principal/collecion/Hombres/204354-800-Tenis Reebok Classic Leather.jpg', N'Rebook', N'Hombre')
GO
INSERT [dbo].[PRODUCT] ([PRODUCTNAME], [ID], [STOCK], [PRECIO], [CATEGORIA], [IMAGEN], [MARCA], [GENERO]) VALUES (N'Reebok Classic Leather', 67, 18, 100.2800, N'Nuevo', N'~/imagenes/Principal/collecion/Hombres/204578-800-Tenis Reebok Classic Leather.jpg', N'Rebook', N'Hombre')
GO
INSERT [dbo].[PRODUCT] ([PRODUCTNAME], [ID], [STOCK], [PRECIO], [CATEGORIA], [IMAGEN], [MARCA], [GENERO]) VALUES (N'Zig Kinetica 2.5', 68, 19, 100.2900, N'Nuevo', N'~/imagenes/Principal/collecion/Hombres/206598-1600-Tenis Reebok Zig Kinetica 2.5.jpg', N'Rebook', N'Hombre')
GO
INSERT [dbo].[PRODUCT] ([PRODUCTNAME], [ID], [STOCK], [PRECIO], [CATEGORIA], [IMAGEN], [MARCA], [GENERO]) VALUES (N'Zig Kinetica 2.5', 69, 20, 100.3000, N'Más vendido', N'~/imagenes/Principal/collecion/Hombres/206682-800-Tenis Reebok Zig Kinetica 2.5.jpg', N'Rebook', N'Hombre')
GO
INSERT [dbo].[PRODUCT] ([PRODUCTNAME], [ID], [STOCK], [PRECIO], [CATEGORIA], [IMAGEN], [MARCA], [GENERO]) VALUES (N'Flow Velociti Wind 2', 70, 21, 100.3100, N'Más vendido', N'~/imagenes/Principal/collecion/Hombres/3024903-102_Zapatillas de running UA Flow Velociti Wind 2.jpg', N'UnderArmor', N'Hombre')
GO
INSERT [dbo].[PRODUCT] ([PRODUCTNAME], [ID], [STOCK], [PRECIO], [CATEGORIA], [IMAGEN], [MARCA], [GENERO]) VALUES (N'Chanclas Project Rock', 71, 22, 100.3200, N'Más vendido', N'~/imagenes/Principal/collecion/Hombres/3025237-001_Chanclas Project Rock.jpg', N'UnderArmor', N'Hombre')
GO
INSERT [dbo].[PRODUCT] ([PRODUCTNAME], [ID], [STOCK], [PRECIO], [CATEGORIA], [IMAGEN], [MARCA], [GENERO]) VALUES (N'HOVR Phantom 3', 72, 23, 100.3300, N'Más vendido', N'~/imagenes/Principal/collecion/Hombres/3025516-002_Zapatillas de running UA HOVR™ Phantom 3.jpg', N'UnderArmor', N'Hombre')
GO
INSERT [dbo].[PRODUCT] ([PRODUCTNAME], [ID], [STOCK], [PRECIO], [CATEGORIA], [IMAGEN], [MARCA], [GENERO]) VALUES (N'Curry One Low FloTro', 73, 24, 100.3400, N'Oferta', N'~/imagenes/Principal/collecion/Hombres/3025633-300_Zapatillas de baloncesto Curry One Low FloTro unisex.jpg', N'UnderArmor', N'Hombre')
GO
INSERT [dbo].[PRODUCT] ([PRODUCTNAME], [ID], [STOCK], [PRECIO], [CATEGORIA], [IMAGEN], [MARCA], [GENERO]) VALUES (N'Running UA HOVR Phantom 3 ', 74, 25, 100.3500, N'Oferta', N'~/imagenes/Principal/collecion/Hombres/3026465-100_Zapatillas de running UA HOVR™ Phantom 3 .jpg', N'UnderArmor', N'Hombre')
GO
INSERT [dbo].[PRODUCT] ([PRODUCTNAME], [ID], [STOCK], [PRECIO], [CATEGORIA], [IMAGEN], [MARCA], [GENERO]) VALUES (N'AXILUS ACE CLAY HOMBRE', 75, 26, 100.3600, N'Oferta', N'~/imagenes/Principal/collecion/Hombres/6267732-1600-ZAPATILLA FILA AXILUS ACE CLAY HOMBRE.jpg', N'Fila', N'Hombre')
GO
INSERT [dbo].[PRODUCT] ([PRODUCTNAME], [ID], [STOCK], [PRECIO], [CATEGORIA], [IMAGEN], [MARCA], [GENERO]) VALUES (N'AXILUS ACE HOMBRE', 76, 27, 100.3700, N'Oferta', N'~/imagenes/Principal/collecion/Hombres/6289407-1600-ZAPATILLA FILA AXILUS ACE HOMBRE.jpg', N'Fila', N'Hombre')
GO
INSERT [dbo].[PRODUCT] ([PRODUCTNAME], [ID], [STOCK], [PRECIO], [CATEGORIA], [IMAGEN], [MARCA], [GENERO]) VALUES (N'NOVARO HOMBRE', 77, 28, 100.3800, N'Oferta', N'~/imagenes/Principal/collecion/Hombres/6296112-1600-ZAPATILLA FILA NOVARO HOMBRE.jpg', N'Fila', N'Hombre')
GO
INSERT [dbo].[PRODUCT] ([PRODUCTNAME], [ID], [STOCK], [PRECIO], [CATEGORIA], [IMAGEN], [MARCA], [GENERO]) VALUES (N'RACER ADVANTAGE HOMBRE', 78, 29, 100.3900, N'Oferta', N'~/imagenes/Principal/collecion/Hombres/6368316-1600-ZAPATILLA FILA RACER ADVANTAGE HOMBRE.jpg', N'Fila', N'Hombre')
GO
INSERT [dbo].[PRODUCT] ([PRODUCTNAME], [ID], [STOCK], [PRECIO], [CATEGORIA], [IMAGEN], [MARCA], [GENERO]) VALUES (N'TREND 2.0 HOMBRE', 79, 30, 100.4000, N'Oferta', N'~/imagenes/Principal/collecion/Hombres/6385070-1600-ZAPATILLA FILA TREND 2.0 HOMBRE.jpg', N'Fila', N'Hombre')
GO
INSERT [dbo].[PRODUCT] ([PRODUCTNAME], [ID], [STOCK], [PRECIO], [CATEGORIA], [IMAGEN], [MARCA], [GENERO]) VALUES (N'CL Legacy AZ', 80, 15, 110.5000, N'Nuevo', N'~/imagenes/Principal/collecion/mujeres/190963-1600-Tenis Reebok CL Legacy AZ.jpg', N'Reebok', N'Mujer')
GO
INSERT [dbo].[PRODUCT] ([PRODUCTNAME], [ID], [STOCK], [PRECIO], [CATEGORIA], [IMAGEN], [MARCA], [GENERO]) VALUES (N'Floatride Energy Daily Negro', 81, 16, 110.6000, N'Nuevo', N'~/imagenes/Principal/collecion/mujeres/195056-800-Tenis Reebok Floatride Energy Daily Negro.jpg', N'Reebok', N'Mujer')
GO
INSERT [dbo].[PRODUCT] ([PRODUCTNAME], [ID], [STOCK], [PRECIO], [CATEGORIA], [IMAGEN], [MARCA], [GENERO]) VALUES (N'Nano X2 Rosa', 82, 17, 110.7000, N'Nuevo', N'~/imagenes/Principal/collecion/mujeres/196244-800-Tenis Reebok Nano X2 Rosa.jpg', N'Reebok', N'Mujer')
GO
INSERT [dbo].[PRODUCT] ([PRODUCTNAME], [ID], [STOCK], [PRECIO], [CATEGORIA], [IMAGEN], [MARCA], [GENERO]) VALUES (N'Classic Leather', 83, 18, 110.8000, N'Nuevo', N'~/imagenes/Principal/collecion/mujeres/204354-800-Tenis Reebok Classic Leather.jpg', N'Reebok', N'Mujer')
GO
INSERT [dbo].[PRODUCT] ([PRODUCTNAME], [ID], [STOCK], [PRECIO], [CATEGORIA], [IMAGEN], [MARCA], [GENERO]) VALUES (N'Classic Leather', 84, 19, 110.9000, N'Nuevo', N'~/imagenes/Principal/collecion/mujeres/204578-800-Tenis Reebok Classic Leather.jpg', N'Reebok', N'Mujer')
GO
INSERT [dbo].[PRODUCT] ([PRODUCTNAME], [ID], [STOCK], [PRECIO], [CATEGORIA], [IMAGEN], [MARCA], [GENERO]) VALUES (N'Zig Kinetica 2.5', 85, 20, 110.1000, N'Nuevo', N'~/imagenes/Principal/collecion/mujeres/206682-800-Tenis Reebok Zig Kinetica 2.5.jpg', N'Reebok', N'Mujer')
GO
INSERT [dbo].[PRODUCT] ([PRODUCTNAME], [ID], [STOCK], [PRECIO], [CATEGORIA], [IMAGEN], [MARCA], [GENERO]) VALUES (N'HOVR Machina 3', 86, 21, 110.1100, N'Nuevo', N'~/imagenes/Principal/collecion/mujeres/3023772-004_Zapatillas de running UA HOVR™ Machina 3.jpg', N'UnderArmor', N'Mujer')
GO
INSERT [dbo].[PRODUCT] ([PRODUCTNAME], [ID], [STOCK], [PRECIO], [CATEGORIA], [IMAGEN], [MARCA], [GENERO]) VALUES (N'HOVR Machina 3', 87, 22, 110.1200, N'Nuevo', N'~/imagenes/Principal/collecion/mujeres/3024907-304_Zapatillas de running UA HOVR™ Machina 3.jpg', N'UnderArmor', N'Mujer')
GO
INSERT [dbo].[PRODUCT] ([PRODUCTNAME], [ID], [STOCK], [PRECIO], [CATEGORIA], [IMAGEN], [MARCA], [GENERO]) VALUES (N'TriBase Reign 4', 88, 23, 110.1300, N'Más vendido', N'~/imagenes/Principal/collecion/mujeres/3025053-100_Zapatillas de entrenamiento UA TriBase™ Reign 4.jpg', N'UnderArmor', N'Mujer')
GO
INSERT [dbo].[PRODUCT] ([PRODUCTNAME], [ID], [STOCK], [PRECIO], [CATEGORIA], [IMAGEN], [MARCA], [GENERO]) VALUES (N'Charged Aurora 2', 89, 24, 110.1400, N'Más vendido', N'~/imagenes/Principal/collecion/mujeres/3025060-100_Zapatillas de entrenamiento UA Charged Aurora 2.jpg', N'UnderArmor', N'Mujer')
GO
INSERT [dbo].[PRODUCT] ([PRODUCTNAME], [ID], [STOCK], [PRECIO], [CATEGORIA], [IMAGEN], [MARCA], [GENERO]) VALUES (N'HOVR Phantom 3 Metallic', 90, 25, 110.1500, N'Más vendido', N'~/imagenes/Principal/collecion/mujeres/3025521-300_Zapatillas de running UA HOVR™ Phantom 3 Metallic.jpg', N'UnderArmor', N'Mujer')
GO
INSERT [dbo].[PRODUCT] ([PRODUCTNAME], [ID], [STOCK], [PRECIO], [CATEGORIA], [IMAGEN], [MARCA], [GENERO]) VALUES (N'RENNO', 91, 26, 110.1600, N'Más vendido', N'~/imagenes/Principal/collecion/mujeres/6315339-1600-ZAPATILLA FILA RENNO.jpg', N'Fila', N'Mujer')
GO
INSERT [dbo].[PRODUCT] ([PRODUCTNAME], [ID], [STOCK], [PRECIO], [CATEGORIA], [IMAGEN], [MARCA], [GENERO]) VALUES (N'RACER ONE', 92, 27, 110.1700, N'Más vendido', N'~/imagenes/Principal/collecion/mujeres/6366478-1600-ZAPATILLA FILA RACER ONE.jpg', N'Fila', N'Mujer')
GO
INSERT [dbo].[PRODUCT] ([PRODUCTNAME], [ID], [STOCK], [PRECIO], [CATEGORIA], [IMAGEN], [MARCA], [GENERO]) VALUES (N'FORCE', 93, 28, 110.1800, N'Más vendido', N'~/imagenes/Principal/collecion/mujeres/6366797-1600-ZAPATILLA FILA FORCE.jpg', N'Fila', N'Mujer')
GO
INSERT [dbo].[PRODUCT] ([PRODUCTNAME], [ID], [STOCK], [PRECIO], [CATEGORIA], [IMAGEN], [MARCA], [GENERO]) VALUES (N'INTRUDER', 94, 29, 110.1900, N'Más vendido', N'~/imagenes/Principal/collecion/mujeres/6367059-1600-ZAPATILLA FILA INTRUDER.jpg', N'Fila', N'Mujer')
GO
INSERT [dbo].[PRODUCT] ([PRODUCTNAME], [ID], [STOCK], [PRECIO], [CATEGORIA], [IMAGEN], [MARCA], [GENERO]) VALUES (N'GRANT HILL 2 FLORAL', 95, 30, 110.2000, N'Más vendido', N'~/imagenes/Principal/collecion/mujeres/6368614-1600-ZAPATILLA FILA GRANT HILL 2 FLORAL.jpg', N'Fila', N'Mujer')
GO
INSERT [dbo].[PRODUCT] ([PRODUCTNAME], [ID], [STOCK], [PRECIO], [CATEGORIA], [IMAGEN], [MARCA], [GENERO]) VALUES (N'EURO JOGGER SPORT', 96, 31, 110.2100, N'Más vendido', N'~/imagenes/Principal/collecion/mujeres/6383581-1600-ZAPATILLA FILA EURO JOGGER SPORT.jpg', N'Fila', N'Mujer')
GO
INSERT [dbo].[PRODUCT] ([PRODUCTNAME], [ID], [STOCK], [PRECIO], [CATEGORIA], [IMAGEN], [MARCA], [GENERO]) VALUES (N'XT Sprinter 2 Alt', 97, 35, 178.5000, N'Más vendido', N'~/imagenes/Principal/collecion/ninos/197776-800-Tenis Reebok XT Sprinter 2 Alt.jpg', N'Reebok', N'Niño')
GO
INSERT [dbo].[PRODUCT] ([PRODUCTNAME], [ID], [STOCK], [PRECIO], [CATEGORIA], [IMAGEN], [MARCA], [GENERO]) VALUES (N'XT Sprinter 2 Alt BLACK', 98, 36, 178.6000, N'Más vendido', N'~/imagenes/Principal/collecion/ninos/197820-800-Tenis Reebok XT Sprinter 2 Alt.jpg', N'Reebok', N'Niño')
GO
INSERT [dbo].[PRODUCT] ([PRODUCTNAME], [ID], [STOCK], [PRECIO], [CATEGORIA], [IMAGEN], [MARCA], [GENERO]) VALUES (N'Durable XT Azul', 99, 37, 178.7000, N'Más vendido', N'~/imagenes/Principal/collecion/ninos/204742-800-Tenis Reebok Durable XT Azul.jpg', N'Reebok', N'Niño')
GO
INSERT [dbo].[PRODUCT] ([PRODUCTNAME], [ID], [STOCK], [PRECIO], [CATEGORIA], [IMAGEN], [MARCA], [GENERO]) VALUES (N'Rush Runner 4 Reebok Negro', 100, 38, 178.8000, N'Más vendido', N'~/imagenes/Principal/collecion/ninos/206990-800-Tenis Rush Runner 4 Reebok Negro.jpg', N'Reebok', N'Niño')
GO
INSERT [dbo].[PRODUCT] ([PRODUCTNAME], [ID], [STOCK], [PRECIO], [CATEGORIA], [IMAGEN], [MARCA], [GENERO]) VALUES (N'Chanclas UA Locker IV', 101, 39, 178.9000, N'Oferta', N'~/imagenes/Principal/collecion/ninos/3023787-001_Chanclas UA Locker IV.jpg', N'UnderArmor', N'Niño')
GO
INSERT [dbo].[PRODUCT] ([PRODUCTNAME], [ID], [STOCK], [PRECIO], [CATEGORIA], [IMAGEN], [MARCA], [GENERO]) VALUES (N'UA Runplay', 102, 40, 178.1000, N'Oferta', N'~/imagenes/Principal/collecion/ninos/3024212-001_Zapatillas de running UA Runplay.jpg', N'UnderArmor', N'Niño')
GO
INSERT [dbo].[PRODUCT] ([PRODUCTNAME], [ID], [STOCK], [PRECIO], [CATEGORIA], [IMAGEN], [MARCA], [GENERO]) VALUES (N'Grade School UA Assert 9', 103, 41, 178.1100, N'Oferta', N'~/imagenes/Principal/collecion/ninos/3024633-004_Zapatillas de running Grade School UA Assert 9.jpg', N'UnderArmor', N'Niño')
GO
INSERT [dbo].[PRODUCT] ([PRODUCTNAME], [ID], [STOCK], [PRECIO], [CATEGORIA], [IMAGEN], [MARCA], [GENERO]) VALUES (N'Pre-School UA Assert 9 AC', 104, 42, 178.1200, N'Oferta', N'~/imagenes/Principal/collecion/ninos/3024635-001_Zapatillas de running Pre-School UA Assert 9 AC.jpg', N'UnderArmor', N'Niño')
GO
INSERT [dbo].[PRODUCT] ([PRODUCTNAME], [ID], [STOCK], [PRECIO], [CATEGORIA], [IMAGEN], [MARCA], [GENERO]) VALUES (N'Grade School UA Charged Rogue', 105, 43, 178.1300, N'Oferta', N'~/imagenes/Principal/collecion/ninos/3024981-102_Zapatillas de running Grade School UA Charged Rogue.jpg', N'UnderArmor', N'Niño')
GO
INSERT [dbo].[PRODUCT] ([PRODUCTNAME], [ID], [STOCK], [PRECIO], [CATEGORIA], [IMAGEN], [MARCA], [GENERO]) VALUES (N'Grade School UA Charged Pursuit 3', 106, 44, 178.1400, N'Oferta', N'~/imagenes/Principal/collecion/ninos/3024987-002_Zapatillas de running Grade School UA Charged Pursuit 3.jpg', N'UnderArmor', N'Niño')
GO
INSERT [dbo].[PRODUCT] ([PRODUCTNAME], [ID], [STOCK], [PRECIO], [CATEGORIA], [IMAGEN], [MARCA], [GENERO]) VALUES (N'DISRUPTOR KIDS', 107, 45, 178.1500, N'Oferta', N'~/imagenes/Principal/collecion/ninos/6259678-1600-ZAPATILLA FILA DISRUPTOR KIDS.jpg', N'Fila', N'Niño')
GO
INSERT [dbo].[PRODUCT] ([PRODUCTNAME], [ID], [STOCK], [PRECIO], [CATEGORIA], [IMAGEN], [MARCA], [GENERO]) VALUES (N'DISRUPTOR VLC KIDS', 108, 46, 178.1600, N'Oferta', N'~/imagenes/Principal/collecion/ninos/6271722-1600-ZAPATILLA FILA DISRUPTOR VLC KIDS.jpg', N'Fila', N'Niño')
GO
INSERT [dbo].[PRODUCT] ([PRODUCTNAME], [ID], [STOCK], [PRECIO], [CATEGORIA], [IMAGEN], [MARCA], [GENERO]) VALUES (N'RECOVERY KIDS', 109, 47, 178.1700, N'Oferta', N'~/imagenes/Principal/collecion/ninos/6290203-1600-ZAPATILLA FILA RECOVERY KIDS.jpg', N'Fila', N'Niño')
GO
INSERT [dbo].[PRODUCT] ([PRODUCTNAME], [ID], [STOCK], [PRECIO], [CATEGORIA], [IMAGEN], [MARCA], [GENERO]) VALUES (N'LUGANO 6.0 KIDS', 110, 48, 178.1800, N'Oferta', N'~/imagenes/Principal/collecion/ninos/6305752-1600-ZAPATILLA FILA LUGANO 6.0 KIDS.jpg', N'Fila', N'Niño')
GO
INSERT [dbo].[PRODUCT] ([PRODUCTNAME], [ID], [STOCK], [PRECIO], [CATEGORIA], [IMAGEN], [MARCA], [GENERO]) VALUES (N'D-FORMATION KIDS', 111, 49, 178.1900, N'Oferta', N'~/imagenes/Principal/collecion/ninos/6363078-1600-Name_286780.jpg', N'Fila', N'Niño')
GO
SET IDENTITY_INSERT [dbo].[PRODUCT] OFF
GO
INSERT [dbo].[UMUSER] ([USERNAME], [EMAIL], [PASSWORD], [ID]) VALUES (N'Santiago', N'santiago@gmail.com', N'san', CAST(111222233344445555 AS Decimal(18, 0)))
GO
ALTER TABLE [dbo].[PEDIDO_DETALLE]  WITH CHECK ADD  CONSTRAINT [FK_PEDIDO_DETALLE_PRODUCT] FOREIGN KEY([PRODUCT_ID])
REFERENCES [dbo].[PRODUCT] ([ID])
GO
ALTER TABLE [dbo].[PEDIDO_DETALLE] CHECK CONSTRAINT [FK_PEDIDO_DETALLE_PRODUCT]
GO
ALTER TABLE [dbo].[PEDIDO_DETALLE]  WITH CHECK ADD  CONSTRAINT [FK_PEDIDO_DETALLE_UMUSER] FOREIGN KEY([CLIENTE_ID])
REFERENCES [dbo].[UMUSER] ([ID])
GO
ALTER TABLE [dbo].[PEDIDO_DETALLE] CHECK CONSTRAINT [FK_PEDIDO_DETALLE_UMUSER]
GO
ALTER TABLE [dbo].[PEDIDOS]  WITH CHECK ADD  CONSTRAINT [FK_PEDIDOS_UMUSER] FOREIGN KEY([CLIENTE_ID])
REFERENCES [dbo].[UMUSER] ([ID])
GO
ALTER TABLE [dbo].[PEDIDOS] CHECK CONSTRAINT [FK_PEDIDOS_UMUSER]
GO
