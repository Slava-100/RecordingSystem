CREATE PROCEDURE [dbo].[GetAllServices]
AS
select Service.Id , Service.Name from dbo.[Service]