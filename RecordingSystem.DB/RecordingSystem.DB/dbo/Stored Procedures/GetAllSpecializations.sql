CREATE PROCEDURE [dbo].[GetAllSpecializations]
AS
select Specialization.Id , Specialization.Name from dbo.[Specialization]