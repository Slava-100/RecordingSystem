CREATE PROCEDURE [dbo].[AddService]
	@Name nvarchar(50),
	@ServiceCategory nvarchar(50),
	@Price float,
	@SpecializationId int,
	@Male bit
AS
INSERT INTO dbo.[Service]
(
	Name ,
	ServiceCategory ,
	Price ,
	SpecializationId ,
	Male 
)
VALUES
(
	@Name ,
	@ServiceCategory ,
	@Price ,
	@SpecializationId ,
	@Male
)
