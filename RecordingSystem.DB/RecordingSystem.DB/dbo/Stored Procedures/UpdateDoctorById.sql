CREATE PROCEDURE [dbo].[UpdateDoctorById]
	@Id int,
	@Name nvarchar(20), 
	@LastName nvarchar(30), 
	@Male bit, 
	@PhoneNumber nvarchar(10), 
	@Email nvarchar(20), 
	@SpecializationId int, 
	@CabinetId int, 
	@Birthday datetime2(7),
	@IsDeleted bit
AS
UPDATE Doctor
SET
	Name = @Name, 
	LastName = @LastName, 
	Male = @Male, 
	PhoneNumber = @PhoneNumber, 
	Email = @Email, 
	SpecializationId = @SpecializationId, 
	CabinetId = @CabinetId, 
	Birthday = @Birthday,
	IsDeleted = @IsDeleted
WHERE Doctor.Id = @Id
