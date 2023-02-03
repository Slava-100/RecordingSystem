create procedure GetAllPatientsByStatus
@Id_Status INT
AS
select S.Id,S.Name, P.Id, P.Name, P.LastName, P.Male, P.Birthday from dbo.Patient AS P
Left Join dbo.Status AS S ON S.Id = P.StatusId
where P.IsDeleted = 0 AND @Id_Status = S.Id