create procedure dbo.GetActiveRecordingById
@Id int
AS
select*from dbo.ActiveRecording AS A
Inner Join dbo.Patient AS P On A.PatientId = P.Id 
Inner Join dbo.Doctor AS D ON D.Id = A.DoctorId
where @Id = A.Id
