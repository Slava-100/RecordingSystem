CREATE PROCEDURE [dbo].[AddTimeRecording]
	@Date datetime2(7),
	@TimeTableId int,
	@Occupied bit
AS
INSERT INTO dbo.[TimeRecording]
(
	Date,
	TimeTableId,
	Occupied 
)
VALUES
(
	@Date,
	@TimeTableId,
	@Occupied
)
