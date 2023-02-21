CREATE PROCEDURE [dbo].[GetAllTimeRecordingsByDoctorId]
@id Int
AS
select D.Id, D.Name, D.LastName, TR.Id, TR.Date, TR.Occupied, TT.Id, TT.TimeSpanId, TS.Id, TS.Start, TS.[End]  from dbo.[TimeRecording] AS TR
Inner Join dbo.TimeTable AS TT ON TT.Id = TR.TimeTableId
Inner Join dbo.TimeSpan AS TS ON TS.Id = TT.TimeSpanId
Inner Join dbo.Doctor AS D ON D.Id = TT.DoctorId
where D.IsDeleted = 0 and D.Id = @id 