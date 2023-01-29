﻿CREATE PROCEDURE [dbo].[GetAllServiceByMale]
@Male bit
AS
SELECT Sp.Id, Sp.Name As SpecializationName, Se.Name AS ServiceName, Se.Male, Se.Price
FROM [dbo].[Service] AS Se
INNER JOIN [dbo].Specialization AS Sp ON Se.SpecializationId = Sp.Id
WHERE Se.Male = 0 OR Se.Male IS NULL