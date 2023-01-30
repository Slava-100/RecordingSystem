CREATE PROCEDURE [dbo].[GetAllDoctors]
AS
select D.Id , D.Name , D.LastName , Sp.Name , Cab.Number AS NumberCabinet from dbo.[Doctor] AS D
LEFT JOIN dbo.Specialization AS Sp ON D.[SpecializationId] = Sp.[Id]
LEFT JOIN dbo.Cabinet AS Cab ON  D.[CabinetId] = Cab.[Id]