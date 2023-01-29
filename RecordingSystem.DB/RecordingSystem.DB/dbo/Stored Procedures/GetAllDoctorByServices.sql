CREATE procedure [dbo].[GetAllDoctorByServices]
@Id_Services Int
AS
select S.Name, D.Name, D.LastName, D.Id from dbo.Service AS S
Inner Join dbo.Specialization AS Sp ON S.SpecializationId = Sp.Id 
Inner Join dbo.Doctor AS D ON D.SpecializationId = Sp.Id
where @Id_Services = S.Id