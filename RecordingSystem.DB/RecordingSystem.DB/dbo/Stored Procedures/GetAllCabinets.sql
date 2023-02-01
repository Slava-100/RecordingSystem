CREATE PROCEDURE GetAllCabinets
AS
select C.Id As CabinetId, C.Number AS CabinetNumber, C.Status from dbo.Cabinet AS C
