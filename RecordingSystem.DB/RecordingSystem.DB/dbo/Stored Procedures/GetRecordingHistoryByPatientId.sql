CREATE PROCEDURE [dbo].[GetRecordingHistoryByPatientId]
@Id int
AS
SELECT
RH.Id,
RH.ActiveRecordingId,
AR.Id,
AR.[DateTime],
P.Id,
P.[Name],
P.LastName,
Doc.Id,
Doc.[Name],
Doc.LastName,
Diag.Id,
Diag.[Name],
Diag.[Recommendations]
From dbo.RecordingHistory As RH
Left Join dbo.ActiveRecording AS AR ON AR.Id = RH.ActiveRecordingId
Left Join dbo.Patient As P ON P.Id = AR.PatientId
Left Join dbo.Doctor As Doc ON Doc.Id = AR.DoctorId
Left Join dbo.Diagnosis Diag On Diag.Id = RH.DiagnosisId
where PatientId=@Id