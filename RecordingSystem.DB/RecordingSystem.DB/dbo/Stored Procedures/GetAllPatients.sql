create procedure GetAllPatients
AS
select P.Id, P.Name, P.LastName, P.PhoneNumber, P.Male, P.Birthday from dbo.Patient AS P
where P.IsDeleted = 0