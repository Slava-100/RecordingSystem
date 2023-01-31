CREATE TABLE [dbo].[ActiveRecording] (
    [Id]        INT      IDENTITY (1, 1) NOT NULL,
    [PatientId] INT      NULL,
    [DoctorId]  INT      NULL,
    [DateTime]  datetime2(7) NULL,
    [Coming]    BIT      NULL,
    [IsDeleted] BIT      DEFAULT ((0)) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK__ACtiveRec__Docto__05D8E0BE] FOREIGN KEY ([DoctorId]) REFERENCES [dbo].[Doctor] ([Id]),
    CONSTRAINT [FK_ActiveRecording_Patient] FOREIGN KEY ([PatientId]) REFERENCES [dbo].[Patient] ([Id])
);

