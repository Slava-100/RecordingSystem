create procedure GetAllPatients
AS
select P.Id, P.Name, P.LastName, P.PhoneNumber, P.Male, P.Birthday, S.Id, S.Name, S.Discount from dbo.Patient AS P
Left Join dbo.Status AS S ON S.Id = P.StatusId
where P.IsDeleted = 0