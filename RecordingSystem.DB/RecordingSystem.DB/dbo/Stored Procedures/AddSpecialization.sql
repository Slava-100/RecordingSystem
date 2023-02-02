CREATE PROCEDURE [dbo].[AddSpecialization] 
	@Name nvarchar(20) 
AS 
INSERT INTO dbo.[Specialization] 
( 
	Name 
) 
VALUES 
( 
	@Name 
)
