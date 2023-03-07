CREATE PROCEDURE [dbo].[UpdateTimeSpanById]
	@Id INT,
	@Start time(7),	
	@End time(7)
AS
UPDATE TimeSpan
SET
	[Start] = @Start,
	[End] = @End
WHERE [Id]=@Id
