CREATE PROCEDURE [dbo].[GetAllSpecializations]
AS
select Specialization.Id AS SpecializationId, Specialization.Name from dbo.[Specialization]