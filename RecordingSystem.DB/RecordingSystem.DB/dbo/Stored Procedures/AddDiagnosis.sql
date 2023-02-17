CREATE PROCEDURE [dbo].[AddDiagnosis]
	@Name nvarchar(50),
	@Recommendations nvarchar(50)
AS
INSERT INTO dbo.[Diagnosis]
(
	Name,
	Recommendations
)
VALUES
(
	@Name,
	@Recommendations
)
