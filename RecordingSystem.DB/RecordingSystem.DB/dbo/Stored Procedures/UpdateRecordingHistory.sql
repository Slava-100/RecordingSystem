create procedure dbo.UpdateRecordingHistory
	@Id INT,
	@DiagnosisId Int,
	@ActiveRecordingId Int
AS
UPDATE RecordingHistory
SET
	[DiagnosisId] = @DiagnosisId,
	[ActiveRecordingId] = @ActiveRecordingId
WHERE [Id]=@Id
