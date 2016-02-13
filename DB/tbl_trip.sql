USE [CarPool]
GO

/****** Object:  Table [dbo].[tbl_Trip]    Script Date: 11/21/2013 14:51:19 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[tbl_Trip](
	[CarId] [numeric](18, 0) NOT NULL,
	[RouteId] [numeric](18, 0) NOT NULL,
	[Date] [date] NOT NULL,
	[Passenger1] [varchar](25) NULL,
	[Passenger2] [varchar](25) NULL,
	[Passenger3] [varchar](25) NULL,
	[Passenger4] [varchar](25) NULL,
	[Passenger5] [varchar](25) NULL,
	[Passenger6] [varchar](25) NULL,
	[Passenger7] [varchar](25) NULL,
	[Passenger8] [varchar](25) NULL,
	[Passenger9] [varchar](25) NULL,
	[Passenger10] [varchar](25) NULL,
	[SeatsAvailable] [int] NULL
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[tbl_Trip]  WITH CHECK ADD FOREIGN KEY([CarId])
REFERENCES [dbo].[tbl_CarDetails] ([CarId])
GO

ALTER TABLE [dbo].[tbl_Trip]  WITH CHECK ADD FOREIGN KEY([RouteId])
REFERENCES [dbo].[tbl_RouteTable] ([RouteID])
GO


