create procedure GetAllPatientsByStatus
@Id_Status INT
AS
select S.Id AS StatusId,S.Name AS StatusName, P.Id AS PatientId, P.Name AS PatientName, P.LastName, P.Male, P.Birthday from dbo.Patient AS P
Left Join dbo.Status AS S ON S.Id = P.StatusId
where P.IsDeleted = 0 AND @Id_Status = S.Id