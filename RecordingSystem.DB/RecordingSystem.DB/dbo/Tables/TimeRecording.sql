﻿CREATE TABLE [dbo].[TimeRecording] (
    [Id]          INT  IDENTITY (1, 1) NOT NULL,
    [Date]        DATE NOT NULL,
    [TimeTableId] INT  NULL,
    [Occupied]    BIT  NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([TimeTableId]) REFERENCES [dbo].[TimeTable] ([Id])
);

