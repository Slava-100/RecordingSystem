create procedure  [dbo].[GetTimeRecordingById]
@Id int
AS
select*from dbo.TimeRecording AS TR
Inner Join dbo.TimeTable AS TT ON TT.Id = TR.TimeTableId
Inner Join dbo.TimeSpan AS TS ON TS.Id = TT.TimeSpanId
Inner Join dbo.Doctor AS D ON D.Id = TT.DoctorId
where @Id = TR.Id 