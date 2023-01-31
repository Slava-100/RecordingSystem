CREATE PROCEDURE [dbo].[AddPatient]
	@Name nvarchar(30),
	@LastName nvarchar(30),
	@PhoneNumber nvarchar(10),
	@Email nvarchar(30),
	@StatusId int,
	@Male bit,
	@Birthday datetime2(7)
AS
INSERT INTO dbo.[Patient]
(
	Name,
	LastName,
	PhoneNumber,
	Email,
	StatusId,
	Male,
	Birthday
)
VALUES
(
	@Name,
	@LastName,
	@PhoneNumber,
	@Email,
	@StatusId,
	@Male,
	@Birthday
)