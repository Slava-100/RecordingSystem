CREATE PROCEDURE [dbo].[UpdateServiceById]
	@Id INT,
	@Name NVARCHAR(50),
	@Price FLOAT,
	@SpecializationId int,
	@IsDeleted bit,
	@Male bit
AS
	UPDATE Service
	SET
	[Name] = @Name,
	[Price] = @Price,
	[SpecializationId] = @SpecializationId,
	[IsDeleted] = @IsDeleted,
	[Male] = @Male
	WHERE [Id]=@Id