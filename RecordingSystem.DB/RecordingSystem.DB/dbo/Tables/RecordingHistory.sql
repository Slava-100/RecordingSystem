CREATE TABLE [dbo].[RecordingHistory] (
    [Id]                INT IDENTITY (1, 1) NOT NULL,
    [DiagnosisId]       INT NULL,
    [ActiveRecordingId] INT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([ActiveRecordingId]) REFERENCES [dbo].[ActiveRecording] ([Id]),
    FOREIGN KEY ([DiagnosisId]) REFERENCES [dbo].[Diagnosis] ([Id])
);

