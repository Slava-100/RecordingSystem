CREATE TABLE [dbo].[Cabinet] (
    [Id]             INT           IDENTITY (1, 1) NOT NULL,
    [Number]         INT           NOT NULL,
    [Status]         INT           NULL,
    [Specialization] NVARCHAR (30) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

