CREATE PROCEDURE [dbo].[AddCabinet]
	@Number int,
	@Status bit
AS
INSERT INTO dbo.[Cabinet]
(
	Number ,
	Status 
)
VALUES
(
	@Number ,
	@Status 
)