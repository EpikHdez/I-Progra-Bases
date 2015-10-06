
USE ExamWeb


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Select_filter_usuarios]
	(
	@cnombralum varchar(100), 
	@ccontrase varchar(100)
	)
AS
 SELECT * from usuarios 
	
	WHERE 
	(
		(cnombralum = @cnombralum) 
	)
	AND 
	(
		(ccontrase = @ccontrase)
	)
GO
