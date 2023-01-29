CREATE PROCEDURE [dbo].[GetAllDoctors]
AS
select Doctor.Name , Doctor.LastName , Doctor.Id from dbo.[Doctor]