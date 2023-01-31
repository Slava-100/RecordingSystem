CREATE TABLE [dbo].[Doctor] (
    [Id]               INT           IDENTITY (1, 1) NOT NULL,
    [Name]             NVARCHAR (20) NOT NULL,
    [LastName]         NVARCHAR (30) NOT NULL,
    [Male]             BIT           NOT NULL,
    [PhoneNumber]      NVARCHAR (10) NULL,
    [Email]            NVARCHAR (20) NULL,
    [SpecializationId] INT           NULL,
    [CabinetId]        INT           NULL,
    [TimeTableId]      INT           NULL,
    [IsDeleted]        BIT           CONSTRAINT [DF__Doctor__IsDelete__778AC167] DEFAULT ((0)) NULL,
    [Birthday]         datetime2(7)          NOT NULL,
    CONSTRAINT [PK__Doctor__3214EC07A918EE95] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK__Doctor__CabinetI__08B54D69] FOREIGN KEY ([CabinetId]) REFERENCES [dbo].[Cabinet] ([Id]),
    CONSTRAINT [FK__Doctor__Speciali__0A9D95DB] FOREIGN KEY ([SpecializationId]) REFERENCES [dbo].[Specialization] ([Id])
);

