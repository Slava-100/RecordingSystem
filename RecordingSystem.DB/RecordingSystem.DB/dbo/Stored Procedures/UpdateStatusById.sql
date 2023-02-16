CREATE PROCEDURE [dbo].[UpdateStatusById]
	@Id int,
	@Name nvarchar(10),
	@Discount int
AS
UPDATE Status
SET
	[Name] = @Name,
	[Discount] = @Discount
WHERE [Id]=@Id