CREATE PROCEDURE [dbo].[UpdatePatientById]
	@Id INT,
	@Name NVARCHAR(30),
	@LastName NVARCHAR(30),
	@PhoneNumber NVARCHAR(10),
	@Email NVARCHAR(30),
	@StatusId Int,
	@Male bit,
	@IsDeleted bit,
	@Birthday datetime2(7)
AS
	UPDATE Patient
	SET
	[Name] = @Name,
	[LastName] = @LastName,
	[PhoneNumber] = @PhoneNumber,
	[Email] = @Email,
	[StatusId] = @StatusId,
	[Male] = @Male,
	[IsDeleted] = @IsDeleted,
	[Birthday] = @Birthday
	WHERE [Id]=@Id
