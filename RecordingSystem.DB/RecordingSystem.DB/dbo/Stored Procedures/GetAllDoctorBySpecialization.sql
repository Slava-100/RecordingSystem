CREATE procedure [dbo].[GetAllDoctorBySpecialization]
@Id_Specialization Int
AS
select S.Name, D.Name, D.LastName, D.Id from dbo.[Specialization] AS S
Inner Join dbo.[Doctor] AS D ON  D.SpecializationId = S.ID
where S.Id = @Id_Specialization