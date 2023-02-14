CREATE PROCEDURE [dbo].[GetAllDoctors]
AS
select D.Id, D.Name, D.LastName, D.Male, D.Birthday, Sp.Id, Sp.Name, Cab.Id, Cab.Number from dbo.[Doctor] AS D
LEFT JOIN dbo.Specialization AS Sp ON D.[SpecializationId] = Sp.[Id]
LEFT JOIN dbo.Cabinet AS Cab ON  D.[CabinetId] = Cab.[Id]
where D.IsDeleted = 0