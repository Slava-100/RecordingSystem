CREATE PROCEDURE [dbo].[UpdateIsDeletedActiveRecordingById]
	@Id int,
	@IsDeleted bit
AS
UPDATE ActiveRecording
SET
	IsDeleted = @IsDeleted
WHERE ActiveRecording.Id = @Id
