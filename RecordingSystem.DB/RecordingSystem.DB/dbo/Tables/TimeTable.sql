CREATE TABLE [dbo].[TimeTable] (
    [Id]          INT IDENTITY (1, 1) NOT NULL,
    [DoctorId]    INT NULL,
    [DayOfWeekId] INT NULL,
    [TimeSpanId]  INT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([DayOfWeekId]) REFERENCES [dbo].[DayOfWeek] ([Id]),
    FOREIGN KEY ([DoctorId]) REFERENCES [dbo].[Doctor] ([Id]),
    FOREIGN KEY ([TimeSpanId]) REFERENCES [dbo].[TimeSpan] ([Id])
);

