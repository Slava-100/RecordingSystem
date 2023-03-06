create procedure dbo.GetRecordingHistoryById
@Id int
AS
select*from dbo.RecordingHistory AS RH
Inner Join dbo.ActiveRecording AS AR ON AR.Id = RH.ActiveRecordingId
Inner Join dbo.Patient As P ON P.Id = AR.PatientId
Inner Join dbo.Doctor As Doc ON Doc.Id = AR.DoctorId
Inner Join dbo.Diagnosis Diag On Diag.Id = RH.DiagnosisId
where @Id = RH.Id
