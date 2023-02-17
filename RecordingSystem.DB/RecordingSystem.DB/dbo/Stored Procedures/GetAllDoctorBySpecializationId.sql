CREATE procedure [dbo].[GetAllDoctorBySpecializationId]
@Id_Specialization Int
AS
select S.Id, S.Name, D.Id, D.Name, D.LastName from dbo.[Specialization] AS S
Inner Join dbo.[Doctor] AS D ON  D.SpecializationId = S.ID
where S.Id = @Id_Specialization AND D.IsDeleted = 0