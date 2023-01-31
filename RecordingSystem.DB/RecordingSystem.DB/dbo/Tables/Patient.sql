CREATE TABLE [dbo].[Patient] (
    [Id]          INT           IDENTITY (1, 1) NOT NULL,
    [Name]        NVARCHAR (30) NOT NULL,
    [LastName]    NVARCHAR (30) NULL,
    [PhoneNumber] NVARCHAR (10) NOT NULL,
    [Email]       NVARCHAR (30) NULL,
    [StatusId]    INT           NULL,
    [Male]        BIT           NOT NULL,
    [IsDeleted]   BIT           CONSTRAINT [DF__Patient__IsDelet__49C3F6B7] DEFAULT ((0)) NULL,
    [Birthday]    datetime2(7)          NOT NULL,
    CONSTRAINT [PK__Patient__3214EC078B1FA5B0] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Patient_Status] FOREIGN KEY ([StatusId]) REFERENCES [dbo].[Status] ([Id])
);

