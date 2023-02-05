CREATE PROCEDURE [dbo].[UpdateIsDeletedDoctorById]
	@Id int,
	@IsDeleted bit
AS
UPDATE Doctor
SET
	IsDeleted = @IsDeleted
WHERE Doctor.Id = @Id
