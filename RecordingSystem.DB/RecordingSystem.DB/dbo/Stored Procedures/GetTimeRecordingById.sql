create procedure  dbo.GetTimeRecordingById
@Id int
AS
select*from dbo.TimeRecording AS T
where @Id = T.Id