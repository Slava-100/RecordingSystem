create procedure dbo.GetDoctorById
@Id int
AS
select*from dbo.Doctor AS D
where D.Id = @Id