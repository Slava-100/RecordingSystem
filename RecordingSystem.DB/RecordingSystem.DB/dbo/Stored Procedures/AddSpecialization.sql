CREATE PROCEDURE [dbo].[AddDoctor] 
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
