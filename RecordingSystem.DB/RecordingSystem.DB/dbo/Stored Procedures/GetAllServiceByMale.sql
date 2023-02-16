CREATE PROCEDURE [dbo].[GetAllServiceByMale]
@Male bit
AS
SELECT  Se.Id, Se.Name, Se.Price, Se.Male , Sp.Id, Sp.Name
FROM [dbo].[Service] AS Se
LEFT JOIN [dbo].Specialization AS Sp ON Se.SpecializationId = Sp.Id
WHERE Se.Male = @Male OR Se.Male IS NULL OR @Male IS NULL