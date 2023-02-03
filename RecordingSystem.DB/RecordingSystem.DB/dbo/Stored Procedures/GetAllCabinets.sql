CREATE PROCEDURE [dbo].[GetAllCabinets]
AS
select C.Id, C.Number, C.Status from dbo.Cabinet AS C
