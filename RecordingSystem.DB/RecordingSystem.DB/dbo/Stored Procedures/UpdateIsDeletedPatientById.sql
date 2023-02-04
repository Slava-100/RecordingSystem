CREATE PROCEDURE [dbo].[UpdateIsDeletedPatientById]
	@Id int,
	@IsDeleted bit
AS
UPDATE Patient
SET
	IsDeleted = @IsDeleted
WHERE Patient.Id=@Id
