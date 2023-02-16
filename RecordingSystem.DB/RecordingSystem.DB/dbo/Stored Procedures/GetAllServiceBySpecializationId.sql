CREATE PROCEDURE [dbo].[GetAllServiceBySpecializationId]
@SpecializationId Int
AS
select *
from dbo.[Service] AS S
where S.SpecializationId = @SpecializationId