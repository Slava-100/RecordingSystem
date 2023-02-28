create procedure dbo.[GetServiceById]
@Id int
AS
select * from dbo.Service AS S
where @Id = S.Id AND S.IsDeleted = 0

