CREATE PROCEDURE [dbo].[GetAllRecordingHistoryByPatient]
@Id int
AS 
SELECT Ptt.Id, Ptt.Name AS PatientName, Ptt.LastName, RecHis.DiagnosisId, Dg.Name AS DiagnosisName, Dg.Recommendations
FROM [dbo].[Patient] AS Ptt 
INNER JOIN [dbo].ActiveRecording AS AcRec ON Ptt.Id = AcRec.PatientId
INNER JOIN [dbo].RecordingHistory AS RecHis ON AcRec.Id = RecHis.ActiveRecordingId
INNER JOIN [dbo].Diagnosis AS Dg ON RecHis.DiagnosisId = Dg.Id
WHERE Ptt.id = @Id AND AcRec.Coming = 1