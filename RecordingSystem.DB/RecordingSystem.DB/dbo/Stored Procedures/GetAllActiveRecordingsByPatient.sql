create procedure GetAllActiveRecordingsByPatient
@Id_Patient Int
AS
select P.Id AS PatientId, P.Name AS PatientName, P.LastName, A.Id AS ActiveRecordingId, A.DateTime, A.Coming, D.Name AS DoctorName, D.LastName, C.Id AS CabinetId, C.Number  from dbo.Patient AS P
Inner Join dbo.ActiveRecording AS A ON P.Id = A.PatientId
Inner Join dbo.Doctor AS D ON D.Id = A.DoctorId
Left Join dbo.Cabinet AS C On D.CabinetId = C.Id
where P.Id = @Id_Patient AND A.Coming is NULL