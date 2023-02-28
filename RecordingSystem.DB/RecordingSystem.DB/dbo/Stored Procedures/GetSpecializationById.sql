create procedure dbo.[GetSpecializationById]
@Id int
AS
select * from dbo.Specialization AS S
where @Id = S.Id