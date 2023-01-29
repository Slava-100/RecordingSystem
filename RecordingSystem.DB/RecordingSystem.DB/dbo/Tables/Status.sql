CREATE TABLE [dbo].[Status] (
    [Id]       INT           IDENTITY (1, 1) NOT NULL,
    [Name]     NVARCHAR (10) NULL,
    [Discount] INT           NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

