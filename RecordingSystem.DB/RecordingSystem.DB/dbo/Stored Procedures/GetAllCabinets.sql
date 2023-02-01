CREATE PROCEDURE [dbo].[GetAllCabinets]
AS
select D.CabinetId As CabinetId, Cabinet.Number AS CabinetNumber from dbo.[Doctor] AS D
LEFT JOIN dbo.Cabinet ON D.[CabinetId] = Cabinet.[Id]
where D.IsDeleted = 0
