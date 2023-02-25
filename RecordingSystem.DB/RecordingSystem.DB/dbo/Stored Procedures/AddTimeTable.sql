Create PROCEDURE [dbo].[AddTimeTable]
	@DoctorId int,
	@DayOfWeekId int,
	@TimeSpanId int
AS
INSERT INTO dbo.[TimeTable]
(
	DoctorId,
	DayOfWeekId,
	TimeSpanId
)
VALUES
(
	@DoctorId,
	@DayOfWeekId,
	@TimeSpanId
)
