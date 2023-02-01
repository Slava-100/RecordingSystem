CREATE PROCEDURE [dbo].[GetAllCabinets]
AS
select C.Id As CabinetId, C.Number AS CabinetNumber from dbo.Cabinet AS C
