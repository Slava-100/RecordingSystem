CREATE PROCEDURE [dbo].[AddService]
	@Name nvarchar(50),
	@Price float,
	@SpecializationId int,
	@Male bit
AS
INSERT INTO dbo.[Service]
(
	Name ,
	Price ,
	SpecializationId ,
	Male 
)
VALUES
(
	@Name ,
	@Price ,
	@SpecializationId ,
	@Male
)
