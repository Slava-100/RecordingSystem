CREATE PROCEDURE [dbo].[UpdateIsDeletedServiceById]
	@Id int,
	@IsDeleted bit
AS
UPDATE Service
SET
	IsDeleted = @IsDeleted
WHERE Service.Id = @Id
