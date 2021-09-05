
CREATE DATABASE [IsidoraSalon]
 GO

USE [IsidoraSalon]
GO
/****** Object:  Table [dbo].[Kategorija]    Script Date: 3/28/2021 12:54:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kategorija](
	[KategorijaID] [int] NOT NULL,
	[Naziv] [nvarchar](50) NULL,
	[Opis] [nvarchar](50) NULL,
 CONSTRAINT [PK_Kategorija] PRIMARY KEY CLUSTERED 
(
	[KategorijaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Korisnik]    Script Date: 3/28/2021 12:54:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Korisnik](
	[KorisnikID] [int] NOT NULL,
	[ImePrezime] [nvarchar](20) NULL,
	[Kontakt] [nvarchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[KorisnikID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StavkaTermina]    Script Date: 3/28/2021 12:54:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StavkaTermina](
	[TerminID] [int] NOT NULL,
	[RBR] [int] NOT NULL,
	[UslugaID] [int] NULL,
 CONSTRAINT [PK_StavkaTermina] PRIMARY KEY CLUSTERED 
(
	[TerminID] ASC,
	[RBR] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Termin]    Script Date: 3/28/2021 12:54:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Termin](
	[ZaposleniID] [nvarchar](50) NOT NULL,
	[KorisnikID] [int] NOT NULL,
	[TerminID] [int] NOT NULL,
	[DatumZakazivanja] [datetime] NULL,
	[DatumTermina] [datetime] NULL,
 CONSTRAINT [PK_Termin] PRIMARY KEY CLUSTERED 
(
	[ZaposleniID] ASC,
	[KorisnikID] ASC,
	[TerminID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipUsluge]    Script Date: 3/28/2021 12:54:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipUsluge](
	[TipID] [int] NOT NULL,
	[Naziv] [nvarchar](50) NULL,
 CONSTRAINT [PK_TipUsluge] PRIMARY KEY CLUSTERED 
(
	[TipID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usluga]    Script Date: 3/28/2021 12:54:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usluga](
	[UslugaID] [int] NOT NULL,
	[Naziv] [nvarchar](50) NULL,
	[Opis] [nvarchar](50) NULL,
	[Cena] [int] NULL,
	[TipID] [int] NULL,
	[KategorijaID] [int] NULL,
 CONSTRAINT [PK_Usluga] PRIMARY KEY CLUSTERED 
(
	[UslugaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Zaduzenje]    Script Date: 3/28/2021 12:54:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Zaduzenje](
	[ZaposleniID] [nvarchar](50) NOT NULL,
	[UslugaID] [int] NOT NULL,
	[BrojUsluga] [int] NOT NULL,
 CONSTRAINT [PK_Zaduzenje] PRIMARY KEY CLUSTERED 
(
	[ZaposleniID] ASC,
	[UslugaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Zaposleni]    Script Date: 3/28/2021 12:54:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Zaposleni](
	[ZaposleniID] [nvarchar](50) NOT NULL,
	[ImePrezime] [nvarchar](50) NULL,
	[DatumRodjenja] [date] NULL,
	[BrojTelefona] [nvarchar](50) NULL,
	[KategorijaID] [int] NULL,
 CONSTRAINT [PK_Zaposleni] PRIMARY KEY CLUSTERED 
(
	[ZaposleniID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Kategorija] ([KategorijaID], [Naziv], [Opis]) VALUES (1, N'Kat 1', N'yuio')
INSERT [dbo].[Kategorija] ([KategorijaID], [Naziv], [Opis]) VALUES (2, N'Kat 2', N'fghj')
INSERT [dbo].[Kategorija] ([KategorijaID], [Naziv], [Opis]) VALUES (3, N'Kat 2', N'fghj')
GO
INSERT [dbo].[Korisnik] ([KorisnikID], [ImePrezime], [Kontakt]) VALUES (1, N'Pera Coyote', N'98765')
GO
INSERT [dbo].[StavkaTermina] ([TerminID], [RBR], [UslugaID]) VALUES (1, 1, 1)
GO
INSERT [dbo].[Termin] ([ZaposleniID], [KorisnikID], [TerminID], [DatumZakazivanja], [DatumTermina]) VALUES (N'1111', 1, 1, CAST(N'2021-03-28T00:00:00.000' AS DateTime), CAST(N'2021-04-08T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[TipUsluge] ([TipID], [Naziv]) VALUES (1, N'Tip 1')
INSERT [dbo].[TipUsluge] ([TipID], [Naziv]) VALUES (2, N'Tip 2')
INSERT [dbo].[TipUsluge] ([TipID], [Naziv]) VALUES (3, N'Tip 3')
GO
INSERT [dbo].[Usluga] ([UslugaID], [Naziv], [Opis], [Cena], [TipID], [KategorijaID]) VALUES (1, N'Usluga 2', N'kjhg', 654, 1, 2)
GO
INSERT [dbo].[Zaduzenje] ([ZaposleniID], [UslugaID], [BrojUsluga]) VALUES (N'2222', 1, 77)
GO
INSERT [dbo].[Zaposleni] ([ZaposleniID], [ImePrezime], [DatumRodjenja], [BrojTelefona], [KategorijaID]) VALUES (N'1111', N'Isidora Ivanovic', CAST(N'1998-01-01' AS Date), N'456789', 1)
INSERT [dbo].[Zaposleni] ([ZaposleniID], [ImePrezime], [DatumRodjenja], [BrojTelefona], [KategorijaID]) VALUES (N'2222', N'Pera Peric', CAST(N'2001-01-01' AS Date), N'9876', 1)
INSERT [dbo].[Zaposleni] ([ZaposleniID], [ImePrezime], [DatumRodjenja], [BrojTelefona], [KategorijaID]) VALUES (N'3333', N'Mika Mikic', CAST(N'1990-01-01' AS Date), N'87654', 1)
GO
ALTER TABLE [dbo].[Zaduzenje]  WITH CHECK ADD  CONSTRAINT [FK_Zaduzenje_Usluga] FOREIGN KEY([UslugaID])
REFERENCES [dbo].[Usluga] ([UslugaID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Zaduzenje] CHECK CONSTRAINT [FK_Zaduzenje_Usluga]
GO
USE [master]
GO
ALTER DATABASE [IsidoraSalon] SET  READ_WRITE 
GO
