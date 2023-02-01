CREATE PROCEDURE [dbo].[GetAllServiceByMale]
@Male bit
AS
SELECT Sp.Id AS SpecializationId, Sp.Name As SpecializationName, Se.Id AS ServiceId, Se.Name AS ServiceName, Se.Price, Se.Male
FROM [dbo].[Service] AS Se
INNER JOIN [dbo].Specialization AS Sp ON Se.SpecializationId = Sp.Id
WHERE Se.Male = @Male OR Se.Male IS NULL