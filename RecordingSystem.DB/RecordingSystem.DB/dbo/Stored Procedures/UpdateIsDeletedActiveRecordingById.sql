CREATE PROCEDURE [dbo].[UpdateIsDeletedActiveRecordingById]
	@Id int,
	@IsDeleted bit
AS
UPDATE ActiveRecording
SET
	IsDeleted = @IsDeleted
WHERE Doctor.Id = @Id
