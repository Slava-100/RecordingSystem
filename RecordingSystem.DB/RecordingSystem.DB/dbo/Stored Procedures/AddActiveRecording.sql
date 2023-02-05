CREATE PROCEDURE [dbo].[AddActiveRecording]
	@PatientId int,
	@DoctorId int,
	@DateTime datetime2(7)
AS
INSERT INTO dbo.[ActiveRecording]
(
	PatientId,
	DoctorId,
	DateTime
)
VALUES
(
	@PatientId,
	@DoctorId,
	@DateTime
)