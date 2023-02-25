create PROCEDURE [dbo].[AddDayOfWeek]
	@Name datetime2(7)
AS
INSERT INTO dbo.[DayOfWeek]
(
	Name 
)
VALUES
(
	@Name
)

