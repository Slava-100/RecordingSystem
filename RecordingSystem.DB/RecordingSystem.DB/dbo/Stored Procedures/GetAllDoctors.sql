CREATE PROCEDURE [dbo].[GetAllDoctors]
AS
select D.Id AS DoctorId , D.Name , D.LastName , Sp.Id As SpecializationId, Sp.Name As Specialization, Cab.Number AS NumberCabinet from dbo.[Doctor] AS D
LEFT JOIN dbo.Specialization AS Sp ON D.[SpecializationId] = Sp.[Id]
LEFT JOIN dbo.Cabinet AS Cab ON  D.[CabinetId] = Cab.[Id]