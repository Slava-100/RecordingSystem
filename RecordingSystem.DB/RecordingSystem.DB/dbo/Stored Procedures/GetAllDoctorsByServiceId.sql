CREATE procedure [dbo].[GetAllDoctorsByServiceId]
@Id_Services Int
AS
select S.Id, S.Name, D.Id, D.Name, D.LastName from dbo.Service AS S
Inner Join dbo.Specialization AS Sp ON S.SpecializationId = Sp.Id 
Inner Join dbo.Doctor AS D ON D.SpecializationId = Sp.Id
where @Id_Services = S.Id