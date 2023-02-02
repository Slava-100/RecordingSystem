CREATE PROCEDURE [dbo].[GetRecordingHistoryByPatientId]
@Id int
AS
SELECT 
P.Id AS PatientId,
P.[Name] AS PatientName,
P.LastName AS PatientLastName,
RH.ActiveRecordingId AS RecordingId,
AR.[DateTime] AS DateTime,
Doc.Id AS DoctorId,
Doc.[Name] AS DoctorName,
Doc.LastName As DoctorLastName,
Diag.Id As DiagnosisId,
Diag.[Name] As DiagnosisName,
Diag.[Recommendations] As Recomendations
From dbo.RecordingHistory As RH
Left Join dbo.ActiveRecording AS AR ON AR.Id = RH.ActiveRecordingId
Left Join dbo.Patient As P ON P.Id = AR.PatientId
Left Join dbo.Doctor As Doc ON Doc.Id = AR.DoctorId
Left Join dbo.Diagnosis Diag On Diag.Id = RH.DiagnosisId
where PatientId=@Id