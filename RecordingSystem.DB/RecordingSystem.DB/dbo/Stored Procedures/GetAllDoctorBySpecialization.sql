CREATE procedure [dbo].[GetAllDoctorBySpecialization]
@Id_Specialization Int
AS
select S.Id, S.Name AS SpecializationName, D.Id, D.Name AS DoctorName, D.LastName from dbo.[Specialization] AS S
Inner Join dbo.[Doctor] AS D ON  D.SpecializationId = S.ID
where S.Id = @Id_Specialization