USE [emlak]
GO
/****** Object:  Table [dbo].[gayrimenkuller]    Script Date: 14.06.2021 23:13:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[gayrimenkuller](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[durumu] [varchar](50) NOT NULL,
	[tipi] [varchar](50) NOT NULL,
	[isitma_turu] [varchar](50) NOT NULL,
	[oda_sayisi] [int] NOT NULL,
	[salon_sayisi] [int] NOT NULL,
	[fiyat] [varchar](50) NOT NULL,
	[is_havuz] [bit] NULL,
	[manzara] [varchar](50) NULL,
	[is_garaj] [bit] NULL,
	[is_bahce] [bit] NULL,
	[is_balkon] [bit] NULL,
	[kat] [int] NULL,
 CONSTRAINT [PK__tmp_ms_x__3214EC0737574A11] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[kullanicilar]    Script Date: 14.06.2021 23:13:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[kullanicilar](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[kullanici_adi] [nvarchar](50) NULL,
	[sifre] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[gayrimenkuller] ON 

INSERT [dbo].[gayrimenkuller] ([Id], [durumu], [tipi], [isitma_turu], [oda_sayisi], [salon_sayisi], [fiyat], [is_havuz], [manzara], [is_garaj], [is_bahce], [is_balkon], [kat]) VALUES (1, N'Kiralık', N'Yazlık', N'Kombi', 3, 1, N'1500323', 1, N'Şehir', 0, 0, 0, 0)
INSERT [dbo].[gayrimenkuller] ([Id], [durumu], [tipi], [isitma_turu], [oda_sayisi], [salon_sayisi], [fiyat], [is_havuz], [manzara], [is_garaj], [is_bahce], [is_balkon], [kat]) VALUES (2, N'Kiralık', N'Apartman', N'Klima', 3, 1, N'3200', 0, N'Şehir', 0, 0, 0, 4)
INSERT [dbo].[gayrimenkuller] ([Id], [durumu], [tipi], [isitma_turu], [oda_sayisi], [salon_sayisi], [fiyat], [is_havuz], [manzara], [is_garaj], [is_bahce], [is_balkon], [kat]) VALUES (4, N'Satılık', N'Yazlık', N'Klima', 6, 1, N'850000', 1, N'Deniz', 0, 0, 0, NULL)
INSERT [dbo].[gayrimenkuller] ([Id], [durumu], [tipi], [isitma_turu], [oda_sayisi], [salon_sayisi], [fiyat], [is_havuz], [manzara], [is_garaj], [is_bahce], [is_balkon], [kat]) VALUES (5, N'Kiralık', N'Apartman', N'Kombi', 3, 1, N'1500323', 0, N'Şehir', 0, 0, 1, 0)
INSERT [dbo].[gayrimenkuller] ([Id], [durumu], [tipi], [isitma_turu], [oda_sayisi], [salon_sayisi], [fiyat], [is_havuz], [manzara], [is_garaj], [is_bahce], [is_balkon], [kat]) VALUES (8, N'Satılık', N'Apartman', N'Kombi', 5, 2, N'985000', 0, N'', 0, 0, 1, 10)
SET IDENTITY_INSERT [dbo].[gayrimenkuller] OFF
GO
SET IDENTITY_INSERT [dbo].[kullanicilar] ON 

INSERT [dbo].[kullanicilar] ([id], [kullanici_adi], [sifre]) VALUES (1, N'admin', N'123456')
SET IDENTITY_INSERT [dbo].[kullanicilar] OFF
GO
ALTER TABLE [dbo].[gayrimenkuller] ADD  CONSTRAINT [DF_Table_1_ev_durumu]  DEFAULT ('Kiralık') FOR [durumu]
GO
ALTER TABLE [dbo].[gayrimenkuller] ADD  CONSTRAINT [DF_gayrimenkuller_tipi]  DEFAULT ('Apartman') FOR [tipi]
GO
ALTER TABLE [dbo].[gayrimenkuller] ADD  CONSTRAINT [DF_gayrimenkuller_isitma_turu]  DEFAULT ('Kombi') FOR [isitma_turu]
GO
ALTER TABLE [dbo].[gayrimenkuller] ADD  CONSTRAINT [DF_Table_1_havuz]  DEFAULT ((0)) FOR [is_havuz]
GO
ALTER TABLE [dbo].[gayrimenkuller] ADD  CONSTRAINT [DF_Table_1_manzara]  DEFAULT ('Şehir') FOR [manzara]
GO
ALTER TABLE [dbo].[gayrimenkuller] ADD  CONSTRAINT [DF_gayrimenkuller_is_garaj]  DEFAULT ((0)) FOR [is_garaj]
GO
ALTER TABLE [dbo].[gayrimenkuller] ADD  CONSTRAINT [DF_gayrimenkuller_is_bahce]  DEFAULT ((0)) FOR [is_bahce]
GO
ALTER TABLE [dbo].[gayrimenkuller] ADD  CONSTRAINT [DF_gayrimenkuller_is_balkon]  DEFAULT ((0)) FOR [is_balkon]
GO
