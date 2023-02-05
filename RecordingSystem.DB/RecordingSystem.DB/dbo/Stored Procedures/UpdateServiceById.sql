CREATE PROCEDURE [dbo].[UpdateServiceById]
	@Id INT,
	@Name NVARCHAR(50),
	@Price FLOAT,
	@SpecializationId int,
	@Male bit
AS
UPDATE Service
SET
	[Name] = @Name,
	[Price] = @Price,
	[SpecializationId] = @SpecializationId,
	[Male] = @Male
WHERE [Id]=@Id