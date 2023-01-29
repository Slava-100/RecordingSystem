CREATE TABLE [dbo].[TimeSpan] (
    [Id]    INT      IDENTITY (1, 1) NOT NULL,
    [Start] TIME (7) NOT NULL,
    [End]   TIME (7) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

