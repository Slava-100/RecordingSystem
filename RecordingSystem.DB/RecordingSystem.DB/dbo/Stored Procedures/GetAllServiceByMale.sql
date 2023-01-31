CREATE PROCEDURE [dbo].[GetAllServiceByMale]
@Male bit
AS
SELECT Sp.Id, Sp.Name As SpecializationName, Se.Name AS ServiceName, Se.Price, Se.Male
FROM [dbo].[Service] AS Se
INNER JOIN [dbo].Specialization AS Sp ON Se.SpecializationId = Sp.Id
WHERE Se.Male = @Male OR Se.Male IS NULL