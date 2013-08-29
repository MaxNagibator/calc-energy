if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PowerHour]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[PowerHour]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PriceHour]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[PriceHour]
GO

CREATE TABLE [dbo].[PowerHour] (
	[MeasureDate] [datetime] NOT NULL ,
	[Hours] [int] NOT NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[PriceHour] (
	[MeasureDate] [datetime] NOT NULL ,
	[Value] [float] NOT NULL 
) ON [PRIMARY]
GO

