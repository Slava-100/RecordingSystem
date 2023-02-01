CREATE TABLE [dbo].[Cabinet] (
    [Id]             INT           IDENTITY (1, 1) NOT NULL,
    [Number]         INT           NOT NULL,
    [Status]         BIT           NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    UNIQUE NONCLUSTERED ([Number] ASC)
);

