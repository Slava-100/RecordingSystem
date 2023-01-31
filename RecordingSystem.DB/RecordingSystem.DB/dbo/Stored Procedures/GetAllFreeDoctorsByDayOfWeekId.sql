create procedure GetAllFreeDoctorsByDayOfWeekId
@Id_DayOfWeek Int
AS
select Da.Id, Da.Name AS DayOfWeekName, D.Id, D.Name AS DoctorName, D.LastName, TT.Id, TS.Start, TS.[End], TR.Id, TR.[Date], TR.Occupied
FROM dbo.[DayOfWeek] AS Da
Left Join dbo.TimeTable AS TT ON Da.Id = TT.DayOfWeekId
Left Join dbo.TimeSpan AS TS ON TT.TimeSpanId = TS.Id
Inner Join dbo.[Doctor] AS D ON D.Id = TT.DoctorId
Left Join dbo.TimeRecording AS TR ON TR.TimeTableId = TT.Id
where  TR.Occupied = 0
