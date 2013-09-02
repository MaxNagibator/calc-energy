CREATE SCHEMA [CalcEnergy]
  AUTHORIZATION [dbo]
GO

CREATE TABLE [CalcEnergy].[HourPrice] (
  [Date] datetime NOT NULL,
  [Cost] float DEFAULT 0 NOT NULL,
  UNIQUE ([Date])
)
GO

EXEC sp_addextendedproperty 'MS_Description', N'Дифференцированная по часам расчетного периода нерегулируемая цена на электрическую энергию на оптовом рынке, определяемая по результатам конкурентного отбора ценовых заявок на сутки вперед и конкурентного отбора заявок для балансирования системы, руб/МВтч', N'schema', N'CalcEnergy', N'table', N'HourPrice'
GO

ALTER TABLE [CalcEnergy].[HourPrice]
ADD  FOR [Cost]
GO

CREATE TABLE [CalcEnergy].[PowerHour] (
  [Date] datetime NOT NULL,
  [Hour] int DEFAULT 0 NOT NULL
)
GO

EXEC sp_addextendedproperty 'MS_Description', N'Час максимального совокупного потребления электроэнергии в субъекте Российской Федерации
', N'schema', N'CalcEnergy', N'table', N'PowerHour'
GO

CREATE TABLE [CalcEnergy].[Coefficients] (
  [Date] datetime NOT NULL
  ,EnergyOtherCost int DEFAULT 0 NOT NULL
  ,EnergySalesSurchargeCost int DEFAULT 0 NOT NULL
  ,EnergyTransferCost int DEFAULT 0 NOT NULL
  ,PowerSalesSurchargeCost int DEFAULT 0 NOT NULL
  ,PowerAverageCost int DEFAULT 0 NOT NULL
)
GO

EXEC sp_addextendedproperty 'MS_Description', N'различные коеффициенты для рассчёта
', N'schema', N'CalcEnergy', N'table', N'Coefficients'
GO