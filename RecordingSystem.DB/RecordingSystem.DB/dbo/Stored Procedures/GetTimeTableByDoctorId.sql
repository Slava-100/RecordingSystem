CREATE PROCEDURE [dbo].[GetTimeTableByDoctorId]
@Id int
AS
select D.Id, D.Name, D.LastName, Sp.Id, Sp.Name, Cab.Id, Cab.Number, DW.Name, TS.Start, TS.[End] 
FROM dbo.[Doctor] AS D
LEFT JOIN dbo.Specialization AS Sp ON D.[SpecializationId] = Sp.[Id]
LEFT JOIN dbo.Cabinet AS Cab ON  D.[CabinetId] = Cab.[Id]
LEFT JOIN dbo.TimeTable AS TT ON  D.[Id] = TT.[DoctorId]
LEFT JOIN dbo.[DayOfWeek] AS DW ON TT.DayOfWeekId = DW.[Id]
LEFT JOIN dbo.TimeSpan AS TS ON TT.TimeSpanId = TS.Id
where @Id = D.Id

