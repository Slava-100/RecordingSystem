CREATE PROCEDURE [dbo].[UpdateCabinetStatusBuNumber]
	@Id int,
	@Number int,
	@Status bit
AS
	UPDATE Cabinet
SET
	[Status] = @Status,
	[Number] = @Number
WHERE Cabinet.Id = @Id
