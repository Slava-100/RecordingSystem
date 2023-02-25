CREATE TABLE [dbo].[DayOfWeek] (
    [Id]   INT           IDENTITY (1, 1) NOT NULL,
    [Name] datetime2(7) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    UNIQUE NONCLUSTERED ([Name] ASC)
);

