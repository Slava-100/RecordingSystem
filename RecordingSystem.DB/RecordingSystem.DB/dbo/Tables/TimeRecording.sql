CREATE TABLE [dbo].[TimeRecording] (
    [Id]          INT  IDENTITY (1, 1) NOT NULL,
    [Date]        datetime2(7) NOT NULL,
    [TimeTableId] INT  NULL,
    [Occupied]    BIT  NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([TimeTableId]) REFERENCES [dbo].[TimeTable] ([Id])
);

