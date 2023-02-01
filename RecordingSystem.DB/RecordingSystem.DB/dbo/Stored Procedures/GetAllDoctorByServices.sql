CREATE procedure [dbo].[GetAllDoctorByServices]
@Id_Services Int
AS
select S.Id AS ServiceId, S.Name As ServiceName, D.Id AS DoctorId, D.Name AS DoctorName, D.LastName from dbo.Service AS S
Inner Join dbo.Specialization AS Sp ON S.SpecializationId = Sp.Id 
Inner Join dbo.Doctor AS D ON D.SpecializationId = Sp.Id
where @Id_Services = S.Id