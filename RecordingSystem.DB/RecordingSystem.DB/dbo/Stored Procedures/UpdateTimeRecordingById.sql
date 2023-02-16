CREATE PROCEDURE [dbo].[UpdateTimeRecordingById]
	@Id int,
	@Date datetime2(7),
	@TimeTableId int,
	@Occupied bit
AS
UPDATE TimeRecording
SET
	[Date] = @Date,
	[TimeTableId] = @TimeTableId,
	[Occupied]=@Occupied
WHERE [Id]=@Id
