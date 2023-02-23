CREATE TABLE [dbo].[TimeRecording] (
    [Id]          INT  IDENTITY (1, 1) NOT NULL,
    [Date]        datetime2(7) NOT NULL,
    [TimeTableId] INT  NOT NULL,
    [Occupied]    BIT  DEFAULT ((0)) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([TimeTableId]) REFERENCES [dbo].[TimeTable] ([Id])
);

