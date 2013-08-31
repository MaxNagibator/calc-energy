CREATE SCHEMA [CalcEnergy]
  AUTHORIZATION [dbo]
GO

CREATE TABLE [CalcEnergy].[HourPrice] (
  [Date] datetime NOT NULL,
  [Cost] float DEFAULT 0 NOT NULL,
  UNIQUE ([Date])
)
GO

EXEC sp_addextendedproperty 'MS_Description', N'������������������ �� ����� ���������� ������� �������������� ���� �� ������������� ������� �� ������� �����, ������������ �� ����������� ������������� ������ ������� ������ �� ����� ������ � ������������� ������ ������ ��� �������������� �������, ���/����', N'schema', N'CalcEnergy', N'table', N'HourPrice'
GO

ALTER TABLE [CalcEnergy].[HourPrice]
ADD  FOR [Cost]
GO

CREATE TABLE [CalcEnergy].[PowerHour] (
  [Date] datetime NOT NULL,
  [Hour] int DEFAULT 0 NOT NULL
)
GO

EXEC sp_addextendedproperty 'MS_Description', N'��� ������������� ����������� ����������� �������������� � �������� ���������� ���������
', N'schema', N'CalcEnergy', N'table', N'PowerHour'
GO