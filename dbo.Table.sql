CREATE TABLE [dbo].[Table]
(
	[CarImages] IMAGE NOT NULL PRIMARY KEY, 
    [Id] INT NULL, 
    [CarId] INT NULL, 
    [ImagePath] NCHAR(10) NULL, 
    [Date] DATETIME2 NULL
)
