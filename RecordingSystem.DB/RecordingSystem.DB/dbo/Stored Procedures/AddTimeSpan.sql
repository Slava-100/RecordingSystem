CREATE PROCEDURE [dbo].[AddTimeSpan]
	@Start time(7),	
	@End time(7)
AS
INSERT INTO dbo.[TimeSpan]
(
	Start,
	[End]
)
VALUES
(
	@Start,
	@End	
)