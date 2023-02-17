CREATE procedure [dbo].[GetAllServiceByDoctorId]
@Id_Doctor Int
AS
select D.Id, D.Name, D.LastName, S.Id, S.Name, S.Price, S.Male from dbo.[Doctor] AS D
Inner Join dbo.Specialization AS Sp ON D.SpecializationId = Sp.Id 
Inner Join dbo.Service AS S ON Sp.Id = S.SpecializationId
where @Id_Doctor = D.Id AND	S.IsDeleted = 0 AND D.IsDeleted = 0