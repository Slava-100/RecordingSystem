CREATE PROCEDURE [dbo].[UpdateCabinetStatusBuNumber]
	@Number int,
	@Status bit
AS
	UPDATE Cabinet
SET
	[Status] = @Status
WHERE Cabinet.Number = @Number
