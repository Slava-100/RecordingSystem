CREATE PROCEDURE [dbo].[UpdateComingInActiveRecordingById]
	@Id int,
	@Coming bit
AS
UPDATE ActiveRecording
SET
	Coming = @Coming
WHERE ActiveRecording.Id = @Id