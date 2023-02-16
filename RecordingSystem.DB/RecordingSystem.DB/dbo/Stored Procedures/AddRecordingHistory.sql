CREATE PROCEDURE [dbo].[AddRecordingHistory]
	@DiagnosisId int,
	@ActiveRecordingId int
AS
INSERT INTO dbo.[RecordingHistory]
(
	DiagnosisId,
	ActiveRecordingId
)
VALUES
(
	@DiagnosisId,
	@ActiveRecordingId
)
