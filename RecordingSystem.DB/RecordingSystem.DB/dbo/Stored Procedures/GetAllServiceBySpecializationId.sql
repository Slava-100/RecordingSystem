CREATE PROCEDURE [dbo].[GetAllServiceBySpecializationId]
@SpecializationId Int
AS
select S.Id, S.Name, S.Price, S.Male
from dbo.[Service] AS S
where S.SpecializationId = @SpecializationId AND S.IsDeleted = 0