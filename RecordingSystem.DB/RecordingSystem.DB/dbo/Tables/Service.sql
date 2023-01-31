CREATE TABLE [dbo].[Service] (
    [Id]               INT           IDENTITY (1, 1) NOT NULL,
    [Name]             NVARCHAR (50) NOT NULL,
    [Price]            FLOAT (53)    NOT NULL,
    [SpecializationId] INT           NULL,
    [IsDeleted]        BIT           DEFAULT ((0)) NULL,
    [Male]             BIT           NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([SpecializationId]) REFERENCES [dbo].[Specialization] ([Id])
);

